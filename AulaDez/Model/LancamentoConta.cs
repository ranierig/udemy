using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDez.Model; 
internal class LancamentoConta {
    public Conta Conta { get; private set; }
    public char TipoLancamento { get; private set; }
    public double Valor { get; private set; }
    public double SaldoConta { get; private set; }
    public LancamentoConta (Conta conta, char tipoLancamento, double valor, double saldoConta) {
        Conta = conta;
        TipoLancamento = tipoLancamento;
        Valor = valor;
        saldoConta = conta.AtualizaSaldo(tipoLancamento,saldoConta,valor);

    }

}
