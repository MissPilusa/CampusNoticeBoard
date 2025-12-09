namespace Announcement.Models
{
    public class Announcements
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string PostedBy { get; set; }

        public DateTime PostedOn { get; set; }
    }
}
