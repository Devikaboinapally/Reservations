using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.rep
{
    public interface resinterface
    {
        List<Class2> GetResDetails();
        string InsertResDetails(Class2 Sl_No);
        string DeleteResDetails(int Sl_No);
        string UpdateResDetails(Class2 sl_No);
    }
    class ResDetails : resinterface
    {
        SQLEntities4 Sb = new SQLEntities4();
        List<Class2> resinterface.GetResDetails()
        {
            List<Class2> EmpList = null;
            EmpList = Sb.Reservations.Select(s => new Class2()
            {
                Sl_No = s.Sl_No,
                Hotel = s.Hotel,
                Arrival = s.Arrival,
                Departure = s.Departure,
                Type = s.Type,
                Guests = s.Guests,
                Price = s.Price


            }).ToList<Class2>();
            return EmpList;
        }

        string resinterface.InsertResDetails(Class2 Sl_No)
        {
            var abc = Sb.Reservations.Where(i => i.Sl_No == Sl_No.Sl_No).FirstOrDefault();
            if (abc == null)
            {
                Sb.Reservations.Add(new Reservation
                {
                    Sl_No = Sl_No.Sl_No,
                    Hotel = Sl_No.Hotel,
                    Arrival = Sl_No.Arrival,
                    Departure = Sl_No.Departure,
                    Type = Sl_No.Type,
                    Guests = Sl_No.Guests,
                    Price = Sl_No.Price
                });
                Sb.SaveChanges();
                Sb.Dispose();
                return "inserted";
            }
            else
            {
                abc.Sl_No = Sl_No.Sl_No;
                abc.Hotel = Sl_No.Hotel;
                abc.Arrival = Sl_No.Arrival;
                abc.Departure = Sl_No.Departure;
                abc.Type = Sl_No.Type;
                abc.Guests = Sl_No.Guests;
                abc.Price = Sl_No.Price;
            }
            Sb.SaveChanges();
            return "updated";
        }
        string resinterface.DeleteResDetails(int Sl_No)
        {
            var abc = Sb.Reservations.Where(u => u.Sl_No == Sl_No).FirstOrDefault();
            if (abc != null)
            {
                Sb.Reservations.Remove(abc);
            }
            Sb.SaveChanges();
            return "Succesfully Deleted";
        }
        public string UpdateResDetails(Class2 Sl_No)
        {
            var abc = Sb.Reservations.Where(i => i.Sl_No == Sl_No.Sl_No).FirstOrDefault();
            if (abc != null)
            {
                abc.Sl_No = Sl_No.Sl_No;
                abc.Hotel = Sl_No.Hotel;
                abc.Arrival = Sl_No.Arrival;
                abc.Departure = Sl_No.Departure;
                abc.Type = Sl_No.Type;
                abc.Guests = Sl_No.Guests;
                abc.Price = Sl_No.Price;
            }
            Sb.SaveChanges();
            return "Updated";
        }

    }
}