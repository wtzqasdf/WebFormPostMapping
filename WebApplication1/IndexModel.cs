using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1
{
    public class IndexModel
    {
        [Column("tboxName")]
        public string Name { get; set; }

        [Column("tboxAge")]
        public int Age { get; set; }

        [Column("tboxBirthday")]
        public DateTime? Birthday { get; set; }

        [Column("lboxGender")]
        public Gender Gender { get; set; }
    }
}