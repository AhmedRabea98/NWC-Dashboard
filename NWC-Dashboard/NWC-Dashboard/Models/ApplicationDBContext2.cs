using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NWC_Dashboard.Models
{
    public partial class ApplicationDBContext2 : DbContext
    {
        public ApplicationDBContext2()
        {
        }

        public ApplicationDBContext2(DbContextOptions<ApplicationDBContext2> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Projectx> Projectxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
/*            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST= (ADDRESS=(COMMUNITY=tcpcom.world)(PROTOCOL=tcp)(HOST=85.195.99.242)(PORT=1521)))(CONNECT_DATA=(SID=Orcl))); User ID=admuser;Password=admuser");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ADMUSER")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjId);

                entity.ToTable("PROJECT");

                entity.HasIndex(e => e.AcctId, "NDX_PROJECT_ACCOUNT");

                entity.HasIndex(e => e.BaseTypeId, "NDX_PROJECT_BASETYPE");

                entity.HasIndex(e => new { e.ClndrId, e.DeleteSessionId }, "NDX_PROJECT_CALENDAR");

                entity.HasIndex(e => e.CheckoutUserId, "NDX_PROJECT_CHECKOUT_USER_ID");

                entity.HasIndex(e => new { e.DeleteSessionId, e.DeleteDate }, "NDX_PROJECT_DSI");

                entity.HasIndex(e => e.FintmplId, "NDX_PROJECT_FINTMPL");

                entity.HasIndex(e => e.LastFinDatesId, "NDX_PROJECT_LAST_FIN_DATES");

                entity.HasIndex(e => e.LocationId, "NDX_PROJECT_LOCATION");

                entity.HasIndex(e => e.MatrixId, "NDX_PROJECT_MATRIX");

                entity.HasIndex(e => e.OrigProjId, "NDX_PROJECT_ORIG_PROJ_ID");

                entity.HasIndex(e => new { e.ProjectFlag, e.OrigProjId, e.DeleteSessionId, e.ProjShortName, e.ProjId, e.FintmplId }, "NDX_PROJECT_PROJECT_FLAG");

                entity.HasIndex(e => e.SourceProjId, "NDX_PROJECT_SOURCE_PROJ_ID");

                entity.HasIndex(e => new { e.UpdateDate, e.DeleteSessionId, e.ProjId }, "NDX_PROJECT_UPD");

                entity.Property(e => e.ProjId)
                    .HasPrecision(10)
                    .HasColumnName("PROJ_ID");

                entity.Property(e => e.AcctId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ACCT_ID");

                entity.Property(e => e.ActPctLinkFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ACT_PCT_LINK_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ActThisPerLinkFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ACT_THIS_PER_LINK_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.AddActRemainFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("ADD_ACT_REMAIN_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.AddByName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ADD_BY_NAME");

                entity.Property(e => e.AddDate)
                    .HasColumnType("DATE")
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("ADD_DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.AllowCompleteFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ALLOW_COMPLETE_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.AllowNegActFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("ALLOW_NEG_ACT_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.AllowUpdateDateFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ALLOW_UPDATE_DATE_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ApplyActualsDate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("APPLY_ACTUALS_DATE");

                entity.Property(e => e.BaseTypeId)
                    .HasPrecision(10)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("BASE_TYPE_ID");

                entity.Property(e => e.BatchSumFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("BATCH_SUM_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.CheckoutDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("CHECKOUT_DATE");

                entity.Property(e => e.CheckoutFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("CHECKOUT_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CheckoutUserId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("CHECKOUT_USER_ID");

                entity.Property(e => e.ChngEffCmpPctFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("CHNG_EFF_CMP_PCT_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ClndrId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("CLNDR_ID");

                entity.Property(e => e.ControlUpdatesFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("CONTROL_UPDATES_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CostQtyRecalcFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("COST_QTY_RECALC_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.CrExternalKey)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("CR_EXTERNAL_KEY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATE")
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("CREATE_USER");

                entity.Property(e => e.CriticalDrtnHrCnt)
                    .HasColumnType("NUMBER(10,2)")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("CRITICAL_DRTN_HR_CNT");

                entity.Property(e => e.CriticalPathType)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("CRITICAL_PATH_TYPE")
                    .HasDefaultValueSql("'CT_TotFloat' ");

                entity.Property(e => e.DefCompletePctType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("DEF_COMPLETE_PCT_TYPE")
                    .HasDefaultValueSql("'CP_Drtn' ");

                entity.Property(e => e.DefCostPerQty)
                    .HasColumnType("NUMBER(21,8)")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("DEF_COST_PER_QTY");

                entity.Property(e => e.DefDurationType)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("DEF_DURATION_TYPE");

                entity.Property(e => e.DefQtyType)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("DEF_QTY_TYPE");

                entity.Property(e => e.DefRateType)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("DEF_RATE_TYPE");

                entity.Property(e => e.DefRollupDatesFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("DEF_ROLLUP_DATES_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.DefTaskType)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("DEF_TASK_TYPE")
                    .HasDefaultValueSql("'TT_Task' ");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.DeleteSessionId)
                    .HasPrecision(10)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("DELETE_SESSION_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnablePrimeSyncFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ENABLE_PRIME_SYNC_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.EtlHour)
                    .HasPrecision(10)
                    //ValueGeneratedOnAdd()
                    .HasColumnName("ETL_HOUR")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.EtlInterval)
                    .HasPrecision(10)
                    //ValueGeneratedOnAdd()
                    .HasColumnName("ETL_INTERVAL")
                    .HasDefaultValueSql("24 ");

                entity.Property(e => e.FcstStartDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("FCST_START_DATE");

                entity.Property(e => e.FintmplId)
                    .HasPrecision(10)
                    //ValueGeneratedOnAdd()
                    .HasColumnName("FINTMPL_ID");

                entity.Property(e => e.FyStartMonthNum)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("FY_START_MONTH_NUM");

                entity.Property(e => e.Guid)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("GUID");

                entity.Property(e => e.HistInterval)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("HIST_INTERVAL")
                    .HasDefaultValueSql("'Month' ");

                entity.Property(e => e.HistLevel)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("HIST_LEVEL")
                    .HasDefaultValueSql("'HL_None' ");

                entity.Property(e => e.IntgProjType)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("INTG_PROJ_TYPE");

                entity.Property(e => e.LastBaselineUpdateDate)
                    .HasColumnType("DATE")
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("LAST_BASELINE_UPDATE_DATE");

                entity.Property(e => e.LastChecksum)
                    .HasPrecision(10)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("LAST_CHECKSUM");

                entity.Property(e => e.LastFinDatesId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("LAST_FIN_DATES_ID");

                entity.Property(e => e.LastLevelDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("LAST_LEVEL_DATE");

                entity.Property(e => e.LastRecalcDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("LAST_RECALC_DATE");

                entity.Property(e => e.LastScheduleDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("LAST_SCHEDULE_DATE");

                entity.Property(e => e.LastTasksumDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("LAST_TASKSUM_DATE");

                entity.Property(e => e.LocationId)
                    .HasPrecision(10)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.MatrixId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("MATRIX_ID");

                entity.Property(e => e.MspManagedFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("MSP_MANAGED_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.MspUpdateActualsFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("MSP_UPDATE_ACTUALS_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.NameSepChar)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("NAME_SEP_CHAR");

                entity.Property(e => e.OrigProjId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("ORIG_PROJ_ID");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PLAN_END_DATE");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnType("DATE")
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("PLAN_START_DATE");

                entity.Property(e => e.PostPessFinishDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("POST_PESS_FINISH_DATE");

                entity.Property(e => e.PostPessStartDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("POST_PESS_START_DATE");

                entity.Property(e => e.PrePessFinishDate)
                    .HasColumnType("DATE")
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("PRE_PESS_FINISH_DATE");

                entity.Property(e => e.PrePessStartDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PRE_PESS_START_DATE");

                entity.Property(e => e.PriorityNum)
                    .HasPrecision(10)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("PRIORITY_NUM");

                entity.Property(e => e.ProjShortName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PROJ_SHORT_NAME");

                entity.Property(e => e.ProjUpdateDate)
                    .HasColumnType("DATE")
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("PROJ_UPDATE_DATE");

                entity.Property(e => e.ProjUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PROJ_URL");

                entity.Property(e => e.ProjectFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("PROJECT_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PublishSpreadAssignLevel)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("PUBLISH_SPREAD_ASSIGN_LEVEL")
                    .HasDefaultValueSql("'SL_Taskrsrc' ");

                entity.Property(e => e.PxEnablePublicationFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("PX_ENABLE_PUBLICATION_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.PxLastUpdateDate)
                    .HasColumnType("DATE")
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("PX_LAST_UPDATE_DATE");

                entity.Property(e => e.PxNextDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PX_NEXT_DATE");

                entity.Property(e => e.PxPriority)
                    .HasColumnType("NUMBER")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PX_PRIORITY")
                    .HasDefaultValueSql("50 ");

                entity.Property(e => e.PxSafetyDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("PX_SAFETY_DATE");

                entity.Property(e => e.RemTargetLinkFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("REM_TARGET_LINK_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ResetPlannedFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("RESET_PLANNED_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.RiskLevel)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("RISK_LEVEL");

                entity.Property(e => e.RsrcId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("RSRC_ID");

                entity.Property(e => e.RsrcMultiAssignFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("RSRC_MULTI_ASSIGN_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.RsrcRoleMatchFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("RSRC_ROLE_MATCH_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RsrcSelfAddFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("RSRC_SELF_ADD_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.RsrcSelfAddOutFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("RSRC_SELF_ADD_OUT_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.ScdEndDate)
                    .HasColumnType("DATE")
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("SCD_END_DATE");

                entity.Property(e => e.ScheduleType)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                //    .ValueGeneratedOnAdd()
                    .HasColumnName("SCHEDULE_TYPE");

                entity.Property(e => e.SourceProjId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("SOURCE_PROJ_ID");

                entity.Property(e => e.StepCompleteFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("STEP_COMPLETE_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.StrgyPriorityNum)
                    .HasPrecision(10)
                //    .ValueGeneratedOnAdd()
                    .HasColumnName("STRGY_PRIORITY_NUM");

                entity.Property(e => e.SumAssignLevel)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("SUM_ASSIGN_LEVEL")
                    .HasDefaultValueSql("'SL_Taskrsrc' ");

                entity.Property(e => e.SumBaseProjId)
                    .HasPrecision(10)
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("SUM_BASE_PROJ_ID");

                entity.Property(e => e.SumDataDate)
                    .HasColumnType("DATE")
                    //.ValueGeneratedOnAdd()
                    .HasColumnName("SUM_DATA_DATE");

                entity.Property(e => e.SumOnlyFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                //    .ValueGeneratedOnAdd()
                    .HasColumnName("SUM_ONLY_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TaskCodeBase)
                    .HasPrecision(10)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("TASK_CODE_BASE");

                entity.Property(e => e.TaskCodePrefix)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("TASK_CODE_PREFIX");

                entity.Property(e => e.TaskCodePrefixFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("TASK_CODE_PREFIX_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TaskCodeStep)
                    .HasPrecision(10)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("TASK_CODE_STEP");

                entity.Property(e => e.TsRsrcMarkActFinishFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("TS_RSRC_MARK_ACT_FINISH_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TsRsrcVwComplAsgnFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("TS_RSRC_VW_COMPL_ASGN_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TsRsrcVwInactActvFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("TS_RSRC_VW_INACT_ACTV_FLAG")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("UPDATE_USER");

                entity.Property(e => e.UseProjectBaselineFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    //   .ValueGeneratedOnAdd()
                    .HasColumnName("USE_PROJECT_BASELINE_FLAG")
                    .HasDefaultValueSql("'Y' ");

                entity.Property(e => e.WbsMaxSumLevel)
                    .HasPrecision(10)
                    // .ValueGeneratedOnAdd()
                    .HasColumnName("WBS_MAX_SUM_LEVEL");

                entity.Property(e => e.WebLocalRootPath)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    //  .ValueGeneratedOnAdd()
                    .HasColumnName("WEB_LOCAL_ROOT_PATH");
            });

            modelBuilder.Entity<Projectx>(entity =>
            {
                entity.HasKey(e => e.ProjId);

                entity.ToTable("PROJECTX");

                entity.Property(e => e.ProjId)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("PROJ_ID");

                entity.Property(e => e.Annualdiscountrate)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ANNUALDISCOUNTRATE");

                entity.Property(e => e.Anticipatedfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ANTICIPATEDFINISHDATE");

                entity.Property(e => e.Anticipatedstartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ANTICIPATEDSTARTDATE");

                entity.Property(e => e.Containssummarydata)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTAINSSUMMARYDATA");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Currentbudget)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURRENTBUDGET");

                entity.Property(e => e.Currentvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CURRENTVARIANCE");

                entity.Property(e => e.Datadate)
                    .HasColumnType("DATE")
                    .HasColumnName("DATADATE");

                entity.Property(e => e.Discountapplicationperiod)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("DISCOUNTAPPLICATIONPERIOD");

                entity.Property(e => e.Distributedcurrentbudget)
                    .HasColumnType("NUMBER")
                    .HasColumnName("DISTRIBUTEDCURRENTBUDGET");

                entity.Property(e => e.Earnedvaluecomputetype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EARNEDVALUECOMPUTETYPE");

                entity.Property(e => e.Earnedvalueetccomputetype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EARNEDVALUEETCCOMPUTETYPE");

                entity.Property(e => e.Earnedvalueetcuservalue)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EARNEDVALUEETCUSERVALUE");

                entity.Property(e => e.Earnedvalueuserpercent)
                    .HasColumnType("NUMBER")
                    .HasColumnName("EARNEDVALUEUSERPERCENT");

                entity.Property(e => e.Finishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("FINISHDATE");

                entity.Property(e => e.Forecastfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("FORECASTFINISHDATE");

                entity.Property(e => e.Forecaststartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("FORECASTSTARTDATE");

                entity.Property(e => e.Independentetclaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INDEPENDENTETCLABORUNITS");

                entity.Property(e => e.Independentetctotalcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("INDEPENDENTETCTOTALCOST");

                entity.Property(e => e.Locationname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LOCATIONNAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Netpresentvalue)
                    .HasColumnType("NUMBER(23,6)")
                    .HasColumnName("NETPRESENTVALUE");

                entity.Property(e => e.Obsname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBSNAME");

                entity.Property(e => e.Obsobjectid)
                    .HasPrecision(10)
                    .HasColumnName("OBSOBJECTID");

                entity.Property(e => e.Originalbudget)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORIGINALBUDGET");

                entity.Property(e => e.Overallprojectscore)
                    .HasColumnType("NUMBER")
                    .HasColumnName("OVERALLPROJECTSCORE");

                entity.Property(e => e.Parentepsobjectid)
                    .HasPrecision(10)
                    .HasColumnName("PARENTEPSOBJECTID");

                entity.Property(e => e.Paybackperiod)
                    .HasPrecision(10)
                    .HasColumnName("PAYBACKPERIOD");

                entity.Property(e => e.Proposedbudget)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROPOSEDBUDGET");

                entity.Property(e => e.Returnoninvestment)
                    .HasColumnType("NUMBER(23,6)")
                    .HasColumnName("RETURNONINVESTMENT");

                entity.Property(e => e.Riskexposure)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RISKEXPOSURE");

                entity.Property(e => e.Risklevel)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("RISKLEVEL");

                entity.Property(e => e.Riskscore)
                    .HasPrecision(10)
                    .HasColumnName("RISKSCORE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("DATE")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Sumaccountingvarbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACCOUNTINGVARBYLABORUNITS");

                entity.Property(e => e.Sumaccountingvariancebycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACCOUNTINGVARIANCEBYCOST");

                entity.Property(e => e.Sumactivitycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTIVITYCOUNT");

                entity.Property(e => e.Sumactthisperiodmaterialcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTTHISPERIODMATERIALCOST");

                entity.Property(e => e.Sumactthisperiodnonlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTTHISPERIODNONLABORCOST");

                entity.Property(e => e.Sumactthisperiodnonlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTTHISPERIODNONLABORUNITS");

                entity.Property(e => e.Sumactualduration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALDURATION");

                entity.Property(e => e.Sumactualexpensecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALEXPENSECOST");

                entity.Property(e => e.Sumactualfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMACTUALFINISHDATE");

                entity.Property(e => e.Sumactuallaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALLABORCOST");

                entity.Property(e => e.Sumactuallaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALLABORUNITS");

                entity.Property(e => e.Sumactualmaterialcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALMATERIALCOST");

                entity.Property(e => e.Sumactualnonlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALNONLABORCOST");

                entity.Property(e => e.Sumactualnonlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALNONLABORUNITS");

                entity.Property(e => e.Sumactualprogressdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMACTUALPROGRESSDATE");

                entity.Property(e => e.Sumactualstartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMACTUALSTARTDATE");

                entity.Property(e => e.Sumactualthisperiodcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALTHISPERIODCOST");

                entity.Property(e => e.Sumactualthisperiodlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALTHISPERIODLABORCOST");

                entity.Property(e => e.Sumactualthisperiodlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALTHISPERIODLABORUNITS");

                entity.Property(e => e.Sumactualtotalcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALTOTALCOST");

                entity.Property(e => e.Sumactualvaluebycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALVALUEBYCOST");

                entity.Property(e => e.Sumactualvaluebylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMACTUALVALUEBYLABORUNITS");

                entity.Property(e => e.Sumatcompletionduration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONDURATION");

                entity.Property(e => e.Sumatcompletionexpensecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONEXPENSECOST");

                entity.Property(e => e.Sumatcompletionlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONLABORCOST");

                entity.Property(e => e.Sumatcompletionlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONLABORUNITS");

                entity.Property(e => e.Sumatcompletionmaterialcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONMATERIALCOST");

                entity.Property(e => e.Sumatcompletionnonlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONNONLABORCOST");

                entity.Property(e => e.Sumatcompletionnonlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONNONLABORUNITS");

                entity.Property(e => e.Sumatcompletiontotalcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONTOTALCOST");

                entity.Property(e => e.Sumatcompletiontotalcostvar)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMATCOMPLETIONTOTALCOSTVAR");

                entity.Property(e => e.Sumbaselinecompactivitycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINECOMPACTIVITYCOUNT");

                entity.Property(e => e.Sumbaselineduration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINEDURATION");

                entity.Property(e => e.Sumbaselineexpensecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINEEXPENSECOST");

                entity.Property(e => e.Sumbaselinefinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMBASELINEFINISHDATE");

                entity.Property(e => e.Sumbaselinelaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINELABORCOST");

                entity.Property(e => e.Sumbaselinelaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINELABORUNITS");

                entity.Property(e => e.Sumbaselinematerialcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINEMATERIALCOST");

                entity.Property(e => e.Sumbaselinenonlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINENONLABORCOST");

                entity.Property(e => e.Sumbaselinenonlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINENONLABORUNITS");

                entity.Property(e => e.Sumbaselinenotstartedactcnt)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINENOTSTARTEDACTCNT");

                entity.Property(e => e.Sumbaselinestartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMBASELINESTARTDATE");

                entity.Property(e => e.Sumbaselinetotalcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBASELINETOTALCOST");

                entity.Property(e => e.Sumblinprogressactivitycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBLINPROGRESSACTIVITYCOUNT");

                entity.Property(e => e.Sumbudgetatcmpbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBUDGETATCMPBYLABORUNITS");

                entity.Property(e => e.Sumbudgetatcompletionbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMBUDGETATCOMPLETIONBYCOST");

                entity.Property(e => e.Sumcompletedactivitycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOMPLETEDACTIVITYCOUNT");

                entity.Property(e => e.Sumcostpercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTPERCENTCOMPLETE");

                entity.Property(e => e.Sumcostpercentofplanned)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTPERCENTOFPLANNED");

                entity.Property(e => e.Sumcostperfindexbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTPERFINDEXBYCOST");

                entity.Property(e => e.Sumcostperfindexbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTPERFINDEXBYLABORUNITS");

                entity.Property(e => e.Sumcostvariancebycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTVARIANCEBYCOST");

                entity.Property(e => e.Sumcostvariancebylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTVARIANCEBYLABORUNITS");

                entity.Property(e => e.Sumcostvarianceindex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTVARIANCEINDEX");

                entity.Property(e => e.Sumcostvarianceindexbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTVARIANCEINDEXBYCOST");

                entity.Property(e => e.Sumcostvarindexbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMCOSTVARINDEXBYLABORUNITS");

                entity.Property(e => e.Sumdurationpercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMDURATIONPERCENTCOMPLETE");

                entity.Property(e => e.Sumdurationpercentofplanned)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMDURATIONPERCENTOFPLANNED");

                entity.Property(e => e.Sumdurationvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMDURATIONVARIANCE");

                entity.Property(e => e.Sumeacbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEACBYCOST");

                entity.Property(e => e.Sumeacbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEACBYLABORUNITS");

                entity.Property(e => e.Sumeachighpctbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEACHIGHPCTBYLABORUNITS");

                entity.Property(e => e.Sumeaclowpctbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEACLOWPCTBYLABORUNITS");

                entity.Property(e => e.Sumearlyenddate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMEARLYENDDATE");

                entity.Property(e => e.Sumearlystartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMEARLYSTARTDATE");

                entity.Property(e => e.Sumearnedvaluebycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEARNEDVALUEBYCOST");

                entity.Property(e => e.Sumearnedvaluebylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEARNEDVALUEBYLABORUNITS");

                entity.Property(e => e.Sumetcbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMETCBYCOST");

                entity.Property(e => e.Sumetcbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMETCBYLABORUNITS");

                entity.Property(e => e.Sumexpensecostpctcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEXPENSECOSTPCTCOMPLETE");

                entity.Property(e => e.Sumexpensecostvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMEXPENSECOSTVARIANCE");

                entity.Property(e => e.Sumfinishdatevariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMFINISHDATEVARIANCE");

                entity.Property(e => e.Suminprogressactivitycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMINPROGRESSACTIVITYCOUNT");

                entity.Property(e => e.Sumlaborcostpercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMLABORCOSTPERCENTCOMPLETE");

                entity.Property(e => e.Sumlaborcostvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMLABORCOSTVARIANCE");

                entity.Property(e => e.Sumlaborunitspercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMLABORUNITSPERCENTCOMPLETE");

                entity.Property(e => e.Sumlaborunitsvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMLABORUNITSVARIANCE");

                entity.Property(e => e.Sumlateenddate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMLATEENDDATE");

                entity.Property(e => e.Sumlatestartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMLATESTARTDATE");

                entity.Property(e => e.Summaterialcostpctcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMMATERIALCOSTPCTCOMPLETE");

                entity.Property(e => e.Summaterialcostvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMMATERIALCOSTVARIANCE");

                entity.Property(e => e.Summaxactualfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMMAXACTUALFINISHDATE");

                entity.Property(e => e.Summaxcalendarid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMMAXCALENDARID");

                entity.Property(e => e.Summaxrestartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMMAXRESTARTDATE");

                entity.Property(e => e.Summincalendarid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMMINCALENDARID");

                entity.Property(e => e.Sumnonlaborcostpctcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMNONLABORCOSTPCTCOMPLETE");

                entity.Property(e => e.Sumnonlaborcostvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMNONLABORCOSTVARIANCE");

                entity.Property(e => e.Sumnonlaborunitspctcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMNONLABORUNITSPCTCOMPLETE");

                entity.Property(e => e.Sumnonlaborunitsvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMNONLABORUNITSVARIANCE");

                entity.Property(e => e.Sumnotstartedactivitycount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMNOTSTARTEDACTIVITYCOUNT");

                entity.Property(e => e.Sumperformancepercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPERFORMANCEPERCENTCOMPLETE");

                entity.Property(e => e.Sumperfpctcmpbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPERFPCTCMPBYLABORUNITS");

                entity.Property(e => e.Sumplannedduration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDDURATION");

                entity.Property(e => e.Sumplannedexpensecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDEXPENSECOST");

                entity.Property(e => e.Sumplannedfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMPLANNEDFINISHDATE");

                entity.Property(e => e.Sumplannedlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDLABORCOST");

                entity.Property(e => e.Sumplannedlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDLABORUNITS");

                entity.Property(e => e.Sumplannedmaterialcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDMATERIALCOST");

                entity.Property(e => e.Sumplannednonlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDNONLABORCOST");

                entity.Property(e => e.Sumplannednonlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDNONLABORUNITS");

                entity.Property(e => e.Sumplannedstartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMPLANNEDSTARTDATE");

                entity.Property(e => e.Sumplannedtotalcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDTOTALCOST");

                entity.Property(e => e.Sumplannedvaluebycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDVALUEBYCOST");

                entity.Property(e => e.Sumplannedvaluebylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMPLANNEDVALUEBYLABORUNITS");

                entity.Property(e => e.Sumprogressfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMPROGRESSFINISHDATE");

                entity.Property(e => e.Sumremainingduration)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGDURATION");

                entity.Property(e => e.Sumremainingexpensecost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGEXPENSECOST");

                entity.Property(e => e.Sumremainingfinishdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMREMAININGFINISHDATE");

                entity.Property(e => e.Sumremaininglaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGLABORCOST");

                entity.Property(e => e.Sumremaininglaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGLABORUNITS");

                entity.Property(e => e.Sumremainingmaterialcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGMATERIALCOST");

                entity.Property(e => e.Sumremainingnonlaborcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGNONLABORCOST");

                entity.Property(e => e.Sumremainingnonlaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGNONLABORUNITS");

                entity.Property(e => e.Sumremainingstartdate)
                    .HasColumnType("DATE")
                    .HasColumnName("SUMREMAININGSTARTDATE");

                entity.Property(e => e.Sumremainingtotalcost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMREMAININGTOTALCOST");

                entity.Property(e => e.Sumschdpctcmpbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHDPCTCMPBYLABORUNITS");

                entity.Property(e => e.Sumschdperfindexbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHDPERFINDEXBYLABORUNITS");

                entity.Property(e => e.Sumschdvariancebylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHDVARIANCEBYLABORUNITS");

                entity.Property(e => e.Sumschdvarianceindexbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHDVARIANCEINDEXBYCOST");

                entity.Property(e => e.Sumschdvarindexbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHDVARINDEXBYLABORUNITS");

                entity.Property(e => e.Sumschedulepercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHEDULEPERCENTCOMPLETE");

                entity.Property(e => e.Sumscheduleperfindexbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHEDULEPERFINDEXBYCOST");

                entity.Property(e => e.Sumschedulevariancebycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHEDULEVARIANCEBYCOST");

                entity.Property(e => e.Sumschedulevarianceindex)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSCHEDULEVARIANCEINDEX");

                entity.Property(e => e.Sumstartdatevariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMSTARTDATEVARIANCE");

                entity.Property(e => e.Sumtocompleteperfindexbycost)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMTOCOMPLETEPERFINDEXBYCOST");

                entity.Property(e => e.Sumtotalcostvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMTOTALCOSTVARIANCE");

                entity.Property(e => e.Sumtotalfloat)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMTOTALFLOAT");

                entity.Property(e => e.Sumunitspercentcomplete)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMUNITSPERCENTCOMPLETE");

                entity.Property(e => e.Sumvaratcmpbylaborunits)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SUMVARATCMPBYLABORUNITS");

                entity.Property(e => e.Totalbenefitplan)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALBENEFITPLAN");

                entity.Property(e => e.Totalbenefitplantally)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALBENEFITPLANTALLY");

                entity.Property(e => e.Totalfunding)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALFUNDING");

                entity.Property(e => e.Totalspendingplan)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALSPENDINGPLAN");

                entity.Property(e => e.Totalspendingplantally)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALSPENDINGPLANTALLY");

                entity.Property(e => e.Unallocatedbudget)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNALLOCATEDBUDGET");

                entity.Property(e => e.Undistributedcurrentvariance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UNDISTRIBUTEDCURRENTVARIANCE");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.UpdateDimDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UPDATE_DIM_DATE")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.UpdateDimHash)
                    .HasColumnType("NUMBER")
                    .HasColumnName("UPDATE_DIM_HASH")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.HasSequence("MDRS_16651$");

            modelBuilder.HasSequence("MDRS_1665A$");

            modelBuilder.HasSequence("PC_PROCESS_STAT_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
