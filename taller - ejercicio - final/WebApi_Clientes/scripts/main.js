$(function () {
    $('#btnLogin').click(function () { loginUsuario(); });
});

function ajax(strUsuario, strClave) {
    var result;
    var usuario = {};
    usuario.User = strUsuario;
    usuario.Clave = strClave;

    $.ajax({
        url: 'http://localhost:6030/api/login',
        type: 'POST',
        data: usuario,
        async: false
    }).done(function (data) {
        result = data;
    }).error(function (xhr, status, error) {
        alert(error);
        var s = status;
        var e = error;
    });

    return result;
}

function loginUsuario() {
    if (validar() == true) {
        var usuario = $("#txtUsuario").val();
        var clave = $("#txtClave").val();
        var result = ajax(usuario, clave);
        alert(result);
    } else {
        alert('Debe completar todos los campos');
    }
    
}

function validar() {
    usuario = document.getElementById("txtUsuario").value;
    clave = document.getElementById("txtClave").value;
    if (usuario.length == 0 || clave.length == 0) {
        return false;
    }
    return true;
}


