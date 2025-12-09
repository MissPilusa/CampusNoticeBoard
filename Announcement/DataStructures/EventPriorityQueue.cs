using Announcement.Models;

namespace Announcement.DataStructures
{
    public class EventPriorityQueue
    {
        //this class will store all events in a priority queue
        //in a sorted maner 
        //lower priority number means higher priority for example 1 = highest


        //create a lsit that will hold events objects
        private List<Event> _event = new List<Event>();

        //create a variavble that will give the event a unique ID
        private int _nextId = 1;

        //create a method to add an event, and store them by priority 
        public void Add(Event e)
        {
            e.Id = _nextId++;

            e.Date = DateTime.Now;
            _event.Add(e);

            //sort the event by smallest and by date
            _event = _event.OrderBy(r => r.Priority).ThenBy(r => r.Date).ToList();
        }

        public List<Event> GetAll()
        {
            return _event.ToList();
        }

        public Event Peek()
        {
            return _event.Count > 0 ? _event[0] : null;
        }

        public Event RemoveHighestPriority()
        {
            if (_event.Count == 0) return null;

            //get the highest priority event
            var highestPriority = _event[0];
            _event.RemoveAt(0);
            return highestPriority;
          
        }
    }
}
