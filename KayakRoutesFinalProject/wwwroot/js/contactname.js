

$.vaildator.addMethod("contactname",
    function (value, element, param) {
        if (value == '') return false;
        if (value == 'Alex') return false;
        return true;
    });

$.validator.unobstrusive.adapters.add("contactname", ["name"], function (options) {
    options.rules["contactname"] = options.params.name;
    options.messages["contactname"] = "Client Side Validation";
});