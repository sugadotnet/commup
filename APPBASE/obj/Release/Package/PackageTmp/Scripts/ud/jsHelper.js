/*=========================================
AJAX Section
=========================================*/
function AJAXTypePOST() {
    return "POST";
} //End function AJAXTypePOST
function AJAXTypeGET() {
    return "GET";
} //End function AJAXTypeGET
function AJAXContentTypeAppJsonUtf() {
    return "application/json; charset=utf-8";
} //End function AJAXContentTypeAppJsonUtf
function AJAXDataTypeJson() {
    return "json";
} //End function AJAXDataTypeJson

/*=========================================
GET COMMAND ID SECTION
=========================================*/
function getRowidFromCmd(psCmdID){
	var vReturn = psCmdID;
	var vReturn = vReturn.
	              replace(getLabelCmdAsCRUDNew(),'').
	              replace(getLabelCmdAsCRUDEdit(),'').
	              replace(getLabelCmdAsCRUDDelete(),'').
	              replace(getLabelCmdAsCRUDSave(),'').
	              replace(getLabelCmdAsCRUDReset(),'').
	              replace(getLabelCmdAsCRUDView(),'').
	              replace(getLabelCmdAsCRUDPrint(),'').
				  replace(getLabelCmdToView(),'').
				  replace(getLabelCmdToPrint(),'');
	return vReturn;
} //End function getDatarowid
function getCmdTypeFromRowid(psCmdID, psRowid){
	return psCmdID.replace(psRowid, '');
} //End function getCmdTypeFromRowid
function getRowDataValue(psRowid, psPrefixID){
	return $('#'+psPrefixID+psRowid).val();;
} //End function getRowDataValue

/*=========================================
Action Command ToDo By RUID
=========================================*/
function doActionToViewByRUID(psRUID, psURL){
	//window.location = psURL;
	//alert(psURL);
	$.ajax({
	    type: AJAXTypePOST(),
	    url: psURL,
	    success: function(msg) {
			$('#result').html(msg);
	    }, //success
	    complete: function() {
	    }, //End complete
	    error: function() {
	    } //End error
	}); //End jQueryAJAX POST
} //End function doActionToViewByRUID
function doActionToPrintByRUID(psRUID, psURL){
	alert('No Data to Print');
} //End function doActionToPrintByRUID

