function modifyUser(){
    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')

    let flag = false;
    if(email != null){
        flag= true
    }
    if(flag == true){
        handleUpdate();
    }
    }
    function handleUpdate(){
        let email = localStorage.getItem('email')
        email = email.replace(/['‘’"“”]/g, '')
        console.log(email)

        
        let UId = document.getElementById("UserId").value;
        let fname1 = document.getElementById("FName").value;
        let mname1 = document.getElementById("mName").value;
        let lname1 = document.getElementById("LName").value;
        let salutation = document.getElementById("salutation").value;
        let pswd1 = document.getElementById("Pswd").value;
        let gender1 = document.getElementById("gender").value;
        let age1 = document.getElementById("age").value;

        fetch(`https://localhost:7218/api/UserControler/modify?Email=${email}` ,{
            method : "PUT",
            body : JSON.stringify(
                {
                    "userId": 0,
                    "age": 0,
                    "salutation": "string",
                    "firstName": "string",
                    "middleName": "string",
                    "lastName": "string",
                    "gender": "string",
                    "email": email,
                    "password": "string"
                  }),
        headers:{
            "Content-type": "application/json; charset=UTF-8",
        },
        })
        //alert("Updated Successfully!")
         .then((response) => console.log(response))
         if(response.status === 200){
             alert("updated!")
            window.location.href = "view.html"
         }else{
             alert("something went wrong")
         }
}