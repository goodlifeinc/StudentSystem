const path = require('path');
const Hapi = require('hapi');
const Inert = require('inert');
const indexRoute = require('./routes/index');
const db = require('./db');

// Create a server with a host and port
const server = new Hapi.Server();
server.connection({ 
    host: 'localhost', 
    port: Number(process.argv[2] || 8080) 
});

const modules = [Inert, db()];
const routes = indexRoute();

server.register(modules, err => {
    if (err) throw err;

    // this is workaround to catch 
    // all not existing requests
    // and redirect them to /
    server.ext('onPreResponse', function (request, reply) {
        
        var response = request.response;
        if (!response.isBoom ||
            response.output.statusCode !== 404) {
    
            return reply.continue();
        }
    
        reply.redirect('/');
    });

    server.route(routes);
    
    // Start the server
    server.start((err) => {
    
        if (err) {
            throw err;
        }
        console.log('Server running at:', server.info.uri);
    });
});