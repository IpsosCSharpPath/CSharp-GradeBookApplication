﻿using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            if (averageGrade <= 20)
            {
                return 'A';
            }
            else if (averageGrade > 20 && averageGrade <= 40)
            {
                return 'B';
            }
            else if (averageGrade > 40 && averageGrade <= 60)
            {
                return 'C';
            }
            else if (averageGrade > 60 && averageGrade <= 80)
            {
                return 'D';
            }

            return 'F';
        } 
    }
}
