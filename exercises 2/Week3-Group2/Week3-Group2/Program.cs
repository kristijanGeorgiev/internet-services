

using System.Text;

namespace Week3_Group2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reference type
            Person myPerson = new Person();
            myPerson.Name = "Kristijan";
            Console.WriteLine(myPerson.Name);
            ChangeByRef(myPerson);
            int myInt = 100;
            PassByValue(myInt);
            Console.WriteLine(myInt);
            int refInt = 8;
            PassByRefInt(ref refInt);
            Console.WriteLine(refInt);
            string name = "Kristijan";
            string surname = "Georgiev";
            Swap(name, surname);
            Console.WriteLine(name);
            Console.WriteLine(surname);
            string firstName, lastName;
            Split("Steve Ray Brown", out firstName, out lastName);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            int total = Sum(1, 2, 3, 8, 1, 3, 21, 7);
            Console.WriteLine(total);
            int score;
            score = 100;
            if(score >= 60)
            {
                Console.WriteLine("Passing grade");
            }
            else
            {
                Console.WriteLine("Failing grade");
            }
            string nameee;
            Console.WriteLine("Enter your name: ");
            nameee = Console.ReadLine();
            Console.WriteLine($" Hi {nameee}, how are you?");
            int num1, num2, sum, sub, div, mul, mod;
            Console.WriteLine("Enter number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            sub = num1 - num2;
            div = num1 / num2;
            mul = num1 * num2;
            mod = num1 % num2;
            Console.WriteLine("{0} + {1} = {2} ", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2} ", num1, num2, sub);
            Console.WriteLine("{0} * {1} = {2} ", num1, num2, mul);
            Console.WriteLine("{0} / {1} = {2} ", num1, num2, div);
            Console.WriteLine("{0} % {1} = {2} ", num1, num2, mod);
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = LeapYear(year);
            Console.WriteLine("The year {0} is leap year: {1} ", year, isLeapYear);
            string name1 = "Kristijan";
            var date = DateTime.Now;
            var hour = date.Hour;
            var minutes = date.Minute;
            var seconds = date.Second;
            var day = date.DayOfWeek;
            Console.WriteLine($"Hello {name1}!, Today is {date}, Today is {day} and it's {hour} {minutes} {seconds}");
            Console.WriteLine("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while(i<=n)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Enter a number between 1 and 3");
            int numSwitch = Convert.ToInt32(Console.ReadLine());
            switch(numSwitch)
            {
                case 1:
                    Console.WriteLine("You entered one");
                    break;
                case 2:
                    Console.WriteLine("You entered two");
                    break;
                case 3:
                    Console.WriteLine("You entered three");
                    break;
            }
            #endregion
        }

        private static bool LeapYear(int year)
        {
            var isLeapYear = (year % 4 == 0) && (year % 100 != 0);
            isLeapYear = isLeapYear || (year % 400 == 0);
            return isLeapYear;
        }

        private static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i< ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

        private static void Split(string name, out string firstName, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstName = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        private static void PassByValue(int myPassedInt)
        {
            myPassedInt = 1001;
            Console.WriteLine(myPassedInt);
        }
        private static void ChangeByRef(Person myPerson)
        {
            myPerson.Name = "Ana";
            Console.WriteLine(myPerson.Name);
        }
        private static void PassByRefInt(ref int refInt)
        {
            refInt = refInt + 1;
            Console.WriteLine(refInt);
        }
        private static void Swap(string name, string surname)
        {
            string temp = name;
            name = surname;
            surname = temp;
            Console.WriteLine(name);
            Console.WriteLine(surname);

        }
    }
}
