namespace Eterna.Models
{
    public class TeamTrainer
    {
        public int Id{ get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedinUrl { get; set; }


        public int TeamPositionID { get; set; }
        public TeamPosition TeamPosition { get; set; }  
    }
}
