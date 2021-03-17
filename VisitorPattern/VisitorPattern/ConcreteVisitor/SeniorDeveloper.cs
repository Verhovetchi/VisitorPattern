using System;

namespace VisitorPattern
{
     class SeniorDeveloper : IDeveloper
     {
          public void Visit(ProjectClass projectClass) => Console.WriteLine("Rewrite junior class!");

          public void Visit(DataBase dataBase) => Console.WriteLine("Fixing databese!");

          public void Visit(Test test) => Console.WriteLine("Create good test!");
     }
}
