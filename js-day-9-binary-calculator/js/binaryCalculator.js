var screen='';
var a='',b='';
var operation = '';
document.getElementById("btn0").addEventListener("click", function() {
    screen+= '0';
    if(operation == ''){
        a+=0;
    }
    else{
        b+=0;
    }
    updateScreen();
});
document.getElementById("btn1").addEventListener("click", function() {
    screen+= '1';
    if(operation == ''){
        a+=1;
    }
    else{
        b+=1;
    }
    updateScreen();
});

document.getElementById("btnSum").addEventListener("click", function() {
    screen+= ' + ';
    operation = '+';
    updateScreen();
});

document.getElementById("btnSub").addEventListener("click", function() {
    screen+= ' - ';
    operation = '-';
    updateScreen();
});

document.getElementById("btnMul").addEventListener("click", function() {
    screen+= ' * ';
    operation = '*';
    updateScreen();
});

document.getElementById("btnDiv").addEventListener("click", function() {
    screen+= ' / ';
    operation = '/';
    updateScreen();
});

document.getElementById("btnEql").addEventListener("click", function() {
    let c=0;
    if(operation == '+'){
        c = parseInt(a, 2) + parseInt(b, 2);
        c = dec2bin(c);
    }
    else if(operation == '-'){
        c = parseInt(a, 2) - parseInt(b, 2);
        c = dec2bin(c);
    }
    else if(operation == '*'){
        c = parseInt(a, 2) * parseInt(b, 2);
        c = dec2bin(c);
    }
    else{
        c = parseInt(a, 2) / parseInt(b, 2);
        c = dec2bin(c);
    }
    screen = c.toString();
    // CleanUp
    operation = '';
    a=screen;
    b='';
    c='';
    updateScreen();
});

document.getElementById("btnClr").addEventListener("click", function() {
    screen= '';
    a='';
    b='';
    c='';
    updateScreen();
});
function updateScreen(){
    document.getElementById("res").innerText = screen;
}
function dec2bin(dec){
    return (dec >>> 0).toString(2);
}