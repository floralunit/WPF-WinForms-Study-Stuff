using System;
using System.Collections.Generic;
/* Класс Stack<T> представляет коллекцию, которая использует алгоритм LIFO ("последний вошел - первый вышел"). 
* При такой организации каждый следующий добавленный элемент помещается поверх предыдущего. 
* Извлечение из коллекции происходит в обратном порядке - извлекается тот элемент, который находится выше всех в стеке.
В классе Stack можно выделить два основных метода, которые позволяют управлять элементами:
Push: добавляет элемент в стек на первое место
Pop: извлекает и возвращает первый элемент из стека
Peek: просто возвращает первый элемент из стека без его удаления
*/
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Flower> flowers = new Stack<Flower>();
            flowers.Push(new Flower() { Name = "Маргаритка" });
            flowers.Push(new Flower() { Name = "Подсолнух" });
            flowers.Push(new Flower() { Name = "Незабудка" });

            Console.WriteLine("Первоначальный состав стека:");
            foreach (Flower f in flowers)
            {
                Console.WriteLine(f.Name);
            }

            // получаем первый элемент без его извлечения
            Console.WriteLine();
            Flower ff = flowers.Peek();
            Console.WriteLine("Последний вошедший в стек элемент - ");
            Console.WriteLine(ff.Name);

            // Удаление последнего вошедшего элемента
            Flower flower = flowers.Pop(); // теперь в стеке Подсолнух и Маргаритка
            Console.WriteLine();
            Console.WriteLine("Стек после удаления последнего вошедшего элемента:");
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
