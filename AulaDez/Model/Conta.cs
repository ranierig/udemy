using System;
using System.Collections.Generic;
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
    
}
