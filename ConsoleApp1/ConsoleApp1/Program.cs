using ConsoleApp1._5._12;
using System.Collections;

Queue q1 = new Queue();
q1.Enqueue(1);
q1.Enqueue(2);
q1.Enqueue(3);
foreach (object item in q1)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine(q1.Contains(4));
foreach (object item in q1)
{
    Console.Write($"{item} ");
}
