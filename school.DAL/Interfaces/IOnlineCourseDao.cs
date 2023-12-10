using school.DB.Entidades;
using school.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DB.Interfaces
{
    public interface IOnlineCourseDao
    {
        void SaveOnlineCourse(OnlineCourse onlineCourse);
        void UpdateOnlineCourse(OnlineCourse onlineCourse);
        List<OnlineCourseModel> GetOnlineCourses();
        OnlineCourseModel GetOnlineCourseById(int onlineCourseId);
    }
}
