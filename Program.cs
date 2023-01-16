namespace H1GPDag1
{//                 (PascalCasing)
    internal class Program
    {
        //Field (camelCasing)
        private int songId = 10;
        //              Parameters
        //        MethodName
        //   ReturnType
        //Modifier          (PascalCasing)
        internal static void Main(string[] args)
        {
            //Namespace.Class.Methodname(Parameter);
            System.Console.WriteLine("Its... ALIVE!!!");
            //local variable
            string song2 = "den den den da da den den den Wohooo!";
            //bool knowsIt = PlayMusic(song2);

            Console.Write("Height in cm? ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight in kg? ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"BMI :{CalculateBmi(height, weight)}"); 

        }

        /// <summary>
        /// Method plays a song
        /// </summary>
        /// <param name="song"></param>
        static bool PlayMusic(string song)
        {
            Console.WriteLine(song);
            Console.WriteLine("You know this song?");
            ConsoleKeyInfo v = Console.ReadKey();
            if (v.KeyChar == 'y') return true;
            else return false;
        }

        static float CalculateBmi(int height, int weight)
        {
            return weight / (height/100f * height/100);
        }
    }
}