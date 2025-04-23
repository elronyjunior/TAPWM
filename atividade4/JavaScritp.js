function Media(){
    var nome=window.prompt('Qual o seu nome?');
    var notas=[];
    var media=0;
    for(let i =0;i<3;i++){
        notas[i]=window.prompt('insira suas notas, uma por vez')
        media+=parseFloat(notas[i]);
    }
    media=(media/3).toFixed(2)
    window.alert(`${nome} suas notas foram ${notas} e  sua media foi ${parseFloat(media)} pontos`)
}
function Operacoes(){
    var nome=window.prompt('Qual o seu nome?');
    var n=[];
    for(let i =0;i<2;i++){
        n[i]=parseFloat(window.prompt('insira um numero por vez para fazer todas as operações'))
        
    }
    window.alert(`Vamos fazer as contas ${nome} =) \n
        Soma: ${n[0]} + ${n[1]} = ${n[0] + n[1]} \n
        Subtração: ${n[0]} - ${n[1]} = ${n[0] - n[1]} \n
        Mutiplicação: ${n[0]} X ${n[1]} = ${n[0] * n[1]} \n
        Divisão: ${n[0]} / ${n[1]} = ${n[0] / n[1]} \n
        Modulo: ${n[0]} % ${n[1]} = ${n[0] % n[1]}`)
}

if(window.location.href.includes('Media.html')){
    Media();
}
else if(window.location.href.includes('Operacoes.html')){
    Operacoes()
}