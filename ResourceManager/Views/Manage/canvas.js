window.onload = function(){
    var canvas = document.getElementById('canvas');
    var ctx = canvas.getContext("2d");



    var c = $('#' + '@(ViewBag.ProcessNumber)').val();


        ctx.fillText(c,10,90);
        ctx.fillStyle = 'Green';
        ctx.fillRect(200*i, 0, 100, 100);
    
}