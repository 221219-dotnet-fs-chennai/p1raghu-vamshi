async function deleteUserDetails(){
    const handledelete = document.getElementById("deleteuserDetails");

    handledelete.addEventListener("submit" , event =>{
        event.preventDefault();
    });

    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')

    let pswd1 = document.getElementById("pswd").value;

    await fetch ("https://localhost:7218/api/UserControler/Delete" + new URLSearchParams({
        email : email,
        password : pswd1
    }),{
        method : "DELETE",
        headers :{
            "Content-type": "application/json; charset=UTF-8",
        },
    })
    .then((response) =>{
        if(response.status == 200){
            alert("Deleted Successfully!");
            window.location.href = "Login.html";
        }
        else{
            alert("User is not present");
            window.location.href = "DeleteEdu.html";
        }
    })
    .then((response)=> console.log(response))
}