/*=========================================
LOGIN VALIDATION
=========================================*/
function isValidLogin(psUserID, psPassword) {
    vReturn = true;
    if ((psUserID == '') || (psUserID == null) ||
         (psPassword == '') || (psPassword == null)) {
        vReturn = false;
    } //End if
    return vReturn;
} //End function isValidLogin
/*=========================================
FIELD VIEW STATE
=========================================*/
function setStateView() {
    //Color TextBox
    $("input[type=text], input[type=password], textarea").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldAsLabelDesc, textarea.FieldAsLabelDesc").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldEnableOnNew, textarea.FieldEnableOnNew").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldAsReadOnly, textarea.FieldAsReadOnly").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldEnableAlways, input[type=password].FieldEnableAlways, textarea.FieldEnableAlways").removeClass(gsFieldDisable).addClass(gsFieldEnable);
    //ReadOnly TextBox
    $("input[type=text], input[type=password]").attr('readonly', 'readonly');
    $("input[type=text].FieldEnableAlways, input[type=password].FieldEnableAlways").removeAttr("readonly");
    //ReadOnly TextArea
    $("textarea").attr('readonly', 'readonly');
    $("textarea.FieldEnableAlways").removeAttr("readonly");
    //Enabled/Disabled button
    $("button.CmdAsLookUpKey").removeAttr("disabled");
    $("button.CmdAsLookUp").attr("disabled", "disabled");
    $("button.CmdAsLinkKey").removeAttr("disabled");
    $("button.CmdAsLinkUpload").attr("disabled", "disabled");
    $("button.CmdAsLink").attr("disabled", "disabled");
    $("button.CmdAsCalendar").attr("disabled", "disabled");
    $("button.CmdAsLinkAlwaysEnable").removeAttr("disabled");
    $("button.CmdAsLookUpAlwaysEnable").removeAttr("disabled");
    //Enabled/Disabled button Base
    $("button.CmdAsLookUpKey").removeClass(gscmdLookUpDisabled).addClass(gscmdLookUpEnabled);
    $("button.CmdAsLookUp").removeClass(gscmdLookUpEnabled).addClass(gscmdLookUpDisabled);
    $("button.CmdAsLinkKey").removeClass(gscmdLinkDisabled).addClass(gscmdLinkEnabled);
    $("button.CmdAsLink").removeClass(gscmdLinkEnabled).addClass(gscmdLinkDisabled);
    $("button.CmdAsLinkUpload").removeClass(gscmdUploadEnabled).addClass(gscmdUploadDisabled);
    $("button.CmdAsCalendar").removeClass(gscmdCalendarEnabled).addClass(gscmdCalendarDisabled);
    $("button.CmdAsLinkAlwaysEnable").removeClass(gscmdLinkDisabled).addClass(gscmdLinkEnabled);
    $("button.CmdAsLookUpAlwaysEnable").removeClass(gscmdLookUpDisabled).addClass(gscmdLookUpEnabled);
    //Enabled/Disabled button Icon
    $("button.CmdAsLookUpKey i").removeClass(gscmdLookUpIconDisabled).addClass(gscmdLookUpIconEnabled);
    $("button.CmdAsLookUp i").removeClass(gscmdLookUpIconEnabled).addClass(gscmdLookUpIconDisabled);
    $("button.CmdAsLinkKey i").removeClass(gscmdLinkIconDisabled).addClass(gscmdLinkIconEnabled);
    $("button.CmdAsLink i").removeClass(gscmdLinkIconEnabled).addClass(gscmdLinkIconDisabled);
    $("button.CmdAsLinkUpload i").removeClass(gscmdUploadIconEnabled).addClass(gscmdUploadIconDisabled);
    $("button.CmdAsCalendar i").removeClass(gscmdCalendarIconEnabled).addClass(gscmdCalendarIconDisabled);
    $("button.CmdAsLinkAlwaysEnable i").removeClass(gscmdLinkIconDisabled).addClass(gscmdLinkIconEnabled);
    $("button.CmdAsLookUpAlwaysEnable i").removeClass(gscmdLookUpIconDisabled).addClass(gscmdLookUpIconEnabled);
    //Diable/Enable Command CRUD
    setStateViewButton();
} //End function setStateView()
function setStateNew() {
    //Color TextBox
    $("input[type=text], input[type=password], textarea").removeClass(gsFieldDisable).addClass(gsFieldEnable);
    $("input[type=text].FieldAsLabelDesc, textarea.FieldAsLabelDesc").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldEnableOnNew, textarea.FieldEnableOnNew").removeClass(gsFieldDisable).addClass(gsFieldEnable);
    $("input[type=text].FieldAsReadOnly, textarea.FieldAsReadOnly").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldEnableAlways, input[type=password].FieldEnableAlways, textarea.FieldEnableAlways").removeClass(gsFieldDisable).addClass(gsFieldEnable);
    //ReadOnly TextBox
    $("input[type=text], input[type=password]").removeAttr("readonly");
    $("input[type=text].FieldAsLabelDesc").attr('readonly', 'readonly');
    $("input[type=text].FieldEnableOnNew").removeAttr("readonly");
    $("input[type=text].FieldAsReadOnly").attr('readonly', 'readonly');
    $("input[type=text].FieldEnableAlways, input[type=password].FieldEnableAlways").removeAttr("readonly");
    //ReadOnly TextArea
    $("textarea").removeAttr("readonly");
    $("textarea.FieldAsLabelDesc").attr('readonly', 'readonly');
    $("textarea.FieldEnableOnNew").removeAttr("readonly");
    $("textarea.FieldAsReadOnly").attr('readonly', 'readonly');
    $("textarea.FieldEnableAlways").removeAttr("readonly");
    //Enabled/Disabled button
    $("button.CmdAsLookUpKey").attr("disabled", "disabled");
    $("button.CmdAsLookUp").removeAttr("disabled");
    $("button.CmdAsLinkKey").attr("disabled", "disabled");
    $("button.CmdAsLinkUpload").removeAttr("disabled");
    $("button.CmdAsLink").removeAttr("disabled");
    $("button.CmdAsCalendar").removeAttr("disabled");
    $("button.CmdAsLinkAlwaysEnable").removeAttr("disabled");
    $("button.CmdAsLookUpAlwaysEnable").removeAttr("disabled");
    //Enabled/Disabled button Base
    $("button.CmdAsLookUpKey").removeClass(gscmdLookUpEnabled).addClass(gscmdLookUpDisabled);
    $("button.CmdAsLookUp").removeClass(gscmdLookUpDisabled).addClass(gscmdLookUpEnabled);
    $("button.CmdAsLinkKey").removeClass(gscmdLinkEnabled).addClass(gscmdLinkDisabled);
    $("button.CmdAsLinkUpload").removeClass(gscmdUploadDisabled).addClass(gscmdUploadEnabled);
    $("button.CmdAsLink").removeClass(gscmdLinkDisabled).addClass(gscmdLinkEnabled);
    $("button.CmdAsCalendar").removeClass(gscmdCalendarDisabled).addClass(gscmdCalendarEnabled);
    $("button.CmdAsLinkAlwaysEnable").removeClass(gscmdLinkDisabled).addClass(gscmdLinkEnabled);
    $("button.CmdAsLookUpAlwaysEnable").removeClass(gscmdLookUpDisabled).addClass(gscmdLookUpEnabled);
    //Enabled/Disabled button Icon
    $("button.CmdAsLookUpKey i").removeClass(gscmdLookUpIconEnabled).addClass(gscmdLookUpIconDisabled);
    $("button.CmdAsLookUp i").removeClass(gscmdLookUpIconDisabled).addClass(gscmdLookUpIconEnabled);
    $("button.CmdAsLinkKey i").removeClass(gscmdLinkIconEnabled).addClass(gscmdLinkIconDisabled);
    $("button.CmdAsLinkUpload i").removeClass(gscmdUploadIconDisabled).addClass(gscmdUploadIconEnabled);
    $("button.CmdAsLink i").removeClass(gscmdLinkIconDisabled).addClass(gscmdLinkIconEnabled);
    $("button.CmdAsCalendar i").removeClass(gscmdCalendarIconDisabled).addClass(gscmdCalendarIconEnabled);
    $("button.CmdAsLinkAlwaysEnable i").removeClass(gscmdLinkIconDisabled).addClass(gscmdLinkIconEnabled);
    $("button.CmdAsLookUpAlwaysEnable i").removeClass(gscmdLookUpIconDisabled).addClass(gscmdLookUpIconEnabled);
    //Diable/Enable Command CRUD
    setStateNewButton();
} //End function setStateNew()
function setStateEdit() {
    //Color TextBox
    $("input[type=text], input[type=password], textarea").removeClass(gsFieldDisable).addClass(gsFieldEnable);
    $("input[type=text].FieldAsLabelDesc, textarea.FieldAsLabelDesc").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldEnableOnNew, textarea.FieldEnableOnNew").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldAsReadOnly, textarea.FieldAsReadOnly").removeClass(gsFieldEnable).addClass(gsFieldDisable);
    $("input[type=text].FieldEnableAlways, input[type=password].FieldEnableAlways, textarea.FieldEnableAlways").removeClass(gsFieldDisable).addClass(gsFieldEnable);
    //ReadOnly TextBox
    $("input[type=text], input[type=password]").removeAttr("readonly");
    $("input[type=text].FieldAsLabelDesc").attr('readonly', 'readonly');
    $("input[type=text].FieldEnableOnNew").attr('readonly', 'readonly');
    $("input[type=text].FieldAsReadOnly").attr('readonly', 'readonly');
    $("input[type=text].FieldEnableAlways, input[type=password].FieldEnableAlways").removeAttr("readonly");
    //ReadOnly TextArea
    $("textarea").removeAttr("readonly");
    $("textarea.FieldAsLabelDesc").attr('readonly', 'readonly');
    $("textarea.FieldEnableOnNew").attr('readonly', 'readonly');
    $("textarea.FieldAsReadOnly").attr('readonly', 'readonly');
    $("textarea.FieldEnableAlways").removeAttr("readonly");

    //Enabled/Disabled button
    $("button.CmdAsLookUpKey").attr("disabled", "disabled");
    $("button.CmdAsLookUp").removeAttr("disabled");
    $("button.CmdAsLinkKey").removeAttr("disable");
    $("button.CmdAsLinkUpload").removeAttr("disabled");
    $("button.CmdAsLink").removeAttr("disabled");
    $("button.CmdAsCalendar").removeAttr("disabled");
    $("button.CmdAsLinkAlwaysEnable").removeAttr("disabled");
    $("button.CmdAsLookUpAlwaysEnable").removeAttr("disabled");
    
    //Enabled/Disabled button Base
    $("button.CmdAsLookUpKey").removeClass(gscmdLookUpEnabled).addClass(gscmdLookUpDisabled);
    $("button.CmdAsLookUp").removeClass(gscmdLookUpDisabled).addClass(gscmdLookUpEnabled);
    $("button.CmdAsLinkKey").removeClass(gscmdLinkEnabled).addClass(gscmdLinkDisabled);
    $("button.CmdAsLinkUpload").removeClass(gscmdUploadDisabled).addClass(gscmdUploadEnabled);
    $("button.CmdAsLink").removeClass(gscmdLinkDisabled).addClass(gscmdLinkEnabled);
    $("button.CmdAsCalendar").removeClass(gscmdCalendarDisabled).addClass(gscmdCalendarEnabled);
    $("button.CmdAsLinkAlwaysEnable").removeClass(gscmdLinkDisabled).addClass(gscmdLinkEnabled);
    $("button.CmdAsLookUpAlwaysEnable").removeClass(gscmdLookUpDisabled).addClass(gscmdLookUpEnabled);
    //Enabled/Disabled button Icon
    $("button.CmdAsLookUpKey i").removeClass(gscmdLookUpIconEnabled).addClass(gscmdLookUpIconDisabled);
    $("button.CmdAsLookUp i").removeClass(gscmdLookUpIconDisabled).addClass(gscmdLookUpIconEnabled);
    $("button.CmdAsLinkKey i").removeClass(gscmdLinkIconEnabled).addClass(gscmdLinkIconDisabled);
    $("button.CmdAsLinkUpload i").removeClass(gscmdUploadIconDisabled).addClass(gscmdUploadIconEnabled);
    $("button.CmdAsLink i").removeClass(gscmdLinkIconDisabled).addClass(gscmdLinkIconEnabled);
    $("button.CmdAsCalendar i").removeClass(gscmdCalendarIconDisabled).addClass(gscmdCalendarIconEnabled);
    $("button.CmdAsLinkAlwaysEnable i").removeClass(gscmdLinkIconDisabled).addClass(gscmdLinkIconEnabled);
    $("button.CmdAsLookUpAlwaysEnable i").removeClass(gscmdLookUpIconDisabled).addClass(gscmdLookUpIconEnabled);

    //Diable/Enable Command CRUD
    setStateEditButton();
} //End function setStateEdit()
/*=========================================
COMMAND VIEW STATE
=========================================*/
function setStateViewButton() {
    //Enable/Disable
    $(".cmdNew").removeAttr("disabled");
    $(".cmdEdit").attr("disabled", "disabled");
    $(".cmdDelete").attr("disabled", "disabled");
    $(".cmdSave").attr("disabled", "disabled");
    $(".cmdReset").removeAttr("disabled");
    //Enable/Disable Base
    $(".cmdNew").removeClass(gscmdNewDisabled).addClass(gscmdNewEnabled);
    $(".cmdEdit").removeClass(gscmdEditEnabled).addClass(gscmdEditDisabled);
    $(".cmdDelete").removeClass(gscmdDeleteEnabled).addClass(gscmdDeleteDisabled);
    $(".cmdSave").removeClass(gscmdSaveEnabled).addClass(gscmdSaveDisabled);
    $(".cmdReset").removeClass(gscmdResetDisabled).addClass(gscmdResetEnabled);
    //Enable/Disable Icon
    $(".cmdNew i").removeClass(gscmdNewIconDisabled).addClass(gscmdNewIconEnabled);
    $(".cmdEdit i").removeClass(gscmdEditIconEnabled).addClass(gscmdEditIconDisabled);
    $(".cmdDelete i").removeClass(gscmdDeleteIconEnabled).addClass(gscmdDeleteIconDisabled);
    $(".cmdSave i").removeClass(gscmdSaveIconEnabled).addClass(gscmdSaveIconDisabled);
    $(".cmdReset i").removeClass(gscmdResetIconDisabled).addClass(gscmdResetIconEnabled);
} //End function setStateViewButton()
function setStateNewButton() {
    //Enable/Disable
    $(".cmdNew").attr("disabled", "disabled");
    $(".cmdEdit").attr("disabled", "disabled");
    $(".cmdDelete").attr("disabled", "disabled");
    $(".cmdSave").removeAttr("disabled");
    $(".cmdReset").removeAttr("disabled");
    //Enable/Disable Base
    $(".cmdNew").removeClass(gscmdNewEnabled).addClass(gscmdNewDisabled);
    $(".cmdEdit").removeClass(gscmdEditEnabled).addClass(gscmdEditDisabled);
    $(".cmdDelete").removeClass(gscmdDeleteEnabled).addClass(gscmdDeleteDisabled);
    $(".cmdSave").removeClass(gscmdSaveDisabled).addClass(gscmdSaveEnabled);
    $(".cmdReset").removeClass(gscmdResetDisabled).addClass(gscmdResetEnabled);
    //Enable/Disable Icon
    $(".cmdNew i").removeClass(gscmdNewIconEnabled).addClass(gscmdNewIconDisabled);
    $(".cmdEdit i").removeClass(gscmdEditIconEnabled).addClass(gscmdEditIconDisabled);
    $(".cmdDelete i").removeClass(gscmdDeleteIconEnabled).addClass(gscmdDeleteIconDisabled);
    $(".cmdSave i").removeClass(gscmdSaveIconDisabled).addClass(gscmdSaveIconEnabled);
    $(".cmdReset i").removeClass(gscmdResetIconDisabled).addClass(gscmdResetIconEnabled);
} //End function setStateNewButton()
function setStateEditButton() {
    //Enable/Disable
    $(".cmdNew").attr("disabled", "disabled");
    $(".cmdEdit").attr("disabled", "disabled");
    $(".cmdDelete").attr("disabled", "disabled");
    $(".cmdSave").removeAttr("disabled");
    $(".cmdReset").removeAttr("disabled");
    //Enable/Disable Base
    $(".cmdNew").removeClass(gscmdNewEnabled).addClass(gscmdNewDisabled);
    $(".cmdEdit").removeClass(gscmdEditEnabled).addClass(gscmdEditDisabled);
    $(".cmdDelete").removeClass(gscmdDeleteEnabled).addClass(gscmdDeleteDisabled);
    $(".cmdSave").removeClass(gscmdSaveDisabled).addClass(gscmdSaveEnabled);
    $(".cmdReset").removeClass(gscmdResetDisabled).addClass(gscmdResetEnabled);
    //Enable/Disable Icon
    $(".cmdNew i").removeClass(gscmdNewIconEnabled).addClass(gscmdNewIconDisabled);
    $(".cmdEdit i").removeClass(gscmdEditIconEnabled).addClass(gscmdEditIconDisabled);
    $(".cmdDelete i").removeClass(gscmdDeleteIconEnabled).addClass(gscmdDeleteIconDisabled);
    $(".cmdSave i").removeClass(gscmdSaveIconDisabled).addClass(gscmdSaveIconEnabled);
    $(".cmdReset i").removeClass(gscmdResetIconDisabled).addClass(gscmdResetIconEnabled);
} //End function setStateEditButton()
function setStateReadyEditDelete() {
    //Enable/Disable
    $(".cmdNew").attr("disabled", "disabled");
    $(".cmdEdit").removeAttr("disabled");
    $(".cmdDelete").removeAttr("disabled");
    $(".cmdSave").attr("disabled", "disabled");
    $(".cmdReset").removeAttr("disabled");
    //Enable/Disable Base
    $(".cmdNew").removeClass(gscmdNewEnabled).addClass(gscmdNewDisabled);
    $(".cmdEdit").removeClass(gscmdEditDisabled).addClass(gscmdEditEnabled);
    $(".cmdDelete").removeClass(gscmdDeleteDisabled).addClass(gscmdDeleteEnabled);
    $(".cmdSave").removeClass(gscmdSaveEnabled).addClass(gscmdSaveDisabled);
    $(".cmdReset").removeClass(gscmdResetDisabled).addClass(gscmdResetEnabled);
    //Enable/Disable Icon
    $(".cmdNew i").removeClass(gscmdNewIconEnabled).addClass(gscmdNewIconDisabled);
    $(".cmdEdit i").removeClass(gscmdEditIconDisabled).addClass(gscmdEditIconEnabled);
    $(".cmdDelete i").removeClass(gscmdDeleteIconDisabled).addClass(gscmdDeleteIconEnabled);
    $(".cmdSave i").removeClass(gscmdSaveIconEnabled).addClass(gscmdSaveIconDisabled);
    $(".cmdReset i").removeClass(gscmdResetIconDisabled).addClass(gscmdResetIconEnabled);
} //End function setStateReadyEditDelete()
/*=========================================
COMMAND DATA VIEW STATE
=========================================*/
function setStateValidDataToobar() {
    //Enable/Disable
    $(".cmdDataView").removeAttr("disabled");
    $(".cmdDataEdit").removeAttr("disabled");
    $(".cmdDataDelete").removeAttr("disabled");
    //Enable/Disable Base
    $(".cmdDataView").removeClass(gscmdDataViewDisabled).addClass(gscmdDataViewEnabled);
    $(".cmdDataEdit").removeClass(gscmdDataEditDisabled).addClass(gscmdDataEditEnabled);
    $(".cmdDataDelete").removeClass(gscmdDataDeleteDisabled).addClass(gscmdDataDeleteEnabled);
    //Enable/Disable Icon
    $(".cmdDataView i").removeClass(gscmdDataViewIconDisabled).addClass(gscmdDataViewIconEnabled);
    $(".cmdDataEdit i").removeClass(gscmdDataEditIconDisabled).addClass(gscmdDataEditIconEnabled);
    $(".cmdDataDelete i").removeClass(gscmdDataDeleteIconDisabled).addClass(gscmdDataDeleteIconEnabled);
} //End function setStateValidDataToobar()
/*=========================================
ENABLED/DISABLED FIELD STATE
=========================================*/
function setEnableTextbox(psFieldID) {
} //End function setEnableTextbox
function setEnableComboBox(psFieldID) {
} //End function setEnableComboBox
function setEnableTextArea(psFieldID) {
} //End function setEnableTextArea
function setDisableTextbox(psFieldID) {
} //End function setDisableTextbox
function setDisableComboBox(psFieldID) {
} //End function setDisableComboBox
function setDisableTextArea(psFieldID) {
} //End function setDisableTextArea
/*=========================================
IMAGES UPLOAD
=========================================*/
function previewImage(poFileID, psImgID) {
    var input = null;
    input = poFileID;
    if (input.files && input.files[0]) {
        var reader = null;
        reader = new FileReader();

        reader.onload = function(e) {
            //alert(e.target.result);
            //var timestamp = new Date().getTime();
            $(psImgID).attr('src', e.target.result);
            //$(psImgID).removeAttr("src").attr("src", e.target.result);
            //$(psImgID).attr('src', $(psImgID).attr('src') + '?' + timestamp);
        };
        reader.readAsDataURL(input.files[0]);
    }
} //End function previewImage
function uploadImage(psURL, psImgID, psFileName, psOPS) {
    var vsUrl = "";
    if ((psURL != "") && (psURL != null)) {
        vsUrl = HelperUrl + "/" + psURL;
    } else {
        vsUrl = HelperUrl + "/AjaxFileUploader.ashx";
    }
    vsUrlPar = "?psFileName=" + psFileName;
    vsUrlPar = vsUrlPar + "&OPS=" + psOPS;
    vsUrl = vsUrl + vsUrlPar;

    $.ajaxFileUpload({
        url: vsUrl,
        secureuri: false,
        fileElementId: psImgID,
        //dataType: 'json',
        //data: { name: 'logan', id: 'id' },
        //data: vsUrlPar,
        success: function(data, status) {
            if (typeof (data.error) != 'undefined') {
                if (data.error != '') {
                    alert(data.error);
                } else {
                    //alert(data.msg);
                }
            }
        },
        error: function(data, status, e) {
            alert(e);
        }
    });

} //End function uploadImage
/*=========================================
VALIDATION
=========================================*/
function isValidDate(psDate) {
    var currVal = psDate;
    if (currVal == '')
        return false;

    //Declare Regex  
    var rxDatePattern = /^(\d{1,2})(\/|-)(\d{1,2})(\/|-)(\d{4})$/;
    var dtArray = currVal.match(rxDatePattern); // is format OK?

    if (dtArray == null) {
        return false;
    }
    if (vssnAppDefDateFormatShort == "MM/dd/yyyy") {
        //Checks for mm/dd/yyyy format.
        dtMonth = dtArray[1]; //mm
        dtDay = dtArray[3];   //dd
        dtYear = dtArray[5];  //yyyy
    }
    if (vssnAppDefDateFormatShort == "dd/MM/yyyy") {
        //Checks for mm/dd/yyyy format.
        dtDay = dtArray[1]; //mm
        dtMonth = dtArray[3];   //dd
        dtYear = dtArray[5];  //yyyy
    }


    if (dtMonth < 1 || dtMonth > 12)
        return false;
    else if (dtDay < 1 || dtDay > 31)
        return false;
    else if ((dtMonth == 4 || dtMonth == 6 || dtMonth == 9 || dtMonth == 11) && dtDay == 31)
        return false;
    else if (dtMonth == 2) {
        var isleap = (dtYear % 4 == 0 && (dtYear % 100 != 0 || dtYear % 400 == 0));
        if (dtDay > 29 || (dtDay == 29 && !isleap))
            return false;
    }
    return true;
} //End function isValidDate
function isValidValue(pnValue, pnRangeVal1, pnRangeVal2, psOprID) {
    var vReturn = false;

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_001') {
            if ((pnValue >= pnRangeVal1) && (pnValue <= pnRangeVal2)) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_002') {
            if ((pnValue > pnRangeVal1) && (pnValue < pnRangeVal2)) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_003') {
            if ((pnValue >= pnRangeVal1) && (pnValue < pnRangeVal2)) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_004') {
            if ((pnValue > pnRangeVal1) && (pnValue <= pnRangeVal2)) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_005') {
            if (pnValue >= pnRangeVal1) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_006') {
            if (pnValue <= pnRangeVal1) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_007') {
            if (pnValue > pnRangeVal1) { vReturn = true; }
        } //End if
    } //End if

    if (vReturn == false) {
        if (psOprID == 'LOV_RNGOPR_008') {
            if (pnValue < pnRangeVal1) { vReturn = true; }
        } //End if
    } //End if

    return vReturn;
} //End function isValidValue
/*=========================================
FORMATING
=========================================*/
function initDatePickerShortRange(psIDFrom, psIDTo) {
    var vsDateFmt = vssnAppDefDateFormatShortJS;
    var vsCmdID = '';

    //Date From
    $(psIDFrom).datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: vsDateFmt,
        showAnim: "slide",
        onClose: function (selectedDate) {
            $(psIDTo).datepicker("option", "minDate", selectedDate);
        }
    }); //.mask(vssnAppDefDateFormatShortJS);
    vsCmdID = '#cmd'+psIDFrom.replace(psIDFrom.substring(0, 1), '');
    $(vsCmdID).click(function () {
        $(psIDFrom).datepicker("show");
    });


    //Date To
    $(psIDTo).datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: vsDateFmt,
        showAnim: "slide",
        onClose: function (selectedDate) {
            $(psIDFrom).datepicker("option", "maxDate", selectedDate);
        }
    }); //.mask(vssnAppDefDateFormatShortJS);
    vsCmdID = '#cmd' + psIDTo.replace(psIDTo.substring(0, 1), '');
    $(vsCmdID).click(function () {
        $(psIDTo).datepicker("show");
    });
} //End function initDatePickerShortRange
function initDatePickerShortV2(psID) {
    var vsDateFmt = vssnAppDefDateFormatShortJS;
    //Date Picker
    $(psID).datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: vsDateFmt,
        showAnim: "slide",
        yearRange: "1945:2100"
    }).mask(vssnAppDefDateInputMaskShort);
    //$(psID).mask(vssnAppDefDateInputMaskShort);
} //End function initDatePickerShortV2
function initDatePickerShort(psID) {
    var vsDateFmt = vssnAppDefDateFormatShort;
    vsDateFmt = vsDateFmt.replace("MM", "mm")
    if (vsDateFmt.indexOf("yyyy") == -1)
        vsDateFmt = vsDateFmt.replace("yy", "y")
    else
        vsDateFmt = vsDateFmt.replace("yyyy", "yy")

    //Date Picker
    $(psID).datepicker({
        changeMonth: true,
        changeYear: true
    });
    $(psID).datepicker("option", "dateFormat", vsDateFmt);
    $(psID).datepicker("option", "showAnim", "slide");
    $(psID).datepicker("option", "yearRange", "1945:2100");
    $(psID).mask(vssnAppDefDateInputMaskShort);

    //validate date
    $(psID).each(function(index) {
        var vsID = '#' + $(this).attr('id');
        $(vsID).focusout(function() {
            var vsDateValue = $(vsID).val();
            var vsMessage = "Invalid date : " + vsDateValue;
            if ((vsDateValue != "") && (vsDateValue != "__/__/____") && (vsDateValue != "__/__/__")) {
                if (isValidDate(vsDateValue) == false) {
                    $('#DialogInformationMsg').text(vsMessage);
                    $('#DialogInformation').dialog('open');
                    $(vsID).val("");
                }
            }
        });
    });

} //End function initDatePickerShort
function initNumberDecimal(psID) {
    $(psID).format({ precision: vssnAppDefDecimalDigit, decimal: vssnAppDefDecimalSign, autofix: true });

    //    $(psID).focusout(function() {
    //        if ($(this).val() != null) {
    //            $(this).val(add100Separator($(this).val()));
    //        }
    //    });

} //End function initNumberDecimal
function initNumberInteger(psID) {
    $(psID).format({ precision: 0, autofix: true });

    //    $(psID).focusout(function() {
    //        $(this).val(add100Separator($(this).val()));
    //    });

} //End function initNumberInteger
function formatNumberDecimal(psID) {
    $(psID).each(function(index) {
        var vsID = '#' + $(this).attr('id');
        if ($(vsID).val() != null) {
            var vnValue = parseFloat($(vsID).val());
            var vnValueX = vnValue.toFixed(vssnAppDefDecimalDigit)
            $(vsID).val(setFormatNumber(vnValueX));
        }
    });
} //End function formatNumberDecimal
function formatNumberInteger(psID) {
    $(psID).each(function(index) {
        var vsID = '#' + $(this).attr('id');
        if ($(vsID).val() != null) {
            $(vsID).val(add100Separator($(vsID).val()));
        }
    });
} //End function formatNumberInteger
function setFormatNumber(nStr) {
    var vs100Sep = "";
    if (vssnAppDef1000Separator != null) { vs100Sep = vssnAppDef1000Separator; }
    else { vs100Sep = ","; }
    var vsDecSep = "";
    if (vssnAppDefDecimalSign != null) { vsDecSep = vssnAppDefDecimalSign; }
    else { vsDecSep = "."; }


    nStr += '';
    x = nStr.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + vs100Sep + '$2');
    }

    return x1 + x2.replace(".", vsDecSep);
} //End function setFormatNumber
function setUnformatNumber(sStr) {
    var vs100Sep = "";
    if (vssnAppDef1000Separator != null) { vs100Sep = vssnAppDef1000Separator; }
    else { vs100Sep = ","; }
    var vsDecSep = "";
    if (vssnAppDefDecimalSign != null) { vsDecSep = vssnAppDefDecimalSign; }
    else { vsDecSep = "."; }

    sStr += '';
    x = sStr.split(vsDecSep);
    x1 = x[0].replace(vs100Sep, "");
    x2 = x.length > 1 ? '.' + x[1] : '';
    return x1 + x2;
} //End function setUnformatNumber
function add100Separator(nStr) {
    var vs100Sep = "";
    if (vssnAppDef1000Separator != null) { vs100Sep = vssnAppDef1000Separator; }
    else { vs100Sep = ","; }

    nStr += '';
    x = nStr.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + vs100Sep + '$2');
    }
    return x1 + x2;
} //End function add100Separator
/*=========================================
CONVERTION
=========================================*/
function ConvertStringToInteger(psValue) {
    var vsTemp = psValue;
    return vsTemp.replace(vssnAppDef1000Separator, "");
} //End function ConvertStringToInteger
function ConvertStringToDecimal(psValue) {

    //    var vsTemp1 = psValue;
    //    var vsTemp2 = vsTemp.replace(vssnAppDef1000Separator, "");
    //    var vsTemp3 = vsTemp.replace(vssnAppDef1000Separator, "");
    //    return vsTemp.replace(vssnAppDef1000Separator, "");

    var vsTemp = psValue;
    if ((psValue != "") && (psValue != null)) { vsTemp = ("" + psValue).replace(vssnAppDef1000Separator, ""); } //End if

    return vsTemp;
} //End function ConvertStringToDecimal
/*=========================================
ARITMATHIC
=========================================*/
function MultiplyMe(psMyID, psSrcID1, psSrcID2) {
    $(psSrcID1).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 * vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });

    $(psSrcID2).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 * vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });
} //End function MultiplyMe
function DevideMe(psMyID, psSrcID1, psSrcID2) {
    $(psSrcID1).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 / vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });

    $(psSrcID2).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 / vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });
} //End function DevideMe
function IncrementMe(psMyID, psSrcID1, psSrcID2) {
    $(psSrcID1).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 + vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });

    $(psSrcID2).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 + vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });
} //End function IncrementMe
function SubstractMe(psMyID, psSrcID1, psSrcID2) {
    $(psSrcID1).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 - vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });

    $(psSrcID2).focusout(function() {
        var vnSrcValue1 = $(psSrcID1).val();
        var vnSrcValue2 = $(psSrcID2).val()
        if ((vnSrcValue1 != "") && (vnSrcValue2 != "")) {
            var vnSrcValue1 = parseFloat(setUnformatNumber($(psSrcID1).val()));
            var vnSrcValue2 = parseFloat(setUnformatNumber($(psSrcID2).val()));
            var vnResult = vnSrcValue1 - vnSrcValue2;
            var vsResult = setFormatNumber(vnResult);
            $(psMyID).val(vsResult);
        }
    });
} //End function SubstractMe
/*=========================================
HIDDEN/SHOW STATE
=========================================*/
function setHiddenField(psContentID) {
    $(psContentID).each(function(index) {
        var vsID = '#' + $(this).attr('id');
        $(vsID).hide();
    });
} //End function setHiddenField
function setHideDivContent(psContentID) {
    $(psContentID).hide();
} //End function setHideDivContent
/*=========================================
TABLE EFFECT
=========================================*/
function setTableFilterByTR(psSearchTextID, psTableID) {
    var $rows = $('#' + psTableID + ' tbody tr');
    $('#' + psSearchTextID).keyup(function() {
        var val = $.trim($(this).val()).replace(/ +/g, ' ').toLowerCase();

        $rows.show().filter(function() {
            var text = $(this).text().replace(/\s+/g, ' ').toLowerCase();
            return ! ~text.indexOf(val);
        }).hide();
    });
} //End function setTableFilterByTR
/*=========================================
DIALOG AND ALERT BOX
=========================================*/
//Init Dialog Save On Progress
function initDlgSaveOnProgress(psID) {
    $(psID).dialog({
        autoOpen: false,
        modal: true,
        overlay: { opacity: 0.2, background: "cyan" },
        width: 400
    });
} //End function initDlgSaveOnProgress(psID)
//Init Dialog Load On Progress
function initDlgLoadOnProgress(psID) {
    $(psID).dialog({
        autoOpen: false,
        modal: true,
        overlay: { opacity: 0.2, background: "cyan" },
        width: 400
    });
} //End function initDlgLoadOnProgress(psID)
// Init Dialog Information
function initDlgInformation(psID) {
    $(psID).dialog({
        autoOpen: false,
        modal: true,
        overlay: { opacity: 0.2, background: "cyan" },
        width: 400,
        buttons: {
            "Ok": function() {
                $(this).dialog("close");
            }
        }
    });
} //End function initDlgInformation(psID)
// Init Dialog Warning
function initDlgWarning(psID) {
    $(psID).dialog({
        autoOpen: false,
        modal: true,
        overlay: { opacity: 0.2, background: "cyan" },
        width: 400,
        buttons: {
            "Ok": function() {
                $(this).dialog("close");
            }
        }
    });
} //End function initDlgWarning(psID)
// Init Dialog Error
function initDlgError(psID) {
    $(psID).dialog({
        autoOpen: false,
        modal: true,
        overlay: { opacity: 0.2, background: "red" },
        width: 400,
        buttons: {
            "Ok": function() {
                $(this).dialog("close");
            }
        }
    });
} //End function initDlgError(psID)

