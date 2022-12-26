using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication12.DAL
{
    interface Idepartments
    {
        public void insert(string name);
        public void edite(string name, int id);

        public bool isexistsname(string name );

        public DataTable GeatAll();
        public DataRow Getbyid(int id);

        public void delete(int id);

        public bool isusedemployees(int id);
    }
}
