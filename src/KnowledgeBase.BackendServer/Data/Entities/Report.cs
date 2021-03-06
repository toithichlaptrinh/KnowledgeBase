using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KnowledgeBase.BackendServer.Data.Interfaces;

namespace KnowledgeBase.BackendServer.Data.Entities
{
    [Table("Reports")]
    public class Report : IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int KnowledgeId { get; set; }
        
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string ReportUserId { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }

        public bool IsProcessed { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}