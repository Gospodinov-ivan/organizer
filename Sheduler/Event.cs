using System;

namespace Organizer
{
    /// <summary>
    /// предоставляет абстракцию над таблицей Sheduler
    /// </summary>
    class Event
    {
        public int CODE { get; set; }
        public string EventText { get; set; }
        public DateTime Date { get; set; }
        
        public Event(int CODE, string EventText, DateTime Date)
        {
            this.CODE = CODE;
            this.EventText = EventText;
            this.Date = Date;
        }
    }
}
