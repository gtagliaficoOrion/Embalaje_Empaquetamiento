window.onload = function () 
{
	load(0,pagactqv);
	
}

$(document).ready(function() {
    $('.js-example-basic-multiple').select2();
	
	$('.js-example-basic-multiple').select2({
	  maximumSelectionLength: 2
	});
	
	var seleccionado = '';
	document.getElementById("cocodatrib").value='';
	
	
	$("#scoatributo").select2()
	$("#scoatributo").on('select2:select', function(e) {
		var data = e.params.data;
		if (seleccionado=='')
		{
			seleccionado = data.id;
		}
		else
		{
			seleccionado = seleccionado+','+data.id;
		}
		
		document.getElementById("cocodatrib").value=seleccionado;
	});
	
	$("#scoatributo").on('select2:unselect', function(e) {
		var data = e.params.data;
		swchw = 'N';
		if (seleccionado.includes(','+data.id))
		{
			seleccionado = seleccionado.replace(','+data.id,'');
		}
		
		if (seleccionado.includes(data.id+','))
		{
			seleccionado = seleccionado.replace(data.id+',','');
		}
		
		if (seleccionado.includes(data.id))
		{
			seleccionado = seleccionado.replace(data.id,'');
		}
		
		document.getElementById("cocodatrib").value=seleccionado;
		
	});
	
});

function changeFunc() {
	
	var selectBox = document.getElementById("cosnatribu");
    var selectedValue = selectBox.options[selectBox.selectedIndex].value;
	if (selectedValue==0)
	{
		document.getElementById("scoatributo").className = document.getElementById("scoatributo").className.replace(/\bis-invalid\b/g, "");
		document.getElementById("scoatributoerror").innerHTML = '';

		$.post(baseUrll+'Catributo/listar_atributo', {co_atributo:0}, function(data){
			$("#scoatributo").html(data);
		});

		document.getElementById("addatribt").style.display = "none";
	}
	else
	{
		document.getElementById("addatribt").style.display = "block";
		document.getElementById("scoatributo").className = document.getElementById("scoatributo").className.replace(/\bis-invalid\b/g, "");
		document.getElementById("scoatributoerror").innerHTML = '';
		
	}
 }