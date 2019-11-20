using System;
using System.Collections.Generic;
using System.Text;

namespace GreenWorld
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int PointsTotal { get; set; }
        public int[] CompletedTasksIds { get; set; }

        public string ProfileImageUrl { get; set; }

    }
}
