using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication12.DAL.Interface
{
    interface IDepartment
    {
        public void insert(string name);
        public void edit(int id, string name);
        public void delete(int id);
        public bool isExistName(string name);
        public bool isUsedEmployee(int id);
        public DataTable getAll();
        public DataRow getById(int id);
    }
}
