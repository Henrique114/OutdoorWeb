using Outdoor.Interfaces;

namespace Outdoor.Models
{
    public class CulturalEventModel : IEntity
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string place { get; set; }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }  

    }
}
