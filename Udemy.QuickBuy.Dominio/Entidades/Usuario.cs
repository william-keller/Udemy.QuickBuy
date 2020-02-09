﻿using System.Collections.Generic;

namespace Udemy.QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            throw new System.NotImplementedException();
        }
    }
}
