const signinform = document.getElementById("showUserDetail");


var email = localStorage.getItem("email");
email = email.replace(/['‘’"“”]/g, '')
console.log(email);


fetch(`https://localhost:7218/api/EducationControler/FetchUser/${email} `,
{
    method: "GET",
    headers: {
        "Context-type": "application.json; charset=UTF-8",
    },
})
.then((response) =>response.json())
.then(element => {

    element.forEach(item => {
        const parentDiv = document.createElement('div')
            parentDiv.className = "container"

            const div = document.createElement('div')
            div.className = "card"

            div.appendChild(document.createElement('hr'))
            

            const grade = document.createElement('p')
            grade.textContent = "Grade :- "+ item.grade
            grade.className = "card_user_last_name"

            const passedoutyear = document.createElement('p')
            passedoutyear.textContent = "Passed-Out-Year :- "+ item.passedoutyear
            passedoutyear.className = "card_user_first_name"

            const university = document.createElement('p')
            university.textContent = "University :- "+ item.university
            university.className = "card_user_last_name"

            const ug = document.createElement('p')
            ug.textContent = "ug :- "+ item.ug
           ug.className = "card_user_last_name"

           const specialization = document.createElement('p')
           specialization.textContent = "University :- "+ item.specialization
           specialization.className = "card_user_last_name"



          
            div.appendChild(university)
            div.appendChild(passedoutyear)
            div.appendChild(ug)
            div.appendChild(specialization)
            div.appendChild(grade)




            signinform.appendChild(div)
    });
    
    })