// See https://aka.ms/new-console-template for more information

using Gameplay.Soldiers;
using Lecture02;

Soldier s = new Soldier();
s.Jump();
s.Jump(speed:10);
s.Jump(20);
s.Attack();

Soldier a = new CaptainA();
a.Attack();

Falcon f = new Falcon();
f.Attack();

Console.WriteLine($"Soldier tags =  {Soldier.tag}");