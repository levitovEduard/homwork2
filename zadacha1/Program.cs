// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
{

            int num = Convert.ToInt32(Console.ReadLine());

            int tmp = num, count = 0;

            while (tmp != 0)        
            {
                tmp /= 10;
                count += 1;
            }

            bool palindrom = true;
            for(int i = 0; i < count/2; i+=1)
            {
               int first, last;
               first = (num / (int)Math.Pow(10, i)) % 10;  
                last = (num / (int)Math.Pow(10, count - 1 - i)) % 10;
                if (first != last) palindrom = false;
            }
            if (palindrom)
            {
                Console.WriteLine("Палиндром");
            }
            else
                Console.WriteLine("Не палиндром");
            

            Console.ReadKey(true);
        }
        