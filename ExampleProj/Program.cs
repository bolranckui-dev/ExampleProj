class Person
{
   private string Name;
   private string Surname;
   private int Age;
}

public class GetPerson
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}
class Program
{

    static void Main(string[] args)
    {
        List<GetPerson> persons = new List<GetPerson>();
        persons.Add(new GetPerson { Name = "Viktor", Surname = "Volkov", Age = 21});
        persons.Add(new GetPerson { Name = "John", Surname = "Pork", Age = 32});
        persons.Add(new GetPerson { Name = "Charlie", Surname = "Kirk", Age = 35});
        persons.Add(new GetPerson { Name = "John", Surname = "Snow", Age = 28});
        persons.Add(new GetPerson { Name = "Jane", Surname = "Doe", Age = 18});

        Console.WriteLine("Hello, " + persons[0].Name + "!");

        foreach (var person in persons)
        {
            Console.WriteLine(person.Name +  " - " + person.Surname + " - " + person.Age);
        }

        Console.WriteLine(" ");
        
        for (int i = 0; i < persons.Count; i++)
        {
            if (persons[i].Age > 25)
            {
                Console.WriteLine(persons[i].Name + " - " + persons[i].Surname + " - " + persons[i].Age);
            }
        }
        
        
    }
}