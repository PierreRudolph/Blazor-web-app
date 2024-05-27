function callMethod() {
    DotNet.invokeMethodAsync("Blazor-App", "GetValueFromMethod").then(result => {
        alert("Message from Method:" + result)
    });//invokeMethodAsync ist die Methode um eine C# method aufzurufen 
}

export function callInstanceMethod(instanceObject) {
    instanceObject.invokeMethodAsync("GetValueFromInstance").then(result => {
        alert("Message from Method: " + result)
    });//hier muss der Projekt name nicht eingegeben werden weil wir die Methode von einer instanz aus aufrufen.
}