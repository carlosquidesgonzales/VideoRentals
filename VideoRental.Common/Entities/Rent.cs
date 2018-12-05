namespace VideoRental.Common.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Rent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int VideoId { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime RentedDate { get; set; }

        public bool IsRented { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Video Video { get; set; }
    }
}
