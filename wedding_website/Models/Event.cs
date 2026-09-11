using System.ComponentModel.DataAnnotations;

namespace wedding_website.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }

        public Event(int id, string title, DateTime startTime, string location, string address)
        {
            Id = id;
            Title = title;
            StartTime = startTime;
            Location = location;
            Address = address;
        }
    }
}
