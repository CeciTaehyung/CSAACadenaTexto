using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAACadenaDeTexto
{
    public class ManipuladorDeCadenas
    {
        public string ConvertirAMayusculas(string input)
        {
            return input?.ToUpper();
        }


        public string EliminarEspacios(string input)
        {
            return input?.Replace(" ", "");
        }
    }
}
