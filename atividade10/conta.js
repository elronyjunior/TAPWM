class Conta {
  constructor() {
    this._correntista = "";
    this._banco = "";
    this._numeroConta = "";
    this._saldo = 0;
  }

  get correntista() {
    return this._correntista;
  }
  set correntista(valor) {
    this._correntista = valor;
  }

  get banco() {
    return this._banco;
  }
  set banco(valor) {
    this._banco = valor;
  }

  get numeroConta() {
    return this._numeroConta;
  }
  set numeroConta(valor) {
    this._numeroConta = valor;
  }

  get saldo() {
    return this._saldo;
  }
  set saldo(valor) {
    this._saldo = valor;
  }

  exibirDados() {
    return `Correntista: ${this.correntista}<br>Banco: ${this.banco}<br>Nº Conta: ${this.numeroConta}<br>Saldo: R$ ${this.saldo}`;
  }
}

class Corrente extends Conta {
  constructor() {
    super();
    this._saldoEspecial = 0;
  }

  get saldoEspecial() {
    return this._saldoEspecial;
  }
  set saldoEspecial(valor) {
    this._saldoEspecial = valor;
  }

  exibirDados() {
    return super.exibirDados() + `<br>Saldo Especial: R$ ${this.saldoEspecial}`;
  }
}

class Poupanca extends Conta {
  constructor() {
    super();
    this._juros = 0;
    this._dataVencimento = "";
  }

  get juros() {
    return this._juros;
  }
  set juros(valor) {
    this._juros = valor;
  }

  get dataVencimento() {
    return this._dataVencimento;
  }
  set dataVencimento(valor) {
    this._dataVencimento = valor;
  }

  exibirDados() {
    return super.exibirDados() + `<br>Juros: ${this.juros}%<br>Vencimento: ${this.dataVencimento}`;
  }
}
