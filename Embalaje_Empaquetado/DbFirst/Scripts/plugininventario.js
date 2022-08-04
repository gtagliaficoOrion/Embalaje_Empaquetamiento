$(document).ready(function() {
	load(0,pagactqv);

	$('#tx_comprobante_pago1, #btn_Find').on('click', function(){
		$('#tx_comprobante1').trigger('click');
	});
	
	$('#btn_Rem1').on('click', function()
	{
		$('#tx_comprobante_pago1, #tx_comprobante1').val('');
		$('#btn_Rem1').hide();
		$('#ErrFile1').html('').removeClass('text-info').removeClass('error');
		//$('#tx_comprobante_pago').addClass('error');
		$('#GrpPagCom1').removeClass('has-success');
	})
		
	$('#tx_comprobante1').on('change', function(e){
		files = e.target.files;
		var FileName = e.currentTarget.files[0].name;
		FileName = FileName.toLowerCase();
		var FileExt = FileName.substring(FileName.lastIndexOf('.'));
		var MachCar = /^[a-z0-9\-.()\s]+$/i.test(FileName);		
		var MachExt = /^(.pdf|.xps|.jpg|.jpeg|.bmp|.png)$/.test(FileExt);
		if(!MachCar){
			$('#ErrFile1').html("El Nombre del Archivo contiene caracteres no permitidos (* ? < > , : ; ').").removeClass('text-info').addClass('error').show();
			$('#tx_comprobante_pago1, #tx_comprobante1').val('');
			$('#btn_Rem1').hide();
			$('#tx_comprobante_pago1').addClass('error');
			$('#GrpPagCom1').removeClass('has-success').addClass('has-error');
			return;
		}
			
		if(!MachExt){
			$('#ErrFile1').html('Formato no permitido (Solo .pdf, .xps, .jpg, .bmp, .jpeg, .png).').removeClass('text-info').addClass('error').show();
			$('#tx_comprobante_pago1, #tx_comprobante1').val('');
			$('#btn_Rem1').hide();
			$('#tx_comprobante_pago1').addClass('error');
			$('#GrpPagCom1').removeClass('has-success').addClass('has-error');
			return;
		}
				
			$('#GrpPagCom1').removeClass('has-error').addClass('has-success');
		var ExtImg;
		switch(FileExt) {
			case '.pdf':
				ExtImg = '<i class="fa fa-file-o text-danger"></i> ';
			break;
			case '.xps':
				ExtImg = '<i class="fa fa-file-o text-success"></i> ';
			break;
			default:
				ExtImg = '<i class="fa fa-file-o text-warning"></i> ';
		}
		
		var FileSize = parseFloat(e.currentTarget.files[0].size);
		if(FileSize>1048576){
			$('#ErrFile1').html('El tamaño del archivo excede el maximo (1Mb)').removeClass('text-info').addClass('error').show();
			$('#tx_comprobante_pago1').addClass('error');
			$('#GrpPagCom1').removeClass('has-success').addClass('has-error');
			$('#tx_comprobante_pago1, #tx_comprobante1').val('');
			$('#btn_Rem1').hide();
		}else{
			FileSize /=1024;
			$('#ErrFile1').html(ExtImg+FileSize.toFixed(2)+' kb').removeClass('error').addClass('text-info').show();
			$('#btn_Rem1').show();
			$('#tx_comprobante_pago1').removeClass('error').val(e.currentTarget.files[0].name);
			$('#GrpPagCom1').removeClass('has-error').addClass('has-success');
		}
	})
});

