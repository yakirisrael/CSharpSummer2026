// See https://aka.ms/new-console-template for more information

using Lecture03;

Animal a1 = new Mouse();
Animal a2 = new Squeed();
Animal a3 = new Llama();

List<Animal> animals = new();
animals.Add(a1);
animals.Add(a2);
animals.Add(a3);

foreach (Animal animal in animals)
{
    animal.Sound();
}

/*
Vector2D v1 = new (1, 2);
Vector2D v2 = new (1, 2);

Console.WriteLine(v1);
Console.WriteLine(v2);

Console.WriteLine(v1.Equals(v2));
Console.WriteLine(v1.GetHashCode());
Console.WriteLine(v2.GetHashCode());*/