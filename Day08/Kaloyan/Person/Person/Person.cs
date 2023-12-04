using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private static int counter = 0;

		public Person(string Name = "Name", int Age = 0) 
		{
			this.age = Age;
			this.name = Name;
			counter++;
		}
		public static int GetCount() 
		{
			return counter;
		}
	}
}
