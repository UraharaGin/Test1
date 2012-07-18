using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestPoject.Authorization.Domain
{
    public class MatrialStatus
    {
        [Key]
        public Guid MatrialStatusId { get; set; }

        public string MatrialStatusName { get; set; }
    }
}