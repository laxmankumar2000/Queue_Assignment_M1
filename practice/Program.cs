using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Program
    {
        public static Queue detailsQueue = new Queue();
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Add into Queue");
            Console.WriteLine("2.Get first Details");
            Console.WriteLine("3. remove the first deatils");
            Console.WriteLine();
            Console.WriteLine();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("Enter the choice");
                 choice = int.Parse(Console.ReadLine());
                details d = new details();

                switch (choice)
                {

                    case 1:
                        {
                            Console.WriteLine("Enter the name of user");
                            string user = Console.ReadLine();
                            string res = d.AddIntoQueue(user);
                            Console.WriteLine(res);
                            break;
                        }
                    case 2:
                        {
                            string ans = d.getFirstNumber();
                            if (ans == "")
                                Console.WriteLine("Queue is Empty");
                            else
                                Console.WriteLine(ans);
                            break;
                        }
                    case 3:
                        {
                            string ans = d.getFirstPhone();
                            if(ans == "")
                                Console.WriteLine("Queue is Empty");
                            else
                                Console.WriteLine(ans);

                            break;
                        }
                    case 4:
                        {
                            d.printQueue();
                            break;
                        }

                }
            }
            
        }
    }
}
