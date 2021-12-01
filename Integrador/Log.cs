using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Log
    {
        private String descricao;
        private int id;
        private DateTime data;


        public string Descricao { get => descricao ; set => descricao = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Id { get => id; set => id = value; }

        public Log(string descricao, DateTime data, int id)
        {
            {
                this.id = id;
                this.descricao = descricao;
                this.data = data;   

            }
        }
    }
}
