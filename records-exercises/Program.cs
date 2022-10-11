//Records (Positional

//var room1 = new Room(true, true);
//var room2 = room1 with {Chairs = 4, Tables = 1};
//var room3 = room1 with {hasWindows = false, Chairs = 8, Tables = 2};

//Console.WriteLine(room1);
//Console.WriteLine(room2);
//Console.WriteLine(room3);
//record Room(bool hasWindows, bool hasDoor, int Chairs = 0, int Tables = 0);

//-------------------------------------------------------------------------

//var student = new Student
//{
//    Id = 1,
//    Name = "Daniela",
//    Age = 28,
//    Address = "Cold street"
//};
// I've created a student object but I want to change
// the name of the street. I would need to create
// another instance of Student
//var student2 = new Student
//{
//    Id = student.Id,
//    Name = student.Name,
//    Surname = "Escobar",
//    Age = student.Age,
//    Address = "Cool street"
//};

// Now I want to add a new property to my
// Student class called Surname and above as well

//public class Student
//{
//    public int Id { get; init; }
//    public string Name { get; init; }
//    public string Surname { get; init; }
//    public int Age { get; init; }
//    public string Address { get; init; }

//}

//Init properties are immutable. If I want to add a new
//property or change value of a property I would need to
//create new objects and assign a new value

// This above example would not work if I have
// lots and lots of properties. It would become
// tedious and tiresome to update them, which is
// where Records come in

//var pupil = new Pupil
//{
//    Id = 1,
//    Name = "Chubby",
//    Surname = "Chubster",
//    Age = 4,
//    Address = "Cool street"
//};

// If we want to update our Pupil we'll only need
// to use the "with" expression

//var newPupil = pupil with { Surname = "Charles" };
//public record Pupil
//{
//    public int Id { get; init; }
//    public string Name { get; init; }
//    public string Surname { get; init; }
//    public int Age { get; init; }
//    public string Address { get; init; }
//}

// New Switch expressions exercise with record

var people = new List<Person>()
{
    new Person(1, "Knut"),
    new Person(13, "Annelie"),
    new Person(26, "Putte"),
    new Person(65, "Gudde")
};

foreach (var person in people)
{
    Console.WriteLine(CheckPerson(person));
}

string CheckPerson(Person person)
{
    var result = person switch
    {
        { age: >= 65 } => "Old",
        { age: >= 18 and < 65 } => "adult",
        { age: < 18 and > 12 } => "teen",
        { age: <= 12 } => "child",
        _ => "Unknown"
    };
    return result;
}

record Person(int age, string name);