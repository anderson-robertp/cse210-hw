using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments assign = new Assignments("Samuel Bennett", "Multilpication");
        MathAssignments mathAssign = new MathAssignments("Robert Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        assign.GetSummary();
        mathAssign.GetSummary();
        mathAssign.GetHomeworkList();
        WritignAssignments writeAssign = new WritignAssignments("Mary Waters", "European History", "The Causes of World War II");
        writeAssign.GetSummary();
        writeAssign.GetWritingInformation();
    }
}