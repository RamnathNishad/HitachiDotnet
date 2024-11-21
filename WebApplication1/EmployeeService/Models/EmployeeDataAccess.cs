using Microsoft.EntityFrameworkCore;

namespace EmployeeService.Models
{
    public interface IEmployeeDataAccess
    {
        List<Employee> GetAll();
        Employee Get(int id);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee);
    }
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        EmployeeDbContext dbCtx;
        public EmployeeDataAccess(EmployeeDbContext dbContext)
        {
            this.dbCtx = dbContext;
            
        }

        public void AddEmployee(Employee employee)
        {
            dbCtx.tbl_employees.Add(employee);
            dbCtx.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var record=dbCtx.tbl_employees.Find(id);
            if (record != null)
            {
                dbCtx.tbl_employees.Remove(record);
                dbCtx.SaveChanges();
            }
            else
            {
                throw new Exception("Record not found,could not delete");
            }
        }

        public Employee Get(int id)
        {
            var record= dbCtx.tbl_employees.Find(id);
            if (record == null)
            {
                throw new Exception("ecode not found");
            }
            else
            {
                return record;
            }
        }

        public List<Employee> GetAll()
        {           
            return dbCtx.tbl_employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            //var record = dbCtx.tbl_employees.Find(employee.Ecode);
            //if (record != null)
            //{
            //    //Update the values
            //    record.Ename = employee.Ename;
            //    record.Salary = employee.Salary;
            //    record.Deptid = employee.Deptid;

            //    dbCtx.SaveChanges();
            //}
            //else
            //{
            //    throw new Exception("Record not found, could not update");
            //}

            //call stored procedure
            var ec = employee.Ecode;
            var sal = employee.Salary;

            dbCtx.Database.ExecuteSqlInterpolated($"exec sp_updatesal @ec={ec},@sal={sal}");
        }
    }
}
