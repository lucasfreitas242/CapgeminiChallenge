using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Questao3
{
    public class Encriptador
    {
        string texto = "tenha um bom dia";

        public string TextoSemEspacos()
        {
            string textoSemEspaco = Regex.Replace(texto, @"\s", "");

            return textoSemEspaco;
        }
    }
}
