$(document).ready(function () {
    GetProduct();
});

$('#language').on('change', function () {
    console.log('change');
    $('#currency').val($('#language').val());
    //$.ajax({

    //    url: 'http://localhost:44354/GetCurrency',
    //    type: 'GET',
    //    data: {
    //        'Id': $('#language').val()
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        alert('Data: ' + data);
    //    },
    //    error: function (request, error) {
    //        alert("Request: " + JSON.stringify(request));
    //    }
    //});
});

function GetCustomer() {
    $.ajax({

        url: 'http://localhost:44354/api/Customer/Get',
        type: 'GET',
        success: function (data) {
            console.log('customer',data);
        },
        error: function (request, error) {
            alert("Request: " + JSON.stringify(request));
        }
    });
}

function GetProduct() {
    $.ajax({
        url: 'https://localhost:44354/api/product',
        type: 'GET',
        dataType : 'json',
        success: function (data) {
            console.log('product', data);
        }, error: function (data) {
            console.log('product', data);

        }
            
    });
}