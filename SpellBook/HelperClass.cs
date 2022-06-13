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
             
            int cislo = generator.Next(0, poleForma.Length-1);
            int cislo1 = generator.Next(0, poleTypy.Length - 1);
            
            
        }
        public int VYgenerujCislo(int max)
        {
            
        }
       
    }
}
