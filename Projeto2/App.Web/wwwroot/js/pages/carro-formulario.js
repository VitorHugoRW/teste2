function salvar() {
    let obj = {
        nome_carros: ($("[name='nome_carros']").val() || ''),
        ano_carros: ($("[name='ano_carros']").val() || ''),
        modelo_carros: ($("[name='modelo_carros']").val() || '')
    };

    CarroSalvar(obj).then(function () {
        window.location.href = '/carro';
    }, function (err) {
        alert(err);
    });
    $('#table-carros').DataTable();
}
