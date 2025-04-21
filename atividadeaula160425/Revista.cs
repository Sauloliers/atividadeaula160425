using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula160425
{
    internal class Revista:Publicacao
    {
        private string volume;
        private string principaisAssuntos;
        public string GetVolume()
        {
            return volume;
        }
        public void SetVolume(string vol)
        {
            volume = vol;
        }
        public string GetPrincipaisAssuntos()
        {
            return principaisAssuntos;
        }
        public void SetPrincipaisAssuntos(string principaisassuntos)
        {
            principaisAssuntos = principaisassuntos;
        }
    }
}
