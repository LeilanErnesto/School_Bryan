using school.DB.Entidades;
using school.DB.Models;

namespace school.DB.Interfaces
{
    public interface IStudentDao
    {
        void SaveStudent(Student student);
        void UpdateStudent(Student student);
        void RemoveStudent(Student student);
        List<StudentModel> GetStudents();
        StudentModel GetStudentById(int studentId);
    }
}
