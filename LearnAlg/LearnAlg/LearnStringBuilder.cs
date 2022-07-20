using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg
{
    public class LearnStringBuilder
    {
        // A String is immutable, meaning #String cannot be changed once created. And each append causes a string copy. With #StringBuilder we eliminate this copy....  
        // StringBuilder" is a class in C# which means it has properties and methods
        // StringBuilder uses the System.Text namespace
        // We use Stringbuilder to change strings
        // StringBuilder is more efficient in terms of memory than using String methods

        public static string StringBuilderExample()
        {
            StringBuilder newString = new StringBuilder();

            // Methods
            newString.Append('-', 6);
            newString.Append(" Here is the title! ");
            newString.Append('-', 6);

            newString.AppendLine();

            newString.Append("And here is a paragraph");

            newString.Replace("And here is a paragraph", "Whops!");

            newString.Remove(0, 30);
            newString.Insert(0, "My name is Dennis");
            newString.AppendFormat("{0:C}", 100);


            StringBuilder anotherString = new StringBuilder();
            anotherString.Append('-', 6).Append(" Here is the title! ").Append('-', 6);
            return newString.ToString();
        }
    }
}
