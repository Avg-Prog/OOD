﻿using SRP;

List<Person> persons = new List<Person>();

Console.WriteLine("Welcome to the HR application, choose your action:");
Console.WriteLine("1. Add person");
Console.WriteLine("2. Edit person");
Console.Write(">");

var option = Console.ReadLine();
switch (option)
{
    case "1":
        AddPerson();
        break;
    case "2":
        EditPerson();
        break;
    default:
        break;
}

void AddPerson()
{
    Person toAdd = new Person();
    Console.WriteLine("Enter name:");
    toAdd.Name = Console.ReadLine();

    var ssn = "";
    bool isSSNValid = false;
    do
    {
        Console.WriteLine("Enter social security number:");
        ssn = Console.ReadLine();

        if (ssn.Length == 11)
        {
            if (int.TryParse(ssn.Substring(0, 9).ToString(), out int firstNine))
            {
                if (int.TryParse(ssn.Substring(9).ToString(), out int checkNumber))
                {
                    int remainder = firstNine % 97;
                    if (97 - remainder == checkNumber)
                    {
                        isSSNValid = true;
                    }
                }
            }

        }
    } while (isSSNValid is false);

    toAdd.SocialSecurityNumber = ssn;
    persons.Add(toAdd);
}

void EditPerson()
{
    Console.WriteLine("Enter the social security number for the person you wish to edit:");
    Console.Write(">");
    var ssnToEdit = Console.ReadLine();

    var personToEdit = persons.Where(p => p.SocialSecurityNumber == ssnToEdit).FirstOrDefault();
    if (personToEdit is not null)
    {
        Console.WriteLine("Enter new name:");
        personToEdit.Name = Console.ReadLine();

        var ssn = "";
        bool isSSNValid = false;
        do
        {
            Console.WriteLine("Enter new social security number:");
            ssn = Console.ReadLine();

            if (ssn.Length == 11)
            {
                if (int.TryParse(ssn.Take(9).ToString(), out int firstNine))
                {
                    if (int.TryParse(ssn.Take(new Range(9, 11)).ToString(), out int checkNumber))
                    {
                        int remainder = firstNine % 97;
                        if (97 - remainder == checkNumber)
                        {
                            isSSNValid = true;
                        }
                    }
                }

            }
        } while (isSSNValid is false);

        personToEdit.SocialSecurityNumber = ssn;
    }
}
