using SaveTime.DataModel.Marker;
using SaveTime.DataModel.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTime.DataModel.Business
{
   public class Record : IEntity
    {
        public int Id { get; set; }
        public int EmloyeeId { get; set; }
        public Employee Employee { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime Time { get; set; }
    }
}
