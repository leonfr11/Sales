using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Salesman")]
        [ForeignKey("Salesman")]
        public int SalesmanId { get; set; }
        public virtual Salesman Salesman { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
