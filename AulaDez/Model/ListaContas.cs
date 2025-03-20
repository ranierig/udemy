using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDez.Model; 
internal class ListaContas {
    public List<Conta> Contas { get; set; }
    public void AdicionaConta () {
        Contas.Add(new Conta(12,"Ranieri",0)!);
        Console.WriteLine("Conta Adicionada");
        Contas.ToString();
    }

}
