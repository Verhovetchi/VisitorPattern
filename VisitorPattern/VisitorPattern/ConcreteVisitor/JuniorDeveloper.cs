using System;

namespace VisitorPattern
{
     class JuniorDeveloper : IDeveloper
     {
          public void Visit(ProjectClass projectClass) => Console.WriteLine("Writing bad class!");

          public void Visit(DataBase dataBase) => Console.WriteLine("Drop database!");

          public void Visit(Test test) => Console.WriteLine("Create not good test!");
     }
}
