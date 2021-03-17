using System;

namespace VisitorPattern
{
     public interface IDeveloper
     {
          void Visit(ProjectClass projectClass);

          void Visit(DataBase dataBase);
          
          void Visit(Test test);
     }
}
