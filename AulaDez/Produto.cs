using System.Globalization;

namespace Course {
    class Produto {

        
        private string _nome;
        //private double _preco;
       // private int _quantidade;        

        public string Nome {
            get { return _nome; }
            set {
                if (Nome != null || Nome.Length > 1) {
                    Nome = value;
                }
                else {
                    Console.WriteLine("Não foi posível alterar o nome.");
                }
            }
        }

        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {
            this.Quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            this.Quantidade = quantidade;
        }
        public Produto (string nome, double preco) : this() {
            this._nome = nome;
            this.Preco = preco;
        }
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}