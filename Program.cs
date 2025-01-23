using System;
using System.Collections.Generic;

namespace ZooManagementSystem
{
    // Base class for animals
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int Count { get; set; } // Number of animals of this type

        public Animal(int id, string name, string species, int age, int count)
        {
            Id = id;
            Name = name;
            Species = species;
            Age = age;
            Count = count;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Species: {Species}, Age: {Age}, Count: {Count}");
        }
    }

    // Derived class for animals with specific traits
    public class SpecialAnimal : Animal
    {
        public string SpecialTrait { get; set; }

        public SpecialAnimal(int id, string name, string species, int age, int count, string specialTrait)
            : base(id, name, species, age, count)
        {
            SpecialTrait = specialTrait;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Special Trait: {SpecialTrait}");
        }
    }

    class Program
    {
        static List<Animal> animals = new List<Animal>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nZoo Management System:");
                Console.WriteLine("1. Add Animal");
                Console.WriteLine("2. View All Animals");
                Console.WriteLine("3. View Animal Details");
                Console.WriteLine("4. Edit Animal");
                Console.WriteLine("5. Delete Animal");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddAnimal();
                        break;
                    case "2":
                        ViewAllAnimals();
                        break;
                    case "3":
                        ViewAnimalDetails();
                        break;
                    case "4":
                        EditAnimal();
                        break;
                    case "5":
                        DeleteAnimal();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddAnimal()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter species: ");
            string species = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter count: ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Does the animal have a special trait? (yes/no): ");
            string hasSpecialTrait = Console.ReadLine().ToLower();

            if (hasSpecialTrait == "yes")
            {
                Console.Write("Enter special trait: ");
                string specialTrait = Console.ReadLine();
                animals.Add(new SpecialAnimal(nextId++, name, species, age, count, specialTrait));
            }
            else
            {
                animals.Add(new Animal(nextId++, name, species, age, count));
            }

            Console.WriteLine("Animal added successfully!");
        }

        static void ViewAllAnimals()
        {
            if (animals.Count == 0)
            {
                Console.WriteLine("No animals found.");
                return;
            }

            foreach (var animal in animals)
            {
                animal.DisplayInfo();
            }
        }

        static void ViewAnimalDetails()
        {
            Console.Write("Enter animal ID: ");
            int id = int.Parse(Console.ReadLine());

            var animal = animals.Find(a => a.Id == id);
            if (animal != null)
            {
                animal.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Animal not found.");
            }
        }

        static void EditAnimal()
        {
            Console.Write("Enter animal ID to edit: ");
            int id = int.Parse(Console.ReadLine());

            var animal = animals.Find(a => a.Id == id);
            if (animal == null)
            {
                Console.WriteLine("Animal not found.");
                return;
            }

            Console.Write("Enter new name (leave blank to keep current): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name)) animal.Name = name;

            Console.Write("Enter new species (leave blank to keep current): ");
            string species = Console.ReadLine();
            if (!string.IsNullOrEmpty(species)) animal.Species = species;

            Console.Write("Enter new age (leave blank to keep current): ");
            string ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out int age)) animal.Age = age;

            Console.Write("Enter new count (leave blank to keep current): ");
            string countInput = Console.ReadLine();
            if (int.TryParse(countInput, out int count)) animal.Count = count;

            if (animal is SpecialAnimal specialAnimal)
            {
                Console.Write("Enter new special trait (leave blank to keep current): ");
                string specialTrait = Console.ReadLine();
                if (!string.IsNullOrEmpty(specialTrait)) specialAnimal.SpecialTrait = specialTrait;
            }

            Console.WriteLine("Animal updated successfully!");
        }

        static void DeleteAnimal()
        {
            Console.Write("Enter animal ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            var animal = animals.Find(a => a.Id == id);
            if (animal != null)
            {
                animals.Remove(animal);
                Console.WriteLine("Animal deleted successfully!");
            }
            else
            {
                Console.WriteLine("Animal not found.");
            }
        }
    }
}
