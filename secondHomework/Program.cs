using System;
using System.Text.RegularExpressions;

namespace secondHomework
{
    class Program

        
    {
        static void RemoveExtraSpace()
        {

            

            string text = "The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";

            text = Regex.Replace(text, @"\s+", " ");
            

            Console.WriteLine(text);

            Console.ReadLine();


        }
        static void Main(string[] args)
        {
           

            RemoveExtraSpace();
            Console.ReadLine();
        }
    }
}
