using CuongkientrucContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWeek.DAL
{
    class RamDAO
    {
        CuongkientrucDataContext db = new CuongkientrucDataContext("SERVER=den1.mssql7.gear.host;DATABASE=cuongkientruc;USER=cuongkientruc;PASSWORD=quoccuongc114%");

        public List<Ram> SelectAll()
        {
            List<Ram> rams = db.Rams.ToList();
            return rams;
        }
        public List<Ram> NameSearch(String nameSearch)
        {
            List<Ram> rams = db.Rams.Where(x => x.Name.Contains(nameSearch)).ToList();
            return rams;
        }
        public bool Update(Ram newRam)
        {
            Ram dbram = db.Rams.SingleOrDefault(x => x.Code == newRam.Code);
            if(dbram != null)
            {
                dbram.Name = newRam.Name;
                dbram.Price = newRam.Price;
                dbram.Bus = newRam.Bus;
                dbram.Type = newRam.Type;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public Ram GetDetails(int code)
        {
            Ram ram = db.Rams.SingleOrDefault((x => x.Code == code));
            return ram;
        }
        public bool DeleteProd(int code)
        {
            Ram dbram = db.Rams.SingleOrDefault((x => x.Code == code));
            if(dbram!= null)
            {
                try
                {
                    db.Rams.DeleteOnSubmit(dbram);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public bool Insert(Ram newRam)
        {
            try
            {
                db.Rams.InsertOnSubmit(newRam);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
