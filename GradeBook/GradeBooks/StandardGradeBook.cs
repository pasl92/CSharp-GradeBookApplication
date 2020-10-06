using System;
using System.Linq;
using GradeBook.Enums;
using System.Collections.Generic;


namespace GradeBook.GradeBooks
{
    public class StandardGradeBook  : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            Type = GradeBookType.Standard;
        }
    }
}