﻿using System.Collections.Generic;

namespace Udemy.QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            throw new System.NotImplementedException();
        }
    }
}