var total_show 	= 4;

$("#form-searcha").submit(function( event ) {
	/*$('#btn-del-girl').attr("disabled", true);*/
	var parametros = $(this).serialize();
	loada(0);
	event.preventDefault();
});

$('#pag-temasa').on('click','a',function(e){
	e.preventDefault(); 
	var pageNum = $(this).attr('data-ci-pagination-page');
	tag 		= $("#txt-taga").val();
	search 		= $("#txt-searcha").val();
	user_id 	= $("#txt-user-ida").val();
	year 		= $("#txt-yeara").val();
	month 		= $("#txt-montha").val();

	loada(pageNum);
});

function loada(pageNum)
{
	purl = baseUrll+'Cproductoa/loadContent/'+pageNum;
	search = '';//document.getElementById("txt-searcha").value;
	codpro = document.getElementById("coprod5").value; 
	$.ajax({
		type: "POST",
		data: {
			page_num   : pageNum,
			total_show : total_show,
			search     : search,
			codpro     : codpro
		},
		url: purl,
		dataType: 'JSON',
		beforeSend: function(objeto){
			$("#div-cnt-ajaxa").html('<div class="col-md-12 text-center">'+
				'<div class="spinner-border" role="status"><span class="sr-only">Loading...</span> </div><center><h4>Cargando contenido ...</h4></div></center>');
		},
		success: function(responseData){

			$("#pag-regista").html(responseData.totalreg);
			$('#pag-temasa').html(responseData.pagination);
			$("#div-cnt-ajaxa").html('');
			$('#div-cnt-ajaxa').empty();
			$('#div-cnt-ajaxa').append(responseData.search);
		}
	});
}
