using SaveTime.DataModel.Marker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTime.DataModel.Organization
{
    public class Branch : IEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public TimeSpan StepWork { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public IList<Employee> Employees { get; set; }
        public Branch()
        {
            Employees = new List<Employee>();
        }
    }
}
