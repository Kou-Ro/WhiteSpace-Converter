namespace WhiteSpaceConverter
{
   class Program
   {
      public static void Main(string[] args)
      {
         if (args.Length<2)
         {
            Console.Error.WriteLine("Pleas enter arguments.\nwsc <InptFile> <OutputFile>");
            return;
         }

         string origin = "";
         try
         {
            origin = File.ReadAllText(args[0]);
         }
         catch (Exception e)
         {
             Console.Error.WriteLine("inp");
            Console.Error.WriteLine(e.Message);
         }

         string newcode = "";

         foreach (char o in origin)
         {
            if (o == 'T' || o == 't' ||o=='\t') newcode += '\t';
            else if (o == 'S' || o == 's'||o==' ') newcode += ' ';
            else if (o == '\n') newcode += "\n";
            else
            {
               Console.Error.WriteLine($"Can't use the character '{o}'.You can use only 'T' or 'S' or return code.");
               return;
            }
         }


         try
         {
            File.WriteAllText(args[1],newcode);
         }
         catch (Exception e)
         {
            Console.Error.WriteLine("out");
            Console.Error.WriteLine(e.Message);
         }

      }
   }
}