using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options) : base(options) { }

        public virtual DbSet<EmployeeEntity> EmployeesEntities {  get; set; }   
    }
}
