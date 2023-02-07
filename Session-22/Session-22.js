// Excercise 1
function stringReversal (str) 
{
let output = str.split('').reverse().join('');
return output;
}

function displayResult()
{
var input = document.getElementById("input").value ;
var output = stringReversal(input);
document.getElementById("outputField").innerHTML = output;
}

function checkPalindrome(str)
{
    console.log (input2);
    let pali = str.split('').reverse().join('');
    pali.toLowerCase();
    var msg = '';
    
    if (str == pali)
    {
        msg = "It IS a palindrome!";
    }
    else
    {
       msg = "It is NOT a palindrome!";
    } 
    console.log ("msg");
    return msg;
}

function displayPalindrome()
{
var input2 = document.getElementById("input2").value ;
var output2 = checkPalindrome(input2);
document.getElementById("out2").innerHTML = output2;
}
//Exc 4
function multiply(a,b)
{
var aIsNum = false;
var bIsNum = false;

while(!aIsNum)
{
    if ( typeof(a) != "number" ) 
    {
        alert("Enter a number");
    }
    else{
    aIsNum = true;
    }
}
while(!bIsNum)
{ 
    if( typeof(b) != "number")
    {
        console.log ("Enter a number")    
    }
    else bIsNum = true;
}
return a*b;
}




