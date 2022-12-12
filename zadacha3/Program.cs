// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = Convert.ToInt32(Console.ReadLine());
            int index = 1;
            while(index <= num)
            {
                Console.Write(index * index * index);
                Console.Write(" ");
                index += 1;
            }
