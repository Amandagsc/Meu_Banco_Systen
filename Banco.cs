using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Banco_Systen
{
    public class Banco
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public Conta conta { get; set; }
        public string Agencia { get; set; }


        public Banco()
        {
            conta = new Conta();
        }

    }
}
