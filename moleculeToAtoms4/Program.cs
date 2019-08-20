using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace moleculeToAtoms4
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/molecule-to-atoms/train/csharp

            //Alright so my issue now is that I'm three loops deep, and no one really wants to be three loops deep
            //I think the distribution will be easier if I actually remove the parentheses first, and then I can work on the square brackets afterwards
            //Turns out I have curly brackets to deal with as well

            //But I still think first its parentheses, then its square brackets, and then curly
            //I think the parentheses will be around every 2nd thing, or 1st in computing terms when counting zero



            //H2O
            //"Mg(OH)2"
            //"K4[ON(SO3)2]2"

            string molecule = "HO[ON(SO3)2]2";




            string[] moleculeSplit = molecule.Split('(', ')');

            foreach (object atom in moleculeSplit)
            {
                Console.WriteLine(atom);
            }





            Console.ReadLine();
        }









        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            return null;
        }
    }
}
