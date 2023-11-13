using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease
{
    public class Person
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string family;

		public string Family
		{
			get { return family; }
			set { family = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set 
			{
				if (value < 0 || value > 100)
				{
					throw new ArgumentException("Invalid age");
				}
				age = value; 
			}
		}

		private double salary;

		public double Salary
		{
			get { return salary; }
			set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Invalid salary");
                }
                salary = value; 
			}
		}

        public Person(string name, string family, int age, double salary)
        {
            this.Name = name;
			this.Family = family;
			this.Age = age;
			this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{name} {family} get {salary:f2} leva";
        }

		public void IncreaseSalary(int percent)
		{ 
			if(age > 30) salary += salary * percent / 100;
			else salary += salary * percent / 200;
        }

    }
}
