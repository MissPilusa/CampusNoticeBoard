namespace Announcement.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

        public int Priority { get; set; }  //how urgent 
        // 1 = highest priority and 5 = lowest priority 

        public DateTime Date { get; set; }
    }
}
