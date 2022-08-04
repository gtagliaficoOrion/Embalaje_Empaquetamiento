mtermico = '';

mtermico += '<div id="modalfmarca" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" class="modal fade text-left">';
mtermico += '<div role="document" class="modal-dialog">';
mtermico += '<div class="modal-content">';

mtermico += '<div class="modal-header">';
mtermico += '<h5 class="modal-title">Datos Marca</h5>';
mtermico += '<button type="button" data-dismiss="modal" aria-label="Close" class="close"><span aria-hidden="true">×</span></button>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<form id="form_marca">';
mtermico += '<input type="hidden" id="faaccionmar" name="accion">';
mtermico += '<input type="hidden" id="facomarca" name="co_marca">';

mtermico += '<div class="panel-body">';
mtermico += '<div class="row">';
mtermico += '<div class="col-lg-12">';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Nombre Marca:</label>';
mtermico += '<input name="tx_marca" id="fatxmarca" class="form-control" type="text" placeholder="Nombre Marca" required="required">';
mtermico += '<div style="text-align:left;font-weight:bold;" id="fatxmarcaerror" class="invalid-feedback"></div>';
mtermico += '</div>';	

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '</form>';

mtermico += '</div>';

mtermico += '<div class="modal-footer">';
mtermico += '<button type="button" id="botoncerrfmar" data-dismiss="modal" class="btn btn-secondary">Close</button>';
mtermico += '<button type="button" class="btn btn-primary" href="javascript:void(0)" onclick="add_marcasub()">Save changes</button>';
mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';




mtermico += '<div id="modalfproducto" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" class="modal fade text-left">';
mtermico += '<div role="document" class="modal-dialog modal-lg">';
mtermico += '<div class="modal-content">';

mtermico += '<div class="modal-header">';
mtermico += '<h5 class="modal-title">Datos Producto</h5>';
mtermico += '<button type="button" data-dismiss="modal" aria-label="Close" class="close"><span aria-hidden="true">×</span></button>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<form id="form_producto">';
mtermico += '<input type="hidden" id="faaccionpro" name="accion">';
mtermico += '<input type="hidden" id="facoproducto" name="co_producto">';
mtermico += '<input type="hidden" id="faimgproductooriginal" name="img_producto_original">';

mtermico += '<div class="panel-body">';
mtermico += '<div class="row">';

mtermico += '<div class="col-lg-6">';

mtermico += '<div class="form-group">';
mtermico += '<a href="javascript:;" class="thumbnail1">';
mtermico += '<img id="tx_imagen_preview3" style="width:100%; height:150px" onclick="insertimagenn(3)" />';
mtermico += '<input type="file" name="img_producto" id="img_mostrar3" onchange="previewImage(img_mostrar3,3);" style="display:none;" required="required"/>';
mtermico += '</a>';	
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Nombre Producto:</label>';
mtermico += '<input  name="tx_producto" id="fatxproducto" class="form-control" type="text" placeholder="Nombre Producto" required="required">';
mtermico += '<div style="text-align:left;font-weight:bold;" id="fatxproductoerror" class="invalid-feedback"></div>';
mtermico += '</div>';	

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Categoria :</label>';
mtermico += '<select name="co_categoria" id="cocategoriafp" class="form-control" data-live-search="true" required="required">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="cocategoriafperror" class="invalid-feedback"></div>';
mtermico += '</div>';


mtermico += '</div>';

mtermico += '<div class="col-lg-6">';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Descripci&oacute;n</label>';
mtermico += '<textarea class="form-control" rows="3" id="txdescripcionpfp" name="tx_descripcion" placeholder="Descripci&oacute;n del producto"></textarea>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Estado producto:</label>';
mtermico += '<select name="co_status" id="costatusfp" class="form-control" data-live-search="true" required="required">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="costatusfperror" class="invalid-feedback"></div>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Precio:</label>';
mtermico += '<input class="form-control" type="text" id="canpreciofp" name="can_precio" required="required">';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="canpreciofperror" class="invalid-feedback"></div>';
mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '</form>';

mtermico += '</div>';

