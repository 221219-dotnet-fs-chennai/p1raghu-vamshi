async function addEducation() {
    const handleeducation = document.getElementById("addEducation");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')

    let UId = document.getElementById("UserId").value; 
    let rollno = document.getElementById("Rollno").value;
    let university1 = document.getElementById("university").value;
    let passedoutyear1 = document.getElementById("passedoutyear").value;
    let grade1 = document.getElementById("grade").value;
    let ug1 = document.getElementById("ug").value;
    let specialization1 = document.getElementById("specialization").value;


    await fetch(`https://localhost:7218/api/EducationControler/AddEducation? ` ,

        {
            method: "POST",
            body: JSON.stringify({
                

                "userId": UId,
                "rollNo": rollno,
                "university": university1,
                "ug": ug1,
                "specialization": specialization1,
                "passedoutyear": passedoutyear1,
                "grade": grade1
                
            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => console.log(response))
        alert("Added Education Details")
    window.location.href = "view.html"
}