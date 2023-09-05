using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Info Client1 = new Info("Steven Jhonson","986782342","5555-555-555");
            Info Client2 = new Info("Ralf Manson","","5555-555-555");

            AppointmentInfo Client1appointment = new AppointmentInfo(DateTime.Now,"Wall Street","Armand");
            AppointmentInfo Client2appointment = new AppointmentInfo(DateTime.Now,"Queen Street","");

            string appointmentResult = AppointmentService.CreateAppointment(Client1,Client1appointment);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(Client2,Client2appointment);
            Console.WriteLine(appointmentResult2);
        }
    }
}
