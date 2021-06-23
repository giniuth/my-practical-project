# **Password Generator**
# SFIA 2


Project brief
The project was intended to create a service-orientated architecture for an application, which will be composed of at least 4 services that work together. I have decided to create a password generator using C#, ASP.NET, XUnit testing the application through unit testing and deployment the application using GitHub action.

![Screenshot (508)](https://user-images.githubusercontent.com/82108067/123120872-95209980-d43c-11eb-891a-d53ab2eababf.png)



**Additional information:**
---

<!-- UL -->
* Users are then required to give us more details including the guest capacity, whether they’d like Alcohol, Catering and if so what Cuisine.

* Users at this point can add a description or give us further details that will help the event company when it comes to planning their specific event.

**Project Tracking**
---


[This is the link to my Trello Board](https://trello.com/b/ioxDkTOo/qaproject)

Using a Trello board helped me visualise the process clearly and keep track of workflow against the time limit.The benefits of having a visual grid helped me see how much progress I was making. I also kept a column for hurdles/errors I overcame since I do believe its important to note down this information. Additionally, using a colour coding system helped me immensely (eg: Red was associated with urgent/I need help).

<!-- Blockquote -->
> Trello board two weeks into the project

![Screenshot (509)](https://user-images.githubusercontent.com/82108067/123125828-c56a3700-d440-11eb-971e-f1e8fa2e6827.png)

* Notes
* User stories
* To do
* Doing
* Done

In hindsight, I'm glad I took a simple approach - I was able to assign the tasks into the right column quicker and having less clutter on the Trello Board made it slightly less overwhelming. 



**Risk Assessment**
---



**Testing**
---

*XUnit Testing*
 
This image above shows the XUnit tests written on visual studio code have successfully passed.
From the image above we can see the overall code coverage of the application is 73.5%. In order to improve this percentage, I would test the if-else statements.

Testing proof
![Screenshot (451)](https://user-images.githubusercontent.com/82108067/123105032-5afccb00-d42f-11eb-9f09-76c38bd071f1.png)
![Screenshot (461)](https://user-images.githubusercontent.com/82108067/123105042-5df7bb80-d42f-11eb-8d1c-c3315e000d34.png)
![Screenshot (460)](https://user-images.githubusercontent.com/82108067/123105049-605a1580-d42f-11eb-8480-ecb3f0c3e6eb.png)






The routing constraint"{id:int}" tells the page to accept requests to the page that contain int route data. If a request to the page doesn't contain route data that can be converted to an int , the runtime returns an HTTP 404 (not found) error.

**Deployment**
---

![Screenshot (481)](https://user-images.githubusercontent.com/82108067/123105517-c9418d80-d42f-11eb-9d20-caeb482d6286.png)



**Issues faced**

![Screenshot (475)](https://user-images.githubusercontent.com/82108067/123105231-8d0e2d00-d42f-11eb-8bab-9a747239668f.png)
Another issue I came across was the terraform file being too large meaning when it came to committing and pushing my changes onto GitHub, this was being prevented. I then decided to save all my work and do the reset command shown below which then helped resolve the situation.
git reset --hard @{u}
Another issue I faced was a typo I made in the case sensitivity of my appsettings (AppSettings). I realised this after I deployed my services which meant I had to destroy my terraform (‘terraform destroy’) and rebuild it again with the correct casing. His error caused my frontend to not work as shown below.( add 441)


**Future improvements:**
---

* The code coverage result can be increase by carrying out more tests, in particular testing for if-else statements
* With additional timings, I could have combined 4 yaml files into one – this would make my work neater and since its only 4 services and not too complex this would be better
* More work can be done on the frontend (HTML) to enhance it and make it more visually appealing

[Backup proof of working application]
As mentioned in the risk assessment, when working through the final project – one of the obstacles I came across was GitHub actions going down (down-time) – this meant my changes in the workflow were not building meaning my front-end website will not be updated to the latest version.

![Screenshot (486)](https://user-images.githubusercontent.com/82108067/123105359-a616de00-d42f-11eb-8a7b-719a6f12ec17.png)
![Screenshot (487)](https://user-images.githubusercontent.com/82108067/123105415-b464fa00-d42f-11eb-9125-f91b5e3593be.png)
![Screenshot (485)](https://user-images.githubusercontent.com/82108067/123105385-aca55580-d42f-11eb-94d1-c33ad91b09db.png)


Author
---

Gini Uthayakumar
