using System.ComponentModel.DataAnnotations;

namespace DotNetCoreCalendar.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //relation data
        public virtual Location Location { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Event(IFormCollection form, Location location)
        {
            Name = form["Event.Name"].ToString();
            Description = form["Event.Description"].ToString();
            StartTime = DateTime.Parse(form["Event.StartTime"].ToString());
            EndTime = DateTime.Parse(form["Event.EndTime"].ToString());
            Location = location;
        }
        public void UpdateEvent(IFormCollection form, Location location)
        {
            Name = form["Event.Name"].ToString();
            Description = form["Event.Description"].ToString();
            StartTime = DateTime.Parse(form["Event.StartTime"].ToString());
            EndTime = DateTime.Parse(form["Event.EndTime"].ToString());
            Location = location; 
        }
        public Event()
        {

        }
        
    }
}
