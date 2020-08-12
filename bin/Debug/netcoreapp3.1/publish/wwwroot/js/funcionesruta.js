$(document).ready(function () {

    toastr.options = {
        "debug": false,
        "newestOnTop": false,
        "positionClass": "toast-bottom-right",
        "closeButton": true,
        "progressBar": true
    };    
  

    $('#btngrabarruta').on('click', function (event) {
        var arr = [];
        var codigo, nombre, vendedorId, desdeuno = "", hastauno = "", desdedos = "", hastados = "", zonaId;
        codigo = $('#Txtcodigo').val();
        nombre = $('#Txtnombre').val();
        vendedorId = $('#Cmbvendedor').val();
        desdeuno = $('#Txtdesdeuno').val();
        hastauno = $('#Txthastauno').val();
        desdedos = $('#Txtdesdedos').val();
        hastados = $('#Txthastados').val();
        zonaId = $('input:radio[name=optionsRadios]:checked').val();
        
        if (codigo == '') {
            toastr.warning('Warning - El Codigo no puede estar vacio');
        }
        else
            if (nombre == '') {
                toastr.warning('Warning - El Nombre no puede estar vacio');
            }
            else
                if (desdeuno == '') {
                    toastr.warning('Warning - La Calle A1 no puede estar vacio');
                }
                else
                    if (hastauno == '') {
                        toastr.warning('Warning - La Calle A2 no puede estar vacio');
                    }
                    else
                        if (desdedos == '') {
                            toastr.warning('Warning - La Calle B1 no puede estar vacio');
                        }
                        else
                            if (hastados == '') {
                                toastr.warning('Warning - La Calle B2 no puede estar vacio');
                            }
                            else
                                if (zonaId == '0' || zonaId == '' || zonaId == undefined) {
                                    toastr.warning('Warning - Debe Seleccionar la Zona');
                                }
                                else {

                                    $.ajax({
                                        dataType: 'JSON',
                                        type: 'POST',
                                        url: "/Ruta/GuardarRuta",
                                        data: { "CodigoIn": codigo, "NombreIn": nombre, "vendedorId": vendedorId, "Desde1": desdeuno, "Hasta1": hastauno, "Desde2": desdedos, "Hasta2": hastados, "Codzona": zonaId },
                                        success: function (r) {
                                            if (r.success) {
                                                $('#Txtcodigo').val("");
                                                $('#Txtnombre').val("");
                                                $('#Txtdesdeuno').val("");
                                                $('#Txthastauno').val("");
                                                $('#Txtdesdedos').val("");
                                                $('#Txthastados').val("");
                                                $("#optionsRadios").prop("checked", false);
                                                toastr.info('Info - El Registro se guardo de forma Exitosa');
                                            }
                                            else {
                                                toastr.error('Error - Ocurrio un Error al guardar los Datos');
                                            }
                                        },
                                        error: function (jqXHR, textStatus, errorThrown) {
                                            console.log(textStatus + ' ' + errorThrown);
                                        }
                                    });
                                }
        return false;
    });

    $('#btnactualizarruta').on('click', function (event) {
        var arr = [];
        var codigo, nombre, vendedorId, desdeuno = "", hastauno = "", desdedos = "", hastados = "", zonaId;
        codigo = $('#Txtcodigo').val();
        nombre = $('#Txtnombre').val();
        vendedorId = $('#Cmbvendedor').val();
        desdeuno = $('#Txtdesdeuno').val();
        hastauno = $('#Txthastauno').val();
        desdedos = $('#Txtdesdedos').val();
        hastados = $('#Txthastados').val();
        zonaId = $('input:radio[name=optionsRadios]:checked').val();

        if (codigo == '') {
            toastr.warning('Warning - El Codigo no puede estar vacio');
        }
        else
            if (nombre == '') {
                toastr.warning('Warning - El Nombre no puede estar vacio');
            }
            else
                if (desdeuno == '') {
                    toastr.warning('Warning - La Calle A1 no puede estar vacio');
                }
                else
                    if (hastauno == '') {
                        toastr.warning('Warning - La Calle A2 no puede estar vacio');
                    }
                    else
                        if (desdedos == '') {
                            toastr.warning('Warning - La Calle B1 no puede estar vacio');
                        }
                        else
                            if (hastados == '') {
                                toastr.warning('Warning - La Calle B2 no puede estar vacio');
                            }
                            else
                                if (zonaId == '0' || zonaId == '' || zonaId == undefined) {
                                    toastr.warning('Warning - Debe Seleccionar la Zona');
                                }
                                else {

                                    $.ajax({
                                        dataType: 'JSON',
                                        type: 'POST',
                                        url: "/Ruta/ModificarRuta",
                                        data: { "CodigoIn": codigo, "NombreIn": nombre, "vendedorId": vendedorId, "Desde1": desdeuno, "Hasta1": hastauno, "Desde2": desdedos, "Hasta2": hastados, "Codzona": zonaId },
                                        success: function (r) {
                                            if (r.success) {
                                                toastr.info('Info - El Registro se actualizo de forma Exitosa');
                                            }
                                            else {
                                                toastr.error('Error - Ocurrio un Error al actualizar los Datos');
                                            }
                                        },
                                        error: function (jqXHR, textStatus, errorThrown) {
                                            console.log(textStatus + ' ' + errorThrown);
                                        }
                                    });
                                }
        return false;
    });
    
})