using MVCEFAPP.Models;

using Microsoft.EntityFrameworkCore;

namespace MVCEFAPP.Models

{

    public class RepositoryDoctor

    {

        public static List<Doctor> GetDoctors()

        {

            HospitalDbContext ctx = new HospitalDbContext();

            var list = ctx.Appointment.ToList();

            return list;

        }

        public static Doctor GetDoctorById(int id)

        {

            HospitalDbContext ctx = new HospitalDbContext();

            var doctor = ctx.Appointment.Find(id);

            return doctor;

        }

        public static void AddNewDoctor(Doctor doctor)

        {

            HospitalDbContext ctx = new HospitalDbContext();

            ctx.Appointment.Add(doctor);

            ctx.SaveChanges();

        }

        public static void ModifyDoctor(Doctor doctor)

        {

            HospitalDbContext ctx = new HospitalDbContext();

            ctx.Entry(doctor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            ctx.SaveChanges();

        }

        public static void RemoveDoctor(int id)

        {

            HospitalDbContext ctx = new HospitalDbContext();

            Doctor doctor = ctx.Appointment.Find(id);

            ctx.Appointment.Remove(doctor);

            ctx.SaveChanges();

        }

    }

}
