using Announcement.Models;

namespace Announcement.DataStructures
{
    public class NoticeQueue
    {
        //create a queue that will store notice objects in memory 
        private Queue<Notice> _queue = new Queue<Notice>();

        //create a variable that will give each notice a unique number
        private int _nextId = 1;

        //add new announcement at the top of the stack
        public void Add(Notice notice)
        {
            notice.Id = ++_nextId;
            notice.Date = DateTime.UtcNow;

            _queue.Enqueue(notice); //puts announcement at the top             

        }

        //get all notices on the stack
        public List<Notice> GetNotices()
        {
            return new List<Notice>(_queue);
        }

        //view announcement without removing
        public Notice Peek()
        {
            //return the top/most recent announcement 
            return _queue.Count > 0 ? _queue.Peek() : null;
        }

        //remove lastets announcement
        public Notice RemoveLatest()
        {
            return _queue.Count > 0 ? _queue.Dequeue() : null;
        }
    }
}
