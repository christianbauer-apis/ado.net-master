using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Hospital
{
    class Medical
    {
        MedicalDAL odb = new MedicalDAL();
        public string PrescriptionName { get; set; }
        public string Name { get; set; }
        public int pId { get; set; }
        public int cId { get; set; }
        public string Dosage { get; set; }
        

        public Medical(int pid, string prescription, string dosage)

        {
            pId = pid;
            PrescriptionName = prescription;
            Dosage = dosage;
        }

        public Medical(int cid, string name)
        {
            cId = cid;
            Name = name;
        }

        public Medical(string name)
        {
            Name = name;
        }
        public int addPrescription(Medical m)
        {
            return odb.insertPrescription(m);
        }

        public int addCondition(Medical m)
        {
            return odb.insertCondition(m);
        }

        public int deletePrescription(Medical m)
        {
            return odb.deletePrescription(m);
        }

        public int deleteCondition(Medical m)
        {
            return odb.deleteCondition(m);
        }

        public DataTable conditionView(Medical m)
        {
            return odb.conditionView(m);
        }

        public DataTable prescriptionView(Medical m)
        {
            return odb.prescriptionView(m);
        }
      
    }

    
}
