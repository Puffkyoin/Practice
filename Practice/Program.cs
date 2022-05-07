using System;
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
    }
}