mtermico += '<div class="modal-footer">';
mtermico += '<button type="button" id="botoncerrfpro" data-dismiss="modal" class="btn btn-secondary">Close</button>';
mtermico += '<button type="button" class="btn btn-primary" href="javascript:void(0)" onclick="add_productosub()">Save changes</button>';
mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div id="modalfslider" class="modal fade text-left" tabindex="-1" role="dialog">';
mtermico += '<div class="modal-dialog">';
mtermico += '<div class="modal-content row">';
mtermico += '<div class="modal-header">';
mtermico += '<button aria-hidden="true" data-dismiss="modal" class="close" type="button">&times;</button>';
mtermico += '<h4 id="titlemodapag" class="modal-title">Datos de Slidder</h4>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<input type="hidden" id="faaccionsli" name="accion">';
mtermico += '<input type="hidden" id="facoslider" name="co_producto">';
mtermico += '<input type="hidden" id="faimgslideroriginal" name="img_original">';

mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<a href="javascript:;" class="thumbnail1">';
mtermico += '<img id="tx_imagen_preview4" style="width:100%; height:150px" onclick="insertimagenn(4)" />';
mtermico += '<input type="file" name="tx_foto" id="img_mostrar4" onchange="previewImage(img_mostrar4,4);" style="display:none;" required="required"/>';
mtermico += '</a>';	
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Descripci&oacute;n</label>';
mtermico += '<textarea class="form-control" rows="3" id="fametx_descripcion" name="tx_descripcion" placeholder="Descripci&oacute;n del producto"></textarea>';
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Categoria:</label>';
mtermico += '<select name="co_categoria" id="cocategoriaforslider" class="form-control" data-live-search="true">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Estado producto:</label>';
mtermico += '<select name="co_status" id="fameco_status" class="form-control" data-live-search="true" required="required">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="fameco_statuserror" class="invalid-feedback"></div>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '<button type="button" class="btn btn-primary col-lg-offset-8" href="javascript:void(0)" onclick="add_slidersub()">Save changes</button>';
mtermico += '<button style="margin-left:5px;" type="button" id="botoncerrfslider" data-dismiss="modal" class="btn btn-secondary">Close</button>';

mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';









mtermico += '<div id="modalreferencia" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" class="modal fade text-left">';
mtermico += '<div role="document" class="modal-dialog modal-lg">';
mtermico += '<div class="modal-content">';

mtermico += '<div class="modal-header">';
mtermico += '<h5 class="modal-title">Referencia de Pago</h5>';
mtermico += '<button type="button" data-dismiss="modal" aria-label="Close" class="close"><span aria-hidden="true">×</span></button>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<form id="form_referencia">';


mtermico += '<div class="panel-body">';
mtermico += '<div class="row">';

mtermico += '<div class="col-lg-6">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Referencia</label>';
//mtermico += '<img id="tx_imgreferencia2" style="width:100%; height:322px"/>';
mtermico += '<iframe id="tx_imgreferencia2" style="width:100%; height:322px" frameborder="0" scrolling="yes"></iframe>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '<div class="col-lg-6">';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Fecha de Pago:</label>';
mtermico += '<p id="fepagocu2"></p>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Cuotas canceladas:</label>';
mtermico += '<p id="fcucance2"></p>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Monto:</label>';
mtermico += '<p id="fmontocucanc2"></p>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Observaciones:</label>';
mtermico += '<p id="txobservacionesarp2"></p>';
mtermico += '</div>';

mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';

mtermico += '</form>';

mtermico += '</div>';

mtermico += '<div class="modal-footer">';
mtermico += '<button type="button" data-dismiss="modal" class="btn btn-secondary">Close</button>';
mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';





mtermico += '<div id="modalreferencia1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" class="modal fade text-left">';
mtermico += '<div role="document" class="modal-dialog modal-lg">';
mtermico += '<div class="modal-content">';

