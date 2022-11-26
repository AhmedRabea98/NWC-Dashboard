using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWC_Dashboard.DTO;
using NWC_Dashboard.Models;
using System.Collections.Generic;
using System.Linq;

namespace NWC_Dashboard.Controllers
{

    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly ApplicationDBContext2 context2;
        public MainController(ApplicationDBContext context , ApplicationDBContext2 context2)
        {
            this.context = context;
            this.context2 = context2;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var proInfo = context.UnifierUsPs.ToList();
            var PaymentNew = context.UnifierUxpas.ToList();
            var changePending = context.UnifierUcoxes.ToList();
            var project = context2.Projects.ToList();
            var projectX = context2.Projectxes.ToList();

            Data data = new Data();
            
            //Main Data
            data.Clusters = proInfo.Select(e => e.FypNwcCluster).Distinct().ToList();
            data.Projects = proInfo.Select(e => e.Ugenprojectname).Count();
            data.Budget = proInfo.Select(e => e.PiContractvalue).Sum();
            data.RevisedBudget = proInfo.Select(e => e.PiModifiedcontractvalue).Sum();
            data.ApprovedWorks = proInfo.Select(e => e.PiValueWorksExecuted).Sum();
            data.BackLog = data.RevisedBudget - data.ApprovedWorks;

            data.PaymentApproved = PaymentNew.Where(e => e.Status.ToLower() == "Approved".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.PaymentPending = PaymentNew.Where(e => e.Status.ToLower() == "Pending".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.PaymentApprovedBudget = PaymentNew.Where(e => e.Status.ToLower() == "Approved".ToLower()).Select(e => e.Amount).Sum();
            data.PaymentPendingBudget = PaymentNew.Where(e => e.Status.ToLower() == "Pending".ToLower()).Select(e => e.Amount).Sum();
            data.PaymentApprovedPercentage = (data.PaymentApproved / (decimal)data.Projects) * 100;
            data.PaymentPendingPercentage = (data.PaymentPending / (decimal)data.Projects) * 100;

            data.ChangeOrderApproved = changePending.Where(e => e.Status.ToLower() == "Approved".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.ChangeOrderPending = changePending.Where(e => e.Status.ToLower() == "Pending".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.ChangeOrderApprovedBudget = changePending.Where(e => e.Status.ToLower() == "Approved".ToLower()).Select(e => e.Amount).Sum();
            data.ChangeOrderPendingBudget = changePending.Where(e => e.Status.ToLower() == "Pending".ToLower()).Select(e => e.Amount).Sum();
            data.ChangeOrderApprovedPercentage = (data.ChangeOrderApproved / (decimal)data.Projects) * 100;
            data.ChangeOrderPendingPercentage = (data.ChangeOrderPending / (decimal)data.Projects) * 100;

            // Map Values
            data.TotalProjectInArRiyad = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "RD".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAshSharqiyah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "ER".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInMakkah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "MA".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInJizan = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "JA".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAlQussim = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "QA".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAsir = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "AS".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInNajran = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "NJ".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInHail = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "HI".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInTabuk = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "TA".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAlhududAshShamaliyah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "NB".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAlJawaf = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "JU".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAlBahah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "BA".ToLower()).Select(e => e.Ugenprojectname).Count();
            data.TotalProjectInAlMadinah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "MD".ToLower()).Select(e => e.Ugenprojectname).Count();

            data.BudgetInArRiyad = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "RD".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAshSharqiyah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "ER".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInMakkah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "MA".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInJizan = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "JA".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAlQussim = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "QA".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAsir = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "AS".ToLower()).Select(e => e.PiContractvalue).Sum(); 
            data.BudgetInNajran = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "NJ".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInHail = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "HI".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInTabuk = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "TA".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAlhududAshShamaliyah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "NB".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAlJawaf = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "JU".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAlBahah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "BA".ToLower()).Select(e => e.PiContractvalue).Sum();
            data.BudgetInAlMadinah = proInfo.Where(e => e.FypNwcRegion?.ToLower() == "MD".ToLower()).Select(e => e.PiContractvalue).Sum();

           
            // Water Projects
            foreach(var w in proInfo.Select(e => e.FypNwcProjectType).Distinct().ToList())
            {
                if (w != null)
                {
                    data.waterProjects.Add(new WaterProjects
                    {
                        Name = w,
                        TotalProjects = proInfo.Where(e => e.FypNwcProjectType == w).Select(e => e.Ugenprojectname).Count(),
                        Budget = proInfo.Where(e => e.FypNwcProjectType == w).Select(e => e.PiModifiedcontractvalue).Sum(),

                    });

                   
                }
                data.waterProjects.Last().Percentage = (data.waterProjects.Last().TotalProjects / (decimal)proInfo.Select(e=>e.Ugenprojectname).Count()) *100;
            }

            // Project Classification
            foreach (var pc in proInfo.Select(e => e.PsProjectClassification).Distinct().ToList())
            {
                if (pc != null)
                {
                    data.projectClassifications.Add(new ProjectClassification
                    {
                        Name = pc,
                        TotalProjects = proInfo.Where(e => e.PsProjectClassification == pc).Select(e => e.Ugenprojectname).Count(),
                        Budget = proInfo.Where(e => e.PsProjectClassification == pc).Select(e => e.PiModifiedcontractvalue).Sum(),

                    });

                }
                
            }


            // Contract Status
            foreach (var cs in proInfo.Select(e => e.PiContractstatus).Distinct().ToList())
            {
                if (cs != null)
                {
                    data.contractStatuses.Add(new ContractStatus
                    {
                        Name = cs,
                        TotalProjects = proInfo.Where(e => e.PiContractstatus == cs).Select(e => e.Ugenprojectname).Count(),
                        Budget = proInfo.Where(e => e.PsProjectClassification == cs).Select(e => e.PiModifiedcontractvalue).Sum(),
                    });

                }
                data.contractStatuses.Last().Percentage = (data.contractStatuses.Last().TotalProjects / (decimal)proInfo.Select(e => e.Ugenprojectname).Count()) * 100;
            }

            foreach (var e in proInfo)
            {

                foreach (var b in project)
                {
                    if (e.UuuIntP6ProjectId == b.ProjShortName)
                    {

                        //data.CompledtedProjects = e.Ugenprojectname.Count();
                        foreach (var pp in projectX)
                        {
                            if (b.ProjId == pp.ProjId)
                            {
                                if (pp.Sumperformancepercentcomplete == (decimal)100.00)
                                {
                                    data.CompledtedProjects += 1;
                                    data.CompledtedProjectsPercentage = (data.CompledtedProjects / (decimal)data.Projects) * 100;
                                }
                                if (b.ProjectFlag.ToLower() == "Y".ToLower())
                                {
                                    if (pp.Sumperformancepercentcomplete < (decimal)25.00)
                                    {
                                        //data.ProjectsIn25 += 1;
                                        data.ProjectsIn25 += pp.Sumperformancepercentcomplete.Value;
                                        data.ProjectsIn25Budget += e.PiModifiedcontractvalue.Value;
                                    }
                                    else if (pp.Sumperformancepercentcomplete >= (decimal)25.00 && pp.Sumperformancepercentcomplete < (decimal)50.00)
                                    {
                                        //data.ProjectsIn50 += 1;
                                        data.ProjectsIn50 += pp.Sumperformancepercentcomplete.Value;
                                        data.ProjectsIn50Budget += e.PiModifiedcontractvalue.Value;

                                    }
                                    else if (pp.Sumperformancepercentcomplete >= (decimal)50 && pp.Sumperformancepercentcomplete < (decimal)75)
                                    {
                                        // data.ProjectsIn75 += 1;
                                        data.ProjectsIn75 += pp.Sumperformancepercentcomplete.Value;
                                        data.ProjectsIn75Budget += e.PiModifiedcontractvalue.Value;

                                    }
                                    else if (pp.Sumperformancepercentcomplete >= (decimal)75)
                                    {
                                        //data.ProjectsInMore75 += 1;
                                        data.ProjectsInMore75 += pp.Sumperformancepercentcomplete.Value;

                                        data.ProjectsInMore75Budget += e.PiModifiedcontractvalue.Value;

                                    }
                                }
                            }

                        }

                    }
                }
            }

            return Ok(data);
        }
    }
}
