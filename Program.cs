namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomCollection collection = new CustomCollection();
            string choice;

            do
            {
                Console.WriteLine("Employeni elave et:");
                Console.WriteLine("Id Employer:");
                Console.WriteLine("All Employers");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Ad: ");
                        string name = Console.ReadLine();
                        Console.Write("Soyad: ");
                        string surname = Console.ReadLine();
                        Console.Write("Yaş: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Maaş: ");
                        decimal salary = Convert.ToDecimal(Console.ReadLine());

                        collection.AddPerson(new Employee(name, surname, age, salary));
                        break;
                    case 2:
                        Console.Write("İd: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Person employee = collection.FindEmployeeById(id);
                        if (employee != null)
                        {
                            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}, Salary: {((Employee)employee).Salary}");
                        }
                        else
                        {
                            Console.WriteLine("İstifadəçi tapılmadı.");
                        }
                        break;
                    case 3:
                        collection.DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Düzgün secim et.");
                        break;
                }

                Console.Write("Davam etmək istəyirsiniz? (yes/no): ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "yes");





        }
    }
}