mtermico += '<div class="modal-header">';
mtermico += '<h5 class="modal-title">Referencia de Pago</h5>';
mtermico += '<button type="button" data-dismiss="modal" aria-label="Close" class="close"><span aria-hidden="true">×</span></button>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<form">';
mtermico += '<input type="hidden" id="codetallepago1" name="co_detalle_pago">';
mtermico += '<input type="hidden" id="cofacturapago1" name="co_factura">';

mtermico += '<div class="panel-body">';
mtermico += '<div class="row">';


mtermico += '<div class="col-lg-6">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Referencia</label>';
//mtermico += '<img id="tx_imgreferencia1" style="width:100%; height:322px"/>';
mtermico += '<iframe id="tx_imgreferencia1" style="width:100%; height:322px" frameborder="0" scrolling="yes"></iframe>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '<div class="col-lg-6">';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Fecha de Pago:</label>';
mtermico += '<p id="fepagocu"></p>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Cuotas canceladas:</label>';
mtermico += '<p id="fcucance"></p>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Monto:</label>';
mtermico += '<p id="fmontocucanc"></p>';
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Observaciones:</label>';
mtermico += '<textarea class="form-control" rows="3" id="txobservacionesarp" name="tx_observaciones" placeholder="Observaciones"></textarea>';
mtermico += '</div>';

mtermico += '</div>';





mtermico += '</div>';
mtermico += '</div>';

mtermico += '</form>';

mtermico += '</div>';

mtermico += '<div class="modal-footer">';
mtermico += '<button type="button" class="btn btn-primary" href="javascript:void(0)" onclick="arprpf(1)">Aprobar</button>';
mtermico += '<button type="button" class="btn btn-danger" href="javascript:void(0)" onclick="arprpf(2)">Rechazar</button>';
mtermico += '<button type="button" data-dismiss="modal" class="btn btn-secondary">Cerrar</button>';
mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';












mtermico += '<div id="mdpagocuo8" class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog">';
mtermico += '<div class="modal-dialog modal-sm">';
mtermico += '<div class="modal-content">';
mtermico += '<div class="modal-header">';
mtermico += '<h4 class="modal-title">Registro de Pago</h4>';
mtermico += '<button type="button" data-dismiss="modal" aria-label="Close" class="close"><span aria-hidden="true">×</span></button>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<form id="form_dpago">';
mtermico += '<input type="hidden" id="cfrpcuo">';
mtermico += '<div class="container">';
mtermico += '<div class="row">';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="payment_method">';
mtermico += '<div class="heading_s1">';
mtermico += '<h4>Datos Pago por Zelle</h4>';
mtermico += '</div>';











mtermico += '</div>';



mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';
 
mtermico += '</form>';

mtermico += '</div>';//final body

mtermico += '<div class="modal-footer">';

mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';





mtermico += '<div id="modalfpromocion" class="modal fade text-left" tabindex="-1" role="dialog">';
mtermico += '<div class="modal-dialog">';
mtermico += '<div class="modal-content row">';
mtermico += '<div class="modal-header">';
mtermico += '<button aria-hidden="true" data-dismiss="modal" class="close" type="button">&times;</button>';
mtermico += '<h4 id="titlemodapag" class="modal-title">Datos de Slidder</h4>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<input type="hidden" id="faaccionpro" name="accion">';
mtermico += '<input type="hidden" id="facopromocion" name="co_producto">';
mtermico += '<input type="hidden" id="faimgpromocionoriginal" name="img_original">';

mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<a href="javascript:;" class="thumbnail1">';
mtermico += '<img id="tx_imagen_preview5" style="width:100%; height:150px" onclick="insertimagenn(5)" />';
mtermico += '<input type="file" name="tx_foto" id="img_mostrar5" onchange="previewImage(img_mostrar5,5);" style="display:none;" required="required"/>';
mtermico += '</a>';	
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Descripci&oacute;n</label>';
mtermico += '<textarea class="form-control" rows="3" id="fatx_descripcionpro" name="tx_descripcion" placeholder="Descripci&oacute;n del producto"></textarea>';
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Categoria:</label>';
mtermico += '<select name="co_categoria" id="cocategoriaforpromocion" class="form-control" data-live-search="true">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '</div>';
mtermico += '</div>';


