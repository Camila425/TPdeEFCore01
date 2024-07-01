using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPdeEFCore01.Entidades
{
    public class Shoe
    {
        public int ShoeId { get; set; }

        public int BrandId { get; set; }
        public Brand? brand { get; set; }

        public int SportId { get; set; }
        public Sport? sport { get; set; }

        public int GenreId { get; set; }
        public Genre? genre { get; set; }

        public int ColorId { get; set; }
        public Color? color { get; set; } = null!;

        [StringLength(150)]

        public string Model { get; set; }
        [MaxLength]
        public string Description { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public bool Active { get; set; } = true;
        public ICollection<ShoeSizes> shoeSizes { get; set; } = new List<ShoeSizes>();


    }
}
