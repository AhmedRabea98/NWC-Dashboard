using System;
using System.Collections.Generic;

#nullable disable

namespace NWC_Dashboard.Models
{
    public partial class Project
    {
        public int ProjId { get; set; }
        public int FyStartMonthNum { get; set; }
        public string ChngEffCmpPctFlag { get; set; }
        public string RsrcSelfAddFlag { get; set; }
        public string RsrcRoleMatchFlag { get; set; }
        public string RsrcSelfAddOutFlag { get; set; }
        public string AllowCompleteFlag { get; set; }
        public string RsrcMultiAssignFlag { get; set; }
        public string CheckoutFlag { get; set; }
        public string ProjectFlag { get; set; }
        public string StepCompleteFlag { get; set; }
        public string CostQtyRecalcFlag { get; set; }
        public string SumOnlyFlag { get; set; }
        public string BatchSumFlag { get; set; }
        public string NameSepChar { get; set; }
        public string DefCompletePctType { get; set; }
        public string ProjShortName { get; set; }
        public int? AcctId { get; set; }
        public int? OrigProjId { get; set; }
        public int? SourceProjId { get; set; }
        public int? BaseTypeId { get; set; }
        public int? ClndrId { get; set; }
        public int? SumBaseProjId { get; set; }
        public int? TaskCodeBase { get; set; }
        public int? TaskCodeStep { get; set; }
        public int? PriorityNum { get; set; }
        public int? WbsMaxSumLevel { get; set; }
        public int? RiskLevel { get; set; }
        public int? StrgyPriorityNum { get; set; }
        public int? LastChecksum { get; set; }
        public decimal? CriticalDrtnHrCnt { get; set; }
        public decimal? DefCostPerQty { get; set; }
        public DateTime? LastRecalcDate { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public DateTime? ScdEndDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? SumDataDate { get; set; }
        public DateTime? LastTasksumDate { get; set; }
        public DateTime? FcstStartDate { get; set; }
        public string DefDurationType { get; set; }
        public string TaskCodePrefix { get; set; }
        public string Guid { get; set; }
        public string DefQtyType { get; set; }
        public string AddByName { get; set; }
        public string WebLocalRootPath { get; set; }
        public string ProjUrl { get; set; }
        public string DefRateType { get; set; }
        public string ActThisPerLinkFlag { get; set; }
        public string DefTaskType { get; set; }
        public string ActPctLinkFlag { get; set; }
        public string AddActRemainFlag { get; set; }
        public string CriticalPathType { get; set; }
        public string TaskCodePrefixFlag { get; set; }
        public string DefRollupDatesFlag { get; set; }
        public string RemTargetLinkFlag { get; set; }
        public string ResetPlannedFlag { get; set; }
        public string AllowNegActFlag { get; set; }
        public int? RsrcId { get; set; }
        public string MspManagedFlag { get; set; }
        public string MspUpdateActualsFlag { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public int? CheckoutUserId { get; set; }
        public string SumAssignLevel { get; set; }
        public int? LastFinDatesId { get; set; }
        public string UseProjectBaselineFlag { get; set; }
        public DateTime? LastBaselineUpdateDate { get; set; }
        public string TsRsrcVwComplAsgnFlag { get; set; }
        public string TsRsrcMarkActFinishFlag { get; set; }
        public string TsRsrcVwInactActvFlag { get; set; }
        public string CrExternalKey { get; set; }
        public DateTime? ApplyActualsDate { get; set; }
        public string Description { get; set; }
        public string IntgProjType { get; set; }
        public int? MatrixId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? PxLastUpdateDate { get; set; }
        public decimal? PxPriority { get; set; }
        public DateTime? PxNextDate { get; set; }
        public string PxEnablePublicationFlag { get; set; }
        public DateTime? LastLevelDate { get; set; }
        public DateTime? LastScheduleDate { get; set; }
        public DateTime? PxSafetyDate { get; set; }
        public string ControlUpdatesFlag { get; set; }
        public string HistInterval { get; set; }
        public string HistLevel { get; set; }
        public string ScheduleType { get; set; }
        public DateTime? PrePessStartDate { get; set; }
        public DateTime? PrePessFinishDate { get; set; }
        public DateTime? PostPessStartDate { get; set; }
        public DateTime? PostPessFinishDate { get; set; }
        public string AllowUpdateDateFlag { get; set; }
        public int? FintmplId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public int? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? ProjUpdateDate { get; set; }
        public string PublishSpreadAssignLevel { get; set; }
        public int EtlInterval { get; set; }
        public int EtlHour { get; set; }
        public string EnablePrimeSyncFlag { get; set; }
    }
}
