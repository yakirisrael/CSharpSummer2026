// See https://aka.ms/new-console-template for more information


using Lecture04;

Students students = new Students(4);
Student s1 = new Student("Ron");
Student s2 = new Student("Ben");
Student s3 = new Student("Yahli");
Student s4 = new Student("Lev");
students[0] = s2;
students[1] = s3;
students[2] = s1;
students[3] = s4;

Teacher t = new Teacher();
t.Walk(100);

List<IWalkable> walkables = new List<IWalkable>();
walkables.Add(t);
walkables.Add(s1);
walkables.Add(s2);
walkables.Add(s3);
walkables.Add(s4);

foreach (IWalkable walkable in walkables)
    walkable.Walk(200);


