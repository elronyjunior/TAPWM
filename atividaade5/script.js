let dados = JSON.parse(localStorage.getItem("dadosPesquisa")) || [];

document.getElementById('pesquisaForm').addEventListener('submit', function (e) {
  e.preventDefault();

  const form = e.target;
  const novoDado = {
    idade: parseInt(form.idade.value),
    sexo: form.sexo.value,
    opiniao: parseInt(form.opiniao.value)
  };

  dados.push(novoDado);
  localStorage.setItem("dadosPesquisa", JSON.stringify(dados));

  form.reset();
  exibirEstatisticas();
});

document.getElementById('exportarBtn').addEventListener('click', () => {
  if (dados.length === 0) return alert("Nenhum dado para exportar!");

  const texto = dados.map(d => JSON.stringify(d)).join('\n');
  const blob = new Blob([texto], { type: "text/plain" });
  const link = document.createElement("a");
  link.href = URL.createObjectURL(blob);
  link.download = "dados.txt";
  link.click();
});

document.getElementById('importarInput').addEventListener('change', function () {
  const arquivo = this.files[0];
  if (!arquivo) return;

  const leitor = new FileReader();
  leitor.onload = function () {
    const linhas = leitor.result.trim().split('\n');
    dados = linhas.map(l => JSON.parse(l));
    localStorage.setItem("dadosPesquisa", JSON.stringify(dados));
    exibirEstatisticas();
  };
  leitor.readAsText(arquivo);
});

function exibirEstatisticas() {
  if (dados.length === 0) {
    document.getElementById('status').innerHTML = "<div class='alert alert-warning'>Nenhum dado registrado.</div>";
    return;
  }

  let total = dados.length;
  let somaIdade = 0;
  let maisVelha = -Infinity;
  let maisNova = Infinity;
  let pessimos = 0;
  let otimosEBons = 0;
  let contagemSexo = { masculino: 0, feminino: 0, outros: 0 };

  dados.forEach(p => {
    somaIdade += p.idade;
    if (p.idade > maisVelha) maisVelha = p.idade;
    if (p.idade < maisNova) maisNova = p.idade;
    if (p.opiniao === 1) pessimos++;
    if (p.opiniao >= 3) otimosEBons++;
    contagemSexo[p.sexo]++;
  });

  let media = somaIdade / total;
  let porcentagem = (otimosEBons / total) * 100;

  document.getElementById('status').innerHTML = `
    <div class="alert alert-info">
      <strong>Total de respostas:</strong> ${total}<br>
      <strong>Média de idade:</strong> ${media.toFixed(2)}<br>
      <strong>Mais velho(a):</strong> ${maisVelha}<br>
      <strong>Mais novo(a):</strong> ${maisNova}<br>
      <strong>Qtd. de "Péssimo":</strong> ${pessimos}<br>
      <strong>% Ótimo/Bom:</strong> ${porcentagem.toFixed(2)}%<br>
      <strong>Homens:</strong> ${contagemSexo.masculino} |
      <strong>Mulheres:</strong> ${contagemSexo.feminino} |
      <strong>Outros:</strong> ${contagemSexo.outros}
    </div>
  `;
}

exibirEstatisticas();
