
using System.Collections.Generic;

namespace App_Models.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int age  { get; set; }
        public string email { get; set; }
        public string patientphone { get; set; }

        public string DoctorsVisited { get; set; }

        public List<Doctor> Doctors { get; set; }
    }

    public class MedicineRecord
    {
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }

        public int PatientID { get; set; }
        public int DoctorID { get; set; }

        public bool MedicineFlag { get; set; }


        public List<Patient> Patients { get; set; }
    }

    public class MedicineRegulation
    {
        public int MedicineID { get; set; }
        public string Regulation { get; set; }
        public decimal Price { get; set; }
        public bool MedicineFlag { get; set; }
        public List<MedicineRecord> MedicineRecords { get; set; }
    }

    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorFname { get; set; }
        public string DoctorLname { get; set; }
        public string DoctorContactNum { get; set; }

        public  string NumberOfVisits { get; set; }

        public List<Appointment> Appointments { get; set; }
    }

    public class Appointment
    {
        public int DoctorID { get; set; }
        public string PatientFname { get; set; }
        public string PatientLname { get; set; }
        public int age { get; set; }

        public System.DateTime DateVisited { get; set; }

        public int PatientID { get; set; }

        public List<Doctor> Doctors { get; set; }

    }

}
