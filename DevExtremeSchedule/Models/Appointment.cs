using Newtonsoft.Json;

namespace DevExtremeSchedule.Models
{
    public class Appointment
    {
        [JsonProperty(PropertyName = "AppointmentId")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "StartDate")]
        public string StartDate { get; set; }
        [JsonProperty(PropertyName = "EndDate")]
        public string EndDate { get; set; }
        [JsonProperty(PropertyName = "AllDay")]
        public bool? AllDay { get; set; }
    }


}

