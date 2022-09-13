using System.Text;

namespace ConsoleAppGroup1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.Clear();

                Console.WriteLine("---- Menu ----\n1: ArrayEx\n2: ListEx\n3: DictionaryEx\n4: \n5: StringBuilder \n6: SpeedTest\n7: ExceptionsEx\n8: RandomEx\n0: Exit\n\nPress number to run Example.\n\n");
                char selection = Console.ReadKey(true).KeyChar;
                switch (selection)
                {
                    case '1':
                        ArrayEx();
                        break;

                    case '2':
                        ListEx();
                        break;

                    case '3':
                        DictionaryEx();
                        break;

                    case '4':
                        int startNumber = 13;
                        int result = PrimitivVarible(startNumber);
                        Console.WriteLine($"start number = {startNumber}\nresult number = {result}");
                        break;

                    case '5':

                        StringBuilder stringBuilder = new StringBuilder();
                        // the word hello

                        break;

                    case '6':
                        SpeedTest();
                        break;

                    case '7':
                        ExceptionsEx();
                        break;

                    case '8':
                        RandomEx();
                        break;

                    case '0':
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            } while (loop);

        }// End of Main
        private static void RandomEx()
        {
            Random random = new Random(1);//seed number tells the random what table of random numbers to use
            //Random random = new Random();//uses the computer clock to get as a seed number
            //Random random = new Random(DateTime.Now.Ticks);//same as new Random()

            int randomNumber = random.Next();

            Console.WriteLine("Random Number was: " + randomNumber); //0 to 2.1B


            Console.WriteLine("0 to 10");
            for (int i = 0; i < 10; i++)
            {
                // 0-10 max
            }

            Console.WriteLine("1 to 10");
            for (int i = 0; i < 10; i++)
            {
                //min and max 1-10
            }
        }

        private static void ExceptionsEx()
        {
            bool notNumber = true;

            while (notNumber)
            {
                

                try
                {
                   //this line of code will not run if Convert above has a exception
                }
                catch (FormatException)
                {
                    
                }
                catch (OverflowException)
                {
                   
                }
                finally//will always run this part
                {

                }
            }
            Console.WriteLine("after loop");

        }

        private static void SpeedTest()
        {
            string starsString = "";
            DateTime stringStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                starsString += "*";
            }

            DateTime stringEnd = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            DateTime sbStart = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("*");
            }

            DateTime sbEnd = DateTime.Now;

            Console.WriteLine($"string time: {stringEnd - stringStart}");
            Console.WriteLine($"StringBuilder time: {sbEnd - sbStart}");
        }

        private static void AddWorld(StringBuilder stringBuilder)//ref to original varible
        {
            stringBuilder.Append("world!");
        }

        static int PrimitivVarible(int numberIn)//int is a copy
        {
            numberIn = numberIn + 12;

            return numberIn;
        }

        static void ListEx()
        {
            List<double> tempeturs = new List<double>();

     
        }


        static void ArrayEx()
        {
            string[] names = new string[5];


            //sort

        }

        static void DictionaryEx()
        {

            //Dictionary<int, string> socialNumberVualt = new Dictionary<int, string>();

            
        }
    }
}