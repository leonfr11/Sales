using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Salesman
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
