using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Telefone
    {
        private String numero;
        private int cliente_id;


        public string Numero { get => numero; set => numero = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }

        public Telefone (string numero, int cliente_id)
        {
            {
                this.cliente_id = cliente_id;
                this.numero = numero;
            }
        }
    }
}
