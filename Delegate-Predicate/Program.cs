using System;
using Domain.Models;

static List<Person> People()
{
    return new List<Person>()
            {
                new Person{Id = 1, Name = "Semed", Surname = "Huseynov", Address = "Ehmedli", Salary = 2500 },
                new Person{Id = 2, Name = "Elnur", Surname = "Memmedov", Address = "Azadliq", Salary = 200 },
                new Person{Id = 3, Name = "Tunzale", Surname = "Memmedova", Address = "Azadliq", Salary = 500 },
                new Person{Id = 4, Name = "Nergiz", Surname = "Memmedova", Address = "Azadliq", Salary = 2300 },
            };
}   



static void GetFilteredSalaryPersons(List<Person> people,Predicate<Person>func)
{		
    foreach (var item in people)
    {
        if (func(item))
        {
            var result = $"Name: {item.Name} - Surname: {item.Surname} - Salary: {item.Salary} - Address: {item.Address}";
            Console.WriteLine(result);
        }
    }
}


static bool CheckPerson(Person person)
{
    return person.Salary > 1000;
}

GetFilteredSalaryPersons(People(),CheckPerson);








static List<Book> Authors()
{
    return new List<Book>()
            {
                new Book{Id = 1,Author = "Nizami", Page = 290},
                new Book{Id = 2,Author = "Xaqani", Page = 565},
                new Book{Id = 3,Author = "Nasimi", Page = 897},
                new Book{Id = 4,Author = "Nizami", Page = 342},
            };
}


static void GetByAuthors(List<Book> books, Predicate<Book> func)
{
    int count = 0;
    foreach (var item in books)
    {
        if (func(item))
        {
            count++;
        }
    }

    Console.WriteLine(count);
}


static bool CheckAuthor(Book book)
{
    return book.Author == "Nizami";
}

GetByAuthors(Authors(), CheckAuthor);
