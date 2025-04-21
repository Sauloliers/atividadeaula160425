using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula160425
{
    internal class Livro: Publicacao
    {
        private long INBS;
        public long GetINBS()
        {
            return INBS;
        }
        public void SetINBS(long inbs)
        {
            INBS = inbs;
        }

    }
}
