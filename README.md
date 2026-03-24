# Game Interest Tracker API
A simple fullstack project built with ASP.NET Core and JavaScript that allows users to register their interest in a game (inspired by MMORPG-style class selection).

# Features
REST API built with ASP.NET Core (.NET 8)
Full CRUD operations (Create, Read, Update, Delete)
SQLite database with Entity Framework Core
Data validation using Data Annotations
Filtering users by favorite class
Simple frontend client using vanilla JavaScript (fetch API)

# Tech Stack
Backend: C#, ASP.NET Core Web API
Database: SQLite + Entity Framework Core
Frontend: HTML, JavaScript (Fetch API)
Tools: Postman, Swagger

# API Endpoints
Method	Endpoint	Description
GET	/api/UserInterests	Get all users
GET	/api/UserInterests/{id}	Get user by ID
POST	/api/UserInterests	Create a new user
PUT	/api/UserInterests/{id}	Update a user
DELETE	/api/UserInterests/{id}	Delete a user

# Example Request
{ "username": "Arturo", "email": "arturo@test.com", "favoriteClass": "Knight" }

# Running the Project
Backend
dotnet restore
dotnet build
dotnet run

API will be available at:

http://localhost:5138

Frontend

Open the Client/index.html file using a local server (e.g. Live Server in VS Code).
Make sure the API URL matches your backend port:

const API_URL = "http://localhost:5138/api/UserInterests";

# Configuration 
You can change the port in:
Properties/launchSettings.json
Or run with a custom URL:

dotnet run --urls="http://localhost:5000"

# What I learned
Building REST APIs with ASP.NET Core
Working with Entity Framework Core and migrations
Handling HTTP requests and responses properly
Debugging common backend issues (CORS, database migrations, API errors)
Connecting a frontend client to a backend service


# Future Improvements
Authentication (JWT)
Better UI (React or similar)
Deployment to cloud (Render / Railway)
Replace SQLite with a production database
