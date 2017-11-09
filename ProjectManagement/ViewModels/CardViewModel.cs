using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagement.Models;
using ProjectManagement.DAL;

namespace ProjectManagement.ViewModels
{
    public class CardViewModel
    {
        public List<Comment> Comments { get; set; }


        //public class CardEditViewModel
        //{
        //    public int CardID { get; set; }
        //    public int ProjectID { get; set; }
        //    public string ProjectTitle { get; set; }
        //    public CardStatus? Status { get; set; }
        //    public string Title { get; set; }
        //    public string Description { get; set; }
        //    public People PersonAssigned { get; set; }
        //    public IEnumerable<Comment> Comments { get; set; }

        //    public CardBuilder getCard(Card aCard)
        //    {
        //        PMContext db = new PMContext();

        //        CardBuilder cardRetrieved = new CardBuilder();

        //        cardRetrieved.CardID = aCard.CardID;
        //        cardRetrieved.ProjectID = aCard.ProjectID;
        //        cardRetrieved.ProjectTitle = db.Projects
        //            .Where(p => p.ProjectID == aCard.ProjectID)
        //            .Select(p => p.Title)
        //            .ToString();
        //        cardRetrieved.Status = aCard.Status;
        //        cardRetrieved.Title = aCard.Title;
        //        cardRetrieved.Description = aCard.Description;
        //        cardRetrieved.PersonAssigned = aCard.PersonAssigned;
        //        cardRetrieved.Comments = db.Comments
        //            .Where(c => c.CardID == aCard.CardID)
        //            .OrderBy(c => c.DateTime);

        //        return (cardRetrieved);
        //    }
        //}
    }
}