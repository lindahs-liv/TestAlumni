using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
