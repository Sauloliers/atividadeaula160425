using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula160425
{
     abstract class Item
    {
        private string nome;
        private int codigo;
        private DateTime aquisicao;


        public string GetNome() {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public int GetCodigo()
        {
            return codigo;
        }
        public void SetCodigo(int cod)
        {
            this.codigo = cod;
        }
        public DateTime GetAquisicao()
        {
            return aquisicao;
        }
        public void SetAquisicao(string data)
        {
            if (DateTime.TryParseExact(data, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataConvertida))
            {
                DateTime dataSemHora = new DateTime(dataConvertida.Year, dataConvertida.Month, dataConvertida.Day);

                if (dataConvertida > DateTime.Now)
                {
                    Console.WriteLine("Data não pode ser futura. Usando data atual.");
                    aquisicao = DateTime.Today;
                }
                else
                {
                    aquisicao = dataSemHora;
                }
            }
            else
            {
                Console.WriteLine("Formato inválido. Usando data atual.");
                aquisicao = DateTime.Today;
            }
        }
    }
}
