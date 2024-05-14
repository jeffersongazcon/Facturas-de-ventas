using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Productos : IcrudBase <Productos>
    {
        public List<Productos> productosList = new List<Productos>();

        public string Add(Productos ENTITY)
        {
            productosList.Add(ENTITY);
            return "Producto agregado exitosamente";

        }
        public string Delete(Productos ENTITY)
        {
            if (productosList.Remove(ENTITY))
                return "Producto eliminado exitosamente.";
            else
                return "Producto no encontrado.";
        }
        public string Update(Productos ENTITY)
        {
            var index = productosList.FindIndex(p => p.productosList == ENTITY.productosList);
            if (index != -1)
            {
                productosList[index] = ENTITY;
                return "Producto actualizado exitosamente.";
            }
            else
            {
                return "Producto no encontrado.";
            }
        }
        public List<Productos> GetAll()
        {
            return productosList;
        }
    }
}
