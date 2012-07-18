using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestPoject.Authorization.Domain
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public DateTime DayOfBirth { get; set; }

        public Guid GenderId { get; set; }

        public Guid MatrialStatusId { get; set; }
    }
}