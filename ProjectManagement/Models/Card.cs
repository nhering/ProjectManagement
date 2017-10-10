using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectManagement.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public int ProjectID { get; set; }
        public CardStatus? Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public People PersonAssigned { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }

    public enum CardStatus
    {
        Pending = 1,
        Active = 2,
        Completed = 3,
        Confirmed = 4
    }
}