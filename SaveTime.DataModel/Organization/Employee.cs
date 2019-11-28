using SaveTime.DataModel.Dictionary;
using SaveTime.DataModel.Marker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTime.DataModel.Organization
{
    public class Employee : IEntity, IAccountOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public IList<Service> Services { get; set; } /*= new List<Service>();*/

        //Два примера
        public Employee()
        {
            Services = new List<Service>();
        }
    }
}
