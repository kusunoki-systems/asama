$(function () {
    // 有効期限開始
    $("#GDRG_ValidDateFromCheck").on("change", function () {
        if ($("#GDRG_ValidDateFromCheck").prop("checked")) {
            // チェックがはいっている
            $('#GDRG_ValidDateFrom').prop('disabled', true);
            $('#GDRG_ValidDateFrom').val('1900-01-01');
        } else {
            // チェックがはいっていない
            $('#GDRG_ValidDateFrom').prop('disabled', false);
        }
    });
    //有効期限終了
    $("#GDRG_ValidDateToCheck").on("change", function () {
        if ($("#GDRG_ValidDateToCheck").prop("checked")) {
            // チェックがはいっている
            $('#GDRG_ValidDateTo').prop('disabled', true);
            if ($('#GDRG_ValidDateTo').val() == '') {
              $('#GDRG_ValidDateTo').val('2900-12-31');
            }
        } else {
            // チェックがはいっていない
            $('#GDRG_ValidDateTo').prop('disabled', false);
            if ($('#GDRG_ValidDateTo').val() == '2900-12-31') {
                var now = new Date();
                var y = now.getFullYear();
                var m = ("0" + (now.getMonth() + 1)).slice(-2);
                var d = ("0" + now.getDate()).slice(-2);
                $('#GDRG_ValidDateTo').val(y + '-' + m + '-' + d);
            }
        }
    });
    //注射
    $("#GDRG_OrderInjectionFlag").on("change", function () {
        if($("#GDRG_OrderInjectionFlag").prop("checked")) {
            // チェックがはいっている
            $('#GDRG_Syringeful').prop('disabled', false);
        } else {
            // チェックがはいっていない
            $('#GDRG_Syringeful').prop('disabled', true);
        }
    });
    //処方
    $("#GDRG_OrderMedicineFlag").on("change", function () {
        if ($("#GDRG_OrderMedicineFlag").prop("checked")) {
            // チェックがはいっている
            $('#GDRG_UnitPharm').prop('disabled', false);
        } else {
            // チェックがはいっていない
            $('#GDRG_UnitPharm').prop('disabled', true);
        }
    });
    ////新規の場合のオーダ初期単位
    //$("#GDRG_UnitInit").on("change", function () {
    //    if ($("#GDRG_HotCode").val('<自動採番>')) {
    //        // 新規の場合
    //        //$('#GDRG_UnitReceipt').val($('#GDRG_UnitInit').val())
    //        var txt = $('[name = GDRG_UnitInit] option:selected').text();
    //        //$('#GDRG_UnitReceipt').val(txt);
    //        $('#GDRG_UnitReceipt').val($('#GDRG_UnitInit').val());
    //    }
    //});
});