if (!window.CustomTouch)
  window.CustomTouch = {};

window.CustomTouch.LazySwipe = (function () {
  function swipe(element) {

    this.element = element;
    var self = this;

    //These events for firefox and webkit-based browsers
    element.addEventListener('touchstart', function (evt) { self.start.call(self, evt); });
    element.addEventListener('touchmove', function (evt) { self.move.call(self, evt); });
    element.addEventListener('touchend', function (evt) { self.end.call(self, evt); });

    //These events for all browsers that support mouse events
    element.addEventListener('mousedown', function (evt) { self.start.call(self, evt); });
    element.addEventListener('mousemove', function (evt) { self.move.call(self, evt); });
    element.addEventListener('mouseup', function (evt) { self.end.call(self, evt); });

    this.swipeLeftEvent = new Event('swipeleft');
    this.swipeRightEvent = new Event('swiperight');
  };

  swipe.prototype.start = function (evt) {
    evt.preventDefault();
    //We need to know where we started from later to make decisions on the nature of the event.
    this.initialLocation = this.getPositionFromTarget(evt)
  }

  swipe.prototype.move = function (evt) {
  }

  swipe.prototype.end = function (evt) {
    var currentLocation = this.getPositionFromTarget(evt, swipable);

    //If you end to the right of where you started, you swipe right.
    if (currentLocation.x > this.initialLocation.x) {
      this.element.dispatchEvent(this.swipeRightEvent);
    } //If you end to the left of where you started, you swipe left.
    else if (currentLocation.x < this.initialLocation.x) {
      this.element.dispatchEvent(this.swipeLeftEvent);
    }
  }

  swipe.prototype.getPositionFromTarget = function(evt) {

    var pageX, pageY;
    if (evt.touches) { //If this is a touch event
      pageX = evt.changedTouches[0].pageX;
      pageY = evt.changedTouches[0].pageY;
    }
    else { //If this is a mouse event
      pageX = evt.pageX;
      pageY = evt.pageY;
    }

    return {
      y: pageY - evt.target.offsetTop,
      x: pageX - evt.target.offsetLeft
    };
  }


  return swipe;
})();
