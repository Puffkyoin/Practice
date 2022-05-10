using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Выбери программу которую хочешь запустить.
            
            //DamageCalculation();
            //InTheShop();
            //PasswordEntry();
            //CurrencyConverter();
            //PasswordEntryCicle();
            //BankDeposit();
            //Battle();
            //Array();
            //SeatReservation();
        }
        
        public static void DamageCalculation() {
            float health;
            int armor;
            int damage;

            Console.Write("Введите кол-во жизней:");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во бронни:");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во урона:");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / 100 * armor;

            Console.Write($"После атаки в {damage} урона, у вас осталось {health} жизней.");
        }

        public static void InTheShop()
        {
            int money;
            int eatCount;
            int eatPrice = 10;
            int isEnoughMoney;

            Console.WriteLine($"Добро пожаловать в пекарню! \nСегодня еда по {eatPrice} монет.\n");
            Console.Write("Сколько у вас золота?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно?");
            eatCount = Convert.ToInt32(Console.ReadLine());

            isEnoughMoney = money >= eatCount * eatPrice ? 1 : 0;
            eatCount *= isEnoughMoney;

            money -= eatCount * eatPrice;

            Console.WriteLine($"У вас в сумке {eatCount} еды и {money} золота.");
        }

        public static void PasswordEntry()
        {
            string password = "scp-001";
            string userInput;

            Console.Write("Введите пароль:");
            userInput = Console.ReadLine();

            if(userInput == password)
            {
                Console.WriteLine("Информация о процедуре 110-монтаук");
            }    
            else
            {
                Console.WriteLine("Летальный мeмагент запущен");
            }
        }

        public static void CurrencyConverter()
        {
            int rubToUsd = 64, usdToRub = 66;
            float rub;
            float usd;
            float currencyCount;

            Console.Write("Введите баланс рублей:");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов:");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Добро пожаловать в обменник валют. У нас вы можете обменять рубли в доллары и доллары в рубли.");
            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Скалько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей");
                    }

                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.Write("Скалько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());

                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;

                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во долларов");
                    }

                    break;
            }

            Console.WriteLine($"Ваш баланс {rub} рублей и {usd} долларов");

        }

        public static void PasswordEntryCicle()
        {
            int tryCount = 5;
            string password = "123456";
            string userInput;

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите пароль:");
                userInput = Console.ReadLine();


                if (password == userInput)
                {
                    Console.WriteLine("Секретики");
                    break;
                }
                else
                {
                    Console.WriteLine($"У вас осталось - {tryCount - i} попыток");
                }
            }
           
        }

        public static void BankDeposit()
        {
            float money;
            int years;
            int percent;
            
            Console.Write("Введите кол-во денег внесенных на вклад:");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад:");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент:");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine($" В этом году у вас - {money} денег");
                Console.ReadKey();
            }
            Console.WriteLine("Срок вашего вклада истёк.");
        }

        public static void Battle()
        {
            int youHealth = 100;
            int yourDamage = 5;
            int enemyHealth = 50;
            int enemyDamage = 10;

            while (youHealth>0 && enemyHealth>0)
            {
                youHealth -= enemyDamage;
                enemyHealth -= yourDamage;
                Console.WriteLine($"У вас {youHealth} жизней.");
                Console.WriteLine($"У вашего врага {enemyHealth} жизней");
                
                if (enemyHealth <= 0 && youHealth <= 0)
                {
                    Console.WriteLine("Ничья!");
                }
                else if (youHealth <= 0)
                {
                    Console.WriteLine("Поражение!");
                }
                else if(enemyHealth<=0)
                {
                    Console.WriteLine("Победа!");
                }
            }
            
        }

        public static void Array()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            // Задания 1,2 array sum
            /*int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
                sum += array[i];
            }
            
            Console.WriteLine($"\nСумма элементов массива равна {sum}.");*/
            
            
            /*Задание 3 максимальное число в массиве
            int maxValue = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine($"Максимальное число в массиве: {maxValue}");*/
        }

        public static void SeatReservation()
        {
            bool isOpen = true;
            int[] tables = { 5, 4, 8, 9, 3, 7, 1 };
            
            while(isOpen)
            {
                Console.SetCursorPosition(0, 15);
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine($"За столом - {i+1}, свободно {tables[i]} мест");
                }
                
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Администрирование кафэ.\n");
                Console.WriteLine("\n1 - забронировать место \n\n2 - выход из программы.");
                Console.Write("\nВведите номер команды:");
                
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userTable, userPlace;
                        
                        Console.Write("За каким столов вы хотите забронировать место:");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (tables.Length <= userTable || userTable < 0)
                        {
                            Console.WriteLine("Такого стола нет.");
                            break;
                        }
                        
                        Console.Write("Сколько мест вы хотите забронировать:");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (tables[userTable] < userPlace || userPlace < 0)
                        {
                            Console.WriteLine("Недостаточно мест.");
                            break;
                        }
                        tables[userTable] -= userPlace; 
                        break;
                    
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }            
        }
    }
}