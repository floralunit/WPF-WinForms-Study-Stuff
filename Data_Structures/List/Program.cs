using System;
using System.Collections.Generic;
/* Класс List<T> из пространства имен System.Collections.Generic представляет простейший список однотипных объектов.
 * Список — упорядоченный набор элементов, для каждого из которых хранится указатель на следующий
(или для двусвязного списка и на следующий и на предыдущий) элементы списка.
*/
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление нового списка.
            var flowers = new List<string>();

            // Добавление новых элементов в список.
            flowers.Add("Ромашки");
            flowers.Add("Розы");
            flowers.Add("Фиалки");

            // Вывод элементов списка.
            foreach (var flower in flowers)
            {
                Console.WriteLine(flower);
            }

            Console.WriteLine();

            // Получение элемента списка по индексу.
            var firstElement = flowers[0];

            Console.WriteLine(firstElement);

            // Удаление элемента из списка.
            flowers.Remove(firstElement);

            // Удаление элемента из списка по индексу.
            flowers.RemoveAt(1);

            Console.WriteLine();

            // Вывод элементов списка.
            foreach (var item in flowers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