/*=========================================
LOOKUP
=========================================*/
function initDlgLookUp(psID) {
    $(psID).dialog({
        autoOpen: false,
        modal: true,
        overlay: { opacity: 0.2, background: "red" },
        width: 700,
        height: 500,
        resizable: true,
        draggable: true,
        //dialogClass: "dlgLookup",
        buttons: {
            "Ok": function () {
                $(this).dialog("close");
            }
        }
    }); //End $(psID).dialog
} //End function initDlgLookUp(psID)
function showLookup(psLookupURL, psHtmlTagID_ImgLoading, paSearchValue,
                    psHtmlTagID_RUID, psHtmlTagID_ID, psHtmlTagID_Desc) {
    var vaTargetTag = new Array();
    vaTargetTag[0] = psHtmlTagID_RUID;
    vaTargetTag[1] = psHtmlTagID_ID;
    vaTargetTag[2] = psHtmlTagID_Desc;
    $("#DialogLookupContent").empty();
    var vsURL = BaseUrl + psLookupURL;
    var voDTO = { paSearchValue: paSearchValue, paTargetTag: vaTargetTag };
    jQuery.ajaxSettings.traditional = true;
    $.ajax({ type: AJAXTypeGET(), url: vsURL, data: voDTO, traditional: true
    }).done(function (data) {
        $("#DialogLookupContent").html(data);
        $('#DialogLookup').dialog('open');
    });  //End $.ajax
}; //End function showLookup
function showLookup_LoadSingle(psLookupURL, psHtmlTagID_ImgLoading, paSearchValue,
                               psRSLTDATA_URL, psRSLTDATA_TAG,
                               psHtmlTagID_RUID, psHtmlTagID_ID, psHtmlTagID_Desc) {
    var vaTargetTag = new Array();
    vaTargetTag[0] = psHtmlTagID_RUID;
    vaTargetTag[1] = psHtmlTagID_ID;
    vaTargetTag[2] = psHtmlTagID_Desc;
    vaTargetTag[3] = psRSLTDATA_URL;
    vaTargetTag[4] = psRSLTDATA_TAG;

    $("#DialogLookupContent").empty();
    var vsURL = BaseUrl + psLookupURL;
    var voDTO = { paSearchValue: paSearchValue, paTargetTag: vaTargetTag };
    jQuery.ajaxSettings.traditional = true;
    $.ajax({ type: AJAXTypeGET(), url: vsURL, data: voDTO, traditional: true
    }).done(function (data) {
        $("#DialogLookupContent").html(data);
        $('#DialogLookup').dialog('open');
    });  //End $.ajax
}; //End function showLookup


