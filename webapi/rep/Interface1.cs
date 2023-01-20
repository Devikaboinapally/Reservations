using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.rep
{
    public interface Interface1
    {

        List<Class1> GetEmpDetails();

        string DeleteEmpDetails(int empid);
        string InsertEmpDetails(Class1 empid);
        string UpdateEmpDetails(Class1 empid);
        string BulkInsertEmpDetails(List<Class1> em);
        string BulkDeleteEmpDetails(List<Class1> em);
        entity GetEmpDetailsId(int empid);
    }

    class EmpDetails : Interface1
    {
        SQLEntities1 sb = new SQLEntities1();
        List<Class1> Interface1.GetEmpDetails()
        {
            List<Class1> EmpList = null;
            EmpList = sb.entities.Select(s => new Class1()
            {
                empid = s.empid,
                empName = s.empName,
                phoneno = s.phoneno,
                Address = s.Address,
                Designation = s.Designation,
                age = s.age

            }).ToList<Class1>();
            return EmpList;
        }
        string Interface1.InsertEmpDetails(Class1 empid)
        {
            var abc = sb.entities.Where(i => i.empid == empid.empid).FirstOrDefault();
            if (abc == null)
            { 
                sb.entities.Add(new entity
                {
                    empid = empid.empid,
                    empName = empid.empName,
                    Address = empid.Address,
                    Designation = empid.Designation,
                    age = empid.age,
                    phoneno = empid.phoneno
                });
                sb.SaveChanges();
                sb.Dispose();
            }
          
            return "inserted";
        }


        string  Interface1.DeleteEmpDetails(int empid)
        {
            var abc = sb.entities.Where(u => u.empid == empid).FirstOrDefault();
            if (abc != null)
            {
                sb.entities.Remove(abc);
            }
            sb.SaveChanges();
            return "Succesfully Deleted";
        }

        public string UpdateEmpDetails(Class1 empid)
        {
            var abc = sb.entities.Where(i => i.empid == empid.empid).FirstOrDefault();
            if (abc != null)
            {
                abc.empid = empid.empid;
                abc.empName = empid.empName;
                abc.phoneno = empid.phoneno;
                abc.Address = empid.Address;
                abc.age = empid.age;
                abc.Designation = empid.Designation;
            }
            sb.SaveChanges();
            return "Updated";
        }
        string Interface1.BulkInsertEmpDetails(List<Class1> em)
        {
            if (em.Count != 0)
            {
                foreach (var insert in em)
                {

                    sb.entities.Add(new entity
                    {
                        empid = insert.empid,
                        empName = insert.empName,
                        age = insert.age,
                        phoneno = insert.phoneno,
                        Address = insert.Address,
                        Designation = insert.Designation
                    });


                }

                sb.SaveChanges();
                sb.Dispose();
                return "Bulk inserted";
            }

            sb.SaveChanges();
            sb.Dispose();
            return "Bulk non";
        }


        public string BulkDeleteEmpDetails(List<Class1> em)
        {
            foreach (var delete in sb.entities)
            {
                sb.entities.Remove(delete);
            }
            sb.SaveChanges();
            return "Bulk deleted";
        }




        entity Interface1.GetEmpDetailsId(int empid)
        {
            var abc = sb.entities.FirstOrDefault(i => i.empid == empid);
            return abc;
        }

      
    }
}










    


























