using System.Collections.Generic;

namespace Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public static List<Produto> Produtos = new List<Produto>();

        public Produto(
            string Nome,
            double Preco
        ) {
            this.Id = GetNextId();
            this.Nome = Nome;
            this.Preco = Preco;

            Produtos.Add(this);
        }

        public int GetNextId() {
            return Produtos.Count > 0 ? Produtos.Max(it => it.Id) + 1 : 1;
        }


    }
}