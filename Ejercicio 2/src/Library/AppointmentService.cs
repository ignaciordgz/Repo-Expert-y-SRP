using System;
using System.Text;

// La clase AppointmentService Rompía con el Principio de SRP, debido a que tiene demasiadas responsabilidades para una clase.
// Separamos los atributos para que sea mas fácil de leer y no haya tantos parametros en los metodos de las clases.

namespace Library
{
    // Informacion de el cliente
    public class Info
    {
        public string Name { get; set;}
        public string Id { get; set;}
        public string PhoneNumber { get; set;}

        public Info(string name, string id, string phoneNumber)
        {
            Name = name;
            Id = id;
            PhoneNumber = phoneNumber;
        }
    }
    // Informacion de la consulta
    public class AppointmentInfo
    {
        public DateTime Date { get; set;}
        public string AppointmentPlace { get; set;}
        public string DoctorName { get; set;}

        public AppointmentInfo(DateTime date, string appoinmentPlace, string doctorName)
        {
            DateTime Date = date;
            AppointmentPlace = appoinmentPlace;
            DoctorName = doctorName;
        }
    }
    
    // Clase con la responsabilidad de Validar la informacion ingresada
    public class Valid
    {
        public static bool Validation(Info info, AppointmentInfo appointment)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(info.Name))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(info.Id))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(info.PhoneNumber))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.AppointmentPlace))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.DoctorName))
            {
                isValid = false;
            }
        
            return isValid;
        }
    }
    // Clase para enviar mensaje si se valida toda la informacion
    public class Appointment
    {
        public string Schedule(Info info, AppointmentInfo appointment)
        {
            return "Appointment Scheduled";
        }
    }
    // Crea la Consulta
    public class AppointmentService
    {
        public static string CreateAppointment(Info info, AppointmentInfo appointment)
        {
            bool isValid = Valid.Validation(info,appointment);

            if (isValid)
            {
                Appointment appointment1 = new Appointment();
                string message = appointment1.Schedule(info,appointment);
                return message;
            }
            else
            {
                return "Cant make an Appointment, Invalid Info";
            }
        }
    }
}
