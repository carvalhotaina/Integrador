using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Estoque
    {
        private String codigo_p, volume_liq, peso_liq;
        private int codigo_interno, quantidade;
        private float valor_venda, valor_compra;
        private DateTime data_entrada;

        public string Codigo_p { get => codigo_p; set => codigo_p = value; }
        public string Volume_liq { get => volume_liq; set => volume_liq = value; }
        public string Peso_liq { get => peso_liq; set => peso_liq = value; }
        public int Codigo_interno { get => codigo_interno; set => codigo_interno = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public float Valor_venda { get => valor_venda; set => valor_venda = value; }
        public float Valor_compra { get => valor_compra; set => valor_compra = value; }
        public DateTime Data_entrada { get; set; }

        public Estoque(string codigo_p, string volume_liq, string Peso_liq, int codigo_interno, int quantidade, float valor_venda, float valor_compra, DateTime data_entrada)
        {
            {
                this.codigo_p = codigo_p;
                this.volume_liq = volume_liq;
                this.Peso_liq = Peso_liq;
                this.codigo_interno = codigo_interno;
                this.quantidade = quantidade;
                this.valor_venda = valor_venda;
                this.valor_compra = valor_compra;
                this.data_entrada = data_entrada;


            }
        }
        public Estoque()
        { 
        
        }


    }
}
