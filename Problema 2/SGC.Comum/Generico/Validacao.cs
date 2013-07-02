using System.Text.RegularExpressions;

namespace SGC.Comum
{
    public static class Validacao
    {
        private const string RegEx_DataYYYMMDD = @"^(?:(?:(?:(?:[13579][26]|[2468][048])00)|(?:[0-9]{2}(?:(?:[13579][26])|(?:[2468][048]|0[48]))))(?:(?:(?:09|04|06|11)(?:0[1-9]|1[0-9]|2[0-9]|30))|(?:(?:01|03|05|07|08|10|12)(?:0[1-9]|1[0-9]|2[0-9]|3[01]))|(?:02(?:0[1-9]|1[0-9]|2[0-9]))))|(?:[0-9]{4}(?:(?:(?:09|04|06|11)(?:0[1-9]|1[0-9]|2[0-9]|30))|(?:(?:01|03|05|07|08|10|12)(?:0[1-9]|1[0-9]|2[0-9]|3[01]))|(?:02(?:[01][0-9]|2[0-8]))))$";
        private const string RegEx_Email = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        public static bool DataYYYYMMDDValida(string pData)
        {
            return (new Regex(RegEx_DataYYYMMDD)).IsMatch(pData);
        }

        public static bool EmailValido(string pEmail)
        {
            return (new Regex(RegEx_Email)).IsMatch(pEmail);
        }
    }
}
