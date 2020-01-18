using System;
using ExerEnumeraçaoComposicao.Entidades.Enumeraçao;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExerEnumeraçaoComposicao.Entidades {
    class Ordem 
    {
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Ordem()
        {
        }

        public Ordem(DateTime momento, OrderStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItems(OrdemItem item)
        {
            Items.Add(item);
        }

        public void RemoveItems(OrdemItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (OrdemItem item in Items)
            {
                soma += item.SubTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento da ordem: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Ordem dos status: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Ordem dos items");
            foreach(OrdemItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total preço: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
