using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class details
    {
           
        public string AddIntoQueue(string user)
        {
            //Alice-9090909090
            
            int count = 0;
            for(int i = 0;i<user.Length;i++)
            {
                if (user[i]=='-')
                    count++;
            }
            //bob9090909090
            if (count != 1)
            {
                return "*";
            }
            //-90909090909099
            string[] str = user.Split('-');
            //Console.WriteLine(str.Length);

            if (str[0] == "" || str[1] == "")
            {
                return "!";
            }
/*
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
}
            
*/

            //alice-3434

            if (str[1].Length != 10)
                return "@";

            Program.detailsQueue.Enqueue(user);


            return "";
        }

        public string getFirstNumber()
        {
            if (Program.detailsQueue.Count != 0)
            {
                string res1 = "";
                if (Program.detailsQueue.Count != 0)
                {
                    object res = Program.detailsQueue.Peek();
                    res1 = (string)res;
                }
                return res1;
            }
            
            return "";
        }
//we have to delete the first phone number from the queue and return only number.
        public string getFirstPhone()
        {
            string[] strarr;
            string[] strand;
            if (Program.detailsQueue.Count != 0)
            {

                Object res = Program.detailsQueue.Peek();

                string res1 = (string)res;

                 strarr = res1.Split('-');

                Object and = Program.detailsQueue.Dequeue();

                string and1 = (string)and;

                strand = and1.Split('-');
                return strand[1];
            }

            return "";
        }

        public void printQueue()
        {
            //IEnumerator ie = Program.detailsQueue.GetEnumerator();
            Console.WriteLine("COubnt is " +  Program.detailsQueue.Count);
            foreach (var item in Program.detailsQueue)
            {
                Console.WriteLine(item);
            }

        }

    }
}
