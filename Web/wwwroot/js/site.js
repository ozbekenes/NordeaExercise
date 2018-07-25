// Write your JavaScript code.
function ConvertText() {

    var request = new XMLHttpRequest();


    $("#formatter").click(function (e) {
        $("#resultTextArea").val = null;
        var formatType = $('input[name=FormatType]:checked').val();
        //$("input[name=FormatType]").each(function () {
        //    formatType = $(this).val();
        //});
        var formatter = { InputText: $('#InputText').val(), FormatType: formatType };
        $.ajax({
            url: "/Api/Format",
            type: "POST",
            data: JSON.stringify(formatter),
            contentType: "application/json",
            success: function (data) {
                $("#resultTextArea").val(data);
                console.log(data);
            },
            error: function (reponse) {
                alert("error : " + reponse);
            }
        });
        //var input = 'asdasd';
        //SendRequest("/api/convert", input, DisplayResult);
    });
}

function SendRequest(uri, data, callback) {
    var httpRequest = new XMLHttpRequest();
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4 && httpRequest.status == 200) {
            callback(httpRequest.responseText);
        }
    }
    var dataWithEscapedCharacters = data;
    httpRequest.open("POST", uri, true);
    httpRequest.setRequestHeader("Content-Type", "application/json");
    httpRequest.send("\"" + dataWithEscapedCharacters + "\"");
}

function DisplayResult(text) {
    document.getElementById("resultTextArea").innerText = text;
}

function initEvents() {
    ConvertText();
};

$(function () {
    initEvents();
});