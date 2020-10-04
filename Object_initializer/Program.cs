using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		var student1 = new Student() { StudentID = 1, StudentName = "John" };
		var student2 = new Student() { StudentID = 2, StudentName = "Steve" };
		var student3 = new Student() { StudentID = 3, StudentName = "Bill" };
		var student4 = new Student() { StudentID = 3, StudentName = "Bill" };
		var student5 = new Student() { StudentID = 5, StudentName = "Ron" };

		IList<Student> studentList = new List<Student>() {
													student1,
													student2,
													student3,
													student4,
													student5
												};

		Console.WriteLine("Total Students: {0}", studentList.Count);
	}
}

public class Student
{
	public int StudentID { get; set; }
	public string StudentName { get; set; }

}