const signinform = document.getElementById("showUserDetail");


    var email = localStorage.getItem("email");
    email = email.replace(/['‘’"“”]/g, '')
    console.log(email);


    fetch(`https://localhost:7218/api/UserControler/FetchUser/${email} `,
    {
        method: "GET",
        headers: {
            "Context-type": "application.json; charset=UTF-8",
        },
    })
    .then((response) =>response.json())
    // .then((json)=>console.log(json[0]))
    .then((element) => {
        const parentDiv = document.createElement('div')
                parentDiv.className = "container"

                const div = document.createElement('div')
                div.className = "card"

                div.appendChild(document.createElement('hr'))



                const user_id = document.createElement('p')
                user_id.textContent = "User-Id :- " + element[0].userId
                user_id.className = "card_user_user_id"

                const salutation = document.createElement('p')
                salutation.textContent = "Salutation:- "+ element[0].salutation
                salutation.className = "card_user_salutation"

                const first_name = document.createElement('p')
                first_name.textContent = "First-Name :- "+ element[0].firstName
                first_name.className = "card_user_first_name"

                const middle_name = document.createElement('p')
                middle_name.textContent = "Middle-Name :- "+ element[0].middleName
                middle_name.className = "card_user_middle_name"

                const last_name = document.createElement('p')
                last_name.textContent = "Last-Name :- "+ element[0].lastName
                last_name.className = "card_user_last_name"

                const age = document.createElement('p')
                age.textContent = "Age :- " + element[0].age
                age.className = "card_user_age"

                const gender = document.createElement('p')
                gender.textContent = "Gender :- " + element[0].gender
                gender.className = "card_user_gender"

                const email = document.createElement('p')
                email.textContent = "Email :- "+ element[0].email
                email.className = "card_user_email"




                div.appendChild(user_id)
                div.appendChild(salutation)
                div.appendChild(first_name)
                div.appendChild(middle_name)
                div.appendChild(last_name)
                div.appendChild(age)
                div.appendChild(gender)
                div.appendChild(email)

        


                signinform.appendChild(div)
    })