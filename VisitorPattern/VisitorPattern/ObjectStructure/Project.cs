using System;

namespace VisitorPattern
{
     public class Project : IProjectElement
     {
          IProjectElement[] projectElements;

          public Project()
          {
               projectElements = new IProjectElement[]
               {
                    new ProjectClass(),
                    new DataBase(),
                    new Test()
               };
          }

          public void Accept(IDeveloper developer)
          {
               foreach (var element in projectElements)
                    element.Accept(developer);
          }
     }
}
