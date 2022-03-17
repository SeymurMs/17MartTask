using System;

namespace _17MartTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string no;
            do
            {
                Console.WriteLine("Sayi daxil edin :");
                no = Console.ReadLine();    
            } while (!CheckUpper(no));
            string str;
            int studentLimit;

            do
            {
                Console.WriteLine("Telebe sayi daxil edin ");
                str = Console.ReadLine();

            } while (!int.TryParse(str ,out studentLimit) &&  studentLimit <0);
                
            Group group = new Group(no, studentLimit);

            


        }
        static bool CheckUpper(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (char.IsUpper(name[0]) && char.IsUpper(name[1]) && char.IsDigit(name[2]) && char.IsDigit(name[3]) && char.IsDigit(name[4]))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
