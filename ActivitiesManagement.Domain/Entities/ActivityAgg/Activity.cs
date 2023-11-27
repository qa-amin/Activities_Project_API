using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitiesManagement.Domain.Entities.ActivityAgg
{
    public class Activity
    {
        public Guid Id { get; private set; }
        public string  Title { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public string City { get; private set; }
        public string Venue { get; private set; }

    }
}
