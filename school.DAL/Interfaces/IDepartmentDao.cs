using school.DB.Entidades;
using school.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DB.Interfaces
{
    public interface IDepartmentDao
    {
        void SaveDepartment(Department department);
        void UpdateDepartment(Department department);
        void RemoveDepartment(Department department);
        List<DepartmentModel> GetDepartments();
        DepartmentModel GetDepartmentById(int DepartmentId);
    }
}
