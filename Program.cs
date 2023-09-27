namespace fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DATA TYPES
            char silabi = 'A';  // char accepts a single character or letter
            string jina = "Kelly"; // string takes a word or sentence it accepts multiple charcter. 
            int nambari = 99;  //int takes whole number and also -(negative) numbers
            double dot = 2.444; //double takes a floating value. Most commonly used when working with floating values.
            float doti = 3.55F; //it also takes a floating value. It has a (F) prefix
            decimal deci = 3.55566m; //it also takes a floating value. It has a (M) prefix.
            bool nice = true; //boolean takes either true or false
            Console.WriteLine($"Our char is {silabi} \n and our \" string is {jina}");

          /*<-----WORKING WITH STRINGS---->*/

            string sentensi = "Hallo, Ich heiBe Kelly";
            Console.WriteLine(sentensi.Length);
            Console.WriteLine(sentensi.ToUpper());
            Console.WriteLine(sentensi.Contains("heiBe"));
            Console.WriteLine(sentensi[11]); //Find a letter at a specified index
            Console.WriteLine(sentensi.IndexOf("heiBe")); //Finds the index at which a character or word begins
            Console.WriteLine(sentensi.Substring(8,4)); // Used to print out part of a string by specifying the starting index and how many characters you want to print out.
            
            /*<--------NUMBERS IN C#------>*/

            Console.WriteLine(40);
            Console.WriteLine(4 * 4);
            Console.WriteLine(7 % 2); //Modulus operator returns the remainder after division.
            Console.WriteLine(7 / 2); //A division operation that returns a whole number

            int nummer = 20;
           // nummer++;    //increment operator
            Console.WriteLine(nummer);
            Console.WriteLine(Math.Pow(nummer,3));


            /*<-------GETTING USER INPUT--------->*/

            Console.Write("Enter your name: ");
            string heiBe = Console.ReadLine();
            Console.Write("Enter your age: ");
            int alter =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Confirm that your name is {heiBe} and you are {alter}  years old.");

            //SIMPLE CALCULATOR
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            var sum = num1 + num2;

            Console.WriteLine(sum);

            //MAD LIB APPLICATION
            string continent, capitalCity, population;
            Console.Write("Enter continent: ");
            continent = Console.ReadLine();

            Console.Write("Enter the capital city: ");
            capitalCity = Console.ReadLine();

            Console.Write("Enter population: ");
            population =Console.ReadLine();
            Console.WriteLine($"Kenya is a country in {continent} its capital city is {capitalCity} and it has a population of approximately {population} people");



            /*<------ARRAYS IN C#------->*/
            int[] namba = new int[] { 1, 2, 3, 4, 5 };
            foreach(int nm in namba)
            {
                Console.WriteLine(nm);
            }
        
        
        }
    }
}