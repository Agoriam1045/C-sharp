using Lectia4;

Console.WriteLine("Hello world");

Being being1 = new Person();
being1.GetMovementSpeed();

Person person1 = new Person();
person1.GetMovementSpeed(Person.Emotion.Angry);

ITalkable talkable1 = new Person();
talkable1.Talk();
Console.WriteLine(talkable1.Age);