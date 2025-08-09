MYAPP = {
    prompotuser: function () {
        var name = prompt("whar is your name");
    }
}
function setfocusbyid(id) {
  
    let input = document.getElementById(id);
  
    input.focus();
    //input.firstChild.focus();
}
function setfocusbyidtofirstchild(id) {


    let input = document.getElementById(id);
    console.log(id);
    console.log(input);
    input.firstChild.focus();
}
function setfocus(element) {

    element.focus();

}
function setreadonly(element) {

    element.readOnly = true;

}
function setwrite(element) {

    element.readOnly = false;

}
function setenable(element) {

    element.disabled = false;

}
function setdisable(element) {

    element.disabled = true;

}

function getid(e) {
    let td = document.querySelectorAll("#" + e.id + " td");

    let obj = [];
    obj = [td[0].textContent, td[1].textContent, td[2].textContent, td[3].textContent, td[4].textContent];
    obj[0] = td[0].innerHTML;
    obj[1] = td[1].innerHTML;
    obj[2] = td[2].innerHTML;
    obj[3] = td[3].innerHTML;
    obj[4] = td[4].innerHTML;



    return obj;
}

function GetIvoiceId(element) {
    let td = document.querySelectorAll("#" + e.id + " td");
    return td[0].innerHTML;
}
function additem(id, counter) {
    $(id).after($(id).clone())
    $(id).last().attr("id", "item" + counter)

}
function addelement(html, parentid) {
    var template = document.createElement('template');
    html = html.trim();
    template.innerHTML = html;
    var element = template.content.firstChild;
    let parent = document.getElementById(parentid);
    parent.append(element);
    console.log("any");
}
function selectAllTextToFirstChild(elementId) {
    let input = document.getElementById(elementId);
    if (input) {
      
        input.firstChild.select();
    }
}

function selectAllText(elementId) {
    let input = document.getElementById(elementId);
    if (input) {

        input.select();
    }
}

function addKeydownListenerItemId(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownItemID', event.key);
        });
    }
}
function addKeydownListenerItemIdFirstChild(elementId, dotNetHelper) {
    const element = document.getElementById(elementId).firstChild;
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownItemIDFirstChild', event.key);
        });
    }
}
function addKeydownListenerItemName(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownItemName', event.key);
        });
    }
}

function addKeydownListenerItemStore(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownItemStore', event.key);
        });
    }
}

function addKeydownListenerItemUnit(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownItemUnit', event.key);
        });
    }
}
function addKeydownListenerItemDiscount(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownItemDiscount', event.key);
        });
    }
}
function addKeydownListenerQuantity(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownQuantity', event.key);
        });
    }
}

function addKeydownListenerprice(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownPrice', event.key);
        });
    }
}

function addKeydownListenerRefernce(elementId, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (element) {
        element.addEventListener('keydown', (event) => {
            dotNetHelper.invokeMethodAsync('HandleKeydownRefernce', event.key);
        });
    }
}
