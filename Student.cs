using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesTests
{
    public class Student
    {
        public string Name;
        public int Marks;
        public string Result { get; set; }

        public Student(string sName, int sMarks)
        {
            Name = sName;
            Marks = sMarks;
            Result = fResult(sMarks);
            
        }
        public string fResult(int iMarks)
        {
            if(iMarks < 35) 
            {
                Result = "Fail";
            }
            else { Result = "Pass"; }
            return Result;
        }
    }
}
