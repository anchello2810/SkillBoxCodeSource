using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

        
        // Первая часть ДЗ 
        // Создаем переменные 
        // Имена
        string name = "Петр";  
        // Возраст
        byte age = 15;
            // Рост
            int height = 175;
            // Предметы
            double History = 5;
            double Math = 3;
            double  Russian = 3;
            //Общий балл
            double mark = (History+Math+Russian)/3;

            // Изменяем цвет шрифта для печати в консоли на DarkBlue
            Console.ForegroundColor = ConsoleColor.White;
            // Выводы
            // 
            string Newpattern1 = ($"Имя: {name} Возраст: {age} Рост: {height} История: {History} Математика: {Math} Русский язык: {Russian} Общий балл: ({ History}+{ Math}+{ Russian})/ 3 ={ mark}");
            Console.SetCursorPosition((Console.WindowWidth - Newpattern1.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(Newpattern1, name, age, History, Math, Russian, $"({History}+{Math}+{Russian})/3={mark}");
            Console.SetCursorPosition((Console.WindowWidth - Newpattern1.Length) / 2, Console.CursorTop);
            Console.WriteLine(" Имя: {0}  Возраст: {1} Рост: {2} История {3}  Математика {4}  Русский язык {5} Общий балл {6}",
                                      name,
                                      age,
                                      height,
                                      History,
                                      Math,
                                      Russian,
                                      $"({History}+{Math}+{Russian})/3={mark}");
            Console.SetCursorPosition((Console.WindowWidth - Newpattern1.Length) / 2, Console.CursorTop);
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} История: {History} Математика: {Math} Русский язык: {Russian} Общий балл: ({ History}+{ Math}+{ Russian})/ 3 ={ mark}");
            string Newpattern2 = "Петр 15 175 5 3 3 (5+3+3)/3=3,66666666666667";
            Console.SetCursorPosition((Console.WindowWidth - Newpattern2.Length) / 2, Console.CursorTop);
            Console.WriteLine(Newpattern2, name + " " + age + " " + height + " " + History + " " + Math + " " + Russian + " " + $"({History}+{Math}+{Russian})/3={mark}");
            Console.ReadKey();
        }

    }
}

