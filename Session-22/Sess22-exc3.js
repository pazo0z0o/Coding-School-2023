//let element = document.getElementById("show");
//element.addEventListener("click",ShowTable());

function ShowTable()
{
    let tab  = document.getElementById("CusTable");
    let hideAttr = tab.getAttribute("hidden");
    
    if (hideAttr) {
        tab.removeAttribute("hidden");
        btn_show.innerText = "Hide table";
     } else {
        tab.setAttribute("hidden", "hidden");
        btn_show.innerText = "Show table";
     }

}

function addCustomers()
{
    let tab  = document.getElementById("CusTable");

    const Customer = 
    {
        Name: document.querySelector('#name').value,
        Surname: document.querySelector('#surnamename').value,
        Age: document.querySelector('#age').value,
        Gender: document.querySelector('#gender').value,
    };

    allPosts.push(Customer);
    createPostsTableRow(newCustomer, CusTable);
}


function createPostsTableRow(post,CusTable)
{
let rowEl = CusTable.insertRow();

//rowEl.setAttribute("data-id",post.id)

let name = rowEl.insertCell(0);
name.innerHTML = post.Name;

let surname = rowEl.insertCell(1);
name.innerHTML = post.Surname

let age = rowEl.insertCell(2);
name.innerHTML = post.Age;
let gender = rowEl.insertCell(3);
name.innerHTML = post.Gender;
}