async function modifyEducation(){
    const handleUpdate = document.getElementById("modifyEducation");

    handleUpdate.addEventListener("submit" , event =>{
        event.preventDefault();
    });

    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')

      let prev1 = document.getElementById("prev").value;
      let newprev1 = document.getElementById("newprev").value;
      let location1 = document.getElementById("location").value;
      let years1 = document.getElementById("years").value;

    await fetch("https://localhost:7218/api/Company/modify" + new URLSearchParams({
        email : email,
        prev : prev1,
    }),{
        method : "PUT",
        body : JSON.stringify({
            "previousCompany": newprev1,
            "companylocation": location1,
            "experienceyear": years1
        }),
        headers:{
            "Content-type" : "application/json; charset=UTF-8",
        },
    })
    alert("Updated Successfully!")

}