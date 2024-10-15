namespace DesafioProjetoHospedagem.Models;

public class Person
{
    public Person() { }

    public Person(string firstname)
    {
        Firstname = firstname;
    }

    public Person(string firstname, string lastname)
    {
        Firstname = firstname;
        Lastname = Lastname;
    }
    private String _firstname;
    public String Firstname
    {
        get { return _firstname; }
        set { _firstname = value; }
    }
    private String _lastname;
    public String Lastname
    {
        get { return _lastname; }
        set { _lastname = value; }
    }
    public string CompleteName { get => $"{Firstname} {Lastname}".ToUpper();}
}