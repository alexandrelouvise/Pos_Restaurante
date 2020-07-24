$(document).ready(function () {
    var id = $("#Id");

    $.ajax({
        url: "/Cliente/CarregarDetalhes",
        type: "GET",
        data: { id: id.val() },
        success: function (data) {
            CarregarDetalhes(data);
        }
    });

});

function CarregarDetalhes(data) {
    for (var i = 0; i < data.listEndereco.length; i++) {

        var row = $("<tr>");
        console.log(data.listEndereco[i]);
        console.log(data.listEndereco[i].endereco);
        row.append($("<td>" + data.listEndereco[i].rua + "</td>"))
            .append($("<td>" + data.listEndereco[i].numero + "</td>"))
            .append($("<td>" + data.listEndereco[i].complemento + "</td>"))
            .append($("<td>" + data.listEndereco[i].bairro + "</td>"))
            .append($("<td>" + data.listEndereco[i].cidade + "</td>"))
            .append($("<td><input type='button' value='Remove' onclick='Remove(this)' /></td>"));

        $("#tblEnderecos tbody").append(row);
    }
};


function RemoveEndereco(button) {
    //Determine the reference of the Row using the Button.
    var row = $(button).closest("TR");
    var name = $("TD", row).eq(0).html();
    var table = $("#tblEnderecos")[0];

    //Delete the Table row using it's Index.
    table.deleteRow(row[0].rowIndex);
};

$("body").on("click", "#btnSave", function () {
    //Loop through the Table rows and build a JSON array.
    var clientes = new Array();
    var enderecos = new Array();
    var telefones = new Array();

    var cliente = {};
    cliente.Nome = $("#Nome").val();
    cliente.Apelido = $("#Apelido").val();

    $("#tblTelefones TBODY TR").each(function () {
        var row = $(this);
        telefone = {};
        telefone.NumeroTelefone = row.find("TD").eq(0).html();
        telefones.push(telefone);
    });

    $("#tblEnderecos TBODY TR").each(function () {
        var row = $(this);
        endereco = {};
        endereco.Logradouro = row.find("TD").eq(0).html();
        endereco.Numero = row.find("TD").eq(1).html();
        endereco.Complemento = row.find("TD").eq(2).html();
        enderecos.push(endereco);
    });


    cliente.listTelefone = telefones;
    cliente.listEndereco = enderecos;
    clientes.push(cliente);
    console.log(JSON.stringify(clientes));


    ////Send the JSON array to Controller using AJAX.
    $.ajax({
        type: "POST",
        url: "/Cliente/Create",
        data: JSON.stringify(clientes),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            alert(r + " record(s) inserted.");
        }
    });
});

$("#addEnderecoRow").click(function () {
    var row = $("<tr>");

    var rua = $("#txtRua");
    var numero = $("#txtNumero");
    var complemento = $("#txtComplemento");
    var bairro = $("#txtBairro");
    var cidade = $("#txtCidade");

    row.append($("<td>" + rua.val() + "</td>"))
        .append($("<td>" + numero.val() + "</td>"))
        .append($("<td>" + complemento.val() + "</td>"))
        .append($("<td>" + bairro.val() + "</td>"))
        .append($("<td>" + cidade.val() + "</td>"))
        .append($("<td><input type='button' value='Remover' onclick='RemoveEndereco(this)' /></td>"));

    rua.val("");
    numero.val("");
    complemento.val("");
    bairro.val("");
    cidade.val("");

    $("#tblEnderecos tbody").append(row);
});

$("#addTelefoneRow").click(function () {
    var row = $("<tr>");

    var telefone = $("#txtTelefone");

    row.append($("<td>" + telefone.val() + "</td>"))
        .append($("<td><input type='button' value='Remove' onclick='RemoveTelefone(this)' /></td>"));

    telefone.val("");

    $("#tblTelefones tbody").append(row);
});

function RemoveTelefone(button) {
    //Determine the reference of the Row using the Button.
    var row = $(button).closest("TR");
    var name = $("TD", row).eq(0).html();
    var table = $("#tblTelefones")[0];

    //Delete the Table row using it's Index.
    table.deleteRow(row[0].rowIndex);
};
