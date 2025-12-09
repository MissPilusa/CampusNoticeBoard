using Microsoft.AspNetCore.Mvc;
using Announcement.Models;
using Announcement.DataStructures;

namespace CampusNoticeBoard.Controllers
{
    public class BoardController : Controller
    {
        //Create a refernece for all data structures
        private static AnnouncementStack _annStack = new AnnouncementStack();
        private static NoticeQueue _noticesQueue = new NoticeQueue();
        private static EventPriorityQueue _eventQueue = new EventPriorityQueue();

        //will return the latest announcement/event/ top items from our data
        public IActionResult Index()
        {
            //pass the latest announcement, next notice and top event 
            ViewBag.LatestAnnouncement = _annStack.Peek();
            ViewBag.NextQueue = _noticesQueue.Peek();
            ViewBag.TopEvent = _eventQueue.Peek();
            return View();
        }

        public IActionResult Announcement()
        {
            //grab all the announcement by the latest/top 
            return View("~/Views/Announcement/Announcements.cshtml", _annStack.GetAnnouncements());
        }

        //give the user the ability to add a new announcement
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View("~/Views/Announcement/AddAnnouncement.cshtml");
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcements announcements)
        {
            _annStack.Add(announcements);
            return RedirectToAction("Announcement");
        }

        public IActionResult RemoveAnnouncement()
        {
            _annStack.RemoveLatest();
            return RedirectToAction("Announcement");
        }

        //Queue
        //Show all queues
        public IActionResult Notices()
        {
            return View("~/Views/Notice/Notices.cshtml", _noticesQueue.GetNotices());
        }

        //show the form to user
        [HttpGet]
        public IActionResult AddNotice()
        {
            return View("~/Views/Notice/AddNotice.cshtml");
        }

        [HttpPost]
        public IActionResult AddNotice(Notice notice)
        {
            _noticesQueue.Add(notice);
            return RedirectToAction("Notices");
        }

        public IActionResult RemoveNotice()
        {
            _noticesQueue.RemoveLatest();
            return RedirectToAction("Notices");
        }

        //Event
        public IActionResult Events()
        {
            return View("~/Views/Event/Event.cshtml", _eventQueue.GetAll());
        }

        //show the form to user
        [HttpGet]
        public IActionResult AddEvents()
        {
            return View("~/Views/Event/AddEvent.cshtml");
        }

        [HttpPost]
        public IActionResult AddEvent(Event e)
        {
            _eventQueue.Add(e);
            return RedirectToAction("Events");
        }

        public IActionResult RemoveEvents()
        {
            _eventQueue.RemoveHighestPriority();
            return RedirectToAction("Events");
        }
    }
}
