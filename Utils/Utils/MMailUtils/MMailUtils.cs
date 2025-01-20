using System;
using System.Text.RegularExpressions;
namespace Utils.MMailUtils
{
    public static class MMailUtils
    {
       

        public static bool VerificaDati(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Length > 3;
        }

        public static bool EValidaEmail(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Espressione regolare per validare esattamente un indirizzo email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Controlla se la stringa è ESATTAMENTE un'email valida
            return Regex.IsMatch(input, pattern);
        }
   
}
}
       
	
	

