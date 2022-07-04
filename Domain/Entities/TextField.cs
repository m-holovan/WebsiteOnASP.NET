using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name of the page(title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Content is filled by the administrator";
    }
}
