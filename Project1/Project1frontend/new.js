 async function addSignUp(){
    addUser();
    addSkill();
    addExperience();
    addEducation();
    addAddress();
}
//-------------------------User Details----------------
async function addUser() {
    const handleeducation = document.getElementById("add_btn");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    // let email = localStorage.getItem('email')
    // email = email.replace(/['‘’"“”]/g, '')
    // console.log(email);
    let UId1 = document.getElementById("UId").value;
    let fname1 = document.getElementById("FName").value;
    let mname1 = document.getElementById("mName").value;
    let lname1 = document.getElementById("LName").value;
    let Salutation = document.getElementById("Salutation").value;
    let email1 = document.getElementById("Email").value;
    let pswd1 = document.getElementById("Pswd").value;
    let gender1 = document.getElementById("gender").value;
    let age1 = document.getElementById("age").value;


    await fetch("https://localhost:7218/api/UserControler/AddTrainer?",
        {
            method: "POST",
            body: JSON.stringify({

                "UserId": UId1,
                "firstname": fname1,
                "Middlename": Mname1,
                "lastname": lname1,
                "Salutation":Salutation,
                "email": email1,
                "password":pswd1,
                "gender": gender1,
                "age": age1

            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => response.json())
        //.then((data)=>console.log(data))
        // .then((data)=>{
        //     localStorage.setItem("email", data.email)
        //     localStorage.setItem("password", data.password)
        // })
        alert("added User Details!")
    window.location.href = "view.html"
}