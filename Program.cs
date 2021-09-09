using System;

namespace based
{
    class Program
    {
        static void Main(string[] args)
        {
            int convertFrom, convertTo;

            if (args.Length > 2)
            {
                int.TryParse(args[0], out convertFrom);
                int.TryParse(args[1], out convertTo);
                if (convertTo < 2 || convertFrom < 2)
                {
                    Console.WriteLine($"Need to be atleast 2.");
                }
                else
                {
                    string result = converttobase(convertFrom, convertTo, args[2]);
                    if( args[2] == converttobase(convertTo, convertFrom, result))
                    {
                        Console.WriteLine($"{result}");
                    }
                    else
                    {
                        Console.WriteLine("Failed to convert.");
                    }
                }
            }
            else
                Console.WriteLine($" Help{Environment.NewLine}based <from base> <to base> <number>{Environment.NewLine}{Environment.NewLine}Freeware, please enjoy!{Environment.NewLine}");

            Console.WriteLine($"{ConvertFromBase10(21005421333231490, 112)}{ConvertFromBase10(901603589558481303, 112)}{ConvertFromBase10(8574948976, 112)}"); 
        }

        static string converttobase(int from, int to, string number)
        {
            int f = from > text.Length ? text.Length : from, t = to > text.Length ? text.Length : to;

            return ConvertFromBase10(ConvertToBase10(number, f), t);            
        }

        private static ulong ConvertToBase10(string number, int f)
        {
            ulong result = 0;
            int temp = 0;
            for (int pos = 0; pos < number.Length; pos++)
            {
                temp = text.IndexOf(number[pos]);
                if (temp > f) return 0; // Failed!!!
                result = (result * (ulong)f) + (ulong)temp;
            }
            return result;
        }

        private static string ConvertFromBase10(ulong number, int t)
        {
            string retval = "";
            ulong v = number;
            while (v > 0)
            {
                int part = ((ulong)v < (ulong)t) ? (int) v : (int) (v % (ulong)t);
                v /= (ulong)t;
                retval = text[part] + retval;
            }
            return retval;
        }
        static readonly string text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_#@!$¤£§½ÅåÄäÖöåÿïîñõüÜíìÎÔô¢£¥¦¨©ª«¬­®¯°±²³+-=*/ .,:\\";
    }
}
