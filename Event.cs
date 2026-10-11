using System;

namespace MunicipalServices
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; } // 1 = High, 2 = Medium, 3 = Low

        public override string ToString()
        {
            return $"{Title} | {Category} | {EventDate:yyyy-MM-dd} | Priority: {Priority}";
        }
    }
}