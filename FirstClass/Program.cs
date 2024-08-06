using FirstClass;

public class Program ()
{
    static void Main()
    {
        Person student1 = new Person()
        {
            FirstName = "Ceyda",
            LastName = "Yılmaz",
            BirthDate = new DateTime(1999, 2,7)
        };

        Person student2 = new Person()
        {

            FirstName = "Canberk",
            LastName = "Doğan",
            BirthDate = new DateTime(1999, 06, 21)
        };

        Person teacher1 = new Person()
        {

            FirstName = "Ayşe",
            LastName = "Yılmaz",
            BirthDate = new DateTime(1999, 7, 7)
        };

        Person teacher2 = new Person()
        {

            FirstName = "Tahir",
            LastName = "Yılmaz",
            BirthDate = new DateTime(1999, 10, 7)
        };


        Console.WriteLine("Students:");
        student1.DisplayInfo();
        student1.DisplayInfo();
  


        Console.WriteLine("Teachers:");
        teacher1.DisplayInfo();
        teacher2.DisplayInfo();



    }
}


