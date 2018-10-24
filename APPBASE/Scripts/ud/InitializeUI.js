//Function initialize jQuery UI
function initUIStandard() {
    //Tabs
    $(".tabs").tabs();
    //Command CRUD
    $("input[type=button].cmdCRUD").button();
    //Command LookUp
    $("input[type=button].cmdLKP").button();
    //Button Submit
    $("input[type=submit]").button();
    //Button Reset
    $("input[type=reset]").button();
    //Init Dialog Save On Progress
    initDlgSaveOnProgress('#DialogSaveOnProgress');
    //Init Dialog Load On Progress
    initDlgLoadOnProgress('#DialogLoadOnProgress');
    //Dialog Information
    initDlgInformation('#DialogInformation');
    //Dialog Warning
    initDlgWarning('#DialogWarning');
    //Dialog Error
    initDlgError('#DialogError');
    //Dialog LookUp
    initDlgLookUp('#DialogLookup');
    //Date Picker Field
    initDatePickerShort(".FieldAsDate");
    //Format Number Decimal
    initNumberDecimal(".FieldAsDecimal");
    //Format Number Integer
    initNumberInteger(".FieldAsInteger");
    //Initialize mandatory sign
    initMandatorySignByFieldClass(".FieldAsMandatory");
    //Date Picker button
    $(".CmdAsCalendar").click(function() {
        var vsIDCliked = $(this).attr('id');
        var vsID = '#' + vsIDCliked.replace(vsIDCliked.substring(0, 3), 'fld');
        $(vsID).datepicker("show");
    });
    //Set hidden field
    //setHiddenField("#HiddenDiv");
    setHideDivContent(".HiddenDiv");
}
