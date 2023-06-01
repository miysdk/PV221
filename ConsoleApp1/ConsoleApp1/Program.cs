using ConsoleApp1._5._12;
using System.Collections;
using ConsoleApp1._6._01;

Hashtable group = new Hashtable()
{
    {
        new Student
        {
            GroupID = 1,
            FirstName = "John",
            LastName = "Miller",
            BirthDate = new DateTime(1997, 3, 12)
        },
        new ArrayList {12,9,10}
    },
    {
        new Student
        {
            GroupID = 2,
            FirstName = "Candice",
            LastName = "Leman",
            BirthDate = new DateTime(2006, 7, 22)
        },
        new ArrayList {8,4,9}
    },
    {
        new Student
        {
            GroupID = 3,
            FirstName = "Joey",
            LastName = "Finch",
            BirthDate = new DateTime(1996, 11, 30)
        },
        new ArrayList{7,9,6}
    },
    {
        new Student
        {
            GroupID = 2,
            FirstName = "Nicole",
            LastName = "Taylor",
            BirthDate = new DateTime(1996, 5, 10)
        },
        new ArrayList {12,11,10}
    }
};


SetGrade("Finch", 8);
RatingList();

void RatingList()
{
    Console.WriteLine("Student list -> grades:");
    foreach (Student student in group.Keys)
    {
        Console.Write($"{student}: ");
        foreach (int  item in (group[student] as ArrayList))
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}

void SetGrade(string name, int grade)
{
    Console.WriteLine($"Student {name} got a grade {grade}\n");
    foreach (Student item in group.Keys)
    {
        if(item.LastName == name)
        {
            (group[item] as ArrayList).Add(grade);
        }
    }
}