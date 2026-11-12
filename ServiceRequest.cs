using System;

namespace MunicipalServices
{
    public class ServiceRequest
    {
        public int RequestId { get; set; } // Unique Identifier (used for AVL Tree)
        public string IssueType { get; set; }
        public string Location { get; set; }
        public int Priority { get; set; } // 1 = High, 2 = Med, 3 = Low (used for Min-Heap)
        public string Status { get; set; }
        public DateTime DateLogged { get; set; }

        public ServiceRequest(int id, string type, string location, int priority, string status)
        {
            RequestId = id;
            IssueType = type;
            Location = location;
            Priority = priority;
            Status = status;
            DateLogged = DateTime.Now;
        }
    }

    // Used for the Graph/MST
    public class Edge
    {
        public int Source { get; set; }
        public int Destination { get; set; }
        public int Weight { get; set; } // Represents distance or dependency

        public Edge(int source, int destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}