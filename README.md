# User Manual
## Installation:
1) Follow the link: https://github.com/Ziggchik/Workers_performance_analisys
2) Press green button "Code"
3) In the drop-down list that opens, select how you want to install the project
### Download Zip:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Download Zip"
3) The "download" folder will contain the downloaded archive, unzip it to any place on your computer
4) In Unzip files open  "Workers_performance_analisys.sln"
6) Save open project (Ctrl+Shift+S) in any place on you computer
7) Press buttons combination "Shift+F5" to launch application
### Open with Visual Stido:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Open with Visual Studio"
3) In Visual Studio click to button "Clone repository"
4) Solution will donwload from repository and you can save project (Ctrl+Shift+S) in any place on you computer
### Download with command:
1) Press button combination "Win+R" and write "cmd"
2) Write this commands:
* git clonehttps://github.com/Ziggchik/Workers_performance_analisys.git
* cd Workers_performance_analisys
* dotnet build
* dotnet run
3) After that application will start
## How to use:
### Admin
1) Run application
2) Authorize wth your login/email and password 
3) In navigation panel you can choose the function you need for administration 
![image](https://user-images.githubusercontent.com/70440445/141262436-ac0a8973-edb9-44f1-b79d-639496bf96bd.png)
#### Administrator functions (Parameters)
![image](https://user-images.githubusercontent.com/70440445/141263743-10654aba-3f4d-470c-ba57-2b3dd31385fe.png)
1) Click on label "Parameters" in navigation panel
2) In the window that opens, you can see a table with information about evaluations parameters
3) If you need delete parameter click button "Delete" opposite the parameter that you want to delete and confirm deleting
![image](https://user-images.githubusercontent.com/70440445/141266046-591dd333-6c8c-4c56-9e6d-c103013d4687.png)
5) If you need add new parameter click button "Create new"
6) In the window that opens, write in textboxes information about new parameter
7) If you want close menu click button "Back", If you filled information and want create parameter click button "Create"
8) After that new information will be added in table
![image](https://user-images.githubusercontent.com/70440445/141265275-1179d55b-cb44-4caa-b752-ceb2dcfe0d39.png)
10) If you need edit existing parameter click button "Edit" or "Details"
11) In the window that opens, change in textboxes information about parameter and click "Save"
12) After that new information will be added in table
![image](https://user-images.githubusercontent.com/70440445/141265356-e46269f5-1ebe-4a59-9a7b-f7743fc10e76.png)
#### Administrator functions (Workers)
![image](https://user-images.githubusercontent.com/70440445/141265168-0bd2c758-c1f0-424b-8131-48e1040c082f.png)
1) Click on label "Workers" in navigation panel
2) In the window that opens, you can see a table with information about workers in company
3) If you need delete worker(better cahange worker status default->fired) click button "Delete" opposite the worker that you want to delete and confirm deleting
![image](https://user-images.githubusercontent.com/70440445/141264498-755e61dd-6b45-43e7-86bc-6fe4a4ac39f5.png)
4) If you need add new parameter click button "Create new"
5) In the window that opens, write in textboxes information about new parameter
6) If you want close menu click button "Back", If you filled information and want create workplace click button "Create"
7) After that new information will be added in table
![image](https://user-images.githubusercontent.com/70440445/141264582-98dcdf15-0253-4902-939a-98a68a6bdbe6.png)
10) If you need edit information about worker click button "Edit" 
11) In the window that opens, change in textboxes information about worker and click "Save"
12) After that new information will be added in table
![image](https://user-images.githubusercontent.com/70440445/141266386-ae8b2ef7-af3c-45f2-a5ec-f6823010ce16.png)
#### Administrator functions (Departments structure)
![image](https://user-images.githubusercontent.com/70440445/141266847-774a3360-a522-4416-9dcd-f9dd52551591.png)
1) Click on label "Departments structure" in navigation panel
2) In the window that opens, you can see departments structure in company (Head of departmen->teamlead->workers(users))
#### Administrator functions (Departments)
![image](https://user-images.githubusercontent.com/70440445/141266993-1212e4e1-6218-4c08-a450-bb6694e3e6d9.png)
1) Click on label "Departments" in navigation panel
2) After that choose department or create new (button "Create") same way as the new information about parameters and workers were created
![image](https://user-images.githubusercontent.com/70440445/141267421-c3811ce3-5116-447b-8021-bb45898e42a5.png)
3) In the window that opens, you can see department information about workers, department parameters and groups for finding employees for department. In this window you can edit department name or or delete it if the department is disbanded (buttons "edit" and "create" in the department map on the top left).
![image](https://user-images.githubusercontent.com/70440445/141268361-aabc1901-cff5-4613-b377-74c4c449f686.png)
4) In the department workers you can view the department employees part.Name, sourname, recent estimates on the parameters of this department and the employee progress are showed here. Also here are filters for viewing the progressing and logging progress of employees.
![image](https://user-images.githubusercontent.com/70440445/141269210-ad958e29-bf90-436a-b6a8-8f262e79b807.png)
![image](https://user-images.githubusercontent.com/70440445/141269346-bc89becd-9482-4318-a522-0f24553a6cb7.png)
5) In the department parameters you can view the parameters which are important specifically for the workes of this department with their assessments. You can also create, delete and parameters by analogy with the standard DB functions described above.
![image](https://user-images.githubusercontent.com/70440445/141270036-12aee73c-803e-4835-afbd-131d8cc76ddf.png)
6) In the department groups you can view departmenys groups. You can also create, delete and parameters by analogy with the standard DB functions described above. You can export data in .xls format (button "export to excel"). And create top list of workers (link "Show").The screenshots below show the function of compiling a list of the best workers and export function (groups).
![image](https://user-images.githubusercontent.com/70440445/141270815-b753cc2b-e3f0-42f4-ad33-e5eaeb5c434a.png)
![image](https://user-images.githubusercontent.com/70440445/141270857-f902a651-b6c4-4ae3-9ec5-19fc513af532.png)
![image](https://user-images.githubusercontent.com/70440445/141270918-32b0709d-82bd-42c5-b290-73465f7c9614.png)
![image](https://user-images.githubusercontent.com/70440445/141270952-42965f75-1763-45d5-b04d-4d9b55ebc542.png)
![image](https://user-images.githubusercontent.com/70440445/141270980-9c92debc-7479-4956-b244-1bd205394c5a.png)
![image](https://user-images.githubusercontent.com/70440445/141271037-445c7f25-e9a7-48b8-90cb-9ee4ad9dc5a0.png)
![image](https://user-images.githubusercontent.com/70440445/141271216-99cc0396-12a9-4e26-97ab-59ab5e506fba.png)
![image](https://user-images.githubusercontent.com/70440445/141271336-7fa3e5e4-b27d-4420-a1de-448aec197f64.png)
#### Administrator functions (logout)
1) If you want leave site click on label "Logout" in navigation panel (up-right corner) 
2) After that you will be rederict in authorization window
### Teamlead
1) Run application
2) Authorize wth your login/email and password 
#### Teamlead functions (Evaluations)
1) After authorization you can see information table with workers evaluations. You can create an delete evaluations by analogy with the standard DB functions described above (See chapter Admin->Administrator functions (Parameters)->points 3-8)
![image](https://user-images.githubusercontent.com/70440445/141272624-16c5ed97-882c-494a-97a4-d1a7263d8e32.png)
![image](https://user-images.githubusercontent.com/70440445/141272649-4e8cc80d-396c-43dd-a8b3-416173d8c785.png)
![image](https://user-images.githubusercontent.com/70440445/141272673-89d2d5a2-bb8d-466a-bae3-e707949bf823.png)
#### Teamlead functions (Departments structure)
![image](https://user-images.githubusercontent.com/70440445/141272819-95270708-e64c-4ea1-9ce5-31516bded03e.png)
1) Click on label "Departments structure" in navigation panel
2) In the window that opens, you can see departments structure in company (Head of departmen->teamlead->workers(users))
#### Teamlead functions (logout)
1) If you want leave site click on label "Logout" in navigation panel (up-right corner) 
2) After that you will be rederict in authorization window
### Head of department
1) Run application
2) Authorize wth your login/email and password
3) #### Head of departmentfunctions (Evaluations)
1) After authorization you can see information table with workers evaluations. You can create an delete evaluations by analogy with the standard DB functions described above (See chapter Admin->Administrator functions (Parameters)->points 3-8), but you can also evaluate the work of team leads.
![image](https://user-images.githubusercontent.com/70440445/141273423-2289b9e9-60e0-46cd-a2e7-f40252ddafd0.png)
![image](https://user-images.githubusercontent.com/70440445/141273483-fad99ba4-41ce-442f-9e68-03020a737dbb.png)
![image](https://user-images.githubusercontent.com/70440445/141273517-9e490f72-4428-4d3d-9b82-eefeda67895b.png)
 #### Head of department functions (Departments structure)
![image](https://user-images.githubusercontent.com/70440445/141273692-89333cad-c53d-4787-8811-68146389140c.png)
1) Click on label "Departments structure" in navigation panel
2) In the window that opens, you can see departments structure in company (Head of departmen->teamlead->workers(users))
#### Head of department functions (logout)
1) If you want leave site click on label "Logout" in navigation panel (up-right corner) 
2) After that you will be rederict in authorization window
### Users (workers)
![image](https://user-images.githubusercontent.com/70440445/141274065-1ed37ace-8425-4e30-8b9a-8e25bf8588fa.png)
## Architecture: 
1) The project create with ASP.NET Core 3.1 MVC and using language C#.
2) The project uses Microsoft.EntityFrameworkCore 5.0.10
3) The project uses addons for Microsoft.EntityFrameworkCore (Tools, Proxies, SqlServer, Design)
4) Database create on SqlServer and use query language T-sql
## Application Updates:
In the near future in application new features will be added to the application:
1) Users functions
2) Updating and improving design
3) Bug fixes (acess control and exeptions)
