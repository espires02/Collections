using System.Diagnostics;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //queue
            Queue<string> students = new Queue<string>();

            students.Enqueue("Dean Winchester");
            students.Enqueue("Sam Winchester");
            students.Enqueue("Bobby Singer");
            students.Enqueue("Castiel");
            students.Enqueue("Crowley");

            if (students.Contains("Castiel"))
            {
                Console.WriteLine("Castiel is in the queue.");
            }

            students.Dequeue();

            foreach(var s  in students)
            {
                Console.WriteLine(s);
            }

            //priority queue
            PriorityQueue<string, int> tasks = new PriorityQueue<string, int>();
            tasks.Enqueue("clean room", 4);
            tasks.Enqueue("finish homework", 2);
            tasks.Enqueue("make breakfast", 1);
            tasks.Enqueue("buy drinks", 3);
            tasks.Enqueue("drive home", 5);

            while (tasks.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Dequeued Item : {item} Priority Was : {priority}");
            }

            //stack
            Stack<string> games = new Stack<string>();

            games.Push("Fortnite");
            games.Push("Minecraft");
            games.Push("Fallout");
            games.Push("Assassins Creed");
            games.Push("Call of Duty");

            if (games.Contains("Fallout"))
            {
                Console.WriteLine("Fallout is in the stack.");
            }

            games.Pop();

            Console.WriteLine("there are " + games.Count + " games left.");

            foreach(var g in games)
            {
                Console.WriteLine(g);
            }

            //linked list
            LinkedList<string> books = new LinkedList<string>();

            books.AddLast("Snowglobe");
            books.AddLast("The Help");
            books.AddLast("Fourth Wing");
            books.AddLast("Divergent");
            books.AddLast("American Rust");

            Console.WriteLine("Here is the first book: " + books.First());
            Console.WriteLine("Here is the last book: " + books.Last());

            LinkedListNode<string> targetLocation = books.Find("Fourth Wing");
            books.AddAfter(targetLocation, "Iron Flame");

            books.RemoveLast();

            Console.WriteLine("There are "+books.Count+" books left.");

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

            //dictionary
            Dictionary<string, Int16> MembersList = new Dictionary<string, Int16>();

            MembersList.Add("Joey", 1);
            MembersList.Add("Monica", 2);
            MembersList.Add("Rachel", 3);
            MembersList.Add("Chandler", 4);
            MembersList.Add("Pheobe", 5);

            Console.WriteLine("Members list values");
            Dictionary<string, Int16>.ValueCollection values = MembersList.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Members list keys");
            Dictionary<string, Int16>.KeyCollection keys = MembersList.Keys;
            foreach(var key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Member list key/value pairs");
            foreach(KeyValuePair <string, Int16> kvp in MembersList)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }

            MembersList.Remove("Joey");

            Console.WriteLine($"Number of members after deletion: {MembersList.Count}");

            //sorted list
            SortedList<int,string> snacks = new SortedList<int,string>();

            snacks.Add(1, "Zebra Cakes");
            snacks.Add(2, "Oatmeal Cream Pie");
            snacks.Add(3, "Chocolate Caramel Bunny");
            snacks.Add(4, "Coconut Cookies");
            snacks.Add(5, "Krispy Kremes");

            Console.WriteLine("What snack would you like to add?");
            var newSnack = Console.ReadLine();

            if (snacks.ContainsValue(newSnack))
            {
                Console.WriteLine(newSnack + " is already in the list.");
            }
            else
            {
                snacks.Add(6, newSnack);
            }

            Console.WriteLine("What is the key for the item you want to remove?");
            int badKey = int.Parse(Console.ReadLine());

            snacks.Remove(badKey);

            Console.WriteLine("The snacks in the list are: ");
            foreach (KeyValuePair < int, string> kvp in snacks) 
            {
                Console.WriteLine($"Key = {kvp.Key}  Value = {kvp.Value}");
            }

            //hashset
            HashSet<string> boyNames = new HashSet<string>();
            boyNames.Add("Steffon");
            boyNames.Add("Damon");
            boyNames.Add("Elijah");
            boyNames.Add("John");
            boyNames.Add("Jeremy");

            HashSet<string> girlNames = new HashSet<string>();
            girlNames.Add("Elena");
            girlNames.Add("Caroline");
            girlNames.Add("Bonnie");
            girlNames.Add("Katherine");
            girlNames.Add("Hayley");

            HashSet<string> namesILike = new HashSet<string>();
            namesILike.Add("Elijah");
            namesILike.Add("Caroline");
            namesILike.Add("Hayley");
            namesILike.Add("Jessie");
            namesILike.Add("Jenna");

            Console.WriteLine("Combined list of boy and girl names");
            boyNames.UnionWith(girlNames);
            foreach(string name in boyNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Names that are in both lists");
            HashSet<string> bothlists = new HashSet<string>();
            bothlists = boyNames;
            bothlists.IntersectWith(namesILike);
            foreach(string name in bothlists)
            {
                Console.WriteLine(name);
            }

            //list
            List<string> drinks = new List<string>();
            drinks.Add("Diet Coke");
            drinks.Add("Water");
            drinks.Add("Bubbly");
            drinks.Add("Dr Pepper");
            drinks.Add("Mtn Dew");

            string[] drinkArr = new string[] { "Fanta", "Coffee", "Lemonade" };
            drinks.AddRange(drinkArr);

            drinks.Sort();
            Console.WriteLine("drinks in ascending order");
            foreach(string d in drinks)
            {
                Console.WriteLine(d);
            }

            drinks.Remove(drinks[1]);

            drinks.Reverse();
            Console.WriteLine("drinks in descending oreder with adjustments");
            foreach(string d in drinks)
            {
                Console.WriteLine(d);
            }
        }
    }
}
