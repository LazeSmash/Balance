const http = require("http"); 
const fs = require("fs");

const port = 8080;

fs.readFile("index.html", function(err, html) {
    if (err) throw err;
    http.createServer(function(request, respone) {
        respone.writeHeader(200, {"Content-Type": "text/html"});
        respone.write(html);
        respone.end();
    }).listen(8080);
})