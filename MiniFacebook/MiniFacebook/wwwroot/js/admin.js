$(document).ready(function () {
    loadData();
});
function loadData() {
    $.ajax({
        url: "/Admin/ListRoles",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var c = [];
            $.each(result, function (key, item) {

                c.push("<tr><td>" + item.id + "</td>");
                c.push("<td>" + item.name + "</td>");
                c.push("<td>" + item.description + "</td>");
                c.push("<td><button type='button' class='btn btn-primary'  onclick='return getbyID(" + item.id + ");'>Edit</button> </td>");
                c.push("<td><button type='button' class='btn btn-danger'  onclick='return Delete(" + item.id + ");'>Delele</button></td></tr>");
            });
            $('.tbody').html(c.join(''));
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}   
function Add() {
    
    $.ajax({
        url: "/Admin/ManageRoles",
        data: { RoleDescription: $('#RoleDescription').val(), RoleName: $('#RoleName').val()},
        type: "POST",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#Id').val("");
            $('#RoleDescription').val("");
            $('#RoleName').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function getbyID(Id) {
    $('#RoleName').css('border-color', 'lightgrey');
    $('#RoleDescription').css('border-color', 'lightgrey');
    
    $.ajax({
        url: "/Admin/getbyID/" + Id,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#Id').val(result.Id);
            $('#RoleName').val(result.Name);
            $('#RoleDescription').val(result.Description);
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}
function Update() {
    $.ajax({
        url: "/Admin/EditRole",
        data: { Id: $('#Id').val(), RoleDescription: $('#RoleDescription').val(), RoleName: $('#RoleName').val() },
        type: "POST",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#Id').val("");
            $('#RoleDescription').val("");
            $('#RoleName').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
function Delete(ID) {
    var ans = confirm("Are you sure you want to delete this Record?");
    if (ans) {
        $.ajax({
            url: "/admin/DeleteRole/" + ID,
            type: "POST",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}
function clearTextBox() {
    $('#ID').val("");
    $('#Name').val("");
    $('#Age').val("");
    $('#State').val("");
    $('#Country').val("");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#Name').css('border-color', 'lightgrey');
    $('#Age').css('border-color', 'lightgrey');
    $('#State').css('border-color', 'lightgrey');
    $('#Country').css('border-color', 'lightgrey');
}
function validate() {
    var isValid = true;
    if ($('#Name').val().trim() == "") {
        $('#Name').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Name').css('border-color', 'lightgrey');
    }
    if ($('#Age').val().trim() == "") {
        $('#Age').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Age').css('border-color', 'lightgrey');
    }
    if ($('#State').val().trim() == "") {
        $('#State').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#State').css('border-color', 'lightgrey');
    }
    if ($('#Country').val().trim() == "") {
        $('#Country').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Country').css('border-color', 'lightgrey');
    }
    return isValid;
}