mtermico += '<div class="col-lg-12">';
mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Estado producto:</label>';
mtermico += '<select name="co_status" id="faco_statuspro" class="form-control" data-live-search="true" required="required">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="faco_statusproerror" class="invalid-feedback"></div>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '<button type="button" class="btn btn-primary col-lg-offset-8" href="javascript:void(0)" onclick="add_promocionsub()">Save changes</button>';
mtermico += '<button style="margin-left:5px;" type="button" id="botoncerrfpromocion" data-dismiss="modal" class="btn btn-secondary">Close</button>';

mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';






mtermico += '<div id="modalfcategoria" class="modal fade text-left" tabindex="-1" role="dialog">';
mtermico += '<div class="modal-dialog">';
mtermico += '<div class="modal-content row">';
mtermico += '<div class="modal-header">';
mtermico += '<button aria-hidden="true" data-dismiss="modal" class="close" type="button">&times;</button>';
mtermico += '<h4 id="titlemodapag" class="modal-title">Datos CAtegoria</h4>';
mtermico += '</div>';

mtermico += '<div class="modal-body">';

mtermico += '<input type="hidden" id="faaccioncat" name="accion">';
mtermico += '<input type="hidden" id="facocategoria" name="co_categoria">';
mtermico += '<input type="hidden" id="faimgcategoriaoriginal" name="img_original">';


mtermico += '<div class="form-group">';
mtermico += '<a href="javascript:;" class="thumbnail1">';
mtermico += '<img id="tx_imagen_preview6" style="width:100%; height:150px" onclick="insertimagenn(6)" />';
mtermico += '<input type="file" name="img_categoria" id="img_mostrar6" onchange="previewImage(img_mostrar6,6);" style="display:none;" required="required"/>';
mtermico += '</a>';	
mtermico += '</div>';

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Nombre Categoria:</label>';
mtermico += '<input name="tx_categoria" id="fatxcategoria" class="form-control" type="text" placeholder="Nombre Categoria" required="required">';
mtermico += '<div style="text-align:left;font-weight:bold;" id="fatxcategoriaerror" class="invalid-feedback"></div>';
mtermico += '</div>';	

mtermico += '<div class="form-group">';
mtermico += '<label style="display: table-cell">Estado Categoria:</label>';
mtermico += '<select name="co_status" id="costatusfc" class="form-control" data-live-search="true" required="required">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="costatusfcerror" class="invalid-feedback"></div>';
mtermico += '</div>';

mtermico += '<button type="button" class="btn btn-primary col-lg-offset-8" href="javascript:void(0)" onclick="add_categoriasub()">Save changes</button>';
mtermico += '<button style="margin-left:5px;" type="button" data-dismiss="modal" class="btn btn-secondary">Cerrar</button>';

mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';
















mtermico += '<div id="mdpagocuo" class="modal fade text-left" tabindex="-1" role="dialog">';
mtermico += '<div class="modal-dialog">';
mtermico += '<div class="modal-content row">';
mtermico += '<div class="modal-header">';
mtermico += '<button aria-hidden="true" data-dismiss="modal" class="close" type="button">&times;</button>';
mtermico += '<h4 id="titlemodapag" class="modal-title">Registro de Pago</h4>';
mtermico += '</div>';
mtermico += '<div class="modal-body">';

mtermico += '<input type="hidden" id="cfrpcuoff">';
mtermico += '<input type="hidden" id="ctprpcuoff">';
mtermico += '<input type="hidden" id="cfrpcuoffmonto">';
mtermico += '<input type="hidden" id="cfrpcuoffmontop">';
mtermico += '<input type="hidden" id="cfrpcuoffcuotas">';

mtermico += '<div class="radio radio col-lg-12"><label><input type="radio" name="radiopago" value="1" id="spzelle"> Zelle</label></div>';

mtermico += '<div style="margin-top:10px;margin-left:10px;" id="detnombretitu" class="col-lg-12">';
mtermico += '<label style="color:#333;font-weight:bold;font-family:Arial, Helvetica, sans-serif;">Titular:</label>';
mtermico += '<span id="nomtitupago"></span>';
mtermico += '</div>';

