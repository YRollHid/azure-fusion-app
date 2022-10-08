#nullable disable
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FieldEngineerApi.Models
{
    public class AppointmentStatus
    {
        [Key]
        public long Id { get; set; }

        public string StatusName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
