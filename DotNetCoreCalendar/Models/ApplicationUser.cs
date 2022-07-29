using Microsoft.AspNetCore.Identity;

namespace DotNetCoreCalendar.Models
{
    public class ApplicationUser:IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
