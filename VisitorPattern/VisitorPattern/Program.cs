using System;

namespace VisitorPattern
{
     class Program
     {
          static void Main(string[] args)
          {
               Project project = new Project();

               IDeveloper junior = new JuniorDeveloper();
               IDeveloper senior = new SeniorDeveloper();

               Console.WriteLine("==============");
               Console.WriteLine("Junior work!");
               project.Accept(junior);
               Console.WriteLine("==============");
               
               Console.WriteLine("==============");
               Console.WriteLine("Senior work!");
               project.Accept(senior);
               Console.WriteLine("==============");

               Console.ReadKey();
          }
     }
}
