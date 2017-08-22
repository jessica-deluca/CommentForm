using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentForm.Models
{
    public class CommentFormViewModel
    {
        public Comment Comment { get; set; } //object of comment
        public Procedure Procedure { get; set; } //object of procedure
    }
}