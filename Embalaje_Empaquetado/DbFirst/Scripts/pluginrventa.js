$(document).ready(function() {
	
	var hoyy = new Date();
	dd   =  hoyy.getDate();
	mm   = hoyy.getMonth() + 1;
    if (dd<10)
	{
		dd = '0'+dd;
	}
	if (mm<10)
	{
		mm = '0'+mm;
	}
	yyyy =  hoyy.getFullYear();

	fehoy = dd+"/"+mm+"/"+yyyy;

	$('#fe_inicio').datepicker('setDate', fehoy);
	$('#fe_fin').datepicker('setDate', fehoy);

	
	var input = document.getElementById("txt-search");
	input.addEventListener("keyup", function(event) {
		if (event.keyCode === 13) {
			event.preventDefault();
			load(0,pagactqv);
		}
	});

	
});

