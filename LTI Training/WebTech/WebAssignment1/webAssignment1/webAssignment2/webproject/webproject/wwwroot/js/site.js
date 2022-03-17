function formvalidator() {
    var user = document.getElementById("username");
    var password = document.getElementById("pwd");
    var email = document.getElementById("email");
    var mobile = document.getElementById("mob");


    if (usernamevalidator(user, "Enetr the corect User Name")) {
        
            if (emailvalidator(email, "Enter correct Email Id")) {
                if (mobilevalidator(mobile, "Enter the ten digit mobile no")) {
                    return true;
                }
            
        }
    }
    return false;


 function usernamevalidator(elem, helperMsg)
{
    var user = /^[a-zA-z]+$/;
    
    if (elem.value.match(user)) {
        return true;
    }
    else {
        alert(helperMsg)
        elem.focus();
        return false;

    }
}

function emailvalidator(elem,helperMsg)
{
    var email = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (elem.value.match(email)) {
        return true;

    }
    else {
        alert(helperMsg);
        elem.focus();
       return false;
    }
}
function mobilevalidator(elem,helperMsg) {
    var mobi = /^(?:(?:\+|0{0,2})91(\s*[\-]\s*)?|[0]?)?[789]\d{9}$/;
    if (elem.value.match(mobi)) {
        return true;
    }
    else {
        alert(helperMsg);
        elem.focus();
        return false;
    }
}

}
