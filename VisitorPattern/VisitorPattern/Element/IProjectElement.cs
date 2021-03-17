using System;

namespace VisitorPattern
{
     interface IProjectElement
     {
          void Accept(IDeveloper developer);
     }
}
