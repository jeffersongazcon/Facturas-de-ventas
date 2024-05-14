using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public interface IcrudBase <T>
    {
        string Add (T ENTITY);
        string Delete (T ENTITY);
        string Update (T ENTITY);
        List<T> GetAll ();
    }
}
