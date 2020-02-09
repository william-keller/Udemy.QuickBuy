using System;
using System.Collections.Generic;
using System.Linq;

namespace Udemy.QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<String> _mensagemValidacao { get; set; }
        public List<String> mensagemValidacao
        {
            get { return _mensagemValidacao ?? new List<string>(); }
        }
        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void Validade();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

    }
}
