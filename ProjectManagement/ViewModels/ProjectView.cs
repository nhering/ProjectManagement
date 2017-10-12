using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagement.Models;
using ProjectManagement.DAL;

namespace ProjectManagement.ViewModels
{
    public class ProjectView
    {
        PMContext db = new PMContext();

        public Project project { get; set; }
        public IEnumerable<Card> Pending { get; set; }
        public IEnumerable<Card> Active { get; set; }
        public IEnumerable<Card> Completed { get; set; }
        public IEnumerable<Card> Confirmed { get; set; }

        public ProjectView(Project project)
        {
            this.project = project;
            var cards = db.Cards.Where(c => c.ProjectID == project.ProjectID).ToList();
            
            if (cards.Count() > 0)
            {
                Pending = cards.Where(c => c.Status == CardStatus.Pending).ToList();
                Active = cards.Where(c => c.Status == CardStatus.Active).ToList();
                Completed = cards.Where(c => c.Status == CardStatus.Completed).ToList();
                Confirmed = cards.Where(c => c.Status == CardStatus.Confirmed).ToList();
            }
        }
    }
}