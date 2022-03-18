//1 - Opening a file that does not exist

static void Main(string[] args)
        {
            string path = @"C:\xampp\MyTest.txt";
            try
            {
                File.ReadAllText(path);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("ERRORE: File non trovato: {0}", ex.Message);
                Console.WriteLine("ERRORE: File non trovato: {0}", ex.ToString());
            }
            Console.ReadLine();
        }
        
// 2 - Read a null element from a list 

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            try
            {
                for(int i = 0; i<4; i++)
                {
                    Console.WriteLine("Elemento: {0}", list.ElementAt(i));
                }
     
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ERRORE: Elemento non trovato: {0}", ex.Message);
                Console.WriteLine("ERRORE: Elemento non trovato: {0}", ex.ToString());
                
            }
            Console.ReadLine();
        }

// 4 - Wrong explicit conversion

        static void Main(string[] args)
        {

            bool flag = true; 
            try
            {
                char ch = Convert.ToChar(flag);
                Console.WriteLine("Conversione eseguita");

     
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine("ERRORE: " + ex.Message);
                Console.WriteLine("ERRORE: " + ex.ToString());
                
            }
            Console.ReadLine();
        }
        
// 7 - Custom Execption

    internal class MyCustomException : Exception   // Desfining my custom exception --> using it into Main
    {
        public MyCustomException()
        {

        }
        public MyCustomException(string message) : base(message)
        {

        }
        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }

        static void Main(string[] args)
        {

        List<string> Students = new List<string> { "Anna", "Paolo", "Matteo", "Benedetta" };

            string name = "Alessio";

            try
            {
                if (!Students.Contains(name))
                    throw new MyCustomException();

            }
            catch(MyCustomException ex)
            {
                Console.WriteLine("ERRORE: Name not found: {0}", ex.Message);
                Console.WriteLine("ERRORE: Name not found: {0}", ex.ToString());
            }

            Console.ReadLine();
            
