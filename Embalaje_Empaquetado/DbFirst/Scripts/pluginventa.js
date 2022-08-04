$(document).ready(function() {
	
	load(0,pagactqv);
	$("#nfact").html('-');
	$("#tpfact").html('-');
	$("#tpagadofact").html('-');
	$("#trestafact").html('-');

	$('#tx_comprobante_pago, #btn_Find').on('click', function(){
		$('#tx_comprobante').trigger('click');
	});
	
	$('#btn_Rem').on('click', function()
	{
		$('#tx_comprobante_pago, #tx_comprobante').val('');
		$('#btn_Rem').hide();
		$('#ErrFile').html('').removeClass('text-info').removeClass('error');
		//$('#tx_comprobante_pago').addClass('error');
		$('#GrpPagCom').removeClass('has-success');
	})
		
	$('#tx_comprobante').on('change', function(e){
		files = e.target.files;
		var FileName = e.currentTarget.files[0].name;
		FileName = FileName.toLowerCase();
		var FileExt = FileName.substring(FileName.lastIndexOf('.'));
		var MachCar = /^[a-z0-9\-.()\s]+$/i.test(FileName);		
		var MachExt = /^(.pdf|.xps|.jpg|.jpeg|.bmp|.png)$/.test(FileExt);
		if(!MachCar){
			$('#ErrFile').html("El Nombre del Archivo contiene caracteres no permitidos (* ? < > , : ; ').").removeClass('text-info').addClass('error').show();
			$('#tx_comprobante_pago, #tx_comprobante').val('');
			$('#btn_Rem').hide();
			$('#tx_comprobante_pago').addClass('error');
			$('#GrpPagCom').removeClass('has-success').addClass('has-error');
			return;
		}
			
		if(!MachExt){
			$('#ErrFile').html('Formato no permitido (Solo .pdf, .xps, .jpg, .bmp, .jpeg, .png).').removeClass('text-info').addClass('error').show();
			$('#tx_comprobante_pago, #tx_comprobante').val('');
			$('#btn_Rem').hide();
			$('#tx_comprobante_pago').addClass('error');
			$('#GrpPagCom').removeClass('has-success').addClass('has-error');
			return;
		}
				
			$('#GrpPagCom').removeClass('has-error').addClass('has-success');
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
			$('#ErrFile').html('El tamaño del archivo excede el maximo (1Mb)').removeClass('text-info').addClass('error').show();
			$('#tx_comprobante_pago').addClass('error');
			$('#GrpPagCom').removeClass('has-success').addClass('has-error');
			$('#tx_comprobante_pago, #tx_comprobante').val('');
			$('#btn_Rem').hide();
		}else{
			FileSize /=1024;
			$('#ErrFile').html(ExtImg+FileSize.toFixed(2)+' kb').removeClass('error').addClass('text-info').show();
			$('#btn_Rem').show();
			$('#tx_comprobante_pago').removeClass('error').val(e.currentTarget.files[0].name);
			$('#GrpPagCom').removeClass('has-error').addClass('has-success');
		}
	})

	$(function() {
		$('input:radio[name="radiopago"]').change(function() {
			if ($(this).val() == '1') 
			{
				document.getElementById("detnombretitu").style.display = "block";
				document.getElementById("detcorreotitu").style.display = "block";
				document.getElementById("GrpPagCom").style.display = "block";
				document.getElementById("ctprpcuoff").value = 1;
			} 
			else 
			{
				document.getElementById("detnombretitu").style.display = "none";
				document.getElementById("detcorreotitu").style.display = "none";
				document.getElementById("GrpPagCom").style.display = "none";
				document.getElementById("ctprpcuoff").value = 2;

			}
		});
	});
	
	var ele = document.querySelectorAll('.validanumericos')[0];
    ele.onkeypress = function(e) {
        if(isNaN(this.value+String.fromCharCode(e.charCode)))
            return false;
    }
    ele.onpaste = function(e){
        e.preventDefault();
    }
	
});