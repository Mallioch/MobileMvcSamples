window.Pincher = (function () {

  var pincher = function (element) {
    this.element = element;
    this.touchInfo = {
      touchLookup: {},
      touchArray: []
    };
    this.mode = 'none'; //move, resize are other modes
    this.currentAngle = 0;

    var self = this;

    this.element.addEventListener('touchstart', function (evt) { self.start.call(self, evt) });
    this.element.addEventListener('touchmove', function (evt) { self.change.call(self, evt) });
    this.element.addEventListener('touchend', function (evt) { self.end.call(self, evt) });

    this.element.addEventListener('MSPointerDown', function (evt) { self.start.call(self, evt) });
    this.element.addEventListener('MSPointerMove', function (evt) { self.change.call(self, evt) });
    this.element.addEventListener('MSPointerUp', function (evt) { self.end.call(self, evt) });
  }

  pincher.prototype.start = function (evt) {
    evt.preventDefault(); //prevent scrolling
    this.registerTouch(evt);
    this.setMode();
  }

  pincher.prototype.change = function (evt) {
    this.changeCount = this.changeCount || 0;
    this.updateTouchEvent(evt);

    if (this.mode === 'move') {
      this.move(evt);
    }
    else if (this.mode === 'resize') {
      this.resize(evt);
      this.resizeCount = this.resizeCount || 0;
      this.resizeCount++;
    }
    else {
      alert('fail');
    }

    this.changeCount++;
  }

  pincher.prototype.resize = function (evt) {
    if (!this.originalDistanceBetweenTouchPoints) {
      var firstLength = Math.abs(this.touchInfo.touchArray[0].pageX - this.touchInfo.touchArray[1].pageX);
      var secondLength = Math.abs(this.touchInfo.touchArray[0].pageY - this.touchInfo.touchArray[1].pageY);

      this.originalDistanceBetweenTouchPoints = Math.sqrt((firstLength * firstLength) + (secondLength * secondLength));

      this.startPoint0 = { x: this.touchInfo.touchArray[0].pageX, y: this.touchInfo.touchArray[0].pageY };
      this.startPoint1 = { x: this.touchInfo.touchArray[1].pageX, y: this.touchInfo.touchArray[1].pageY };

      if (!this.initialAngle) {
        var xDelta = this.startPoint1.x - this.startPoint0.x;
        var yDelta = this.startPoint1.y - this.startPoint0.y;

        this.initialAngle = Math.atan2(xDelta, yDelta);
      }
    }
    else {
      //calc rotation change
      var touch0 = this.touchInfo.touchArray[0];
      var touch1 = this.touchInfo.touchArray[1];

      var xDelta = touch1.pageX - touch0.pageX;
      var yDelta = touch1.pageY - touch0.pageY;

      var newAngle = Math.atan2(xDelta, yDelta);

      var rotationAmount = this.initialAngle - newAngle;

        
      //calc size transform
      var firstLength = Math.abs(this.touchInfo.touchArray[0].pageX - this.touchInfo.touchArray[1].pageX);
      var secondLength = Math.abs(this.touchInfo.touchArray[0].pageY - this.touchInfo.touchArray[1].pageY);

      var newDistance = Math.sqrt((firstLength * firstLength) + (secondLength * secondLength));
      this.activeTransformValue = newDistance / this.originalDistanceBetweenTouchPoints;

      if (this.currentTransformValue) {
        this.activeTransformValue = this.currentTransformValue * this.activeTransformValue;
      }


      //apply to element style
      this.element.style.webkitTransform = 'scale(' + this.activeTransformValue + ')';
      this.element.style.transform = 'scale(' + this.activeTransformValue + ')';

      this.element.style.webkitTransform += ' rotate(' + rotationAmount + 'rad)';
      this.element.style.transform += ' rotate(' + rotationAmount + 'rad)';

    }
  }

  pincher.prototype.move = function (evt) {
    if (!this.startingOffset)
      this.startingOffset = this.getPosition(evt);

    this.element.style.left = (this.touchInfo.touchArray[0].pageX - this.startingOffset.x) + 'px';
    this.element.style.top = (this.touchInfo.touchArray[0].pageY - this.startingOffset.y) + 'px';
  }

  pincher.prototype.end = function (evt) {
    this.removeDeadTouches(evt);

    this.setMode();

    //After a resize finishes, we need to remember the transform value so we can start from there next time.
    //TODO: Can we put this elsewhere?
    if (this.activeTransformValue) {
      this.currentTransformValue = this.activeTransformValue;
    }

    if (this.touchInfo.touchArray.length < 2)
      this.originalDistanceBetweenTouchPoints = null;
  }

  pincher.prototype.updateTouchEvent = function (evt) {
    var touch, i = 0;

    if (evt.pointerId) {
      touch = this.touchInfo.touchLookup[evt.pointerId];
      touch.pageX = evt.pageX;
      touch.pageY = evt.pageY;
    }
    else {
      for (i; i < evt.touches.length; i++) {
        touch = evt.touches[i];
        this.touchInfo.touchLookup[touch.identifier].pageX = touch.pageX;
        this.touchInfo.touchLookup[touch.identifier].pageY = touch.pageY;
      }
    }

  }

  pincher.prototype.removeDeadTouches = function (evt) {

    if (evt.touches) { //touch events
      var ids = '', i = 0;
      for (i; i < evt.touches.length; i++) {
        var touch = evt.touches[i];
        if (ids.length > 0)
          ids += '|';
        ids += touch.identifier;
      }

      for (var key in this.touchInfo.touchLookup) {
        if (ids.indexOf(key) === -1) { //need to remove the touch
          this.touchInfo.touchArray.splice(this.touchInfo.touchLookup[key].indexInArray);
          delete this.touchInfo.touchLookup[key];
        }
      }
    }
    else { //mouse and pointer events
      var touch = this.touchInfo.touchLookup[evt.pointerId];
      this.touchInfo.touchArray.splice(touch.indexInArray);
      delete this.touchInfo.touchLookup[touch.identifier];
    }

  }

  pincher.prototype.registerTouch = function (evt) {
    //It is in this method that we normalize the touch model between the different implementations

    if (evt.touches) { //touch events
      for (var i = 0; i < evt.touches.length; i++) {
        var evtTouch = evt.touches[i];

        if (!this.touchInfo.touchLookup[evtTouch.identifier]) {
          var touch = {
            identifier: evtTouch.identifier,
            pageX: evtTouch.pageX,
            pageY: evtTouch.pageY
          };

          this.touchInfo.touchArray.push(touch);
          this.touchInfo.touchLookup[touch.identifier] = touch;
          touch.indexInArray = this.touchInfo.touchArray.length - 1;
        }
      }
    }
    else { //pointer events
      var touch = {
        pageX: evt.pageX,
        pageY: evt.pageY,
        identifier: evt.pointerId
      };
      this.touchInfo.touchArray.push(touch);
      this.touchInfo.touchLookup[touch.identifier] = touch;
      touch.indexInArray = this.touchInfo.touchArray.length - 1;
    }
  }

  pincher.prototype.setMode = function () {
    this.startingOffset = null;

    if (this.touchInfo.touchArray.length === 1)
      this.mode = 'move';
    else if (this.touchInfo.touchArray.length === 2)
      this.mode = 'resize';
    else
      this.mode = 'none';
  }

  pincher.prototype.getPosition = function (evt) {

    var pageX, pageY;
    if (evt.touches) { //If this is a touch event
      pageX = evt.changedTouches[0].pageX;
      pageY = evt.changedTouches[0].pageY;
    }
    else { //If this is a mouse or pointer event
      pageX = evt.pageX;
      pageY = evt.pageY;
    }

    return {
      y: pageY - evt.target.offsetTop,
      x: pageX - evt.target.offsetLeft
    };
  }

  return pincher;
})();


//PROBLEMS TO SOLVE

//1. Multi-touch - normalize between approaches. Disparate touch collections
//2. There are different modes. Handle this.
//3. Touch objects are not persistent for IE or Android



//Notes
//
//1. To disable pinch and zoom for older Android, need to use viewport
