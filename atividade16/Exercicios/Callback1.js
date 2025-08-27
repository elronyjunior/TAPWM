const prompt = require('prompt-sync')();

function saudacao(nome){
    console.log("olá "+nome);

}

function EntradaNome(callback){
    let nome = prompt("Digite seu nome: ");
    callback(nome);
}

EntradaNome(saudacao)