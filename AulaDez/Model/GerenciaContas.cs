using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDez.Model; 
internal class GerenciaContas {
    public List<Conta> Contas { get; set; } = new List<Conta>();
    public List<LancamentoConta> LancamentoContas { get; set; } = new List<LancamentoConta>();
    public void AdicionaConta () {
        // mock
        Contas.Add(new Conta(1212,"Ranieri",0)!);
        Console.WriteLine("Conta Adicionada");
        Contas.ToString();
    }
    public void ListarContas () {
        Console.Clear();
        Console.WriteLine("Lista de contas");
        Contas.ForEach(c => Console.WriteLine(c.NumeroConta));
        Console.Write("\n Pressione qualquer tecla para continuar.");
        Console.Read();
    }
    public void LancarCredito() {
        try {
            // mock
            LancamentoContas.Add(new LancamentoConta(Contas[0], 'C', 8.2, Contas[0].SaldoConta)!);
            //Contas[0].SaldoConta = LancamentoContas[0].SaldoConta;
            Console.WriteLine($"Creditado R$ 8.2 com sucesso na conta {Contas[0].NumeroConta} e o saldo é de {Contas[0].SaldoConta}");
        } catch (ArgumentOutOfRangeException e) {
            Console.WriteLine($"Entre com uma conta válida: {e}");
        }
        
        Console.Write("\n Pressione qualquer tecla para continuar.");
        Console.Read();

    }

    internal void LancarDebito() {
        Console.Clear();
        try {
            // mock
            LancamentoContas.Add(new LancamentoConta(Contas[0], 'D', 6.5, Contas[0].SaldoConta)!);
            //Contas[0].SaldoConta = LancamentoContas[0].SaldoConta;
            Console.WriteLine($"Debitado R$ 6.5 com sucesso na conta {Contas[0].NumeroConta} e o saldo é de {Contas[0].SaldoConta}");
        } catch (ArgumentOutOfRangeException e) {
            Console.WriteLine($"Entre com uma conta válida: {e}");
        }

        Console.Write("\n Pressione qualquer tecla para continuar.");
        Console.Read();
    }

    internal void ExtratoConta() {
        Console.Clear();
        // mock
        Conta conta = Contas[0];
        Console.WriteLine($"Extrato conta {conta.NumeroConta} | saldo {conta.SaldoConta}");
        LancamentoContas.ForEach(l => Console.WriteLine($"Tipo: {l.TipoLancamento} | Valor: {l.Valor}"));
        Console.Read();

    }
}