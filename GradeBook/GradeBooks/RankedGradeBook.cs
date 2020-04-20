using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;

namespace GradeBook.GradeBooks

{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}