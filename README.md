# TwitterAPI

BU/22C/IT/7386
Christabel Omo Ashafokhe

The Twitter Analytics API is a RESTful web service built using ASP.NET Core that allows users to manage and analyze Twitter data. It provides endpoints to perform CRUD operations on Users and Tweets, enabling the tracking of a user's tweet performance and offering recommendations for improvement based on past performance. The API can also analyze trends in live tweets and provide graphical representations for real-time trend inspection.

#Instructions to Run and Test the API Open the Project in Visual Studio Launch Visual Studio. Select "Open a project or solution" and navigate to the folder containing the project files. Open the .sln file. Restore NuGet Packages

Open the Solution Explorer. Right-click on the solution and select "Restore NuGet Packages". Run the Application

Press F5 or click the "Start Debugging" button in Visual Studio. The application will start and host the API on https://localhost:/. Open Swagger UI

Once the application is running, open a browser and navigate to https://localhost:/swagger. This will open the Swagger UI, where you can see the available endpoints and test them directly.

Examples of API Requests and Expected Responses User Endpoints Get All Users

Request: GET /api/users Response:
[ {
"userId": 1,
"username": "Lazy_pri",
"fullName": "Success", 
"joinDate": "2022-07-08T00:00:00",
"followersCount": 104 }, 

{ "userId": 2, 
"username": "sage",
"fullName": "Christabel Omo",
"joinDate": "2023-07-08T00:00:00",
"followersCount": 29 
} ]
