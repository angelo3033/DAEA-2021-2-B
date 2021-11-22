using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;
using SchoolEntities;

namespace SchoolDAL
{
    public class CPersonDAL
    {
        public List<CPerson> Listar()
        {
            using (SchoolEntities contexto = new SchoolEntities())
            {
                var query = contexto.Person.Select(p => new CPerson
                {
                    PersonID = p.PersonID,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                });
                return query.ToList();
            }
        }
    }
}
