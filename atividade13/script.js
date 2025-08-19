  function converterTexto() {
      const entrada = document.getElementById('entrada').value;
      const saida = document.getElementById('saida');
      const opcao = document.querySelector('input[name="opcao"]:checked');

      if (!opcao) {
        alert('Selecione uma opção!');
        return;
      }

      saida.textContent = opcao.value === 'upper' ? entrada.toUpperCase() : entrada.toLowerCase();
    }