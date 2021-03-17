using System;

namespace VisitorPattern
{
     public class Test : IProjectElement
     {
          public void Accept(IDeveloper developer) => developer.Visit(this);
     }
}
