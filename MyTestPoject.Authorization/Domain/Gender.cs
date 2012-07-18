using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestPoject.Authorization.Domain
{
    public class Gender
    {
        [Key]
        public Guid GenderId { get; set; }

        public string GenderName { get; set; }
    }
}