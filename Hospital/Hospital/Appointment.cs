using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hospital
{
    class Appointment
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public int DID { get; set; }
        public DateTime Date { get; set; }
        AppointmentDAL odb = new AppointmentDAL();


        public Appointment(int pid, int did, DateTime date)
        {
            PID = pid;
            DID = did;
            Date = date;
        }

        public Appointment(int id)
        {
            ID = id;
        }

        public int addAppointment(Appointment a)
        {
            return odb.insertAppointment(a);
        }

        public int deleteAppointment(Appointment a)
        {
            return odb.deleteAppointment(a);
        }

        public DataTable appointmentShow(Appointment a)
        {
            return odb.showAppointments(a);
        }
    }
}
