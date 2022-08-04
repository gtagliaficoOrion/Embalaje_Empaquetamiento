$(window).on('load', function() {
    load(0);

	$.post(baseUrll+'Catributo/listar_atrib', {co_atributo:0}, function(data){
		$("#coatrib").html(data);
	});
});



var total_show 	= 10;

$("#form-search").submit(function( event ) {
	/*$('#btn-del-girl').attr("disabled", true);*/
	var parametros = $(this).serialize();
	load(0);
	event.preventDefault();
});

$('#pag-temas').on('click','a',function(e){
	e.preventDefault(); 
	var pageNum = $(this).attr('data-ci-pagination-page');
	tag 		= $("#txt-tag").val();
	search 		= $("#txt-search").val();
	user_id 	= $("#txt-user-id").val();
	year 		= $("#txt-year").val();
	month 		= $("#txt-month").val();

	load(pageNum);
});

function load(pageNum)
{
	search  = document.getElementById("txt-search").value;
	coatrib = document.getElementById("coatrib").value;

	$.ajax({
		type: "POST",
		data: {
			page_num   : pageNum,
			total_show : total_show,
			search     : search,
			coatrib    : coatrib

		},
		url: baseUrll+'Catributo/loadContent/'+pageNum,
		dataType: 'JSON',
		beforeSend: function(objeto){
			$("#div-cnt-ajax").html('<div class="col-md-12 text-center">'+
				'<div class="spinner-border" role="status"><span class="sr-only">Loading...</span> </div><center><h4>Cargando contenido ...</h4></div></center>');
		},
		success: function(responseData){

			$("#pag-regist").html(responseData.totalreg);
			$('#pag-temas').html(responseData.pagination);
			$("#div-cnt-ajax").html('');
			$("#div-cnt-ajaxx").html('');
			$('#div-cnt-ajax').empty();
			$('#div-cnt-ajaxx').empty();
			$('#div-cnt-ajax').append(responseData.search);
		}
	});
}
