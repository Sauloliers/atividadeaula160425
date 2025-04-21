using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula160425
{
    abstract class Publicacao: Item
    {
        private string autores;
        private string editora;
        private string anoPublicacao;

        public string GetAutores()
        {
            return autores;
        }
        public void SetAutores(string aut)
        {
            autores = aut;
        }
        public string GetEditora()
        {
            return editora;
        }
        public void SetEditora(string edi)
        {
            editora = edi;
        }
        public string GetAnoPublicacao()
        {
            return anoPublicacao;
        }
        public void SetAnoPublicacao(string anopublicacao)
        {
            anoPublicacao = anopublicacao;
        }
    }
}
