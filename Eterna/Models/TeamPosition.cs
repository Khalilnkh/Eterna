using System.Collections.Generic;

namespace Eterna.Models
{
    public class TeamPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeamTrainer> TeamTrainers { get; set; }
    }
}
