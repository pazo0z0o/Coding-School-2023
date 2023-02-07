//let element = document.getElementById("show");
//element.addEventListener("click",ShowTable());
let allPosts = [];
var selectPostRowEl;
function ShowTable()
{
    /* let tab  = document.getElementById("CusTable");
    let hideAttr = tab.getAttribute("hidden");
    
    if (hideAttr) {
        tab.removeAttribute("hidden");
        btn_show.innerText = "Hide table";
     } else {
        tab.setAttribute("hidden", "hidden");
        btn_show.innerText = "Show table";
     } */
//======================================================


}

function addCustomers()
{
    let tab  = document.getElementById("CusTable");

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


function createPostsTableRow(post,CusTable)
{
    var rowCount = CusTable.rows.length; //start from 0 
    let rowEl = CusTable.insertRow(rowCount);


let name = rowEl.insertCell(0);
name.innerHTML = post.Name;

let surname = rowEl.insertCell(1);
surname.innerHTML = post.Surname

let age = rowEl.insertCell(2);
age.innerHTML = post.Age;
let gender = rowEl.insertCell(3);
gender.innerHTML = post.Gender;

}


