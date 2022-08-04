var total_show 	= 10;

$("#form-search").submit(function( event ) {
	/*$('#btn-del-girl').attr("disabled", true);*/
	var parametros = $(this).serialize();
	load(0,pagactqv);
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

	load(pageNum,pagactqv);
});

function load(pageNum,pagrfres)
{
	if (pagrfres == 1)
	{
		purl = baseUrll+'Cslider/loadContent/'+pageNum;
	}
	else
	{
		if (pagrfres==2)
		{
			purl = baseUrll+'Cventa/loadContent/'+pageNum;
		}
		else
		{
			if (pagrfres==3)
			{
				purl = baseUrll+'Cpromocion/loadContent/'+pageNum;
			}
			else
			{
				if (pagrfres==4)
				{
					purl = baseUrll+'Ccategoria/loadContent/'+pageNum;
				}
				else
				{
					if (pagrfres==5)
					{
						purl = baseUrll+'Cproducto/loadContent/'+pageNum;
					}
					else
					{
						if (pagrfres==6)
						{
							purl = baseUrll+'Cvendedor/loadContent/'+pageNum;
						}
						else
						{
							if (pagrfres==7)
							{
								purl = baseUrll+'Crfactura/loadContent/'+pageNum;
							}
							else
							{
								if (pagrfres==8)
								{
									purl = baseUrll+'Crventa/loadContent/'+pageNum;
								}
								else
								{
									if (pagrfres==9)
									{
										purl = baseUrll+'Crentrega/loadContent/'+pageNum;
									}
									else
									{
										if (pagrfres==10)
										{
											purl = baseUrll+'Cusuario/loadContent/'+pageNum;
										}
										else
										{
											if (pagrfres==11)
											{
												purl = baseUrll+'Cinventario/loadContent/'+pageNum;
											}
											else
											{
												purl = baseUrll+'Cpermiso/loadContent/'+pageNum;
											}
										}
									}
								}
							}
						}
					}
				}
			}	
		}
	}
	search = document.getElementById("txt-search").value;

	fe_inicio = '12/10/2000';
	fe_fin    = '12/10/2000';
	ent       = 0;

	if (document.getElementById("fe_inicio"))
	{
		fe_inicio = document.getElementById("fe_inicio").value;
	}

	if (document.getElementById("fe_fin"))
	{
		fe_fin = document.getElementById("fe_fin").value;
	}

	if (document.getElementById("selectbus"))
	{
		ent = document.getElementById("selectbus").value;
	}

	$.ajax({
		type: "POST",
		data: {
			page_num   : pageNum,
			total_show : total_show,
			search     : search,
			fe_inicio  : fe_inicio,
			fe_fin     : fe_fin,
			ent        : ent

		},
		url: purl,
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
