using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;

namespace Week3App1
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Dersin adini daxil ediniz");
            string className=Console.ReadLine();
            Console.WriteLine("Taskin adini daxil ediniz");
            string taskName = Console.ReadLine();
            StringBuilder studentGrades= new StringBuilder();
            studentGrades.AppendLine(className);
            studentGrades.AppendLine(taskName);

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i+1}Telebenin adini daxil ediniz");
                string studentName = Console.ReadLine();
                Console.WriteLine($"{i+1}Bal  daxil ediniz");
                float grade = float.Parse(Console.ReadLine());
                studentGrades.Append(studentName).Append("-").Append(grade).Append("\n");
            }


            Console.WriteLine(studentGrades);           
 
        }
    }
}*/




        /*  static void Main(string[] args)
          {

              for (int i = 10; i >= 0; i=i-2)
              {
                  Console.WriteLine(i);             
              }
          }
      }
  }*/

        //        static void Main(string[] args)
        //        {


        //            Random random = new Random();
        //            int luckyNumber = random.Next(1, 100);
        //            int attemps = 0;
        //            bool flag = false;
        //            while (true) 
        //            {
        //                attemps++;
        //                Console.WriteLine("Enter the Number");
        //                int number =int.Parse( Console.ReadLine());
        //                if (number == luckyNumber)
        //                {
        //                    Console.WriteLine("Congrats You Won!");
        //                    Console.WriteLine($"Bal  daxil ediniz {attemps})");
        //                    break;
        //                }
        //                else if (number < luckyNumber)
        //                {
        //                    Console.WriteLine("Your guess is low");

        //                }
        //                else 
        //                { 
        //                     Console.WriteLine("Your guess is too high");
        //                }
        //            }
        //        }
        //    }
        //}



        //        static void Main(string[] args)
        //        {

        //            int productCount = 0;
        //            float totalPrice = 0;
        //            StringBuilder stringBuilder= new StringBuilder();

        //            while (true)
        //            {
        //                Console.WriteLine("Enter Product Price");
        //                float price = float.Parse(Console.ReadLine());

        //                if (price != 0)
        //                {
        //                    Console.WriteLine("Enter product ");
        //                    string productName = Console.ReadLine();
        //                    productCount++;
        //                    totalPrice = totalPrice + price;
        //                    stringBuilder.Append(productName).Append("--").Append(price).Append("*\n");
        //                }

        //                else
        //                {
        //                    break;
        //                }


        //            }

        //            Console.WriteLine($"Gunluk satilan mallarin sayisi");
        //            Console.WriteLine($"Gunluk satilan mallarin toplam deyeri");
        //            Console.WriteLine($"Gunluk satilan mallarin siyahisi");
        //            Console.WriteLine(stringBuilder);

        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            StringBuilder studentList= new StringBuilder(); 
            string studentName;
            float studentGrade;
            char answer = 'N';
            do
            {
                Console.WriteLine("Enter the student name");
                studentName = Console.ReadLine();
                Console.WriteLine("Student Grade");
                studentGrade=float.Parse(Console.ReadLine());
                Console.WriteLine("Any new students?(Y/N)");
                answer=char.Parse(Console.ReadLine());

                string studentInfo = $"{studentName}-{studentGrade}";
                studentList.AppendLine(studentInfo);
            }
            while (answer=='y');

            Console.WriteLine("List of Students");
            Console.WriteLine(studentList);
            
        }
    }
}