using FinalTask.Models;
using System.Collections.Generic;

namespace FinalTask.ViewModels
{
    public class ServicesVM
    {
        public List<Contact> Contacts { get; set; }
        public List<Card> Cards { get; set; }
        public Skill Skills { get; set; }
        public List<Statistica> Statisticas { get; set; }
    }
}
