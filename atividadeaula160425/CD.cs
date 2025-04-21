using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula160425
{
    internal class CD: Item
    {
        private String genero;
        private String faixa;
        public string GetGenero()
        {
            return genero;
        }
        public void SetGenero(string gen)
        {
            this.genero = gen;
        }
        public string GetFaixa()
        {
            return faixa;
        }
        public void SetFaixa(string fx)
        {
            this.faixa = fx;
        }

    }
}
