using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient
    {
        PatientDAL pdb = new PatientDAL();
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public DateTime Date { get; set; }
        public string PrescriptionName { get; set; }
        public string Condition { get; set; }
        public string Phone { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime DischargeDate { get; set; }

        public Patient(string name, string address, string phone, DateTime dob, DateTime Admit, DateTime Discharge)
        {
            Name = name;
            Address = address;
            Phone = phone;
            DoB = dob;
            AdmitDate = Admit;
            DischargeDate = Discharge;
           
       }
        public Patient()
        {
            
        }

        public Patient(string prescription, string condition)

        {
            PrescriptionName = prescription;
       
            Condition = condition;
        }
        
        public Patient(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public Patient(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
     
        public int addPatient(Patient p)
        {
            return pdb.insertPatient(p);
        }
        public int admitPatient(Patient p)
        {
            return pdb.admitPatient(p);
        }
        public int dischargePatient(Patient p)
        {
            return pdb.dischargePatient(p);
        }
        public int updatePatient(Patient p)
        {
            return pdb.updatePatient(p);
        }
        public string getPID()
        {
            return "Your id is: " + pdb.getPID();
        }
    }

}
