using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hospital
{
    class Doctor
    {
        DoctorDAL dd = new DoctorDAL();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        // public DateTime DoB { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Doctor(int id, string name, string phone, string title, string address)
        {
            Id = id;
            Name = name;
            Title = title;
            Address = address;
            Phone = phone;
        }

        public Doctor()
        { 
        
        }

        public Doctor(int id, DateTime startdate, DateTime endDate)
        {
            Id = id;
            StartDate = startdate;
            EndDate = endDate;
        }

        public int updateDoctor(Doctor d)
        {
            return dd.updateDoctor(d);
        }

        public int updateDoctorAvailability(Doctor d)
        {
            return dd.updateDoctorAvailability(d);
        }

        public DataTable showDoctors()
        {
            return dd.showDoctors();

        }
        public DataTable getDoctor()
        {
            return dd.getDoctor();

        }
    }
}
