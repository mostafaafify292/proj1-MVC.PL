using Microsoft.EntityFrameworkCore;
using Proj1_MVC.DAL.Data;
using Proj1_MVC.DAL.Models;
using Proj1_MVC.PLL.Interfacies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_MVC.PLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AddDbContext _dbContext;
        public DepartmentRepository(AddDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Department department)
        {
            _dbContext.departments.Add(department);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _dbContext.departments.Remove(department);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbContext.departments.AsNoTracking().ToList();
        }

        public Department GetById(int id)
        {
            //var department = _dbContext.departments.Where(d=>d.id == id).FirstOrDefault();
            return _dbContext.departments.Find(id);
        }

        public int Update(Department department)
        {
           _dbContext.departments.Update(department);
            return _dbContext.SaveChanges();
        }
    }
}
