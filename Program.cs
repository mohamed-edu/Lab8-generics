namespace Lab8_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 object med olika ID,Name,Gender, Salary.

            Employee employee1 = new Employee(1001.01, "Jonas", "Man", 75000);
            Employee employee2 = new Employee(1001.02, "lisa", "Femle", 35000);
            Employee employee3 = new Employee(1001.03, "Anna", "Female", 45000);
            Employee employee4 = new Employee(1001.04, "Gustav", "Man", 60000);
            Employee employee5 = new Employee(1001.05, "Helena", "Female", 50000);
           
            // en stack med 5 objekter.
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(employee1);
            stack.Push(employee3);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);
            
            // skriv ut objekterna
            foreach(Employee emp in stack )
            {
                Console.WriteLine($"id: { emp.Id } -- name: {emp.Name} -- gender: { emp.Gender} -- slary: { emp.Salary}");
                Console.WriteLine("objekt som finns kvar;" + stack.Count());
            }
            Console.WriteLine("*****************************************");

            // hämtar alla objekt i stacken genom POP()-metoden och skriver ut
            while (stack.Count > 0)
            {
                Employee poppedEmployee = stack.Pop();
                Console.WriteLine($"Id: {poppedEmployee.Id} -- Name: {poppedEmployee.Name} -- Gender: {poppedEmployee.Gender} -- Salary: {poppedEmployee.Salary}");
                Console.WriteLine($"Antal objekt kvar i stacken: {stack.Count}");       
            }
            Console.WriteLine("*****************************************");


            // lägger igen objekter i stacken
            stack.Push(employee1);
            stack.Push(employee3);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);
            
            
            // hämta två objekt med peek methoden
            Employee peekedEmployee1 = stack.Peek();
            Console.WriteLine($"Peeked: Id: {peekedEmployee1.Id} -- Name: {peekedEmployee1.Name} -- Gender: {peekedEmployee1.Gender} -- Salary: {peekedEmployee1.Salary}");
            Console.WriteLine($"Antal objekt kvar i stacken: {stack.Count}");
            Console.WriteLine("*****************************************");

            // om objekt nummer 3 finns i stacken eller inte
            Console.WriteLine(stack.Contains(employee3));
            Console.WriteLine("*****************************************");

            List<Employee> e = new List<Employee>();
            e.Add(employee1);
            e.Add(employee2);
            e.Add(employee3);
            e.Add(employee4);
            e.Add(employee5);

            if (e.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Employee firstMaleEmployee = e.Find(e => e.Gender.Equals(employee1.Gender));
            Console.WriteLine(firstMaleEmployee.Gender);

            List<Employee> maleEmployees = e.FindAll(e => e.Gender.Equals("Man"));
            if (maleEmployees.Count > 0)
            {
                Console.WriteLine("Male Employees in the list:");
                foreach (Employee maleEmp in maleEmployees)
                {
                    Console.WriteLine($"Id: {maleEmp.Id} -- Name: {maleEmp.Name} -- Gender: {maleEmp.Gender} -- Salary: {maleEmp.Salary}");

                }
                 
            }
            else
            {
                Console.WriteLine("No Male Employees found in the list");
            }
        }
    }
}