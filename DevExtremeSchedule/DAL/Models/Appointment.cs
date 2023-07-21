namespace DevExtremeSchedule.DAL.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool? AllDay { get; set; }
    }
}
