# **Password Generator**
# SFIA 2
http://eventswebapp.azurewebsites.net/

Project brief
The project was intended to create a service-orientated architecture for an application, which will be composed of at least 4 services that work together. I have decided to create a password generator using C#, ASP.NET, XUnit testing the application through unit testing and deployment the application using GitHub action.





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

![Screenshot (121)](https://user-images.githubusercontent.com/82108067/117577185-a3ab2f80-b0e0-11eb-947f-f10e01d1cd72.png)

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
 
Moq is a mocking framework for C# .NET. It is used in **unit testing** to isolate a class under test from its dependencies and ensure that the proper methods on the dependent objects are being called. Mock objects allow you to mimic the behaviour of classes and interfaces, letting you code the in the test interact with them as if they were real.

In my code, I created a separate folder, repositories and interfaces and created objects that would mock my previous work. I then carried out tests (using test explorer) to see if my code was doing what it was supposed to. I tested all the features I had created, so add, delete, update. As you can see below 7 tests passed yet my coverage report shows a 37.5% line coverage. Red means these lines could run but are never executed.

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

**Future improvements:**
---

* The code coverage result can be increase by carrying out more tests, in particular testing for if-else statements
* With additional timings, I could have combined 4 yaml files into one – this would make my work neater and since its only 4 services and not too complex this would be better
* More work can be done on the frontend (HTML) to enhance it and make it more visually appealing



Author
---

Gini Uthayakumar
