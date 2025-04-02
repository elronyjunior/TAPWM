function Media(){
    var nome=window.prompt('Qual o seu nome?');
    var notas=[];
    var media=0;
    for(let i =0;i<3;i++){
        notas[i]=window.prompt('insira suas notas, uma por vez')
        media+=notas[i];
    }
    media=media/3
    window.alert(`${nome} suas notas foram ${notas} e  sua media foi ${parseFloat(media)}`)
}
function Operacoes(){

}

if(window.location.href.includes('Media.html')){
    Media();
}
else if(window.location.href.includes('Operacoes.html')){
    Operacoes()
}