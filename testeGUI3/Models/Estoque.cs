using System.Collections.Generic;

namespace Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Estoque> Estoques = new List<Estoque>();

        public Estoque(
            string Nome
        ) {
            this.Id = GetNextId();
            this.Nome = Nome;

            Estoques.Add(this);
        }

        public int GetNextId() {
            return Estoques.Count > 0 ? Estoques.Max(it => it.Id) + 1 : 1;
        }


    }
}