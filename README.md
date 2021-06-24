# **Password Generator**
# SFIA 2

Project brief
---


The project was intended to create a service-orientated architecture for an application, which will be composed of at least 4 services that work together. I have decided to create a **password generator** using C#, ASP.NET, XUnit testing the application through unit testing and deployment the application using GitHub action.

![Screenshot (508)](https://user-images.githubusercontent.com/82108067/123120872-95209980-d43c-11eb-891a-d53ab2eababf.png)

CI (Continuous Integration)
---


The benefit of having this pipeline is that it allows developers to integrate newly-generated code easily and frequently, and is achieved through the use of automated testing tools to check the correctness of code before full integration. The version control system (VCS) and the version control system provider (VCSP) is Git and GitHub. The VCS is designed to track changes to code over time as contributors add new features to the application. This system allows for cohesive collaboration and the ability to easily revert an application to a previous, stable state if new code breaks something. The CI server handles all the automated building, testing, and deployment of code as it is pushed to the VCS.

Service Architecture
---


![Screenshot (511)](https://user-images.githubusercontent.com/82108067/123141788-aa072800-d450-11eb-9d90-a601f43bcde5.png)



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

![Screenshot (514)](https://user-images.githubusercontent.com/82108067/123174074-77245a80-d477-11eb-8312-625747277ba5.png)

Proof:

![Screenshot (474)](https://user-images.githubusercontent.com/82108067/123139733-6f9c8b80-d44e-11eb-8200-3c2df512fff9.png)

**Testing**
---

*XUnit Testing*
 
![Screenshot (451)](https://user-images.githubusercontent.com/82108067/123105032-5afccb00-d42f-11eb-9f09-76c38bd071f1.png)
![Screenshot (461)](https://user-images.githubusercontent.com/82108067/123105042-5df7bb80-d42f-11eb-8d1c-c3315e000d34.png)
![Screenshot (460)](https://user-images.githubusercontent.com/82108067/123105049-605a1580-d42f-11eb-8480-ecb3f0c3e6eb.png)


This image above shows the XUnit tests written on visual studio code have successfully passed. From the image above we can see the overall code coverage of the application is 73.5%. As you can see, my FrontEnd and Numbers Controller has a 100% test coverage, however my letters and merge controller have less than 100%. This is because in these two controllers I have incorporated an if-else statement. When it came to writing tests, I’m sure with time I would have been able to figure out how to write tests for if-else statements but simply writing more tests would increase this line coverage to 100% thereby increasing the overall line coverage from 73.5% to something higher.

(Room for improvement): I did not manage to find out how to exclude Views from the testing results, which may have affected the final coverage result.
* [ExcludeFromCodeCoverage]

**Deployment**
---

Terraform is an open source “Infrastructure as Code” tool created by HashiCorp for building and managing infrastructure efficiently. Infrastructure as code means we can write code for our hardware infrastructure. Terraform allows you to control your infrastructure on a cloud service provider and there to be little to no downtime when editing files/workflow.
The three commands help create the workflow successfully:
-	terraform init
-	terraform plan
-	terraform apply



![Screenshot (481)](https://user-images.githubusercontent.com/82108067/123105517-c9418d80-d42f-11eb-9d20-caeb482d6286.png)
![Screenshot (484)](https://user-images.githubusercontent.com/82108067/123172677-5ce97d00-d475-11eb-8272-c0a1122d6d93.png)
![Screenshot (470)](https://user-images.githubusercontent.com/82108067/123140404-27ca3400-d44f-11eb-8582-e8b4168fcfb0.png)

![Screenshot (510)](https://user-images.githubusercontent.com/82108067/123140394-2567da00-d44f-11eb-9e5b-86b34220acb5.png)


The YAML language tends to be used for creating configuration files. The images below shows that once a file pushed onto the master branch, the following build and deploy actions should take place. During the project I had alter the code to essentially direct the directory into the place in which my code was stored. The addition of ./code/ were made to AZURE_WEBAPP_PACKAGE_PATH and WORKING_DIRECTORY. Once completed this was committed, this leads to the workflow running and essentially a build and deploy process was then triggered (As shown below in the image).

![Screenshot (512)](https://user-images.githubusercontent.com/82108067/123166616-84d4e280-d46d-11eb-8f63-9f2742bddc3e.png)






**Issues faced**
---

![Screenshot (475)](https://user-images.githubusercontent.com/82108067/123105231-8d0e2d00-d42f-11eb-8bab-9a747239668f.png)

Another issue I faced was a typo I made in the case sensitivity of my appsettings (AppSettings). I realised this after I deployed my services which meant I had to destroy my terraform (‘terraform destroy’) and rebuild it again with the correct casing. His error caused my frontend to not work as shown below.

![Screenshot (441)](https://user-images.githubusercontent.com/82108067/123213527-005e8000-d4be-11eb-9803-376c011bca46.png)

Another issue I came across was the terraform file being too large meaning when it came to committing and pushing my changes onto GitHub, this was being prevented. I then decided to save all my work and do the reset command shown below which then helped resolve the situation.
git reset --hard @{u}


![Screenshot (476)](https://user-images.githubusercontent.com/82108067/123139746-73301280-d44e-11eb-8bd3-f3d3a7017543.png)



**Additional information:**
---

<!-- UL -->
* I have included a gitignore file, this simply blocks out appsettings.Json, any terraform files because they may contain passwords and therefore I have successfully been able to avoid that information getting gin the wrong hands. 

* As part of the requirements, I have demonstrated storing code in a structured manner with the use of branches. I did all my testing on a ‘testing branch’ and merged all my work into the master once I was ready. This ensured I faced no conflicts.


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


What to do in situations beyond our control and how would be handle, mitigate this situation?

Ideally, you want to identity the cause and solve it but in some cases it is simply out of our control. Git is a distributed source control therefore having and keeping a working copy on hand is always a good idea. Another alternative would be switching to another course control, such as Bitbucket. These scenarios depend on the urgency of the issue, after 2-3 hour downtime, git tends to work fine – but sometimes timings get in the way.

There are numerous benefits of moving to the cloud, costs, ease, future of working. In terms of deployment after facing issues on project one using Azure pipelines, I decided it would be smart to go straight into deploying via GitHub Action. The Academy also showed me the number of ways I can create resources in the cloud (cloud shell, azure portal, SDK, Azure CLI)

It very interesting to see how to create resource groups and variables inside Terraform, and then it actually displays inside the Azure Portal – which meant the manual clicking element was taking out. IaaC, such as Terraform ensures the user faces no issues/downtime which is what clients are after. Updates are self-managed and frequent.


Using best practices such as commenting throughout my code, this helps other teammates or in this case Dara understand what my code is intended to do. This saves time and is a good habit to continue doing.



Credits:
Dara Oladapo
QA Community 


Author
---

Gini Uthayakumar
