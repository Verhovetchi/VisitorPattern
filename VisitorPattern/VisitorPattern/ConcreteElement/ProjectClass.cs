using System;

namespace VisitorPattern
{
     public class ProjectClass : IProjectElement
     {
          public void Accept(IDeveloper developer) => developer.Visit(this);
     }
}
