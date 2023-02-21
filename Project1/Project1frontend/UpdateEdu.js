async function modifyEducation(){
    const handleUpdate = document.getElementById("modifyEducation");

    handleUpdate.addEventListener("submit" , event =>{
        event.preventDefault();
    });

    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')



    let university1 = document.getElementById("university").value;
    let passedoutyear1 = document.getElementById("passedoutyear").value;
    let ug1 = document.getElementById("ug").value;
    let specialization1 = document.getElementById("specialization").value;
    let grade1 = document.getElementById("grade").value;

    await fetch("https://localhost:7218/api/EducationControler/modify" + new URLSearchParams({
        email : email,
        degree : degree1,
    }),{
        method : "PUT",
        body : JSON.stringify({
           
            "university": university1,
            "passedoutyear": passedoutyear1,
           "specialization": specialization1,
           "ug": ug1, 
            "grade": grade1
        }),
        headers:{
            "Content-type" : "application/json; charset=UTF-8",
        },
    })
    alert("Updated Successfully!")

}