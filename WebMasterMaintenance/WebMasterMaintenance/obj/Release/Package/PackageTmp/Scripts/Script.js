$(function () {
    $('#MDRG_ValidDateFrom.datepicker').datepicker({
        changeYear: true, //表示年の指定が可能
        changeMonth: true, //表示月の指定が可能
        dateFormat: 'yy-mm-dd', //年-月-日(曜日)
        onSelect: function (onSelect) {
            var toDate = $('#MDRG_ValidDateTo.datepicker').datepicker('getDate');
            $('#MDRG_ValidDateFrom.datepicker').datepicker('option', 'maxDate', toDate);
        }
    });

    $('#MDRG_ValidDateTo.datepicker').datepicker({
        changeYear: true, //表示年の指定が可能
        changeMonth: true, //表示月の指定が可能
        dateFormat: 'yy-mm-dd', //年-月-日(曜日)
        minDate: '0y',
        onSelect: function (onSelect) {
        var toDate = $(this).datepicker('getDate');
        $('#MDRG_ValidDateFrom.datepicker').datepicker('option','maxDate',toDate);
    }
    });

    if($('.load-start :disabled')){
        $('.load-start').prop('disabled', false);
    } else {
        $('.load-start').click(function () {
            $('#loading').show();
        });
    }

});


//各画面でのエンター発火を防止する
$(function () {
    $("input").on("keydown", function (e) {
        if ((e.which && e.which === 13) || (e.keyCode && e.keyCode === 13)) {
            return false;
        } else {
            return true;
        }
    });
});
    
//jQuery(window).load(function () {
//    alert("load stop")
//    jQuery("#loading").hide();
//});
window.onload = function () {
    $(function () {
        $("#loading").fadeOut();
        $("#container").fadeIn();
    });
        var toDate = $('#MDRG_ValidDateTo.datepicker').datepicker('getDate');
        $('#MDRG_ValidDateFrom.datepicker').datepicker('option', 'maxDate', toDate);
}

//医薬品グループマスタのチェックボックスで検索ボタン制御
$('#GM_Drug_Index .check-group input').click(function () {
        var check = 0;
        if ($('#GM_DosageFormClass1').is(':checked')) { check = check + 1; }
        if ($('#GM_DosageFormClass6').is(':checked')) { check = check + 1; }
        if ($('#GM_DosageFormClass4').is(':checked')) { check = check + 1; }
        if (check == 0) {
            $('#SubmitGMDrug').prop('disabled', true);
        }
        else {
            $('#SubmitGMDrug').prop('disabled', false);
        }
});


//全選択チェックボックス用処理
$('#row_all').click(function () {
    if ($("#row_all").is(":checked")) {
        $('.row_check').prop('checked', this.checked);
    }else{
        if ($('#rows :checked').length == $('#rows :input').length) {
            $('.row_check').prop('checked', false);
        }
    }
});

//個別選択チェックボックス用処理
$('.row_check, td.row_field').click(function () {
    if ($('#rows :checked').length == $('#rows :input').length) {
        $('#row_all').prop('checked', 'checked');
    } else {
        $('#row_all').prop('checked', false);
    }
});

////登録ボタン制御処理
$('#row_all, .row_check, td.row_field').click(function () {
    if ($('#rows :disabled').length !== $('#rows :input').length) {
        if ($('#rows :checked').length == $('#rows :disabled').length) {
            $('#Submit').prop('disabled', true);
        }
        else {
            $('#Submit').prop('disabled', false);
        }
    }
});

$('#SubmitDelete').click(function () {
    // 「OK」時の処理開始 ＋ 確認ダイアログの表示
    if (window.confirm("削除しますか？")) {
        //M_Drug
        $(':text').each(function () {
            if (this.id == 'MDRG_DrugName' ||
                this.id == 'MDRG_DrugKana' ||
                this.id == 'MDRG_DisplayDrugName' ||
                this.id == 'MDUT_UnitRatio') {
                this.type = 'hidden';
            }
       });
     }
     // 「キャンセル」時の処理開始
     else {
        return false;
     }
});

$('#btnCsvDownload').click(function () {
    var documentUrl = document.URL;
    var baseUrl = documentUrl.substring(0, documentUrl.indexOf('Index'));
    // baseUrl : 呼び出すControllerまでのurlを抽出したもの。
    location.href = baseUrl + 'CsvDownloadList';
});
