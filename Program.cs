namespace finaltest2
{

    class program
    {
        static void Main(string[] args)
        {


            int epidemic = 0;
            int check = 0;
            Console.WriteLine("Please input num city :");
            int num = int.Parse((Console.ReadLine()));
            string[] city = new string[num];


            for (int i = 0; i < num; ++i)
            {
                Console.WriteLine("Please input name city :");
                string namecity = Console.ReadLine();

                city[i] = namecity;

                while (check == 0)
                {
                    Console.WriteLine("Please input num city allied :");
                    int cityallied = int.Parse((Console.ReadLine()));
                    for (int j = 0; j < cityallied; ++j)
                    {
                        if (cityallied > 0)
                        {
                            Console.WriteLine("Please input allied num :");
                            int allilednum = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID");
                        }
                    }
                }
            }

            for (int k = 0; k < num; ++k)
            {

                Console.Write("{0} {1} {2}", k, city[k], epidemic);
            }
            Console.WriteLine();



            Console.WriteLine("Please input covid epidimic :");
            string covid = Console.ReadLine();
            switch (covid)
            {
                case "Outbreak":
                    int numcovid = int.Parse(Console.ReadLine());
                    if (epidemic <= 3)
                    {
                        epidemic += 2;
                        for (int k = 0; k < num; ++k)
                        {

                            Console.Write("{0} {1} {2}", k, city[k], epidemic);
                        }
                        Console.WriteLine();
                    }
                    break;
                case "Spred":
                    int numcovid1 = int.Parse(Console.ReadLine());
                    epidemic += 1;
                    for (int k = 0; k < num; ++k)
                    {

                        Console.Write("{0} {1} {2}", k, city[k], epidemic);
                    }
                    Console.WriteLine();
                    break;
                case "Vaccined":
                    int numcovid2 = int.Parse(Console.ReadLine());
                    epidemic = 0;
                    for (int k = 0; k < num; ++k)
                    {

                        Console.Write("{0} {1} {2}", k, city[k], epidemic);
                    }
                    Console.WriteLine();
                    break;
                case "Lockdown":
                    int numcovid3 = int.Parse(Console.ReadLine());
                    if (epidemic >= 0)
                    {
                        epidemic -= 1;
                    }
                    for (int k = 0; k < num; ++k)
                    {

                        Console.Write("{0} {1} {2}", k, city[k], epidemic);
                    }
                    Console.WriteLine();
                    break;
                case "Exit":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid");

                    break;



            }





        }
    }
}
