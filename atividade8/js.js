function maior(x, y, z) {
    return Math.max(x, y, z);
}

function crescente(x, y, z) {
    return [x, y, z].sort((a, b) => a - b);
}

function ehPalindromo(str) {
    const limpa = str.toLowerCase().replace(/\s/g, '');
    return limpa === limpa.split('').reverse().join('');
}

function subconjunto(p1, p2) {
    if (!p1 || !p2) return "erro";
    return p1.includes(p2) ? "é um subconjunto" : "não é um subconjunto";
}

// Funções com inputs

function executarMaior() {
    const x = parseFloat(document.getElementById("m1").value);
    const y = parseFloat(document.getElementById("m2").value);
    const z = parseFloat(document.getElementById("m3").value);
    alert("Maior: " + maior(x, y, z));
}

function executarCrescente() {
    const x = parseFloat(document.getElementById("c1").value);
    const y = parseFloat(document.getElementById("c2").value);
    const z = parseFloat(document.getElementById("c3").value);
    alert("Ordem crescente: " + crescente(x, y, z).join(", "));
}

function executarPalindromo() {
    const str = document.getElementById("p1").value;
    const resultado = ehPalindromo(str) ? "É um palíndromo!" : "Não é um palíndromo.";
    alert(resultado);
}

function executarSubconjunto() {
    const p1 = document.getElementById("s1").value.toLowerCase();
    const p2 = document.getElementById("s2").value.toLowerCase();
    alert(subconjunto(p1, p2));
}
