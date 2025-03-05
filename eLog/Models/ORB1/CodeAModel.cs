    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

namespace eLog.Models.ORB1
{
    public class CodeAModel

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }

        [MaxLength(50)]
        public string BallastingOrCleaning { get; set; }

        public DateTime? LastCleaningDate { get; set; }

        [MaxLength(255)]
        public string OilCommercialName { get; set; }

        [MaxLength(255)]
        public string DensityViscosity { get; set; }

        [MaxLength(255)]
        public string IdentityOfTanksBallasted { get; set; }

        public bool? CleanedLastContainedOil { get; set; }

        [MaxLength(255)]
        public string PreviousOilType { get; set; }

        public decimal? QuantityBallast { get; set; }

        public TimeSpan? StartCleaningTime { get; set; }

        [MaxLength(255)]
        public string PositionStart { get; set; }

        public TimeSpan? StopCleaningTime { get; set; }

        [MaxLength(255)]
        public string PositionStop { get; set; }

        [MaxLength(255)]
        public string IdentifyTanks { get; set; }

        [MaxLength(255)]
        public string MethodCleaning { get; set; }

        [MaxLength(255)]
        public string ChemicalType { get; set; }

        public decimal? ChemicalQuantity { get; set; }

        public TimeSpan? StartBallastingTime { get; set; }

        [MaxLength(255)]
        public string BallastingPositionStart { get; set; }

        public TimeSpan? CompletionBallastingTime { get; set; }

        [MaxLength(255)]
        public string BallastingPositionCompletion { get; set; }

        [Required]
        public DateTime RecordEntryDateTime { get; set; }

        [Required]
        public DateTime RecordLastModifiedDateTime { get; set; }

        [ForeignKey("Status")]
        public int StatusID { get; set; }

        [ForeignKey("User")]
        public int ApprovedBy { get; set; }

        [MaxLength(1000)]
        public string Comments { get; set; }

        // Navigation properties for relationships
        public virtual Users User { get; set; }
        public virtual Status Status { get; set; }
        public virtual Users ApprovedByUser { get; set; }

    }
}
