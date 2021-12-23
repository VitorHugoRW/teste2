$(document).ready(function () {
    $('#busca').keypress(function (e) {
        if (e.which === 13) {
            load();
        }
    });
    load();
});

function load() {
    let carro = $('[name="busca"]').val();
    CarroListaCarros(carro).then(function (data) {
        $('#table tbody').html('');
        data.forEach(obj => {
            $('#table tbody').append('' +
                '<tr id="obj-' + obj.id + '">' +
                '<td>' + (obj.nome_carros || '--') + '</td>' +
                '<td>' + (obj.ano_carros || '--') + '</td>' +
                '<td>' + (obj.modelo_carros || '--') + '</td>' +
                '<td> <img style="width:100px" src="https://www.autoo.com.br/fotos/2021/8/1280_960/peugeot_208_2022_1_09082021_49896_1280_960.jpg"></td>' +
                '</tr>');
        });
      
    });
}

