function validar() {
    let form = document.formulario;
    let nome = form.elements["nome"].value.trim();
    let email = form.elements["email"].value.trim();
    let comentario = form.elements["comentario"].value.trim();
    let pesquisa = form.elements["pesquisa"].value;

    if (nome.length < 10) {
        alert("O nome deve ter no mínimo 10 caracteres!");
        return false;
    }
    if (email === "") {
        alert("Digite um e-mail válido!");
        return false;
    }


    if (comentario.length < 20) {
        alert("O comentário deve ter no mínimo 20 caracteres!");
        return false;
    }


    let radios = form.elements["pesquisa"];
    let escolhido = false;
    let valorEscolhido = "";
    for (let i = 0; i < radios.length; i++) {
        if (radios[i].checked) {
            escolhido = true;
            valorEscolhido = radios[i].value;
            break;
        }
    }

    if (!escolhido) {
        alert("Selecione uma opção na pesquisa!");
        return false;
    }


    if (valorEscolhido === "nao") {
        alert("Que bom que você voltou a visitar esta página!");
    } else {
        alert("Volte sempre a esta página!");
    }

    return true;
}
