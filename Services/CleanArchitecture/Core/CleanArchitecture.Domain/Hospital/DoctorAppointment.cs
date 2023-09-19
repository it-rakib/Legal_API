using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class DoctorAppointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int ApptSlno { get; set; }
        public DateTime ApptDate { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string ContactNo { get; set; }
        public string PatientId { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public int? PoSerial { get; set; }
        public int? DepartmentId { get; set; }
        public string AppoinmentTime { get; set; }
        public string Remarks { get; set; }
        public int? IsRegistrd { get; set; }
        public string AppointmentFor { get; set; }
        public string Sex { get; set; }
        public int? QdoctorId { get; set; }
        public int? AgeYear { get; set; }
        public int? AgeMonth { get; set; }
        public int? AgeDay { get; set; }
        public bool? Status { get; set; }
    }
}
