using System;

namespace VisitorPattern
{
     public class DataBase : IProjectElement
     {
          public void Accept(IDeveloper developer) => developer.Visit(this);
     }
}
