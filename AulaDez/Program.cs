using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using AulaDez.Model;
namespace Course;

class Program {
    public static void Main(string[] args) {

        GerenciaContas listaContas = new GerenciaContas();
        
        ExibirOpcoesDoMenu("-1");
        void ExibirOpcoesDoMenu(string _itemMenu) {
            Console.Clear();
            while (_itemMenu != "0") {
                Console.WriteLine("1 - Listar contas");
                Console.WriteLine("2 - Criar conta");
                Console.WriteLine("3 - Depósito");
                Console.WriteLine("4 - Saque");
                Console.WriteLine("5 - Extrato conta");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                _itemMenu = Console.ReadLine();
                
                switch (_itemMenu) {
                    case "1": listaContas.ListarContas();
                        break;
                    case "2": listaContas.AdicionaConta();
                        break;
                    case "3":
                        Console.WriteLine("temp");
                        break;
                    case "4":
                        Console.WriteLine("temp");
                        break;
                    case "5":
                        Console.WriteLine("temp");
                        break;
                    default: Console.WriteLine("");
                        break;
                        
                }
                Console.Clear();
            }
        }
    }
}

