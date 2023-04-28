using System.Collections.Generic;

namespace Models
{
    public class Saldo
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int EstoqueId { get; set; }
        public double Quantidade { get; set; }

        public static List<Saldo> Saldos = new List<Saldo>();

        public Saldo(
            int ProdutoId,
            int EstoqueId,
            double Quantidade
        ) {
            
            this.Id = GetNextId();
            this.ProdutoId = ProdutoId;
            this.EstoqueId = EstoqueId;
            this.Quantidade = Quantidade;

            Saldos.Add(this);
        }

        public int GetNextId() {
            return Saldos.Count > 0 ? Saldos.Max(it => it.Id) + 1 : 1;
        }


    }
}