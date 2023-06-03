using ChalengeApp;
using System.Threading.Tasks.Sources;

Employee worker1 = new Employee("Jan", "Dzban", 24);
Employee worker2 = new Employee("Roman", "Bosy", 35);
Employee worker3 = new Employee("Żylisław", "Świerczyński-Brzęczyszczykiewicz", 55);

worker1.AddScore(5);
worker1.AddScore(4);
worker1.AddScore(5);
worker1.AddScore(4);
worker1.AddScore(5);

worker2.AddScore(5);
worker2.AddScore(2);
worker2.AddScore(4);
worker2.AddScore(5);
worker2.AddScore(4);

worker3.AddScore(5);
worker3.AddScore(6);
worker3.AddScore(2);
worker3.AddScore(5);
worker3.AddScore(5);

List<Employee> workers = new List<Employee>()
{
    worker1, worker2, worker3
};
List<Employee> employeeOfTheMonth = new List<Employee>();




int bestScore = -1;
Employee bestWorker = null;



foreach (var worker in workers)
{
    if (worker.Result > bestScore)
    {
        bestScore = worker.Result;
        bestWorker = worker;
    }
}


foreach (var worker in workers)
{
    if (worker.Result == bestWorker.Result)
    {
        bestWorker = worker;
        employeeOfTheMonth.Add(bestWorker);
    }
}

if (employeeOfTheMonth.Count == 1)
{
    Console.WriteLine("Pracownik miesiąca:");
    Console.WriteLine();
    Console.WriteLine(bestWorker.name + " " + bestWorker.surname + ", wiek: " + bestWorker.age + " lat, uzyskał wynik: " + bestWorker.Result + "pkt");
}
else
{
    Console.WriteLine("Pracownicy miesiąca:");

    foreach (var bestWorkers in employeeOfTheMonth)
    {
        Console.WriteLine();
        Console.WriteLine(bestWorkers.name + " " + bestWorkers.surname + ", wiek: " + bestWorkers.age + " lat, uzyskał wynik: " + bestWorkers.Result + "pkt");
        Console.WriteLine();
    }
}