# Portfolio API

A lightweight, modular REST API powering my personal website (joshuagoad.com).Built with Node.js and Express, this API serves project data, portfolio information, and backend logic for future expansions.

🚀 Features

RESTful JSON endpoints

Modular routing and controller structure

Environment-based configuration

Scalable folder layout

Ready for CI/CD integration (Jenkins)

Designed for forward-compatible expansion

🛠 Tech Stack

Node.js

Express.js

JavaScript

JSON

dotenv

Azure/AWS hosting (depending on where you deploy)

📡 API Endpoints

Endpoint

Method

Description

/projects

GET

Returns list of portfolio projects

/status

GET

Health check endpoint

/about

GET

Returns profile information

(Add or adjust based on your actual routes.)

📦 Installation

git clone https://github.com/Joshua-Goad/portfolio-api
cd portfolio-api
npm install

▶ Running the API

npm start

🔐 Environment Variables

Create a .env file:

PORT=3000
NODE_ENV=development

📈 Future Enhancements

Add authentication

Add database integration (PostgreSQL or MongoDB)

Add logging and monitoring

Add automated tests

Add Jenkins CI/CD pipeline

📄 License

MIT License
