using System;
using System.Linq;

namespace Massives
//Разработка запросов LINQ
{
    class Animal
{
    public string Chorda { get; set; }
    public string Species { get; set; }

    public Animal(string ch, string sp)
    {
        Chorda = ch;
        Species = sp;
    }
}

class LINQ
{
    static void a()
    {
        string[] Chordata = {    "Птицы",
                                     "Рыбы",
                                     "Млекопитающие",
                                     "Земноводные",
                                     "Пресмыкающиеся"
                                   };

        Animal[] Animals = {       new Animal("Слон","Млекопитающие"),
                                       new Animal("Журавль","Птицы"),
                                       new Animal("Лягушка","Земноводные"),
                                       new Animal("Аист","Птицы"),
                                       new Animal("Семга","Рыбы"),
                                       new Animal("Крокодил","Пресмыкающиеся"),
                                       new Animal("Черепаха","Пресмыкающиеся"),
                                       new Animal("Тритон","Земноводные"),
                                       new Animal("Осетр","Рыбы"),
                                       new Animal("Какаду","Птицы"),
                                       new Animal("Саламандра","Земноводные"),
                                       new Animal("Змея","Пресмыкающиеся"),
                                       new Animal("Носорог","Млекопитающие"),
                                       new Animal("Акула","Рыбы"),
                                       new Animal("Жираф","Млекопитающие"),
                                       new Animal("Ящерица","Пресмыкающиеся"),
                                       new Animal("Заяц","Млекопитающие")
                                       };

        var bySpecies = from Species in Chordata
                        join Animalia in Animals
                        on Species equals Animalia.Species
                        into lst
                        select new { Species = Species, AnimalList = lst };
        foreach (var t in bySpecies)
        {
            Console.WriteLine("К классу {0} относятся: ", t.Species);
            foreach (var m in t.AnimalList)
                Console.WriteLine("  " + m.Chorda);
            Console.WriteLine();
        }
        Console.WriteLine("Нажмите любую кнопку!");
        Console.ReadKey();
    }
}
}