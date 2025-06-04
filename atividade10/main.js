function executarRetangulo() {
  const base = parseFloat(prompt("Digite a base do retângulo:"));
  const altura = parseFloat(prompt("Digite a altura do retângulo:"));

  const ret = new Retangulo(base, altura);
  document.getElementById("resultado").innerHTML =
    `Área do retângulo: ${ret.calcularArea()} m²`;
}

function executarContas() {
  // Conta Corrente
  const corrente = new Corrente();
  corrente.correntista = prompt("Nome do correntista (Corrente):");
  corrente.banco = prompt("Banco (Corrente):");
  corrente.numeroConta = prompt("Número da conta (Corrente):");
  corrente.saldo = parseFloat(prompt("Saldo (Corrente):"));
  corrente.saldoEspecial = parseFloat(prompt("Saldo especial (Corrente):"));

  // Conta Poupança
  const poupanca = new Poupanca();
  poupanca.correntista = prompt("Nome do correntista (Poupança):");
  poupanca.banco = prompt("Banco (Poupança):");
  poupanca.numeroConta = prompt("Número da conta (Poupança):");
  poupanca.saldo = parseFloat(prompt("Saldo (Poupança):"));
  poupanca.juros = parseFloat(prompt("Taxa de juros (%):"));
  poupanca.dataVencimento = prompt("Data de vencimento (dd/mm/aaaa):");

  // Mostrar resultados
  document.getElementById("resultado").innerHTML =
    `<strong>Conta Corrente:</strong><br>${corrente.exibirDados()}<br><br>
     <strong>Conta Poupança:</strong><br>${poupanca.exibirDados()}`;
}
