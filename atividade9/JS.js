function calcularIMC() {
  const altura = parseFloat(document.getElementById("altura").value);
  const peso = parseFloat(document.getElementById("peso").value);
  const resultado = document.getElementById("resultado");

  if (isNaN(altura) || isNaN(peso) || altura <= 0 || peso <= 0) {
    resultado.textContent = "Por favor, insira valores válidos.";
    return;
  }

  const imc = peso / (altura * altura);
  const classificacao = obterClassificacaoIMC(imc);

  resultado.textContent = `Seu IMC é ${imc.toFixed(2)} - ${classificacao}`;
}

function obterClassificacaoIMC(imc) {
  if (imc < 18.5) {
    return "Magreza (Obesidade Grau 0)";
  } else if (imc < 25) {
    return "Normal (Obesidade Grau 0)";
  } else if (imc < 30) {
    return "Sobrepeso (Obesidade Grau I)";
  } else if (imc < 40) {
    return "Obesidade (Obesidade Grau II)";
  } else {
    return "Obesidade Grave (Obesidade Grau III)";
  }
}
