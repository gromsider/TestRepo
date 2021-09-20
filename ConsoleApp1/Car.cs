using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        //Константа для представления макс. скорости
        public const int MaxSpeed = 100;

        //Свойства автомобиля
        public int CurrentSpeed { get; set; } = 0;
        public string PatName { get; set; } = "";

        //Флаг проверки, не вышел ли авто из строя
        private bool carIsDead;

        //В автомобиле имеется радиоприемник
        private Radio theMusicBox = new Radio();

        //Конструкторы
        public Car() {}

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PatName = name;
        }

        //Методы
        public void CrankTunes(bool state)
        {
            //Дедегировать запрос внутреннему объекту
            theMusicBox.TurnOn(state);
        }

        //Проверить не перегрелся ли автомобиль
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PatName} is out of order...");
            else
            {
                CurrentSpeed += delta;

                if (CurrentSpeed > MaxSpeed)
                {
                    //Console.WriteLine($"{PatName} has overheated!");
                    CurrentSpeed = 0;
                    carIsDead = true;
                    throw new Exception($"{PatName} has overheated!");
                }
                else
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
