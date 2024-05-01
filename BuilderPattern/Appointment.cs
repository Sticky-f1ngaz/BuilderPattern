using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Appointment
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? BloodGroup { get; set; }
        public List<string> Symptoms { get; set; }
        public List<string> OtherConditions { get; set; }
    }
}
