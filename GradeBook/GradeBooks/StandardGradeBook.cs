using System;
using System.Linq;
using GradeBook.Enums;
using System.Collections.Generic;


namespace GradeBook.GradeBooks
{
    class StandardGradeBook  : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}