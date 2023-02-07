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
//let mulRes = multiply(4,5);
//console.log(mulRes);


function multiply(a,b)
{

    if ( typeof(a) != "number" && typeof(b) != "number") 
    {
       alert("Incorrect input try again");
        return;
    }
   return a*b;
   
}




