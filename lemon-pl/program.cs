using system;
using lemon_pl.lemon-pl.Parser;

namespace lemon_pl.lemon-pl
{
    class Program
    {
        static void Main (string[] args)
        {
            //Test:

            /*Lexer l = new Lexer(args[0]);
            while (!l.EndOfFile())
            {
                var t = l.GetToken();
                Console.WriteLine(t.Content+"   :"+t.Type.ToString());
            }*/

            Parser.Parser pars = new Parser.Parser();
            Node n = pars.GetNode(args[0]);
    }
}