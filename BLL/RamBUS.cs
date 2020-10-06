using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuongkientrucContext;
using ExWeek.DAL;

namespace ExWeek.BLL
{
    class RamBUS
    {
        public List<Ram> getAll()
        {
            List<Ram> rams = new RamDAO().SelectAll();
            return rams;
        }
        public bool DeleteProd(int code)
        {
            bool result = new RamDAO().DeleteProd(code);
            return result;
        }
        public List<Ram> NameSearch(String nameSearch)
        {
            List<Ram> rams = new RamDAO().NameSearch(nameSearch);
            return rams;
        }
        public Ram GetDetails(int code)
        {
            Ram ram = new RamDAO().GetDetails(code);
            return ram;
        }
        public bool Update(Ram newRam)
        {
            bool result = new RamDAO().Update(newRam);
            return result;
        }
        public bool Insert(Ram newRam)
        {
            bool result = new RamDAO().Insert(newRam);
            return result;
        }
    }
}
