const express = require('express');
const path = require('path');

const app = express();
const port = 8000;

// Define the public directory where your HTML file is located
const publicDirectory = path.join(__dirname, '/');

// Set up middleware to serve static files from the public directory
app.use(express.static(publicDirectory));

// Define a route to handle the root URL and serve the index.html file
app.get('/', (req, res) => {
    res.sendFile(path.join(publicDirectory, '/index.html'));
});

// Start the server
app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});
