using school.DB.Entidades;
using school.DB.Models;


namespace school.DB.Interfaces
{
    public interface IInstructorDao
    {
        void SaveInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
        void RemoveInstructor(Instructor instructor);
        List<InstructorModel> GetInstructors();
        InstructorModel GetInstructorById(int instructorId);
    }
}
