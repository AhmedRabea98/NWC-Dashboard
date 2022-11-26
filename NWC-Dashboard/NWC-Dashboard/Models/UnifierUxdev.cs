using System;
using System.Collections.Generic;

#nullable disable

namespace NWC_Dashboard.Models
{
    public partial class UnifierUxdev
    {
        public int Id { get; set; }
        public string RecordNo { get; set; }
        public string Title { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UuuRecordLastUpdateDate { get; set; }
        public int? ProcessStatus { get; set; }
        public string Status { get; set; }
        public int? CreatorId { get; set; }
        public int? ProjectId { get; set; }
        public int? AttachCnt { get; set; }
        public int? Reason { get; set; }
        public decimal? Amount { get; set; }
        public decimal? DelivServConWwYear { get; set; }
        public decimal? DelivNetWwYear { get; set; }
        public string DelivType { get; set; }
        public decimal? DelivNetWwMonth { get; set; }
        public decimal? DelivConWwMonth { get; set; }
        public string Umuyearpd { get; set; }
        public decimal? DelivServConWYear { get; set; }
        public string FypNwcCluster { get; set; }
        public string Umumonthpd { get; set; }
        public decimal? DelivServPerCon { get; set; }
        public DateTime? UuuCreationDate { get; set; }
        public decimal? DelivConWMonth { get; set; }
        public decimal? DelivNetWMonth { get; set; }
        public decimal? DelivNetWYear { get; set; }
        public decimal? DelivConWYear { get; set; }
        public decimal? DelivServConWMonth { get; set; }
        public string DisiText { get; set; }
        public decimal? DelivConWwYear { get; set; }
        public decimal? DelivServConWwMonth { get; set; }
        public decimal? DelivAllServWwYear { get; set; }
        public string FypNwcRegion { get; set; }
        public decimal? DelivAllServWYear { get; set; }
    }
}
