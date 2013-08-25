(function () {

  window.addEventListener('load', function () {

    var addButton = document.getElementById('add');
    add.addEventListener('click', function () {

      var first = document.getElementById('first');
      var second = document.getElementById('second');
      var output = document.getElementById('output');

      output.innerText = parseInt(first.value) + parseInt(second.value);
    });
    

  });
  

})();
