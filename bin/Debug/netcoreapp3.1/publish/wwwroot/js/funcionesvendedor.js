$(document).ready(function () {

    toastr.options = {
        "debug": false,
        "newestOnTop": false,
        "positionClass": "toast-bottom-right",
        "closeButton": true,
        "progressBar": true
    };
    
    // Handle minimalize left menu
    $('#btnagregar').on('click', function (event) {       
        var objeto, porinf, porsup, porccom;
        porinf = $("#Porcinferior").val();
        porsup = $("#Porcsuperior").val()
        porccom = $("#Porccomision").val();

        var rowCount = $('#tablacomisiones tr').length++;
        var trHTML = '<tr><td>' + rowCount + '</td><td>' + porinf + '</td><td>' + porsup + '</td><td>' + porccom + '</td><td><a href="#"><i class="fa fa-trash-o"></i></a></td></tr>';   
        $('#tablacomisiones').append(trHTML);
        $.ajax({
            dataType: 'JSON',
            type: 'POST',
            url: "/Vendedor/AgregarComision",//form.attr('action'),
            data: { "porcinf": porinf, "porsup": porsup, "porccom": porccom },//form.serialize(),
            success: function (r) {
                $("#Porcinferior").val("");
                $("#Porcsuperior").val("")
                $("#Porccomision").val("");
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus + ' ' + errorThrown);
            }
        });

        return false;

    });

    $('#btngrabar').on('click', function (event) {
        var arr = [];
        var codigo, nombre, direccion, email, interno="F", cobrador="F", montometa;
        codigo = $('#Txtcodigo').val();
        nombre = $('#Txtnombre').val();
        direccion = $('#Txtdireccion').val();
        email = $('#Txtemail').val();
        montometa = $('#Txtmontometa').val();
        if (codigo == '') {
            toastr.warning('Warning - El Codigo no puede estar vacio');
        }
        else
            if (nombre == '') {
                toastr.warning('Warning - El Nombre no puede estar vacio');
            }
            else
                if (direccion == '') {
                    toastr.warning('Warning - La Direccion no puede estar vacio');
                }
                else
                    if (email == '') {
                        toastr.warning('Warning - El Email no puede estar vacio');
                    }
                    else
                        if (montometa == '') {
                            toastr.warning('Warning - El Monto de la Meta no puede estar vacio');
                        }
                        else {
                            if ($('#Interno').is(':checked')) {
                                interno = "T";
                            }
                            if ($('#Cobrador').is(':checked')) {
                                cobrador = "T";
                            }
                            $('#tablacomisiones > tbody  > tr').each(function () {
                                var porcinferior = $(this).find("td").eq(1).html();
                                var porcsuperior = $(this).find("td").eq(2).html();
                                var porccomision = $(this).find("td").eq(3).html();
                                alert("Inferior " + porcinferior + " Superior " + porcsuperior + " Comision " + porccomision);
                                arr.push({ Porcentajeinferior: porcinferior, Porcentajesuperior: porcsuperior, Porcentajecomisionvendedor: porccomision, Codvendedor: codigo })

                            });
                            $.ajax({
                                dataType: 'JSON',
                                type: 'POST',
                                url: "/Vendedor/GuardarVendedor",
                                data: { "Codigo": codigo, "Nombre": nombre, "Interno": interno, "Cobrador": cobrador, "Direccionfiscal": direccion, "Correoe": email, "LstComisiones": arr, "Montometa": montometa },
                                success: function (r) {
                                    if (r.success) {
                                        $('#Txtcodigo').val("");
                                        $('#Txtnombre').val("");
                                        $('#Txtdireccion').val("");
                                        $('#Txtemail').val("");
                                        $("#Interno").prop("checked", false);
                                        $("#Cobrador").prop("checked", false);
                                        $("#Txtmontometa").val("0");
                                        $('#tablacomisiones tbody').empty();
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

    $('#btnactualizar').on('click', function (event) {
        var arr = [];
        var codigo, nombre, direccion, email, interno = "F", cobrador = "F", montometa;
        codigo = $('#Txtcodigo').val();
        nombre = $('#Txtnombre').val();
        direccion = $('#Txtdireccion').val();
        email = $('#Txtemail').val();
        montometa = $('#Txtmontometa').val();
        if (codigo == '') {
            toastr.warning('Warning - El Codigo no puede estar vacio');
        }
        else
            if (nombre == '') {
                toastr.warning('Warning - El Nombre no puede estar vacio');
            }
            else
                if (direccion == '') {
                    toastr.warning('Warning - La Direccion no puede estar vacio');
                }
                else
                    if (email == '') {
                        toastr.warning('Warning - El Email no puede estar vacio');
                    }
                    else
                        if (montometa == '') {
                            toastr.warning('Warning - El Monto de la Meta no puede estar vacio');
                        }
                        else {
                            if ($('#Interno').is(':checked')) {
                                interno = "T";
                            }
                            if ($('#Cobrador').is(':checked')) {
                                cobrador = "T";
                            }
                            $('#tablacomisiones > tbody  > tr').each(function () {
                                var porcinferior = $(this).find("td").eq(1).html();
                                var porcsuperior = $(this).find("td").eq(2).html();
                                var porccomision = $(this).find("td").eq(3).html();
                                alert("Inferior " + porcinferior + " Superior " + porcsuperior + " Comision " + porccomision);
                                arr.push({ Porcentajeinferior: porcinferior, Porcentajesuperior: porcsuperior, Porcentajecomisionvendedor: porccomision, Codvendedor: codigo })

                            });
                            $.ajax({
                                dataType: 'JSON',
                                type: 'POST',
                                url: "/Vendedor/ActualizarVendedor",
                                data: { "Codigo": codigo, "Nombre": nombre, "Interno": interno, "Cobrador": cobrador, "Direccionfiscal": direccion, "Correoe": email, "LstComisiones": arr, "Montometa": montometa },
                                success: function (r) {
                                    if (r.success) {
                                       /* $('#Txtcodigo').val("");
                                        $('#Txtnombre').val("");
                                        $('#Txtdireccion').val("");
                                        $('#Txtemail').val("");
                                        $("#Interno").prop("checked", false);
                                        $("#Cobrador").prop("checked", false);
                                        $("#Txtmontometa").val("0");
                                        $('#tablacomisiones tbody').empty();*/
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

    $(".btn-default").on("click", function () {
        var tr = $(this).closest('tr');
        tr.remove();
    });


})

