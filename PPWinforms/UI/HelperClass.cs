using BackEnd;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI
{
    public static class HelperClass
    {
        public static ADOBackend BackEndIO = new ADOBackend("Data Source=(local)\\SQLEXPRESS;Initial Catalog=PPDBDesireTilleras;Integrated Security=SSPI");
        public static string StringWash(string regnr)
        {

            Regex washIt = new Regex(@"^[\p{L}\p{M}0-9\s]{1,10}$");// p{L}any kind of letter from any language.p{m} = a character intended to be combined with another character (e.g. accents, umlauts, enclosing boxes, etc.).
            regnr = Regex.Replace(regnr, "\\s+", string.Empty).Trim();
            
            if (!washIt.IsMatch(regnr))
            {
                throw new FormatException("Input contains invalid characters.");
                //return null;
            }
            string washed = regnr.ToUpper();
            return washed;
        }
        public static Color ChangeLicensePlateTextBoxBackColor(string licensePlate)
        {
            licensePlate = HelperClass.StringWash(licensePlate);
            Color color;            
            if (licensePlate != null)
            {
                color = Color.LightGreen;
            }
            else
            {
                color = Color.White; //Används aldrig.
            }
            return color;
        }
    }
}
