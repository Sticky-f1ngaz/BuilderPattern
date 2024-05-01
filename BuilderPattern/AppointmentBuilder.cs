using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AppointmentBuilder
    {
        public readonly Appointment appointment = new Appointment();

        public AppointmentBuilder Name(string Name)
        {
            appointment.Name = Name;
            return this;
        }
        public AppointmentBuilder Age(int Age)
        {
            appointment.Age = Age;
            return this;
        }
        public AppointmentBuilder BloodGroup(string Blood)
        {
            appointment.BloodGroup = Blood;
            return this;
        }
        public AppointmentBuilder Symptoms(string Symptoms)
        {
            if (appointment.Symptoms is null)
            {
                appointment.Symptoms = new List<string>();
            }
            appointment.Symptoms.Add(Symptoms);
            return this;
        }

        public AppointmentBuilder OtherConditions(string Conditions)
        {
            if (appointment.OtherConditions is null)
            {
                appointment.OtherConditions = new List<string>();
            }
            appointment.OtherConditions.Add(Conditions);
            return this;
        }
        public Appointment build()
        {
            return appointment;
        }
    }
}
