using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret_uygula.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        
        public string ProductPicture { get; set; }
        public int ProductPrice { get; set; }
        public int CategoryId { get; set; }
        virtual public Category Category {  get; set; }
        [NotMapped]
        public IFormFile ImageUpload { get; set; }
    }
}
