
using System.Globalization;

namespace ExerEnumeraçaoComposicao.Entidades {
    class OrdemItem 
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public OrdemItem() 
        { 
        }

        public OrdemItem(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " + Quantidade + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
           
        }
    }
}
