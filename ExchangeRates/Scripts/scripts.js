$(document).ready(function () {
    /* обработка чисел с запятой для сортировки*/
    $.extend($.fn.dataTableExt.oSort, {
        "numeric-comma-pre": function (a) {
            var x = (a == "-") ? 0 : a.replace(/,/, ".");
            return parseFloat(x);
        },

        "numeric-comma-asc": function (a, b) {
            return ((a < b) ? -1 : ((a > b) ? 1 : 0));
        },

        "numeric-comma-desc": function (a, b) {
            return ((a < b) ? 1 : ((a > b) ? -1 : 0));
        }
    });
    $("#valutesTable").DataTable({
        columnDefs: [
            { targets: [3,4,5,6], type: 'numeric-comma' }
        ]
    });
});
