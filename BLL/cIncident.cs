using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cIncident
    {
        public int IncidentId { get; set; }
        public string Incident { get; set; }
        public string IncidentPhone { get; set; }
        public string IncidentName { get; set; }
        public DateTime Time { get; set; }
        public string IncidentLocation { get; set; }
        public decimal IncidentLatitude { get; set; }
        public decimal IncidentLongtitude { get; set; }
        public string Priority { get; set; }
        public string IncidentType { get; set; }
        public string infoLocation { get; set; }
        public decimal infoLatitude { get; set; }
        public decimal infoLongtitude { get; set; }
        public string NavigationNotes { get; set; }
        public string SpecialConsideration { get; set; }
        public string Casualties { get; set; }
        public string PatientName { get; set; }
        public int UniqueID { get; set; }
        public int Age { get; set; }
        public int AgeUnit { get; set; }
        public string Gender { get; set; }
        public string PatientPhone { get; set; }
        public string PatientNotes { get; set; }
    }
}
