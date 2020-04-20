using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}