using System.Diagnostics;

namespace EmployeesList
{
    public class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string job;

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        private string deparment;

        public string Deparment
        {
            get { return deparment; }
            set { deparment = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Employee(string name, decimal salary, string job, string deparment, string email = "n/a", int age = -1 )
        {
            this.Name = name;
            this.Salary = salary;
            this.Job = job; 
            this.Deparment = deparment;
            this.Email = email;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{name} {salary} {job} {deparment} {email} {age}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());
            int result = -42;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();

                var email = int.TryParse(line[4], out result) ? "n/a" : line[4];

                int age = -1;
                if (email == "n/a") age = int.Parse(line[4]);
                else if (line.Count() == 6) age = int.Parse(line[5]);
                // else age = int.Parse(line[4]);

                employees.Add(new Employee
                (
                    name: line[0], 
                    salary: decimal.Parse(line[1]),
                    job: line[2],
                    deparment: line[3],
                    email: email,
                    age: age
                ));
            }

            decimal maxAvr = 0;
            string depName = "";

            // Deparments Names
            var depNames = employees.GroupBy(x => x.Deparment).ToList();
            foreach (var dep in depNames) 
            {
                var agv = dep.Average(x => x.Salary);
                if (agv > maxAvr)
                {
                    maxAvr = agv;
                    depName = dep.Key;
                }
            }

            // Employees with max agerage salary
            Console.WriteLine($"Highest Average Salary: {depName} {maxAvr}");
            var emplArgSal = employees.Where(x => x.Deparment == depName).ToList();
            foreach(var empl in emplArgSal) 
            { 
                Console.WriteLine(empl); 
            }
        }
    }
}