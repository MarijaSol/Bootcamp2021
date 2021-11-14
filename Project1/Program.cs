using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

            int leftBrackets = 0;
            int leftBraces = 0;
            int leftParentheses = 0;

            int rightBrackets = 0;
            int rightBraces = 0;
            int rightParentheses = 0;

            Console.WriteLine("Please, enter the text");
            var text = Console.ReadLine();
            foreach (char ch in text)
            {
                if (ch == '{')
                {   leftBraces++;
                    foreach (char brackets in text)
                    {
                        if (brackets == '}')
                            leftBrackets++;
                        else if (brackets == '(')
                            leftParentheses++;
                        else if (brackets == '}')
                            rightBraces++;
                        else if (brackets == ']')
                            rightBrackets++;
                        else if (brackets == ')')
                            rightParentheses++;
                    }
                    if ((leftBraces == rightBraces) &&
                        ((leftBrackets == rightBrackets) &&
                        (leftParentheses == rightParentheses)))
                        Console.WriteLine("Brackets are correct");
                    
                }
                else
                    Console.WriteLine("Brackets are not correct");
            }

            //if (leftBraces == rightBraces &&
            //    leftBrackets == rightBrackets &&
            //    leftParentheses == rightParentheses)
            //    Console.WriteLine("Brackets are correct");
            //else
            //    Console.WriteLine("Brackets are not correct");

            //foreach (char brackets in text)
            //{
            //    if (brackets == '[')
            //        leftBrackets++;
            //    else if (brackets == '(')
            //        leftParentheses++;
            //    else if (brackets == '}')
            //        rightBraces++;
            //    else if (brackets == ']')
            //        rightBrackets++;
            //    else if (brackets == ')')
            //        rightParentheses++;


            }
    }
}
