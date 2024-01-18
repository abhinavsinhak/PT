using System;
using System.Text;

class StringBuilderExample
{
    static void Main()
    {
       
        StringBuilder sb = new StringBuilder("Initial string.");

        sb.Append(" Adding more text.");
        sb.AppendLine(" Adding a line with a newline at the end.");

        sb.Insert(0, "Start: ");

        sb.Replace("Initial", "Modified");

     
        sb.Remove(0, "Start: ".Length);

        
        Console.WriteLine("Length of StringBuilder: " + sb.Length);

        
        string result = sb.ToString();

        
        Console.WriteLine("Final string: " + result);
    }
}