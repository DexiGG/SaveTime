using SaveTime.DataModel.Business;
using SaveTime.DataModel.Marker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTime.DataModel.Organization
{
    public class Account : IEntity
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public IList<IAccountOwner> IAccountOwners { get; set; }
        public Account()
        {
            IAccountOwners = new List<IAccountOwner>();
        }
    }
}
