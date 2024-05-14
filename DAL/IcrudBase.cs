using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public interface ICrudBase<T>
    {
        string Add(T entity);
        string Delete(T entity);
        string Update(T entity);
        List<T> GetAll();
    }
}
