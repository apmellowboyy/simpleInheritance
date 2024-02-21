using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;
        public string type;
        public string breed;
        public string color;
        public int age;

        // constructor
        public Animal()
        {
            name = "";
            type = "";
            breed = "";
            color = "";
            age = 4;
        }
        //parameterized constructor
        public Animal(string name, string type, string breed, string color, int age)
        {
            this.name = name;
            this.type = type;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
            Console.WriteLine($"I am a {type}, and the best {type} there ever was!");
            Console.WriteLine($"More specifically I am a {breed}");
            Console.WriteLine($"Can't you see I'm {color}? Probably not lmaooooo");
            Console.WriteLine($"I'm at the ripe age of {age}");
            Console.WriteLine();
        }
        public void display2()
        {
            Console.WriteLine($"I am a Human, my name is {name}");
            Console.WriteLine($"I am a {type}, and the best {type} there ever was!");
            Console.WriteLine($"More specifically I am a {breed}");
            Console.WriteLine($"I am {color}");
            Console.WriteLine($"I'm at the ripe age of {age}");
        }

    }

    // derived class of Animal 
    class myPet : Animal
    {
        public int speed;
        public int weight;

        public myPet()
        : base()
        {
            speed = 0;
            weight = 0;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.type = "Cat";
            myPet.breed = "Sphynx";
            myPet.color = "Peach";
            myPet.age = 4;
            myPet.display();

            

            // derived class object using default constructor
            Animal Horse = new Animal();
            Horse.name = "Johny Walker";
            Horse.type = "Horse";
            Horse.breed = "Mustang";
            Horse.color = "Orange";
            Horse.age = 8;
            Horse.display();
            Console.WriteLine();


            //derived class object using parameterized constructor
            Animal Blud = new Animal("Blud","Capybara", "Hydrochoerus hydrochaeris", "Brown", 3);
            Blud.display();
            Console.WriteLine();

            Animal Human = new Animal("Ethan", "Human", "Homosapien", "White", 22);
            Human.display2();
            Console.WriteLine();
        }

    }
}