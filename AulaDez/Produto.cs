using System.Globalization;

namespace Course {
    class Produto {

        
        private string _nome;
        private double _preco;
        private int _quantidade;        

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

        public double Preco { get { return _preco; } }
        public int Quantidade { get { return _quantidade; } }

        public Produto() {
            this._quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            this._quantidade = quantidade;
        }
        public Produto (string nome, double preco) : this() {
            this._nome = nome;
            this._preco = preco;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}