mtermico += '<div style="margin-top:-5px;margin-left:10px;" id="detcorreotitu" class="col-lg-12">';
mtermico += '<label style="color:#333;font-weight:bold;font-family:Arial, Helvetica, sans-serif;">Email: </label>';
mtermico += '<span id="corretitupago"></span>';
mtermico += '</div>';

mtermico += '<div id="GrpPagCom" class="col-lg-12">';
mtermico += '<label style="color:#333;font-weight:bold;font-family:Arial, Helvetica, sans-serif; margin-top:7px;" class="control-label" for="tx_comprobante">Comprobante de Pago</label>';
mtermico += '<input type="file" style="display:none" id="tx_comprobante" name="tx_comprobante">';
mtermico += '<div class="input-group">';
mtermico += '<input type="text" id="tx_comprobante_pago" class="form-control" placeholder=".pdf, .xps, .jpg, .bmp, .jpeg, .png" readonly>';
mtermico += '<span class="input-group-btn">';
mtermico += '<button id="btn_Rem" class="btn btn-danger" type="button" style="display:none" data-toggle="tooltip" data-placement="left" title="Eliminar el Comprobante"><i class="fa fa-trash-o"></i></button>';
mtermico += '<button style="margin-left:-1px" id="btn_Find" class="btn btn-info" type="button" data-toggle="tooltip" data-placement="left" title="Buscar el Comprobante"><i class="fa fa-search-plus"></i></button>';
mtermico += '</span>';
mtermico += '</div>';
mtermico += '<label id="ErrFile" class="error" style="display:none"></label>';
mtermico += '</div>';

mtermico += '<div class="radio col-lg-12"><label><input type="radio" name="radiopago"> Pago Contado (Efectivo)</label></div>';

mtermico += '<div style="margin-top:5px;" id="nucuotasapgag" class="form-group col-lg-12">';
mtermico += '<label style="display: table-cell">Numero de Cuotas a pagar:</label>';
mtermico += '<select name="num_cuotas" id="numcuotasapag" class="form-control" data-live-search="true" required="required" onchange="getvalselect(this);">';
mtermico += '<option value="" selected="selected">Seleccione...</option>';
mtermico += '</select>';
mtermico += '<div style="color:#ff0000;font-weight:bold;" id="cocategoriafcerror" class="invalid-feedback"></div>';
mtermico += '</div>';

mtermico += '<div style="margin-top:10px;" class="form-group col-lg-12">';
mtermico += '<div class="border p-3 p-md-4">';
mtermico += '<div class="heading_s1 mb-3">';
mtermico += '<h6 id="titledepa" style="color:#333;font-weight:bold;font-size:14px">Detalle de pago</h6>';
mtermico += '</div>';
mtermico += '<div class="table-responsive">';

mtermico += '<div class="table-responsive">';
mtermico += '<table class="table">';
mtermico += '<tbody>';
mtermico += '<tr>';
mtermico += '<td class="cart_total_label">Nro Cuotas a Pagar:</td>';
mtermico += '<td id="totalncuocanp" style="text-align:right" class="cart_total_amount"></td>';
mtermico += '</tr>';
mtermico += '<tr>';
mtermico += '<td class="cart_total_label">Total Pagado:</td>';
mtermico += '<td id="totalcuocanp" style="text-align:right" class="cart_total_amount"></td>';
mtermico += '</tr>';
mtermico += '</tbody>';
mtermico += '</table>';
mtermico += '</div>';

mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';

mtermico += '<button type="button" class="btn btn-success col_lg-12 col-lg-offset-7" href="javascript:void(0)" onclick="procpaofc()">Procesar Pago</button>';
mtermico += '<button type="button" style="margin-left:5px" data-dismiss="modal" class="btn btn-secondary col_lg-12">Cerrar</button>';

mtermico += '</div>';


mtermico += '</div>';
mtermico += '</div>';
mtermico += '</div>';












document.getElementById('mtermico').innerHTML = mtermico;










