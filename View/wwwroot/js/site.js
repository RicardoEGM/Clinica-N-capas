
var tableCita;

$(function () {
    GetCitas();
})


function GetCitas() {

    tableCita = $('#cita-table').DataTable({
        "destroy": true,
        "processing": true,
        "deferRender": true,
        "autoWidth": false,
        "responsive": true,
        "select": true,
        "ajax": {
            "url": url_GetCitas,
            "cache": false,
            "type": "GET",
        },
        "columns": [
            {
                "data": "citaID", "width": "3%"
            },
            {
                "data": "doctoresID", "width": "17%"
            },
            {
                "data": "pacienteID", "width": "17%"
            },
            {
                "data": "finicio", "width": "17%"
            },
            {
                "data": "estado", "width": "17%"
            },
            {
                "data": "diagnóstico"
            }
        ],
        "columnDefs": [
            {
                "targets": "*",
                "className": "text-center"
            }
        ]
    });

}
