using System.ComponentModel.DataAnnotations;

namespace FurnitureApp.Models
{
    public class Service
    {

        public int Id { get; set; }
        [StringLength(30)]
        public string Icon { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(300)]

        public string Description { get; set; }
    }
}
