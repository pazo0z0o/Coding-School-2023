let allPosts = [];
var selectPostRowEl;
//function ShowTable()
//{
    /* let tab  = document.getElementById("CusTable");
    let hideAttr = tab.getAttribute("hidden");
    
    if (hideAttr) {
        tab.removeAttribute("hidden");
        btn_show.innerText = "Hide table";
     } else {
        tab.setAttribute("hidden", "hidden");
        btn_show.innerText = "Show table";
     } */
//================================================================
//}
const rowEl = '';
const nameEl= '';
const surname= '';
const age= '';
const gender= '';

function addCustomers()
{
    const tab  = document.getElementById("CusTable");//.addEventListener("submit", function(event)
     //{event.preventDefault()});

    const Customer = 
    {
        Name: document.querySelector('#name').value,
        Surname: document.querySelector('#surname').value,
        Age: document.querySelector('#age').value,
        Gender: document.querySelector('#gender').value,
    };  
allPosts.push(Customer);
createPostsTableRow(Customer, tab);
}
//============================================================
function createPostsTableRow(post,CusTable)
{
for(var i=0;i<allPosts.length;i++ )
{
 
    
var rowEl = CusTable.insertRow();

nameEl = rowEl.insertCell(0);
nameEl.innerHTML = allPosts[i].Name;

surname = rowEl.insertCell(1);
surname.innerHTML =allPosts[i].Surname

age = rowEl.insertCell(2);
age.innerHTML = allPosts[i].Age;

gender = rowEl.insertCell(3);
gender.innerHTML = allPosts[i].Gender;
        
    }
}


/* function createPostsTableRow(post,CusTable)
{
//var rowCount = CusTable.rows.length; //start from 2 
var rowEl = CusTable.insertRow();

nameEl = rowEl.insertCell(0);
nameEl.innerHTML = post.Name;

surname = rowEl.insertCell(1);
surname.innerHTML = post.Surname

age = rowEl.insertCell(2);
age.innerHTML = post.Age;

gender = rowEl.insertCell(3);
gender.innerHTML = post.Gender;


} */



