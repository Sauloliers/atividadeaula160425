using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula160425
{
    internal class DVD: Item
    {
        private string descricaoGeral;
        private string tipo;

        public string GetDescricaoGeral()
        {
            return descricaoGeral;
        }
        public void SetDescricaoGeral(string descricaogeral)
        {
            descricaoGeral = descricaogeral;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string t)
        {
            tipo = t;
        }
    }
}
