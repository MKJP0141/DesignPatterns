using System;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new Item(4, "Item 0");
            collection[1] = new Item(3, "Item 1");
            collection[2] = new Item(8, "Item 2");
            collection[3] = new Item(2, "Item 3");
            collection[4] = new Item(1, "Item 4");
            collection[5] = new Item(0, "Item 5");
            collection[6] = new Item(7, "Item 6");
            collection[7] = new Item(6, "Item 7");
            collection[8] = new Item(5, "Item 8");

            // Create Iterator
            Iterator iterator = collection.CreateIterator();

            iterator.Step = 2;

            Console.WriteLine("Iterating over collection;");
            Console.WriteLine("git test");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            iterator.Step = 1;
            for (Item item = iterator.Last(); !iterator.IsFirst; item = iterator.Prev())
            {
                Console.WriteLine(item.Name);
            }

            var idIterator = collection.CreateIdIterator();

            for (Item item = idIterator.First(); !idIterator.IsDone; item = idIterator.Next())
            {
                Console.WriteLine($"{item.Id}:{item.Name}");
            }
            Console.Read();
        }
    }
}
