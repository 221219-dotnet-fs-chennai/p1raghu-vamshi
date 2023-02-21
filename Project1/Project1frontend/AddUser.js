async function addUser() {
    const handleeducation = document.getElementById("addUser");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')

    let UId1 = document.getElementById("UId").value;
    let fname1 = document.getElementById("FName").value;
    let Mname1 = document.getElementById("MName").value;
    let lname1 = document.getElementById("LName").value;
    let Salutation = document.getElementById("Salutation").value;
    let email1 = document.getElementById("Email").value;
    let pswd1 = document.getElementById("Pswd").value;
    let gender1 = document.getElementById("gender").value;
    let age1 = document.getElementById("age").value;


    await fetch(`https://localhost:7218/api/UserControler/AddTrainer?Email=${email1}`,
        {
            method: "POST",
            body: JSON.stringify({
                "UserId": UId1,
                "age": age1,
                "salutation": Salutation,
                "firstName": fname1,
                "middleName": Mname1,
                "lastName": lname1,
                "gender": gender1,
                "email": email1,
                "password":pswd1
            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => console.log(response))
        alert("added User Details!")
        //window.location.href = "Login.html"
        window.location.href = "view.html"
}