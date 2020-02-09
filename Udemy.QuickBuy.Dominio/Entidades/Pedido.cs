using System;
using System.Collections.Generic;
using Udemy.QuickBuy.Dominio.ObjetoDeValor;

namespace Udemy.QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroCompleto { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }


        public ICollection<ItemPedido> Itens { get; set; }
    }
}
