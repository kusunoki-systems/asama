$(function () {
    //// 有効期限開始
    //$("#MDRG_ValidDateFromCheck").on("change", function () {
    //    if ($("#MDRG_ValidDateFromCheck").prop("checked")) {
    //        // チェックがはいっている
    //        $('#MDRG_ValidDateFrom').val('1900-01-01');
    //        $('#MDRG_ValidDateFrom').prop('disabled', true);
    //    } else {
    //        // チェックがはいっていない
    //        $('#MDRG_ValidDateFrom').prop('disabled', false);
    //    }
    //});
    //有効期限終了
    var date = ''
    $("#MDRG_ValidDateToCheck").on("change", function () {
        if (date == '') {
            if ($('#MDRG_ValidDateTo').val() == '2900-12-31') {
                var now = new Date();
                var y = now.getFullYear();
                var m = ("0" + (now.getMonth() + 1)).slice(-2);
                var d = ("0" + now.getDate()).slice(-2);
                date = y + '-' + m + '-' + d;
            } else {
                date = $('#MDRG_ValidDateTo').val();
            }
        }
        if ($("#MDRG_ValidDateToCheck").prop("checked")) {
            // チェックがはいっている
            $('#MDRG_ValidDateTo').prop('disabled', true);
            date = $('#MDRG_ValidDateTo').val();
            $('#MDRG_ValidDateTo').val('2900-12-31');
        } else {
            // チェックがはいっていない
            $('#MDRG_ValidDateTo').prop('disabled', false);
            $('#MDRG_ValidDateTo').val(date)
        }
        var toDate = $('#MDRG_ValidDateTo.datepicker').datepicker('getDate');
        $('#MDRG_ValidDateFrom.datepicker').datepicker('option', 'maxDate', toDate);

    });
    //注射
    $("#MDRG_OrderInjectionFlag").on("change", function () {
        if($("#MDRG_OrderInjectionFlag").prop("checked")) {
            // チェックがはいっている
            $('#MDRG_Syringeful').prop('readonly', false);
        } else {
            // チェックがはいっていない
            $('#MDRG_Syringeful').prop('readonly', true);
        }
    });
    //処方
    $("#MDRG_OrderMedicineFlag").on("change", function () {
        if ($("#MDRG_OrderMedicineFlag").prop("checked")) {
            // チェックがはいっている
            $('#MDRG_UnitPharm').prop('readonly', false);
        } else {
            // チェックがはいっていない
            $('#MDRG_UnitPharm').prop('readonly', true);
        }
    });
    //新規の場合のオーダ初期単位
    $("#MDRG_UnitInit").on("change", function () {
        if ($("#MDRG_HotCode").val('<自動採番>')) {
            // 新規の場合
            //$('#MDRG_UnitReceipt').val($('#MDRG_UnitInit').val())
            var txt = $('[name = MDRG_UnitInit] option:selected').text();
            //$('#MDRG_UnitReceipt').val(txt);
            $('#MDRG_UnitReceipt').val($('#MDRG_UnitInit').val());
        }
    });
});