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
        public CardStatus? Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<People> PeopleAssigned { get; set; }
    }

    public enum CardStatus
    {
        Pending = 1,
        Active = 2,
        Completed = 3,
        Confirmed = 4
    }
}