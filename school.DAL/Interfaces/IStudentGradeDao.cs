using school.DB.Entidades;
using school.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DB.Interfaces
{
    public interface IStudentGradeDao
    {
        
        void SaveStudentGrade(StudentGrade studentGrade);
        void UpdateStudentGrade(StudentGrade studentGrade);
        /*void RemoveStudentGrade(StudentGrade studentGrade);*/
        List<StudentGradeModel> GetStudentGrades();
        StudentGradeModel GetStudentGradeById(int studentGradeId);
    }
}
