using System;
using System.Collections.Generic;

namespace JRC_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] EmpId = new String[20];
            String[] EmpName = new String[20];
            int[] age = new int[20];
            String[] EmpDepartment = new String[20];
            int num;
            Console.WriteLine("Enter the number of employees : ");

            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {
                Console.WriteLine("Enter employee ID : ");
                EmpId[i] = Console.ReadLine();
                Console.WriteLine("Enter employee name : ");
                EmpName[i] = Console.ReadLine();

                Agelabel:
                Console.WriteLine("Enter the age of employee : ");
                age[i] = int.Parse(Console.ReadLine());
                    if (age[i] > 60) {
                    Console.WriteLine("Employee age cannot be more than 60");
                    goto Agelabel;
                    }
                Console.WriteLine("Assign employee to a department : ");
                EmpDepartment[i] = Console.ReadLine();
                Console.WriteLine();
            }

            for (int j = 0; j < num; j++) {
                Console.WriteLine("Employee ID : " + EmpId[j]);
                Console.WriteLine("Employee name : " + EmpName[j]);
                Console.WriteLine("Employee age : " + age[j]);
                Console.WriteLine("Employee department : " + EmpDepartment[j]);
                Console.WriteLine();
            }
        }
    }
}
