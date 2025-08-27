let http = require('http');
let server = http.createServer(function(req,res){
let url =req.url;
if(url=='/historia'){
    res.end("<html><body><H1 style='text-align:center'><b>Site da fatec Sorocaba na aba de historia</b></H1><body></html>");
}
else if(url=='/curso'){
    res.end("<html><body><H1 style='text-align:center'><b>Site da fatec Sorocaba na aba de curso</b></H1><body></html>");
}

else if(url=='/professor'){
    res.end("<html><body><H1 style='text-align:center'><b>Site da fatec Sorocaba na aba de professor</b></H1><body></html>");
}

else{
    res.end("<html><body><H1 style='text-align:center'><b>Site da fatec Sorocaba</b></H1><body></html>");
}

});
server.listen(3000)

