using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillSelectRestfulService.Models
{
    public class OccupationInvitation
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Ceiling { get; set; }

        public int Invitations { get; set; }

        public int Score { get; set; }

        public DateTime VisaDateofEffect { get; set; }
    }
}