using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDez.Model; 
internal class Conta {
    public int NumeroConta { get; private set; }
    public string NomePessoa { get; set; }
    public double SaldoConta { get; private set; }
    public Conta(int numeroConta, string nomePessoa, double depositoInicial) {
        NumeroConta = numeroConta;
        NomePessoa = nomePessoa;
        SaldoConta = depositoInicial;
    }
    public double AtualizaSaldo (char tipoLancamento, double saldoConta, double valor) {
        if (char.ToUpper(tipoLancamento) == 'C') {
            SaldoConta = saldoConta + valor;
        } else if (char.ToUpper(tipoLancamento) == 'D') {
            SaldoConta = saldoConta - valor;
        } else {
            SaldoConta = saldoConta;
        }
        return SaldoConta; 
    }
}
