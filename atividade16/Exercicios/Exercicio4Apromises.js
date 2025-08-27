//Função para imprimir a primeira parte
function Parte1(){
    for(var i=1;i<=10; i++){
        console.log("primeira parte"+i)
    }
}

setTimeout(Parte1,2000)//para atrassar

const fs = require('fs').promises//importa a versão com Promises
fs.readFile('file.txt','utf8')// O utf8 evita a necessidade de toString()
.then(data =>{
    const registros = data.split('\n');
    registros.forEach((registro,index)=>{
        console.log("segunda parte:"+registro+" "+index);
    });
})
.catch(err=>{
    console.log("Erro ao ler o arquivo:", err)
})