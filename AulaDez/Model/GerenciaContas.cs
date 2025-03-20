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
        // mock
        LancamentoContas.Add(new LancamentoConta(Contas[1], 'C', 8.2, 0));
        Console.Write("\n Pressione qualquer tecla para continuar.");
        Console.Read();

    }
}