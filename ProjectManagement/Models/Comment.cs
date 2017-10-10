using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManagement.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int CardID { get; set; }
        public int PeopleID { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
    }
}