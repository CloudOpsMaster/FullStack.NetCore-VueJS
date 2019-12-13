using System;

class User
{
    string login;
    string name;
    string lastName;
    int age;
    string Date;

    public User() { }
    public User(string _login, string _name, string _lastName, int _age, string _Date)
    {
        login = _login;
        name = _name;
        lastName = _lastName;
        age = _age;
        Date = _Date;
        Console.WriteLine(login + " " + name + " " + lastName + " " + age + " " + Date);
    }


}