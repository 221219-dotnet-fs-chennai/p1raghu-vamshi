async function addExperience() {
    const handleeducation = document.getElementById("addExperience");

    handleeducation.addEventListener("submit", event => {
        event.preventDefault();
    });

    let email = localStorage.getItem('email')
    email = email.replace(/['‘’"“”]/g, '')

    let prev1 = document.getElementById("prev").value;
    let location1 = document.getElementById("location").value;
    let years1 = document.getElementById("years").value;


    await fetch("https://localhost:7218/api/Company?Email" + new URLSearchParams({
        email: email
    }),
        {
            method: "POST",
            body: JSON.stringify({

                "previousCompany": prev1,
                "CompanyLocation": location1,
                "experienceyear": years1

            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8",
            },
        })
        .then((response) => console.log(response))
        alert("Added Experience Details");
    //window.location.href = "view.html"
}