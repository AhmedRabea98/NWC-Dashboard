using System.Collections.Generic;

namespace NWC_Dashboard.DTO
{
    public class DataByCluster
    {
        public List<string> Regions { get; set; } = new List<string>();
        public int? Projects { get; set; }
        public decimal? Budget { get; set; }
        public decimal? RevisedBudget { get; set; }
        public decimal? ApprovedWorks { get; set; }
        public decimal? BackLog { get; set; }
        public int? PaymentApproved { get; set; }
        public int? PaymentPending { get; set; }
        public decimal? PaymentApprovedBudget { get; set; }
        public decimal? PaymentPendingBudget { get; set; }
        public decimal? PaymentApprovedPercentage { get; set; }
        public decimal? PaymentPendingPercentage { get; set; }
        public int? ChangeOrderApproved { get; set; }
        public int? ChangeOrderPending { get; set; }
        public decimal? ChangeOrderApprovedBudget { get; set; }
        public decimal? ChangeOrderPendingBudget { get; set; }
        public decimal? ChangeOrderApprovedPercentage { get; set; }
        public decimal? ChangeOrderPendingPercentage { get; set; }
        public int? TotalProjectInAlJawaf { get; set; }
        public int? TotalProjectInTabuk { get; set; }
        public int? TotalProjectInAlhududAshShamaliyah { get; set; }
        public int? TotalProjectInHail { get; set; }
        public int? TotalProjectInAlMadinah { get; set; }
        public int? TotalProjectInAlQussim { get; set; }
        public int? TotalProjectInMakkah { get; set; }
        public int? TotalProjectInAlBahah { get; set; }
        public int? TotalProjectInAsir { get; set; }
        public int? TotalProjectInJizan { get; set; }
        public int? TotalProjectInNajran { get; set; }
        public int? TotalProjectInArRiyad { get; set; }
        public int? TotalProjectInAshSharqiyah { get; set; }
        public decimal? BudgetInAlJawaf { get; set; }
        public decimal? BudgetInTabuk { get; set; }
        public decimal? BudgetInAlhududAshShamaliyah { get; set; }

        public decimal? BudgetInHail { get; set; }
        public decimal? BudgetInAlMadinah { get; set; }
        public decimal? BudgetInAlQussim { get; set; }
        public decimal? BudgetInMakkah { get; set; }
        public decimal? BudgetInAlBahah { get; set; }
        public decimal? BudgetInAsir { get; set; }
        public decimal? BudgetInJizan { get; set; }
        public decimal? BudgetInNajran { get; set; }
        public decimal? BudgetInArRiyad { get; set; }
        public decimal? BudgetInAshSharqiyah { get; set; }
        public int? CompledtedProjects { get; set; } = 0;
        public decimal? CompledtedProjectsPercentage { get; set; } = 0;
        public decimal? ProjectsIn25 { get; set; } = 0;
        public decimal? ProjectsIn50 { get; set; } = 0;
        public decimal? ProjectsIn75 { get; set; } = 0;
        public decimal? ProjectsInMore75 { get; set; } = 0;
        public decimal? ProjectsIn25Budget { get; set; } = 0;
        public decimal? ProjectsIn50Budget { get; set; } = 0;
        public decimal? ProjectsIn75Budget { get; set; } = 0;
        public decimal? ProjectsInMore75Budget { get; set; } = 0;

        public ICollection<WaterProjects> waterProjects { get; set; } = new List<WaterProjects>();
        public ICollection<ProjectClassification> projectClassifications { get; set; } = new List<ProjectClassification>();
        public ICollection<ContractStatus> contractStatuses { get; set; } = new List<ContractStatus>();

    }
}
