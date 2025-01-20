using System;

namespace Utils.MStringUtils
{
    public static class MStringUtils
    {
        public static bool VericaDati(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Length > 3;
        }
        public static string VerificaStringa(string input, char[] escludiChar = null, string elementoCongiunzione = "", string[] parole = null)
        {
            //aggiunge a stringa input stringhe con concatenazione scelta
            if (parole != null && parole.Length > 0)
            {
                input += string.Join(elementoCongiunzione, parole);
            }

            //rimuove elementi richiesti
            if (escludiChar != null)
            {
                foreach (char c in escludiChar)
                {
                    input = input.Replace(c.ToString(), "");
                }
            }
            return input;
        }

    }

  

    }
 
