function abrirCurso(select) {
      const curso = select.value;
      if (curso === "") return; // se não escolheu nada, não faz nada

      const confirmar = confirm(`Deseja realmente abrir informações sobre o curso ${curso}?`);
      if (confirmar) {
        let url = "";

        switch (curso) {
          case "ADS":
            url = "https://fatecsorocaba.cps.sp.gov.br/cursos-fatec/desenvolvimento-de-sistemas-ams/";
            break;
          case "Logística":
            url = "https://fatecsorocaba.cps.sp.gov.br/cursos-fatec/logistica-ams/";
            break;
          case "Eletrônica":
            url = "https://fatecsorocaba.cps.sp.gov.br/cursos-fatec/eletronica-automotiva/";
            break;
          case "Gestão":
            url = "https://fatecsorocaba.cps.sp.gov.br/cursos-fatec/sistemas-biomedicos/";
            break;
          default:
            alert("Link não disponível.");
            return;
        }

        // Abre o link em uma nova aba
        window.open(url, "_blank");
      }
    }