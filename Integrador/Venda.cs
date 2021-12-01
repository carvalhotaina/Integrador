using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Venda
    {
        
        private int id_venda, estoque_codigo_interno , cliente_id;
        private DateTime data_venda;
        private decimal valor;


    =
        public int Id_venda { get => id_venda; set => id_venda = value; }
        public int Estoque_codigo_interno { get => estoque_codigo_interno; set => estoque_codigo_interno = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }

        public decimal Valor { get => valor; set => valor = value; } 

        public DateTime Data_venda { get => data_venda; set => data_venda = value; }

    public Venda(string nome, string endereco, string cep, int id_venda, decimal valor, int estoque_codigo_interno , DateTime data_venda)
        {
            {
                this.id_venda = id_venda;
                this.estoque_codigo_interno = estoque_codigo_interno;
                this.valor = valor;
                this.data_venda = data_venda;

            }
        }
    }
}
