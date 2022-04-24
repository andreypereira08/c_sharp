using System;

namespace Banco2
{
    public class Cliente
    {
        public Cliente(string v)
        {
            this.Nome = v;
        }

        //private string v;
        public string Nome { get; set; }

    }
}