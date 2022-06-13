using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellBook
{
    internal class HelperClass
    {
        public Random generator = new Random();
        public string[] PoleZTextu(string adresaSouboru)
        {
            string obsahTxt = File.ReadAllText(adresaSouboru);
            return obsahTxt.Split(';');
        }
        public string VygenerujSpellname(string[] poleForma, string[] poleTypy)
        {

        }
        public int VYgenerujCislo(int max)
        {
            
        }
       
    }
}
