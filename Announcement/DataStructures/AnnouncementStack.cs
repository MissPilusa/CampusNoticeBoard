using Announcement.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Announcement.DataStructures
{
    public class AnnouncementStack
    {
        //Create a stack that will store the announcement object in memory 
        private Stack<Announcements> _stack = new Stack<Announcements>();

        //create a variable that will give each announcement a unique number
        private int _nextId = 1;

        //add new announcement at the top of the stack
        public void Add(Announcements announcement)
        {
            announcement.Id = ++_nextId;
            announcement.PostedOn = DateTime.UtcNow;
            _stack.Push(announcement); //puts announcement at the top             

        }

        //get all announcements on the stack
        public List<Announcements> GetAnnouncements()
        {
            return new List<Announcements>(_stack);
        }

        //view announcement without removing
        public Announcements Peek()
        {
            //return the top/most recent announcement 
            return _stack.Count > 0 ? _stack.Peek() : null;
        }

        //remove lastets announcement
        public Announcements RemoveLatest()
        {
            return _stack.Count > 0 ? _stack.Pop() : null;
        }
    }
}
