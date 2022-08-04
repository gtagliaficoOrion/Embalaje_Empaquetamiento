window.onload = function () 
{
	//alert('s');
	//mostrarventas();
}

$(document).ready(function() {
	mostrarventas();
});

//document.getElementById("div-cnt-result").onload = function() {mostrarventas()};

function mostrarventas()
{
	$("#div-cnt-result").html('');
	$('#div-cnt-result').empty();
	$.ajax({
		url      : baseUrll+'Cventa/ventas_general',
		type     : "POST", 
		dataType : "json",
		success  : function(data)
		{
			$('#div-cnt-result').append(data.search);
		},
		error: function (jqXHR, textStatus, errorThrown)
		{
			alert('Error al actualizar ventas');
		}
	});
}