/*=========================================
ACTION
=========================================*/
function gotoPage(psPageID) {
    window.location.replace(BaseUrl + psPageID);
} //End function gotoPage

/*=========================================
TABLE Utility
=========================================*/
//1 Filter Criteria
function doSearchAbleTable(psSearchTag, psTableContainer, psColumnTag) {
    var $rows;
    if (psTableContainer != '') {
        $rows = $(psTableContainer + ' table tbody tr');
    } else {
        $rows = $(psTableContainer + 'table tbody tr');
    } //End if
    $(psSearchTag).keyup(function() {
        var val = '^(?=.*\\b' + $.trim($(this).val()).split(/\s+/).join('\\b)(?=.*\\b') + ').*$',
        reg = RegExp(val, 'i'),
        text;

        $rows.show().filter(function() {
            if ((psColumnTag != '') && (psColumnTag != null)) { text = $(this).children(psColumnTag).text().replace(/\s+/g, ' '); }
            else { text = $(this).text().replace(/\s+/g, ' '); } //End if
            return !reg.test(text);
        }).hide(); //End $row
    }); //End Seach tag
} //End function doSearchAbleTable
/*=========================================
VALIDATION
=========================================*/
function isEmptyString(psStringValue) {
    if ((psStringValue != "") && (psStringValue != null)) {
        return false;
    } else {
        return true;
    }
} //End function isEmptyString
