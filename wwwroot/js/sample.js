export function callInstanceMethod(instanceObject) {
    instanceObject.invokeMethodAsync("GetValueFromInstance").then(result => {
        alert("Message from Method: " + result)
    });//hier muss der Projekt name nicht eingegeben werden weil wir die Methode von einer instanz aus aufrufen.
}