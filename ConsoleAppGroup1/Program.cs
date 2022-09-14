using System.Runtime.CompilerServices;
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

                Console.WriteLine("---- Menu ----\n" +
                    "1: ArrayEx\n" +
                    "2: ListEx\n" +
                    "3: DictionaryEx\n" +
                    "4: foo\n" +
                    "5: StringBuilder \n" +
                    "6: SpeedTest\n" +
                    "7: ExceptionsEx\n" +
                    "8: RandomEx\n" +
                    "0: Exit\n\n" +
                    "Press number to run Example.\n\n");
                char selection = Console.ReadKey(true).KeyChar;
                switch (selection)
                {
                    case '1':
                        Console.Clear();
                        ArrayEx();
                        break;

                    case '2':
                        Console.Clear();
                        ListEx();
                        break;

                    case '3':
                        Console.Clear();
                        DictionaryEx();
                        break;

                    case '4':
                        Console.Clear();
                        int startNumber = 13;
                        int result = PrimitivVarible(startNumber);
                        Console.WriteLine($"start number = {startNumber}\n" +
                            $"result number = {result}");
                        break;

                    case '5':
                        Console.Clear();
                        StringBuilder stringBuilder = new StringBuilder();
                        AddWorld(stringBuilder);

                        break;

                    case '6':
                        Console.Clear();
                        SpeedTest();
                        break;

                    case '7':
                        Console.Clear();
                        ExceptionsEx();
                        break;

                    case '8':
                        Console.Clear();
                        RandomEx();
                        break;

                    case '0':
                        Console.Clear();
                        loop = false;
                        break;

                    default:
                        Console.Clear();
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
            int[] ar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ar[i] = random.Next(10);
            }
            Console.WriteLine(ar.Max());

            Console.WriteLine("1 to 10");
            int[] ar2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ar2[i] = random.Next(1, 10);
                //min and max 1-10
            }
            Console.WriteLine("Max: " + ar2.Max());
            Console.WriteLine("Min: " + ar2.Min());
        }

        private static void ExceptionsEx()
        {
            bool notNumber = true;

            while (notNumber)
            {
                try
                {
                    //this line of code will not run if Convert above has a exception
                    Console.WriteLine("Press 1 to throw the format Exception.");
                    Console.WriteLine("Press 2 to throw the overflow Exception.");

                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            throw new FormatException("This is the format-exception.");
                            break;

                        case "2":
                            throw new OverflowException("This is the overflow-exception.");
                            break;

                        default:
                            throw new Exception("This is the default exception.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally //will always run this part
                {
                    notNumber = false;
                    Console.WriteLine("FINALLY.");
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
            stringBuilder.Insert(0, "hello ");
            stringBuilder.Append("world!");

            Console.WriteLine(stringBuilder.ToString());
        }

        static int PrimitivVarible(int numberIn)//int is a copy
        {
            //numberIn = numberIn + 12;
            //numberIn += 12; // Simplified.

            return numberIn + 12; // even more simplified.
        }

        static void ListEx()
        {
            List<double> temperatures = new List<double>() {
                12.5,
                20.2,
                33.3
            };

            Console.WriteLine("Average: " + temperatures.Average());
            Console.WriteLine("Maximum: " + temperatures.Max());
            Console.WriteLine("Minimum: " + temperatures.Min());
        }


        static void ArrayEx()
        {
            string[] names = { "Gvargis", "Basel", "Deepika", "Erik", "Emil" }; // DATA [1] [2]

            //List<string> list = new List<string>();

            Array.Sort(names);

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine(sortedArray.ToString());

            //List<string> listNames = names.ToList();

            //listNames.Sort(); // Method [2] (sorting list)

            //foreach (string name in listNames)
            //{
            //    Console.WriteLine(name);
            //}
            //
            //foreach (string name in names)
            //{
            //    list.Add(name);
            //}
            //list.Sort();

            //Console.WriteLine(list.ToArray());
        }

        static void printAllInDict(Dictionary<int, string> blah)
        {
            foreach (var item in blah)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        static void DictionaryEx()
        {
            Dictionary<int, string> socialNumberVault = new Dictionary<int, string>(){
                { 213, "Hej"},
                { 231, "Då" }
            };
            //Dictionary<Key, Value> example = new Dictionary<Key, Value>;
            //Key / Value = 
            //    int
            //    string
            //    bool
            //    Dictionary<>
            //    object
            //    double

            socialNumberVault.Add(19920212, "Emil Johansson");

            printAllInDict(socialNumberVault);

            socialNumberVault[19920212] = "Erik Christensson";

            printAllInDict(socialNumberVault);
        }
    }
}