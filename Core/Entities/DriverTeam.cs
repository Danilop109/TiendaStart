using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Entities
{
    public class DriverTeam
    {
        public int IdTeamFk { get; set; }
        public Team Team {get; set;}
        public int IdDriverFk {get; set;}
        public Driver Driver {get; set;}
    }
}