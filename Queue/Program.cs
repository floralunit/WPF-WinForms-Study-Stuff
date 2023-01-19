using System;
using System.Collections.Generic;
/*
Класс Queue<T> представляет обычную очередь, работающую по алгоритму FIFO ("первый вошел - первый вышел").
У класса Queue<T> можно отметить следующие методы:
Dequeue: извлекает и возвращает первый элемент очереди
Enqueue: добавляет элемент в конец очереди
Peek: просто возвращает первый элемент из начала очереди без его удаления
*/
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<Flower> flowers = new Queue<Flower>();
            flowers.Enqueue(new Flower() { Name = "Роза" });
            flowers.Enqueue(new Flower() { Name = "Нарцисс" });
            flowers.Enqueue(new Flower() { Name = "Одуванчик" });

            Console.WriteLine("Сейчас в очереди {0} цветка", flowers.Count);
            Console.WriteLine("Состав очереди:");
            // теперь в очереди Роза, Нарцисс и Одуванчик
            foreach (Flower f in flowers)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine();

            // получаем первый элемент без его извлечения
            Flower ff = flowers.Peek();
            Console.WriteLine("Первый цветок в очереди - ");
            Console.WriteLine(ff.Name);

            // Извлекаем первый элемент в очереди - Роза
            Flower flower = flowers.Dequeue(); // теперь в очереди Нарцисс и одуванчик
            Console.WriteLine();
            Console.WriteLine("Состав очереди после извлечения первого элемента:");
            foreach (Flower f in flowers)
            {
                Console.WriteLine(f.Name);
            }

            Console.ReadLine();
        }
    }

    class Flower
    {
        public string Name { get; set; }
    }
}
