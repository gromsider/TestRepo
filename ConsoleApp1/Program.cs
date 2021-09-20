using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            //Разгоняемся до скорости, превышающей максимальный предел автомобиля, для выпада в исключение
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n*** Error! ***");          //ошибка
                Console.WriteLine($"Member name: {ex.TargetSite}");  //имя члена
                Console.WriteLine($"Class defining member: {ex.TargetSite.DeclaringType}");  //класс, определяющий член
                Console.WriteLine($"Member type: {ex.TargetSite.MemberType}");  //тип члена
                Console.WriteLine($"Message: {ex.Message}");    //сообщение
                Console.WriteLine($"Source: {ex.Source}");      //источник
            }
            // Исключение было обработано в блоке "catch", продолжается выполнение следующего оператора.
            Console.WriteLine("\n*** Out of ex logic! ***");
        }
    }
}
//Свойство StackTrace стр.289