using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NWC_Dashboard.Models
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UnifierUcox> UnifierUcoxes { get; set; }
        public virtual DbSet<UnifierUcx> UnifierUcxes { get; set; }
        public virtual DbSet<UnifierUsP> UnifierUsPs { get; set; }
        public virtual DbSet<UnifierUxdev> UnifierUxdevs { get; set; }
        public virtual DbSet<UnifierUxfyp> UnifierUxfyps { get; set; }
        public virtual DbSet<UnifierUxiahi> UnifierUxiahis { get; set; }
        public virtual DbSet<UnifierUxlssu> UnifierUxlssus { get; set; }
        public virtual DbSet<UnifierUxncr> UnifierUxncrs { get; set; }
        public virtual DbSet<UnifierUxpa> UnifierUxpas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST= (ADDRESS=(COMMUNITY=tcpcom.world)(PROTOCOL=tcp)(HOST=85.195.99.242)(PORT=1521)))(CONNECT_DATA=(SID=Orcl))); User ID=unifiernwc21;Password=unifiernwc21");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("UNIFIERNWC21")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<UnifierUcox>(entity =>
            {
                entity.ToTable("UNIFIER_UCOX");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UCOX_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UCOX_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UCOX_3");

                entity.HasIndex(e => e.ChProjectContractor, "UNIFIER_UCOX__1");

                entity.HasIndex(e => e.ChProjectConsultant, "UNIFIER_UCOX__2");

                entity.HasIndex(e => e.Ugenactivitydpk, "UNIFIER_UCOX__3");

                entity.HasIndex(e => e.Refid, "UNIFIER_UCOX__4");

                entity.HasIndex(e => e.Uxpcpcrecordnobp, "UNIFIER_UCOX__5");

                entity.HasIndex(e => e.Currencyid, "UNIFIER_UCOX__6");

                entity.HasIndex(e => e.CoCreator, "UNIFIER_UCOX__7");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.BcProjectEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_END_DATE");

                entity.Property(e => e.BcProjectEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_COSTS");

                entity.Property(e => e.BcProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_START_DATE");

                entity.Property(e => e.BoqDescion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BOQ_DESCION");

                entity.Property(e => e.CVat)
                    .HasColumnType("FLOAT")
                    .HasColumnName("C_VAT");

                entity.Property(e => e.CVatTotal)
                    .HasColumnType("FLOAT")
                    .HasColumnName("C_VAT_TOTAL");

                entity.Property(e => e.ChContractualValue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CH_CONTRACTUAL_VALUE");

                entity.Property(e => e.ChPercentageCompletion)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CH_PERCENTAGE_COMPLETION");

                entity.Property(e => e.ChPercentageProject)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CH_PERCENTAGE_PROJECT");

                entity.Property(e => e.ChProjectAfterApproved)
                    .IsUnicode(false)
                    .HasColumnName("CH_PROJECT_AFTER_APPROVED");

                entity.Property(e => e.ChProjectAfterRequiredV)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CH_PROJECT_AFTER_REQUIRED_V");

                entity.Property(e => e.ChProjectConsultant)
                    .HasPrecision(10)
                    .HasColumnName("CH_PROJECT_CONSULTANT");

                entity.Property(e => e.ChProjectContractor)
                    .HasPrecision(10)
                    .HasColumnName("CH_PROJECT_CONTRACTOR");

                entity.Property(e => e.ChProjectCurrentValue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CH_PROJECT_CURRENT_VALUE");

                entity.Property(e => e.ChProjectDateAfterAppro)
                    .HasColumnType("DATE")
                    .HasColumnName("CH_PROJECT_DATE_AFTER_APPRO");

                entity.Property(e => e.ChProjectDateAfterReque)
                    .HasColumnType("DATE")
                    .HasColumnName("CH_PROJECT_DATE_AFTER_REQUE");

                entity.Property(e => e.ChProjectDurationElapse)
                    .IsUnicode(false)
                    .HasColumnName("CH_PROJECT_DURATION_ELAPSE");

                entity.Property(e => e.ChProjectEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CH_PROJECT_END_DATE");

                entity.Property(e => e.ChProjectRequestChangeV)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CH_PROJECT_REQUEST_CHANGE_V");

                entity.Property(e => e.ChPurchaseOrder)
                    .IsUnicode(false)
                    .HasColumnName("CH_PURCHASE_ORDER");

                entity.Property(e => e.ChTotalTime)
                    .IsUnicode(false)
                    .HasColumnName("CH_TOTAL_TIME");

                entity.Property(e => e.ChTransactiontNo)
                    .IsUnicode(false)
                    .HasColumnName("CH_TRANSACTIONT_NO");

                entity.Property(e => e.ChangeOrderCountValue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CHANGE_ORDER_COUNT_VALUE");

                entity.Property(e => e.ChoAthuPerson)
                    .HasPrecision(10)
                    .HasColumnName("CHO_ATHU_PERSON");

                entity.Property(e => e.ChoAthuPersonDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_ATHU_PERSON_DATE");

                entity.Property(e => e.ChoCcontractManger)
                    .HasPrecision(10)
                    .HasColumnName("CHO_CCONTRACT_MANGER");

                entity.Property(e => e.ChoClusterProjectsgm)
                    .HasPrecision(10)
                    .HasColumnName("CHO_CLUSTER_PROJECTSGM");

                entity.Property(e => e.ChoClusterProjectsgmd)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_CLUSTER_PROJECTSGMD");

                entity.Property(e => e.ChoClusterSeniorgm)
                    .HasPrecision(10)
                    .HasColumnName("CHO_CLUSTER_SENIORGM");

                entity.Property(e => e.ChoClusterSeniorgmd)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_CLUSTER_SENIORGMD");

                entity.Property(e => e.ChoConManagerDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_CON_MANAGER_DATE");

                entity.Property(e => e.ChoContractorDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_CONTRACTOR_DATE");

                entity.Property(e => e.ChoCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_CREATION_DATE");

                entity.Property(e => e.ChoCreator)
                    .HasPrecision(10)
                    .HasColumnName("CHO_CREATOR");

                entity.Property(e => e.ChoHqGm)
                    .HasPrecision(10)
                    .HasColumnName("CHO_HQ_GM");

                entity.Property(e => e.ChoHqGmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_HQ_GM_DATE");

                entity.Property(e => e.ChoNaCluster)
                    .HasPrecision(10)
                    .HasColumnName("CHO_NA_CLUSTER");

                entity.Property(e => e.ChoNaClusterDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_NA_CLUSTER_DATE");

                entity.Property(e => e.ChoNaHq)
                    .HasPrecision(10)
                    .HasColumnName("CHO_NA_HQ");

                entity.Property(e => e.ChoNaHqDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_NA_HQ_DATE");

                entity.Property(e => e.ChoNwcpmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_NWCPM_DATE");

                entity.Property(e => e.ChoSchedulecontrolGm)
                    .HasPrecision(10)
                    .HasColumnName("CHO_SCHEDULECONTROL_GM");

                entity.Property(e => e.ChoSchedulecontrolGmd)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_SCHEDULECONTROL_GMD");

                entity.Property(e => e.ChoSupervisinconsDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_SUPERVISINCONS_DATE");

                entity.Property(e => e.ChoSupplyChain)
                    .HasPrecision(10)
                    .HasColumnName("CHO_SUPPLY_CHAIN");

                entity.Property(e => e.ChoSupplyChaind2)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_SUPPLY_CHAIND2");

                entity.Property(e => e.ChoTsDirector)
                    .HasPrecision(10)
                    .HasColumnName("CHO_TS_DIRECTOR");

                entity.Property(e => e.ChoTsDirectorDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_TS_DIRECTOR_DATE");

                entity.Property(e => e.ChoTsGm)
                    .HasPrecision(10)
                    .HasColumnName("CHO_TS_GM");

                entity.Property(e => e.ChoTsGmd2)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_TS_GMD2");

                entity.Property(e => e.ChoTsVp)
                    .HasPrecision(10)
                    .HasColumnName("CHO_TS_VP");

                entity.Property(e => e.ChoTsVpd2)
                    .HasColumnType("DATE")
                    .HasColumnName("CHO_TS_VPD2");

                entity.Property(e => e.CoConsOpnion)
                    .IsUnicode(false)
                    .HasColumnName("CO_CONS_OPNION");

                entity.Property(e => e.CoCreator)
                    .HasPrecision(10)
                    .HasColumnName("CO_CREATOR");

                entity.Property(e => e.CoIntdp)
                    .HasPrecision(10)
                    .HasColumnName("CO_INTDP");

                entity.Property(e => e.CoIntopd)
                    .HasPrecision(10)
                    .HasColumnName("CO_INTOPD");

                entity.Property(e => e.CoLettno)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("CO_LETTNO");

                entity.Property(e => e.CoName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("CO_NAME");

                entity.Property(e => e.CoReqdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CO_REQDATE");

                entity.Property(e => e.CoReqlettdate)
                    .HasColumnType("DATE")
                    .HasColumnName("CO_REQLETTDATE");

                entity.Property(e => e.CoSeqNo)
                    .HasMaxLength(1536)
                    .IsUnicode(false)
                    .HasColumnName("CO_SEQ_NO");

                entity.Property(e => e.CoTitle)
                    .HasMaxLength(765)
                    .IsUnicode(false)
                    .HasColumnName("CO_TITLE");

                entity.Property(e => e.CoUserPick)
                    .HasPrecision(10)
                    .HasColumnName("CO_USER_PICK");

                entity.Property(e => e.CountOfChangeOrders)
                    .HasColumnType("FLOAT")
                    .HasColumnName("COUNT_OF_CHANGE_ORDERS");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.Currencyid)
                    .HasPrecision(10)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Currencyrate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CURRENCYRATE");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCbu)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CBU");

                entity.Property(e => e.FypNwcCity)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CITY");

                entity.Property(e => e.FypNwcProjectType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE2");

                entity.Property(e => e.FypNwcRegion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_REGION");

                entity.Property(e => e.IaCoN)
                    .HasPrecision(10)
                    .HasColumnName("IA_CO_N");

                entity.Property(e => e.IaScN)
                    .HasPrecision(10)
                    .HasColumnName("IA_SC_N");

                entity.Property(e => e.NcrNwcPm)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NWC_PM");

                entity.Property(e => e.OmCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("OM_COST");

                entity.Property(e => e.PiConsultantName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONSULTANT_NAME");

                entity.Property(e => e.PiContractorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONTRACTOR_NAME");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.PsProjectClassification)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_CLASSIFICATION");

                entity.Property(e => e.PsProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_TYPE");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.Refid)
                    .HasPrecision(10)
                    .HasColumnName("REFID");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Ucoamountofthiscoca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOAMOUNTOFTHISCOCA");

                entity.Property(e => e.Ucoamountprevtoca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOAMOUNTPREVTOCA");

                entity.Property(e => e.Ucoautocreateflagda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOAUTOCREATEFLAGDA");

                entity.Property(e => e.Ucobdgtchngreqapptb)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UCOBDGTCHNGREQAPPTB");

                entity.Property(e => e.Ucoconumberda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOCONUMBERDA");

                entity.Property(e => e.Ucoconumberia)
                    .HasPrecision(10)
                    .HasColumnName("UCOCONUMBERIA");

                entity.Property(e => e.Ucocountackquotesnqb)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOCOUNTACKQUOTESNQB");

                entity.Property(e => e.Uconactualstodateca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONACTUALSTODATECA");

                entity.Property(e => e.Uconapprovedchangesamtqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONAPPROVEDCHANGESAMTQE");

                entity.Property(e => e.Uconcontractbalanceca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONCONTRACTBALANCECA");

                entity.Property(e => e.Uconcontractnumbertxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UCONCONTRACTNUMBERTXT16");

                entity.Property(e => e.Uconoriginalcontrctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONORIGINALCONTRCTAMTCA");

                entity.Property(e => e.Uconrevisedcontctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONREVISEDCONTCTAMTCA");

                entity.Property(e => e.Ucopendingchangesqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOPENDINGCHANGESQE");

                entity.Property(e => e.Ucopotentialcontactamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOPOTENTIALCONTACTAMTCA");

                entity.Property(e => e.Ucoquoteresrevda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCOQUOTERESREVDA");

                entity.Property(e => e.Ucoreasonpd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UCOREASONPD");

                entity.Property(e => e.Ucoscheduleimpactdaysia)
                    .HasPrecision(10)
                    .HasColumnName("UCOSCHEDULEIMPACTDAYSIA");

                entity.Property(e => e.Ugenactivitydpk)
                    .HasPrecision(10)
                    .HasColumnName("UGENACTIVITYDPK");

                entity.Property(e => e.Ugenaddress1txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS1TXT120");

                entity.Property(e => e.Ugenaddress2txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS2TXT120");

                entity.Property(e => e.Ugenaddress3txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS3TXT120");

                entity.Property(e => e.Ugenbpassignee)
                    .HasPrecision(10)
                    .HasColumnName("UGENBPASSIGNEE");

                entity.Property(e => e.Ugenchangereasonmtl4000)
                    .IsUnicode(false)
                    .HasColumnName("UGENCHANGEREASONMTL4000");

                entity.Property(e => e.Ugencitytxt50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCITYTXT50");

                entity.Property(e => e.Ugenclustertname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCLUSTERTNAME");

                entity.Property(e => e.Ugenconosumda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UGENCONOSUMDA");

                entity.Property(e => e.Ugencontactnametb)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCONTACTNAMETB");

                entity.Property(e => e.Ugencontractrnd)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("UGENCONTRACTRND");

                entity.Property(e => e.Ugencountrypd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCOUNTRYPD")
                    .HasDefaultValueSql("'SA' ");

                entity.Property(e => e.Ugendatecalcdop)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENDATECALCDOP");

                entity.Property(e => e.Ugendescriptionmtl4000)
                    .IsUnicode(false)
                    .HasColumnName("UGENDESCRIPTIONMTL4000");

                entity.Property(e => e.Ugenlineitemcountda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UGENLINEITEMCOUNTDA");

                entity.Property(e => e.Ugenp6plannedcostca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UGENP6PLANNEDCOSTCA");

                entity.Property(e => e.Ugenp6plannedfinishdop)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENP6PLANNEDFINISHDOP");

                entity.Property(e => e.Ugenp6plannedstartdop)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENP6PLANNEDSTARTDOP");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenscopeofworkmtl4000)
                    .IsUnicode(false)
                    .HasColumnName("UGENSCOPEOFWORKMTL4000");

                entity.Property(e => e.Ugenstatepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENSTATEPD");

                entity.Property(e => e.Ugentodaydatedop)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENTODAYDATEDOP");

                entity.Property(e => e.Ugenzipcodetxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UGENZIPCODETXT16");

                entity.Property(e => e.Untpcontractamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UNTPCONTRACTAMTCA");

                entity.Property(e => e.Upocontractdescmlt4000)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTDESCMLT4000");

                entity.Property(e => e.Upocontracttermsmlt4000)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTTERMSMLT4000");

                entity.Property(e => e.Upocontracttypepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTTYPEPD");

                entity.Property(e => e.Uregioncbuname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UREGIONCBUNAME");

                entity.Property(e => e.UsdCurrencyrate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("USD_CURRENCYRATE");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuDmPublishPath)
                    .IsUnicode(false)
                    .HasColumnName("UUU_DM_PUBLISH_PATH");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");

                entity.Property(e => e.UuuUserCompany)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UUU_USER_COMPANY");

                entity.Property(e => e.UuuUserEmail)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UUU_USER_EMAIL");

                entity.Property(e => e.Uvedisadvantagedbuscb)
                    .HasPrecision(10)
                    .HasColumnName("UVEDISADVANTAGEDBUSCB");

                entity.Property(e => e.Uveemailtb120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UVEEMAILTB120");

                entity.Property(e => e.Uvefaxtb16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UVEFAXTB16");

                entity.Property(e => e.Uveminoritybuscb)
                    .HasPrecision(10)
                    .HasColumnName("UVEMINORITYBUSCB");

                entity.Property(e => e.Uvephonetb64)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UVEPHONETB64");

                entity.Property(e => e.Uveprimarycontacttb64)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UVEPRIMARYCONTACTTB64");

                entity.Property(e => e.Uvevendoridtb16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UVEVENDORIDTB16");

                entity.Property(e => e.Uvevendornametb50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UVEVENDORNAMETB50");

                entity.Property(e => e.Uvewomanownedcb)
                    .HasPrecision(10)
                    .HasColumnName("UVEWOMANOWNEDCB");

                entity.Property(e => e.Uxpcpcrecordnobp)
                    .HasPrecision(10)
                    .HasColumnName("UXPCPCRECORDNOBP");

                entity.Property(e => e.VenSuppnam)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("VEN_SUPPNAM");

                entity.Property(e => e.VenSuppnum)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("VEN_SUPPNUM");

                entity.Property(e => e.VendorType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("VENDOR_TYPE");

                entity.Property(e => e.Xid)
                    .HasPrecision(10)
                    .HasColumnName("XID");
            });

            modelBuilder.Entity<UnifierUcx>(entity =>
            {
                entity.ToTable("UNIFIER_UCX");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UCX_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UCX_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UCX_3");

                entity.HasIndex(e => e.Ugenvendorbp, "UNIFIER_UCX__1");

                entity.HasIndex(e => e.Ugenspecsecbp, "UNIFIER_UCX__3");

                entity.HasIndex(e => e.Ugenactivitydpk, "UNIFIER_UCX__4");

                entity.HasIndex(e => e.Ucorfbbp, "UNIFIER_UCX__5");

                entity.HasIndex(e => e.Currencyid, "UNIFIER_UCX__6");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdvancedPerc)
                    .HasColumnType("FLOAT")
                    .HasColumnName("ADVANCED_PERC");

                entity.Property(e => e.AhcId)
                    .HasPrecision(10)
                    .HasColumnName("AHC_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.BcProjectEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_END_DATE");

                entity.Property(e => e.BcProjectEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_COSTS");

                entity.Property(e => e.BcProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_START_DATE");

                entity.Property(e => e.CVat)
                    .HasColumnType("FLOAT")
                    .HasColumnName("C_VAT");

                entity.Property(e => e.CVatTotal)
                    .HasColumnType("FLOAT")
                    .HasColumnName("C_VAT_TOTAL");

                entity.Property(e => e.CheckList1)
                    .IsUnicode(false)
                    .HasColumnName("CHECK_LIST_1");

                entity.Property(e => e.ComAdvpaymenperc)
                    .HasColumnType("FLOAT")
                    .HasColumnName("COM_ADVPAYMENPERC");

                entity.Property(e => e.ConAdvancedPayment)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_ADVANCED_PAYMENT");

                entity.Property(e => e.ConConsignoffDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CON_CONSIGNOFF_DATE");

                entity.Property(e => e.ConPlanfinishDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CON_PLANFINISH_DATE");

                entity.Property(e => e.ConProawrDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CON_PROAWR_DATE");

                entity.Property(e => e.ConReadvancedPayment)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_READVANCED_PAYMENT");

                entity.Property(e => e.ConReadvancedPayment1)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_READVANCED_PAYMENT1");

                entity.Property(e => e.ConReadvancedPayment2)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_READVANCED_PAYMENT2");

                entity.Property(e => e.ConSitehandoverDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CON_SITEHANDOVER_DATE");

                entity.Property(e => e.ConWorkRet)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_WORK_RET");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.Currencyid)
                    .HasPrecision(10)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Currencyrate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CURRENCYRATE");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCity)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CITY");

                entity.Property(e => e.FypNwcProjectType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE2");

                entity.Property(e => e.IaCoD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_CO_D");

                entity.Property(e => e.IaCoN)
                    .HasPrecision(10)
                    .HasColumnName("IA_CO_N");

                entity.Property(e => e.IaScD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_SC_D");

                entity.Property(e => e.IaScN)
                    .HasPrecision(10)
                    .HasColumnName("IA_SC_N");

                entity.Property(e => e.NcrNwcPm)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NWC_PM");

                entity.Property(e => e.NcrPmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_PM_DATE");

                entity.Property(e => e.OmCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("OM_COST");

                entity.Property(e => e.PaTotAdvanceAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_TOT_ADVANCE_AMOUNT");

                entity.Property(e => e.PaTotredvadvAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_TOTREDVADV_AMOUNT");

                entity.Property(e => e.PappReleaseAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAPP_RELEASE_AMOUNT");

                entity.Property(e => e.PappReleaseAmount1)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAPP_RELEASE_AMOUNT1");

                entity.Property(e => e.PiVendorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_VENDOR_NAME");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.ThirdParty)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("THIRD_PARTY");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.TotalcontractAfterChange)
                    .HasColumnType("FLOAT")
                    .HasColumnName("TOTALCONTRACT_AFTER_CHANGE");

                entity.Property(e => e.Uconcontractnumbertxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UCONCONTRACTNUMBERTXT16");

                entity.Property(e => e.Uconoriginalcontrctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONORIGINALCONTRCTAMTCA");

                entity.Property(e => e.Ucorfbbp)
                    .HasPrecision(10)
                    .HasColumnName("UCORFBBP");

                entity.Property(e => e.Ugenactivitydpk)
                    .HasPrecision(10)
                    .HasColumnName("UGENACTIVITYDPK");

                entity.Property(e => e.Ugenaddress1txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS1TXT120");

                entity.Property(e => e.Ugenaddress2txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS2TXT120");

                entity.Property(e => e.Ugenaddress3txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS3TXT120");

                entity.Property(e => e.Ugenbpassignee)
                    .HasPrecision(10)
                    .HasColumnName("UGENBPASSIGNEE");

                entity.Property(e => e.Ugencitytxt50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCITYTXT50");

                entity.Property(e => e.Ugenclustertname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCLUSTERTNAME");

                entity.Property(e => e.Ugencontactnametb)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCONTACTNAMETB");

                entity.Property(e => e.Ugencountrypd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCOUNTRYPD")
                    .HasDefaultValueSql("'SA' ");

                entity.Property(e => e.Ugenp6plannedcostca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UGENP6PLANNEDCOSTCA");

                entity.Property(e => e.Ugenp6plannedfinishdop)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENP6PLANNEDFINISHDOP");

                entity.Property(e => e.Ugenp6plannedstartdop)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENP6PLANNEDSTARTDOP");

                entity.Property(e => e.Ugenprioritypd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPRIORITYPD");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenspecsecbp)
                    .HasPrecision(10)
                    .HasColumnName("UGENSPECSECBP");

                entity.Property(e => e.Ugenstatepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENSTATEPD");

                entity.Property(e => e.Ugenvendorbp)
                    .HasPrecision(10)
                    .HasColumnName("UGENVENDORBP");

                entity.Property(e => e.Ugenzipcodetxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UGENZIPCODETXT16");

                entity.Property(e => e.Uparetainagepctda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPARETAINAGEPCTDA");

                entity.Property(e => e.Upocontractdescmlt4000)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTDESCMLT4000");

                entity.Property(e => e.Upocontracttermsmlt4000)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTTERMSMLT4000");

                entity.Property(e => e.Upocontracttypepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTTYPEPD");

                entity.Property(e => e.Upoexpirydatedop)
                    .HasColumnType("DATE")
                    .HasColumnName("UPOEXPIRYDATEDOP");

                entity.Property(e => e.Uregioncbuname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UREGIONCBUNAME");

                entity.Property(e => e.UsdCurrencyrate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("USD_CURRENCYRATE");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuDmPublishPath)
                    .IsUnicode(false)
                    .HasColumnName("UUU_DM_PUBLISH_PATH");

                entity.Property(e => e.UuuEffectiveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_EFFECTIVE_DATE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");

                entity.Property(e => e.UuuUserEmail)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UUU_USER_EMAIL");

                entity.Property(e => e.UuuUserMobilephone)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UUU_USER_MOBILEPHONE");

                entity.Property(e => e.UuuUserWorkphone)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UUU_USER_WORKPHONE");

                entity.Property(e => e.Uvedisadvantagedbuscb)
                    .HasPrecision(10)
                    .HasColumnName("UVEDISADVANTAGEDBUSCB");

                entity.Property(e => e.Uveemailtb120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UVEEMAILTB120");

                entity.Property(e => e.Uvefaxtb16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UVEFAXTB16");

                entity.Property(e => e.Uveminoritybuscb)
                    .HasPrecision(10)
                    .HasColumnName("UVEMINORITYBUSCB");

                entity.Property(e => e.Uvephonetb64)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UVEPHONETB64");

                entity.Property(e => e.Uveprimarycontacttb64)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UVEPRIMARYCONTACTTB64");

                entity.Property(e => e.Uvevendoridtb16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UVEVENDORIDTB16");

                entity.Property(e => e.Uvevendornametb50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UVEVENDORNAMETB50");

                entity.Property(e => e.Uvewomanownedcb)
                    .HasPrecision(10)
                    .HasColumnName("UVEWOMANOWNEDCB");

                entity.Property(e => e.VatPercent)
                    .HasPrecision(10)
                    .HasColumnName("VAT_PERCENT");

                entity.Property(e => e.VenSupparnam)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("VEN_SUPPARNAM");

                entity.Property(e => e.VenSupplieridPk)
                    .HasPrecision(10)
                    .HasColumnName("VEN_SUPPLIERID_PK");

                entity.Property(e => e.VendorType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("VENDOR_TYPE");

                entity.Property(e => e.Xid)
                    .HasPrecision(10)
                    .HasColumnName("XID");
            });

            modelBuilder.Entity<UnifierUsP>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("UNIFIER_US_P_PK");

                entity.ToTable("UNIFIER_US_P");

                entity.HasIndex(e => e.EnjaPickRef, "UNIFIER_US_P__1");

                entity.HasIndex(e => e.PiContractor, "UNIFIER_US_P__2");

                entity.HasIndex(e => e.FypProjectPk, "UNIFIER_US_P__3");

                entity.HasIndex(e => e.PiConsultant, "UNIFIER_US_P__4");

                entity.HasIndex(e => e.FypPeriodPk, "UNIFIER_US_P__5");

                entity.HasIndex(e => e.FypProjectPkRef, "UNIFIER_US_P__6");

                entity.HasIndex(e => e.CmpConName, "UNIFIER_US_P__7");

                entity.Property(e => e.Pid)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("PID");

                entity.Property(e => e.BcAssessingOptions)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_ASSESSING_OPTIONS");

                entity.Property(e => e.BcCostChart)
                    .IsUnicode(false)
                    .HasColumnName("BC_COST_CHART");

                entity.Property(e => e.BcCostChartAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_COST_CHART_ATT");

                entity.Property(e => e.BcCostMechanism)
                    .IsUnicode(false)
                    .HasColumnName("BC_COST_MECHANISM");

                entity.Property(e => e.BcCostStudy)
                    .IsUnicode(false)
                    .HasColumnName("BC_COST_STUDY");

                entity.Property(e => e.BcCostStudyAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_COST_STUDY_ATT");

                entity.Property(e => e.BcCostSupervision)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_COST_SUPERVISION");

                entity.Property(e => e.BcCreatingNewJobs)
                    .HasPrecision(10)
                    .HasColumnName("BC_CREATING_NEW_JOBS");

                entity.Property(e => e.BcCurrentSize)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_CURRENT_SIZE");

                entity.Property(e => e.BcCurrentVolume)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_CURRENT_VOLUME");

                entity.Property(e => e.BcDesignCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_DESIGN_COST");

                entity.Property(e => e.BcEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_ESTIMATED_COSTS");

                entity.Property(e => e.BcFinalEconomic)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_FINAL_ECONOMIC");

                entity.Property(e => e.BcFinalFinancial)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_FINAL_FINANCIAL");

                entity.Property(e => e.BcFinalStrategic)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_FINAL_STRATEGIC");

                entity.Property(e => e.BcFinancing)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_FINANCING");

                entity.Property(e => e.BcGap)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_GAP");

                entity.Property(e => e.BcImPlan)
                    .IsUnicode(false)
                    .HasColumnName("BC_IM_PLAN");

                entity.Property(e => e.BcImPlanAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_IM_PLAN_ATT");

                entity.Property(e => e.BcImRisks)
                    .IsUnicode(false)
                    .HasColumnName("BC_IM_RISKS");

                entity.Property(e => e.BcImRisksAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_IM_RISKS_ATT");

                entity.Property(e => e.BcInitiativeName)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_INITIATIVE_NAME");

                entity.Property(e => e.BcMonthlyProjectSr)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_MONTHLY_PROJECT_SR");

                entity.Property(e => e.BcNameProgram)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_NAME_PROGRAM");

                entity.Property(e => e.BcNeedProject)
                    .IsUnicode(false)
                    .HasColumnName("BC_NEED_PROJECT");

                entity.Property(e => e.BcNumbeBeneficiaries)
                    .HasPrecision(10)
                    .HasColumnName("BC_NUMBE_BENEFICIARIES");

                entity.Property(e => e.BcNumberJobs)
                    .HasPrecision(10)
                    .HasColumnName("BC_NUMBER_JOBS");

                entity.Property(e => e.BcNumberPosts)
                    .HasPrecision(10)
                    .HasColumnName("BC_NUMBER_POSTS");

                entity.Property(e => e.BcOperationalCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_OPERATIONAL_COSTS");

                entity.Property(e => e.BcOtherBenefits)
                    .IsUnicode(false)
                    .HasColumnName("BC_OTHER_BENEFITS");

                entity.Property(e => e.BcPreviousStudies)
                    .IsUnicode(false)
                    .HasColumnName("BC_PREVIOUS_STUDIES");

                entity.Property(e => e.BcProgram)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROGRAM");

                entity.Property(e => e.BcProjectCostNo)
                    .HasPrecision(10)
                    .HasColumnName("BC_PROJECT_COST_NO");

                entity.Property(e => e.BcProjectEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_END_DATE");

                entity.Property(e => e.BcProjectEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_COSTS");

                entity.Property(e => e.BcProjectInitiatives)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROJECT_INITIATIVES");

                entity.Property(e => e.BcProjectObjectives)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROJECT_OBJECTIVES");

                entity.Property(e => e.BcProjectPlan)
                    .HasPrecision(10)
                    .HasColumnName("BC_PROJECT_PLAN");

                entity.Property(e => e.BcProjectPrograms)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROJECT_PROGRAMS");

                entity.Property(e => e.BcProjectRatio)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_RATIO");

                entity.Property(e => e.BcProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_START_DATE");

                entity.Property(e => e.BcRatioAfter)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_RATIO_AFTER");

                entity.Property(e => e.BcRatioAfterProject)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_RATIO_AFTER_PROJECT");

                entity.Property(e => e.BcRatioBefore)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_RATIO_BEFORE");

                entity.Property(e => e.BcReliability)
                    .IsUnicode(false)
                    .HasColumnName("BC_RELIABILITY");

                entity.Property(e => e.BcRevenueIncrease)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_REVENUE_INCREASE");

                entity.Property(e => e.BcScheduleMonth)
                    .HasPrecision(10)
                    .HasColumnName("BC_SCHEDULE_MONTH");

                entity.Property(e => e.BcScopeProject)
                    .IsUnicode(false)
                    .HasColumnName("BC_SCOPE_PROJECT");

                entity.Property(e => e.BcSizeGap)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_SIZE_GAP");

                entity.Property(e => e.BcSizeProject)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_SIZE_PROJECT");

                entity.Property(e => e.BcStrategic)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_STRATEGIC");

                entity.Property(e => e.BcStrategicConsensus)
                    .IsUnicode(false)
                    .HasColumnName("BC_STRATEGIC_CONSENSUS");

                entity.Property(e => e.BcStrategicProject)
                    .IsUnicode(false)
                    .HasColumnName("BC_STRATEGIC_PROJECT");

                entity.Property(e => e.BcSupplyChain)
                    .HasPrecision(10)
                    .HasColumnName("BC_SUPPLY_CHAIN");

                entity.Property(e => e.BcVolume)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("BC_VOLUME");

                entity.Property(e => e.ChPlannedE)
                    .HasColumnType("DATE")
                    .HasColumnName("CH_PLANNED_E");

                entity.Property(e => e.ChPlannedS)
                    .HasColumnType("DATE")
                    .HasColumnName("CH_PLANNED_S");

                entity.Property(e => e.CmpConName)
                    .HasPrecision(10)
                    .HasColumnName("CMP_CON_NAME");

                entity.Property(e => e.ContractSt1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("CONTRACT_ST1");

                entity.Property(e => e.Description)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EnjaPickRef)
                    .HasPrecision(10)
                    .HasColumnName("ENJA_PICK_REF");

                entity.Property(e => e.FypEntityId)
                    .HasMaxLength(96)
                    .IsUnicode(false)
                    .HasColumnName("FYP_ENTITY_ID");

                entity.Property(e => e.FypEstimatedCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("FYP_ESTIMATED_COST");

                entity.Property(e => e.FypNwcCbu)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CBU");

                entity.Property(e => e.FypNwcCity)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CITY");

                entity.Property(e => e.FypNwcCluster)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CLUSTER");

                entity.Property(e => e.FypNwcContractStatus)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CONTRACT_STATUS");

                entity.Property(e => e.FypNwcPackage)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PACKAGE");

                entity.Property(e => e.FypNwcProjectClassificat)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_CLASSIFICAT");

                entity.Property(e => e.FypNwcProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE");

                entity.Property(e => e.FypNwcProjectType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE2");

                entity.Property(e => e.FypNwcRegion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_REGION");

                entity.Property(e => e.FypNwcSpecialProgram)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_SPECIAL_PROGRAM");

                entity.Property(e => e.FypNwcSubstitution)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_SUBSTITUTION");

                entity.Property(e => e.FypPeriodPk)
                    .HasPrecision(10)
                    .HasColumnName("FYP_PERIOD_PK");

                entity.Property(e => e.FypProjectPk)
                    .HasPrecision(10)
                    .HasColumnName("FYP_PROJECT_PK");

                entity.Property(e => e.FypProjectPkRef)
                    .HasPrecision(10)
                    .HasColumnName("FYP_PROJECT_PK_REF");

                entity.Property(e => e.FypProjectSn)
                    .HasMaxLength(96)
                    .IsUnicode(false)
                    .HasColumnName("FYP_PROJECT_SN");

                entity.Property(e => e.NewHandoverDate)
                    .HasColumnType("DATE")
                    .HasColumnName("NEW_HANDOVER_DATE");

                entity.Property(e => e.OmCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("OM_COST");

                entity.Property(e => e.PhasesProject)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PHASES_PROJECT");

                entity.Property(e => e.PiActualandplanneddifferen)
                    .HasPrecision(10)
                    .HasColumnName("PI_ACTUALANDPLANNEDDIFFEREN");

                entity.Property(e => e.PiActualpercentage)
                    .HasPrecision(10)
                    .HasColumnName("PI_ACTUALPERCENTAGE");

                entity.Property(e => e.PiAdministrativeauthority)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_ADMINISTRATIVEAUTHORITY");

                entity.Property(e => e.PiAdvertiser)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_ADVERTISER");

                entity.Property(e => e.PiAwarddateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_AWARDDATEG");

                entity.Property(e => e.PiBudgetitemname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_BUDGETITEMNAME");

                entity.Property(e => e.PiBudgetprojectno)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_BUDGETPROJECTNO");

                entity.Property(e => e.PiCommitteeformationdate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_COMMITTEEFORMATIONDATE");

                entity.Property(e => e.PiCommitteeformationdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_COMMITTEEFORMATIONDATEG");

                entity.Property(e => e.PiConsultant)
                    .HasPrecision(10)
                    .HasColumnName("PI__CONSULTANT");

                entity.Property(e => e.PiConsultantName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONSULTANT_NAME");

                entity.Property(e => e.PiConsultantcontract)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONSULTANTCONTRACT");

                entity.Property(e => e.PiContractCopy)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACT_COPY");

                entity.Property(e => e.PiContractNotes)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACT_NOTES");

                entity.Property(e => e.PiContractNumberDepartme)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACT_NUMBER_DEPARTME");

                entity.Property(e => e.PiContractReductions)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_CONTRACT_REDUCTIONS");

                entity.Property(e => e.PiContractStartsFrom)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACT_STARTS_FROM");

                entity.Property(e => e.PiContractduration)
                    .HasPrecision(10)
                    .HasColumnName("PI_CONTRACTDURATION");

                entity.Property(e => e.PiContractenddate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTENDDATE");

                entity.Property(e => e.PiContractenddateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_CONTRACTENDDATEG");

                entity.Property(e => e.PiContractextenduration)
                    .HasPrecision(10)
                    .HasColumnName("PI_CONTRACTEXTENDURATION");

                entity.Property(e => e.PiContractor)
                    .HasPrecision(10)
                    .HasColumnName("PI__CONTRACTOR");

                entity.Property(e => e.PiContractorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONTRACTOR_NAME");

                entity.Property(e => e.PiContractorrequestdate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTORREQUESTDATE");

                entity.Property(e => e.PiContractorrequestdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_CONTRACTORREQUESTDATEG");

                entity.Property(e => e.PiContractsigningdate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTSIGNINGDATE");

                entity.Property(e => e.PiContractsigningdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_CONTRACTSIGNINGDATEG");

                entity.Property(e => e.PiContractstatus)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTSTATUS");

                entity.Property(e => e.PiContractstatus1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTSTATUS1");

                entity.Property(e => e.PiContractstatus2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTSTATUS2");

                entity.Property(e => e.PiContractstatus3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTRACTSTATUS3");

                entity.Property(e => e.PiContractvalue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_CONTRACTVALUE");

                entity.Property(e => e.PiContsitehandoverdate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_CONTSITEHANDOVERDATE");

                entity.Property(e => e.PiContsitehandoverdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_CONTSITEHANDOVERDATEG");

                entity.Property(e => e.PiCumulative)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_CUMULATIVE");

                entity.Property(e => e.PiCumulativeActual)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_CUMULATIVE_ACTUAL");

                entity.Property(e => e.PiDateNotificationDirect)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_DATE_NOTIFICATION_DIRECT");

                entity.Property(e => e.PiDateOpeningEnvelopes)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_DATE_OPENING_ENVELOPES");

                entity.Property(e => e.PiDelay)
                    .HasPrecision(10)
                    .HasColumnName("PI_DELAY");

                entity.Property(e => e.PiDescriptionCompetition)
                    .IsUnicode(false)
                    .HasColumnName("PI_DESCRIPTION_COMPETITION");

                entity.Property(e => e.PiDescriptionDurationCon)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_DESCRIPTION_DURATION_CON");

                entity.Property(e => e.PiDescriptionPeriod)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_DESCRIPTION_PERIOD");

                entity.Property(e => e.PiDrawdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_DRAWDATEG");

                entity.Property(e => e.PiDurationContract)
                    .HasPrecision(10)
                    .HasColumnName("PI_DURATION_CONTRACT");

                entity.Property(e => e.PiEndDateOpeningEnvelop)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_END_DATE_OPENING_ENVELOP");

                entity.Property(e => e.PiEndDateScreeningFers)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_END_DATE_SCREENING_FERS");

                entity.Property(e => e.PiEndDateTechnicalAnaly)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_END_DATE_TECHNICAL_ANALY");

                entity.Property(e => e.PiFinalPlannedReceipt)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_FINAL_PLANNED_RECEIPT");

                entity.Property(e => e.PiHomeconnectionsno)
                    .HasPrecision(10)
                    .HasColumnName("PI_HOMECONNECTIONSNO");

                entity.Property(e => e.PiIncreasesInContractVa)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_INCREASES_IN_CONTRACT_VA");

                entity.Property(e => e.PiIrsigningdate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_IRSIGNINGDATE");

                entity.Property(e => e.PiIrsigningdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_IRSIGNINGDATEG");

                entity.Property(e => e.PiLastDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_LAST_DATE");

                entity.Property(e => e.PiLastExtensionFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_LAST_EXTENSION_FROM");

                entity.Property(e => e.PiLastExtensionTo)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_LAST_EXTENSION_TO");

                entity.Property(e => e.PiMobileSupervisor)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_MOBILE_SUPERVISOR");

                entity.Property(e => e.PiModificationduration)
                    .HasPrecision(10)
                    .HasColumnName("PI_MODIFICATIONDURATION");

                entity.Property(e => e.PiModifiedcontenddate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_MODIFIEDCONTENDDATE");

                entity.Property(e => e.PiModifiedcontenddateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_MODIFIEDCONTENDDATEG");

                entity.Property(e => e.PiModifiedcontractvalue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_MODIFIEDCONTRACTVALUE");

                entity.Property(e => e.PiModifiedplannedpercent)
                    .HasPrecision(10)
                    .HasColumnName("PI_MODIFIEDPLANNEDPERCENT");

                entity.Property(e => e.PiNameSignature)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_NAME_SIGNATURE");

                entity.Property(e => e.PiNelineslengths)
                    .HasPrecision(10)
                    .HasColumnName("PI_NELINESLENGTHS");

                entity.Property(e => e.PiNwcmewaclassification)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_NWCMEWACLASSIFICATION");

                entity.Property(e => e.PiPasseddurationpercentage)
                    .HasPrecision(10)
                    .HasColumnName("PI_PASSEDDURATIONPERCENTAGE");

                entity.Property(e => e.PiPeriodhomeconnectionsno)
                    .HasPrecision(10)
                    .HasColumnName("PI_PERIODHOMECONNECTIONSNO");

                entity.Property(e => e.PiPeriodnelineslengths)
                    .HasPrecision(10)
                    .HasColumnName("PI_PERIODNELINESLENGTHS");

                entity.Property(e => e.PiPlannedPrimaryReceipt)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_PLANNED_PRIMARY_RECEIPT");

                entity.Property(e => e.PiPlannedpercentage)
                    .HasPrecision(10)
                    .HasColumnName("PI_PLANNEDPERCENTAGE");

                entity.Property(e => e.PiPono)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_PONO");

                entity.Property(e => e.PiPositionSignatureHolde)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_POSITION_SIGNATURE_HOLDE");

                entity.Property(e => e.PiProjectConsultantEngin)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_PROJECT_CONSULTANT_ENGIN");

                entity.Property(e => e.PiProjectestimatedvalue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_PROJECTESTIMATEDVALUE");

                entity.Property(e => e.PiProjectlastmodifieddate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_PROJECTLASTMODIFIEDDATE");

                entity.Property(e => e.PiProjectlocation)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_PROJECTLOCATION");

                entity.Property(e => e.PiProjectstatus)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_PROJECTSTATUS");

                entity.Property(e => e.PiPurchaseno)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_PURCHASENO");

                entity.Property(e => e.PiReasonForExtension)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_REASON_FOR_EXTENSION");

                entity.Property(e => e.PiReleaseDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_RELEASE_DATE");

                entity.Property(e => e.PiRequestingParty)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_REQUESTING_PARTY");

                entity.Property(e => e.PiResponsible)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_RESPONSIBLE");

                entity.Property(e => e.PiResponsibleDetail)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_RESPONSIBLE_DETAIL");

                entity.Property(e => e.PiReviews)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_REVIEWS");

                entity.Property(e => e.PiSchedulereceiptdate)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_SCHEDULERECEIPTDATE");

                entity.Property(e => e.PiSchedulereceiptdateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_SCHEDULERECEIPTDATEG");

                entity.Property(e => e.PiSector)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_SECTOR");

                entity.Property(e => e.PiSiteProcessingPeriod)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_SITE_PROCESSING_PERIOD");

                entity.Property(e => e.PiStopNumber)
                    .IsUnicode(false)
                    .HasColumnName("PI_STOP_NUMBER");

                entity.Property(e => e.PiSubtractionStatus)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_SUBTRACTION_STATUS");

                entity.Property(e => e.PiSupervisorEmail)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_SUPERVISOR_EMAIL");

                entity.Property(e => e.PiSupervisorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_SUPERVISOR_NAME");

                entity.Property(e => e.PiSupervisorNumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_SUPERVISOR_NUMBER");

                entity.Property(e => e.PiSuspensiondateg)
                    .HasColumnType("DATE")
                    .HasColumnName("PI_SUSPENSIONDATEG");

                entity.Property(e => e.PiSuspensionreason)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("PI_SUSPENSIONREASON");

                entity.Property(e => e.PiTotalInformalExtension)
                    .HasPrecision(10)
                    .HasColumnName("PI_TOTAL_INFORMAL_EXTENSION");

                entity.Property(e => e.PiTotalplansno)
                    .HasPrecision(10)
                    .HasColumnName("PI_TOTALPLANSNO");

                entity.Property(e => e.PiValueWorksExecuted)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PI_VALUE_WORKS_EXECUTED");

                entity.Property(e => e.PiWithdrawal)
                    .IsUnicode(false)
                    .HasColumnName("PI_WITHDRAWAL");

                entity.Property(e => e.Piopcontractno)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PIOPCONTRACTNO");

                entity.Property(e => e.ProInfoReasonSusp)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PRO_INFO_REASON_SUSP");

                entity.Property(e => e.ProInfoSusDiff)
                    .HasPrecision(10)
                    .HasColumnName("PRO_INFO_SUS_DIFF");

                entity.Property(e => e.ProInfoSuspRespAuth)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PRO_INFO_SUSP_RESP_AUTH");

                entity.Property(e => e.ProInfoTodaysus)
                    .HasColumnType("DATE")
                    .HasColumnName("PRO_INFO_TODAYSUS");

                entity.Property(e => e.ProInfoWithdDiff)
                    .HasPrecision(10)
                    .HasColumnName("PRO_INFO_WITHD_DIFF");

                entity.Property(e => e.ProInfoWithdToday)
                    .HasColumnType("DATE")
                    .HasColumnName("PRO_INFO_WITHD_TODAY");

                entity.Property(e => e.ProInfoWithdYears)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRO_INFO_WITHD_YEARS");

                entity.Property(e => e.ProInfoYofsusp)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRO_INFO_YOFSUSP");

                entity.Property(e => e.PsProjectClassification)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_CLASSIFICATION");

                entity.Property(e => e.PsProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_TYPE");

                entity.Property(e => e.ShellTemplateName)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("SHELL_TEMPLATE_NAME");

                entity.Property(e => e.Ugenaddress1txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS1TXT120");

                entity.Property(e => e.Ugenaddress2txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS2TXT120");

                entity.Property(e => e.Ugenaddress3txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS3TXT120");

                entity.Property(e => e.Ugencitytxt50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCITYTXT50");

                entity.Property(e => e.Ugencountrypd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCOUNTRYPD")
                    .HasDefaultValueSql("'SA' ");

                entity.Property(e => e.Ugenestbudgetca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UGENESTBUDGETCA");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenprojecttypepd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTTYPEPD")
                    .HasDefaultValueSql("null ");

                entity.Property(e => e.Ugenprojenddatedo)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENPROJENDDATEDO");

                entity.Property(e => e.Ugenstatepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENSTATEPD");

                entity.Property(e => e.Ugenzipcodetxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UGENZIPCODETXT16");

                entity.Property(e => e.UuuAddressCode)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("UUU_ADDRESS_CODE");

                entity.Property(e => e.UuuAdministrator)
                    .HasPrecision(10)
                    .HasColumnName("UUU_ADMINISTRATOR");

                entity.Property(e => e.UuuIntP6ProjectId)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("UUU_INT_P6_PROJECT_ID");

                entity.Property(e => e.UuuIntScheduleType)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_INT_SCHEDULE_TYPE");

                entity.Property(e => e.UuuIntegratedWith)
                    .HasMaxLength(765)
                    .IsUnicode(false)
                    .HasColumnName("UUU_INTEGRATED_WITH");

                entity.Property(e => e.UuuLat)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_LAT");

                entity.Property(e => e.UuuLatitude)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_LATITUDE");

                entity.Property(e => e.UuuLocation)
                    .HasPrecision(10)
                    .HasColumnName("UUU_LOCATION");

                entity.Property(e => e.UuuLong)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_LONG");

                entity.Property(e => e.UuuLongitude)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_LONGITUDE");

                entity.Property(e => e.UuuProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_PROJECT_START_DATE");

                entity.Property(e => e.UuuShellStatus)
                    .HasPrecision(10)
                    .HasColumnName("UUU_SHELL_STATUS");
            });

            modelBuilder.Entity<UnifierUxdev>(entity =>
            {
                entity.ToTable("UNIFIER_UXDEV");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UXDEV_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UXDEV_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UXDEV_3");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.DelivAllServWYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_ALL_SERV_W_YEAR");

                entity.Property(e => e.DelivAllServWwYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_ALL_SERV_WW_YEAR");

                entity.Property(e => e.DelivConWMonth)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_CON_W_MONTH");

                entity.Property(e => e.DelivConWYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_CON_W_YEAR");

                entity.Property(e => e.DelivConWwMonth)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_CON_WW_MONTH");

                entity.Property(e => e.DelivConWwYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_CON_WW_YEAR");

                entity.Property(e => e.DelivNetWMonth)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_NET_W_MONTH");

                entity.Property(e => e.DelivNetWYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_NET_W_YEAR");

                entity.Property(e => e.DelivNetWwMonth)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_NET_WW_MONTH");

                entity.Property(e => e.DelivNetWwYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_NET_WW_YEAR");

                entity.Property(e => e.DelivServConWMonth)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_SERV_CON_W_MONTH");

                entity.Property(e => e.DelivServConWYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_SERV_CON_W_YEAR");

                entity.Property(e => e.DelivServConWwMonth)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_SERV_CON_WW_MONTH");

                entity.Property(e => e.DelivServConWwYear)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_SERV_CON_WW_YEAR");

                entity.Property(e => e.DelivServPerCon)
                    .HasColumnType("FLOAT")
                    .HasColumnName("DELIV_SERV_PER_CON");

                entity.Property(e => e.DelivType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("DELIV_TYPE");

                entity.Property(e => e.DisiText)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("DISI_TEXT");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCluster)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CLUSTER");

                entity.Property(e => e.FypNwcRegion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_REGION");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Umumonthpd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UMUMONTHPD");

                entity.Property(e => e.Umuyearpd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UMUYEARPD");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");
            });

            modelBuilder.Entity<UnifierUxfyp>(entity =>
            {
                entity.ToTable("UNIFIER_UXFYP");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UXFYP_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UXFYP_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UXFYP_3");

                entity.HasIndex(e => e.BcImage, "UNIFIER_UXFYP__1");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AcpPk)
                    .HasPrecision(10)
                    .HasColumnName("ACP_PK");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.BcAnnualCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_ANNUAL_COST");

                entity.Property(e => e.BcAnnualRevenue)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_ANNUAL_REVENUE");

                entity.Property(e => e.BcCostChartAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_COST_CHART_ATT");

                entity.Property(e => e.BcCostMechanism)
                    .IsUnicode(false)
                    .HasColumnName("BC_COST_MECHANISM");

                entity.Property(e => e.BcCostStudy)
                    .IsUnicode(false)
                    .HasColumnName("BC_COST_STUDY");

                entity.Property(e => e.BcCostStudyAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_COST_STUDY_ATT");

                entity.Property(e => e.BcCostSupervision)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_COST_SUPERVISION");

                entity.Property(e => e.BcCoverageRate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_COVERAGE_RATE");

                entity.Property(e => e.BcDegree)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_DEGREE");

                entity.Property(e => e.BcDesignCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_DESIGN_COST");

                entity.Property(e => e.BcEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_ESTIMATED_COSTS");

                entity.Property(e => e.BcFinalCalssification)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_FINAL_CALSSIFICATION");

                entity.Property(e => e.BcImPlanAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_IM_PLAN_ATT");

                entity.Property(e => e.BcImRisks)
                    .IsUnicode(false)
                    .HasColumnName("BC_IM_RISKS");

                entity.Property(e => e.BcImRisksAtt)
                    .HasPrecision(10)
                    .HasColumnName("BC_IM_RISKS_ATT");

                entity.Property(e => e.BcImage)
                    .HasPrecision(10)
                    .HasColumnName("BC_IMAGE");

                entity.Property(e => e.BcKpi)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_KPI");

                entity.Property(e => e.BcKu1)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_KU1");

                entity.Property(e => e.BcKu11)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_KU11");

                entity.Property(e => e.BcMonthlyProjectSr)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_MONTHLY_PROJECT_SR");

                entity.Property(e => e.BcNeedProject)
                    .IsUnicode(false)
                    .HasColumnName("BC_NEED_PROJECT");

                entity.Property(e => e.BcNumbeBeneficiaries)
                    .HasPrecision(10)
                    .HasColumnName("BC_NUMBE_BENEFICIARIES");

                entity.Property(e => e.BcNumberJobs)
                    .HasPrecision(10)
                    .HasColumnName("BC_NUMBER_JOBS");

                entity.Property(e => e.BcNumberPosts)
                    .HasPrecision(10)
                    .HasColumnName("BC_NUMBER_POSTS");

                entity.Property(e => e.BcOtherBenefits)
                    .IsUnicode(false)
                    .HasColumnName("BC_OTHER_BENEFITS");

                entity.Property(e => e.BcPerIndex)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_PER_INDEX");

                entity.Property(e => e.BcPerUnit)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_PER_UNIT");

                entity.Property(e => e.BcPriority)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PRIORITY");

                entity.Property(e => e.BcProgramMulti)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROGRAM_MULTI");

                entity.Property(e => e.BcProjectCostNo)
                    .HasPrecision(10)
                    .HasColumnName("BC_PROJECT_COST_NO");

                entity.Property(e => e.BcProjectEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_END_DATE");

                entity.Property(e => e.BcProjectEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_COSTS");

                entity.Property(e => e.BcProjectEstimatedVat)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_VAT");

                entity.Property(e => e.BcProjectLinked)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROJECT_LINKED");

                entity.Property(e => e.BcProjectObjectives)
                    .IsUnicode(false)
                    .HasColumnName("BC_PROJECT_OBJECTIVES");

                entity.Property(e => e.BcProjectPlan)
                    .HasPrecision(10)
                    .HasColumnName("BC_PROJECT_PLAN");

                entity.Property(e => e.BcProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_START_DATE");

                entity.Property(e => e.BcRemarks)
                    .IsUnicode(false)
                    .HasColumnName("BC_REMARKS");

                entity.Property(e => e.BcRevenueIncrease)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_REVENUE_INCREASE");

                entity.Property(e => e.BcScheduleMonth)
                    .HasPrecision(10)
                    .HasColumnName("BC_SCHEDULE_MONTH");

                entity.Property(e => e.BcScopeProject)
                    .IsUnicode(false)
                    .HasColumnName("BC_SCOPE_PROJECT");

                entity.Property(e => e.BcScore1)
                    .HasPrecision(10)
                    .HasColumnName("BC_SCORE1");

                entity.Property(e => e.BcScore3)
                    .HasPrecision(10)
                    .HasColumnName("BC_SCORE3");

                entity.Property(e => e.BcServed)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_SERVED");

                entity.Property(e => e.BcSpk)
                    .HasPrecision(10)
                    .HasColumnName("BC_SPK");

                entity.Property(e => e.BcStrategic)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_STRATEGIC");

                entity.Property(e => e.BcStrategicConsensus)
                    .IsUnicode(false)
                    .HasColumnName("BC_STRATEGIC_CONSENSUS");

                entity.Property(e => e.BcStrategicProject)
                    .IsUnicode(false)
                    .HasColumnName("BC_STRATEGIC_PROJECT");

                entity.Property(e => e.BcUnit)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BC_UNIT");

                entity.Property(e => e.BccCreatingNewJobs)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BCC_CREATING_NEW_JOBS");

                entity.Property(e => e.BccDegree)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_DEGREE");

                entity.Property(e => e.BccDegree3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_DEGREE3");

                entity.Property(e => e.BccKpi)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_KPI");

                entity.Property(e => e.BccKpi3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_KPI3");

                entity.Property(e => e.BccKu1)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BCC_KU1");

                entity.Property(e => e.BccKu11)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BCC_KU11");

                entity.Property(e => e.BccKu13)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BCC_KU13");

                entity.Property(e => e.BccKu131)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BCC_KU131");

                entity.Property(e => e.BccPerIndex)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_PER_INDEX");

                entity.Property(e => e.BccPerIndex3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_PER_INDEX3");

                entity.Property(e => e.BccPerUnit)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_PER_UNIT");

                entity.Property(e => e.BccPerUnit3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_PER_UNIT3");

                entity.Property(e => e.BccUnit)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_UNIT");

                entity.Property(e => e.BccUnit3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("BCC_UNIT3");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypMofId)
                    .HasMaxLength(96)
                    .IsUnicode(false)
                    .HasColumnName("FYP_MOF_ID");

                entity.Property(e => e.FypNwcCbu)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CBU");

                entity.Property(e => e.FypNwcCity)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CITY");

                entity.Property(e => e.FypNwcCluster)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CLUSTER");

                entity.Property(e => e.FypNwcContractStatus)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CONTRACT_STATUS");

                entity.Property(e => e.FypNwcPackage)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PACKAGE");

                entity.Property(e => e.FypNwcProjectClassificat)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_CLASSIFICAT");

                entity.Property(e => e.FypNwcProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE");

                entity.Property(e => e.FypNwcProjectType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE2");

                entity.Property(e => e.FypNwcRegion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_REGION");

                entity.Property(e => e.FypNwcSpecialProgram)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_SPECIAL_PROGRAM");

                entity.Property(e => e.FypNwcSubstitution)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_SUBSTITUTION");

                entity.Property(e => e.FypPeriodPk)
                    .HasPrecision(10)
                    .HasColumnName("FYP_PERIOD_PK");

                entity.Property(e => e.FypProjectSn)
                    .HasMaxLength(96)
                    .IsUnicode(false)
                    .HasColumnName("FYP_PROJECT_SN");

                entity.Property(e => e.FypProjectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_PROJECTNAME");

                entity.Property(e => e.FypProjectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_PROJECTNUMBER");

                entity.Property(e => e.IpSn)
                    .HasPrecision(10)
                    .HasColumnName("IP_SN");

                entity.Property(e => e.MofType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("MOF_TYPE");

                entity.Property(e => e.NwcPsn)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NWC_PSN");

                entity.Property(e => e.OmCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("OM_COST");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.PtwMap)
                    .IsUnicode(false)
                    .HasColumnName("PTW_MAP");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.UpdateType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UPDATE_TYPE")
                    .HasDefaultValueSql("'Update' ");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuLatitude)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_LATITUDE");

                entity.Property(e => e.UuuLongitude)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UUU_LONGITUDE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");
            });

            modelBuilder.Entity<UnifierUxiahi>(entity =>
            {
                entity.ToTable("UNIFIER_UXIAHI");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UXIAHI_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UXIAHI_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UXIAHI_3");

                entity.HasIndex(e => e.Ugencontractrefbp, "UNIFIER_UXIAHI__1");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.ConConsignoffDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CON_CONSIGNOFF_DATE");

                entity.Property(e => e.ConProawrDate)
                    .HasColumnType("DATE")
                    .HasColumnName("CON_PROAWR_DATE");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCbu)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CBU");

                entity.Property(e => e.FypNwcRegion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_REGION");

                entity.Property(e => e.IaCD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_C_D");

                entity.Property(e => e.IaCN)
                    .HasPrecision(10)
                    .HasColumnName("IA_C_N");

                entity.Property(e => e.IaCoD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_CO_D");

                entity.Property(e => e.IaCoN)
                    .HasPrecision(10)
                    .HasColumnName("IA_CO_N");

                entity.Property(e => e.IaComDecision)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("IA_COM_DECISION");

                entity.Property(e => e.IaCommentCommite)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_COMMITE");

                entity.Property(e => e.IaCommentCommittee)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_COMMITTEE");

                entity.Property(e => e.IaCommentConsultant)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_CONSULTANT");

                entity.Property(e => e.IaCommentContractor)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_CONTRACTOR");

                entity.Property(e => e.IaCommentCpgmsgm)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_CPGMSGM");

                entity.Property(e => e.IaCommentPcgm)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_PCGM");

                entity.Property(e => e.IaCommentPm)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_PM");

                entity.Property(e => e.IaCommentTs)
                    .IsUnicode(false)
                    .HasColumnName("IA_COMMENT_TS");

                entity.Property(e => e.IaCpgmD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_CPGM_D");

                entity.Property(e => e.IaCpgmN)
                    .HasPrecision(10)
                    .HasColumnName("IA_CPGM_N");

                entity.Property(e => e.IaCsgmD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_CSGM_D");

                entity.Property(e => e.IaCsgmN)
                    .HasPrecision(10)
                    .HasColumnName("IA_CSGM_N");

                entity.Property(e => e.IaDecisionCpgmsgm)
                    .IsUnicode(false)
                    .HasColumnName("IA_DECISION_CPGMSGM");

                entity.Property(e => e.IaDecisionTs)
                    .IsUnicode(false)
                    .HasColumnName("IA_DECISION_TS");

                entity.Property(e => e.IaDescription)
                    .IsUnicode(false)
                    .HasColumnName("IA_DESCRIPTION");

                entity.Property(e => e.IaGmDecision)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("IA_GM_DECISION");

                entity.Property(e => e.IaLetterDate)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_LETTER_DATE");

                entity.Property(e => e.IaNo)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("IA_NO");

                entity.Property(e => e.IaNwcpmD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_NWCPM_D");

                entity.Property(e => e.IaNwcpmN)
                    .HasPrecision(10)
                    .HasColumnName("IA_NWCPM_N");

                entity.Property(e => e.IaScD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_SC_D");

                entity.Property(e => e.IaScN)
                    .HasPrecision(10)
                    .HasColumnName("IA_SC_N");

                entity.Property(e => e.IaVpD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_VP_D");

                entity.Property(e => e.IaVpDecision)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("IA_VP_DECISION");

                entity.Property(e => e.IaVpN)
                    .HasPrecision(10)
                    .HasColumnName("IA_VP_N");

                entity.Property(e => e.PiConsultantName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONSULTANT_NAME");

                entity.Property(e => e.PiContractorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONTRACTOR_NAME");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.PsProjectClassification)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_CLASSIFICATION");

                entity.Property(e => e.PsProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_TYPE");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.SchAttach1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SCH_ATTACH1");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Uconcontractnumbertxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UCONCONTRACTNUMBERTXT16");

                entity.Property(e => e.Uconoriginalcontrctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONORIGINALCONTRCTAMTCA");

                entity.Property(e => e.Uconrevisedcontctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONREVISEDCONTCTAMTCA");

                entity.Property(e => e.Ugenclustertname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCLUSTERTNAME");

                entity.Property(e => e.Ugencontactnametb)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCONTACTNAMETB");

                entity.Property(e => e.Ugencontractrefbp)
                    .HasPrecision(10)
                    .HasColumnName("UGENCONTRACTREFBP");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenprojenddatedo)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENPROJENDDATEDO");

                entity.Property(e => e.Uregioncbuname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UREGIONCBUNAME");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_PROJECT_START_DATE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");

                entity.Property(e => e.WfActionName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("WF_ACTION_NAME");
            });

            modelBuilder.Entity<UnifierUxlssu>(entity =>
            {
                entity.ToTable("UNIFIER_UXLSSU");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UXLSSU_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UXLSSU_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UXLSSU_3");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCbu)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CBU");

                entity.Property(e => e.FypNwcRegion)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_REGION");

                entity.Property(e => e.P6InfoTitle)
                    .HasMaxLength(765)
                    .IsUnicode(false)
                    .HasColumnName("P6_INFO_TITLE");

                entity.Property(e => e.PiConsultantName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONSULTANT_NAME");

                entity.Property(e => e.PiContractorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI__CONTRACTOR_NAME");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.PsProjectClassification)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_CLASSIFICATION");

                entity.Property(e => e.PsProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_TYPE");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.SchAttach1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SCH_ATTACH1");

                entity.Property(e => e.SchBuconName)
                    .HasPrecision(10)
                    .HasColumnName("SCH_BUCON_NAME");

                entity.Property(e => e.SchBuconsName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_BUCONS_NAME");

                entity.Property(e => e.SchBuschleadName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_BUSCHLEAD_NAME");

                entity.Property(e => e.SchCconsultantName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_CCONSULTANT_NAME");

                entity.Property(e => e.SchClusterName)
                    .HasPrecision(10)
                    .HasColumnName("SCH_CLUSTER_NAME");

                entity.Property(e => e.SchContName)
                    .HasPrecision(10)
                    .HasColumnName("SCH_CONT_NAME");

                entity.Property(e => e.SchContractorName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_CONTRACTOR_NAME");

                entity.Property(e => e.SchCscheadName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_CSCHEAD_NAME");

                entity.Property(e => e.SchHeqteam)
                    .HasPrecision(10)
                    .HasColumnName("SCH_HEQTEAM");

                entity.Property(e => e.SchHqhead)
                    .HasPrecision(10)
                    .HasColumnName("SCH_HQHEAD");

                entity.Property(e => e.SchHqschName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_HQSCH_NAME");

                entity.Property(e => e.SchHqsctName)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_HQSCT_NAME");

                entity.Property(e => e.SchLeadName)
                    .HasPrecision(10)
                    .HasColumnName("SCH_LEAD_NAME");

                entity.Property(e => e.SchPm)
                    .HasPrecision(10)
                    .HasColumnName("SCH_PM");

                entity.Property(e => e.SchPmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SCH_PM_DATE");

                entity.Property(e => e.SchScName)
                    .HasPrecision(10)
                    .HasColumnName("SCH_SC_NAME");

                entity.Property(e => e.SsItem1)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM1");

                entity.Property(e => e.SsItem10)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM10");

                entity.Property(e => e.SsItem101)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM10_1");

                entity.Property(e => e.SsItem102)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM10_2");

                entity.Property(e => e.SsItem103)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM10_3");

                entity.Property(e => e.SsItem11)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM1_1");

                entity.Property(e => e.SsItem111)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM11");

                entity.Property(e => e.SsItem1111)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM11_1");

                entity.Property(e => e.SsItem112)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM11_2");

                entity.Property(e => e.SsItem113)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM11_3");

                entity.Property(e => e.SsItem12)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM1_2");

                entity.Property(e => e.SsItem121)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM12_1");

                entity.Property(e => e.SsItem122)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM12_2");

                entity.Property(e => e.SsItem123)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM12_3");

                entity.Property(e => e.SsItem124)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM12");

                entity.Property(e => e.SsItem13)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM1_3");

                entity.Property(e => e.SsItem131)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM13_1");

                entity.Property(e => e.SsItem132)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM13_2");

                entity.Property(e => e.SsItem133)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM13_3");

                entity.Property(e => e.SsItem134)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM13");

                entity.Property(e => e.SsItem14)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM14");

                entity.Property(e => e.SsItem141)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM14_1");

                entity.Property(e => e.SsItem142)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM14_2");

                entity.Property(e => e.SsItem143)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM14_3");

                entity.Property(e => e.SsItem15)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM15");

                entity.Property(e => e.SsItem151)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM15_1");

                entity.Property(e => e.SsItem152)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM15_2");

                entity.Property(e => e.SsItem153)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM15_3");

                entity.Property(e => e.SsItem16)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM16");

                entity.Property(e => e.SsItem161)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM16_1");

                entity.Property(e => e.SsItem162)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM16_2");

                entity.Property(e => e.SsItem163)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM16_3");

                entity.Property(e => e.SsItem17)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM17");

                entity.Property(e => e.SsItem171)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM17_1");

                entity.Property(e => e.SsItem172)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM17_2");

                entity.Property(e => e.SsItem173)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM17_3");

                entity.Property(e => e.SsItem18)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM18");

                entity.Property(e => e.SsItem181)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM18_1");

                entity.Property(e => e.SsItem182)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM18_2");

                entity.Property(e => e.SsItem183)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM18_3");

                entity.Property(e => e.SsItem19)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM19");

                entity.Property(e => e.SsItem191)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM19_1");

                entity.Property(e => e.SsItem192)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM19_2");

                entity.Property(e => e.SsItem193)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM19_3");

                entity.Property(e => e.SsItem2)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM2");

                entity.Property(e => e.SsItem20)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM20");

                entity.Property(e => e.SsItem201)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM20_1");

                entity.Property(e => e.SsItem202)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM20_2");

                entity.Property(e => e.SsItem203)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM20_3");

                entity.Property(e => e.SsItem21)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM2_1");

                entity.Property(e => e.SsItem211)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM21");

                entity.Property(e => e.SsItem2111)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM21_1");

                entity.Property(e => e.SsItem212)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM21_2");

                entity.Property(e => e.SsItem213)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM21_3");

                entity.Property(e => e.SsItem22)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM2_2");

                entity.Property(e => e.SsItem221)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM22");

                entity.Property(e => e.SsItem2211)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM22_1");

                entity.Property(e => e.SsItem222)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM22_2");

                entity.Property(e => e.SsItem223)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM22_3");

                entity.Property(e => e.SsItem23)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM2_3");

                entity.Property(e => e.SsItem231)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM23_1");

                entity.Property(e => e.SsItem232)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM23_2");

                entity.Property(e => e.SsItem233)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM23_3");

                entity.Property(e => e.SsItem234)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM23");

                entity.Property(e => e.SsItem24)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM24");

                entity.Property(e => e.SsItem241)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM24_1");

                entity.Property(e => e.SsItem242)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM24_2");

                entity.Property(e => e.SsItem243)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM24_3");

                entity.Property(e => e.SsItem25)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM25");

                entity.Property(e => e.SsItem251)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM25_1");

                entity.Property(e => e.SsItem252)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM25_2");

                entity.Property(e => e.SsItem253)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM25_3");

                entity.Property(e => e.SsItem26)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM26");

                entity.Property(e => e.SsItem261)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM26_1");

                entity.Property(e => e.SsItem262)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM26_2");

                entity.Property(e => e.SsItem263)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM26_3");

                entity.Property(e => e.SsItem27)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM27");

                entity.Property(e => e.SsItem271)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM27_1");

                entity.Property(e => e.SsItem272)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM27_2");

                entity.Property(e => e.SsItem273)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM27_3");

                entity.Property(e => e.SsItem28)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM28");

                entity.Property(e => e.SsItem281)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM28_1");

                entity.Property(e => e.SsItem282)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM28_2");

                entity.Property(e => e.SsItem283)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM28_3");

                entity.Property(e => e.SsItem29)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM29");

                entity.Property(e => e.SsItem291)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM29_1");

                entity.Property(e => e.SsItem292)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM29_2");

                entity.Property(e => e.SsItem293)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM29_3");

                entity.Property(e => e.SsItem3)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM3");

                entity.Property(e => e.SsItem30)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM30");

                entity.Property(e => e.SsItem301)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM30_1");

                entity.Property(e => e.SsItem302)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM30_2");

                entity.Property(e => e.SsItem303)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM30_3");

                entity.Property(e => e.SsItem31)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM31");

                entity.Property(e => e.SsItem311)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM31_1");

                entity.Property(e => e.SsItem312)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM31_2");

                entity.Property(e => e.SsItem313)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM31_3");

                entity.Property(e => e.SsItem314)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM3_1");

                entity.Property(e => e.SsItem32)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM32");

                entity.Property(e => e.SsItem321)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM32_1");

                entity.Property(e => e.SsItem322)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM32_2");

                entity.Property(e => e.SsItem323)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM32_3");

                entity.Property(e => e.SsItem324)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM3_2");

                entity.Property(e => e.SsItem33)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM33");

                entity.Property(e => e.SsItem331)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM33_1");

                entity.Property(e => e.SsItem332)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM33_2");

                entity.Property(e => e.SsItem333)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM33_3");

                entity.Property(e => e.SsItem334)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM3_3");

                entity.Property(e => e.SsItem34)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM34");

                entity.Property(e => e.SsItem341)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM34_1");

                entity.Property(e => e.SsItem342)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM34_2");

                entity.Property(e => e.SsItem343)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM34_3");

                entity.Property(e => e.SsItem35)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM35");

                entity.Property(e => e.SsItem351)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM35_1");

                entity.Property(e => e.SsItem352)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM35_2");

                entity.Property(e => e.SsItem353)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM35_3");

                entity.Property(e => e.SsItem36)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM36");

                entity.Property(e => e.SsItem361)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM36_1");

                entity.Property(e => e.SsItem362)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM36_2");

                entity.Property(e => e.SsItem363)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM36_3");

                entity.Property(e => e.SsItem37)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM37");

                entity.Property(e => e.SsItem371)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM37_1");

                entity.Property(e => e.SsItem372)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM37_2");

                entity.Property(e => e.SsItem373)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM37_3");

                entity.Property(e => e.SsItem38)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM38");

                entity.Property(e => e.SsItem381)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM38_1");

                entity.Property(e => e.SsItem382)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM38_2");

                entity.Property(e => e.SsItem383)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM38_3");

                entity.Property(e => e.SsItem39)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM39");

                entity.Property(e => e.SsItem391)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM39_1");

                entity.Property(e => e.SsItem392)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM39_2");

                entity.Property(e => e.SsItem393)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM39_3");

                entity.Property(e => e.SsItem4)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM4");

                entity.Property(e => e.SsItem40)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM40");

                entity.Property(e => e.SsItem401)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM40_1");

                entity.Property(e => e.SsItem402)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM40_2");

                entity.Property(e => e.SsItem403)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM40_3");

                entity.Property(e => e.SsItem41)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM4_1");

                entity.Property(e => e.SsItem411)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM41_1");

                entity.Property(e => e.SsItem412)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM41_2");

                entity.Property(e => e.SsItem413)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM41_3");

                entity.Property(e => e.SsItem414)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM41");

                entity.Property(e => e.SsItem42)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM4_2");

                entity.Property(e => e.SsItem421)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM42_1");

                entity.Property(e => e.SsItem422)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM42_2");

                entity.Property(e => e.SsItem423)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM42_3");

                entity.Property(e => e.SsItem424)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM42");

                entity.Property(e => e.SsItem43)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM4_3");

                entity.Property(e => e.SsItem431)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM43_1");

                entity.Property(e => e.SsItem432)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM43_2");

                entity.Property(e => e.SsItem433)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM43_3");

                entity.Property(e => e.SsItem434)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM43");

                entity.Property(e => e.SsItem44)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM44");

                entity.Property(e => e.SsItem441)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM44_1");

                entity.Property(e => e.SsItem442)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM44_2");

                entity.Property(e => e.SsItem443)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM44_3");

                entity.Property(e => e.SsItem45)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM45");

                entity.Property(e => e.SsItem451)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM45_1");

                entity.Property(e => e.SsItem452)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM45_2");

                entity.Property(e => e.SsItem453)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM45_3");

                entity.Property(e => e.SsItem46)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM46");

                entity.Property(e => e.SsItem461)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM46_1");

                entity.Property(e => e.SsItem462)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM46_2");

                entity.Property(e => e.SsItem463)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM46_3");

                entity.Property(e => e.SsItem47)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM47");

                entity.Property(e => e.SsItem471)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM47_1");

                entity.Property(e => e.SsItem472)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM47_2");

                entity.Property(e => e.SsItem473)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM47_3");

                entity.Property(e => e.SsItem48)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM48");

                entity.Property(e => e.SsItem481)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM48_1");

                entity.Property(e => e.SsItem482)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM48_2");

                entity.Property(e => e.SsItem483)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM48_3");

                entity.Property(e => e.SsItem49)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM49");

                entity.Property(e => e.SsItem491)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM49_1");

                entity.Property(e => e.SsItem492)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM49_2");

                entity.Property(e => e.SsItem493)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM49_3");

                entity.Property(e => e.SsItem5)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM5");

                entity.Property(e => e.SsItem50)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM50");

                entity.Property(e => e.SsItem501)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM50_1");

                entity.Property(e => e.SsItem502)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM50_2");

                entity.Property(e => e.SsItem503)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM50_3");

                entity.Property(e => e.SsItem51)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM5_1");

                entity.Property(e => e.SsItem511)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM51_1");

                entity.Property(e => e.SsItem512)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM51_2");

                entity.Property(e => e.SsItem513)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM51_3");

                entity.Property(e => e.SsItem514)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM51");

                entity.Property(e => e.SsItem52)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM5_2");

                entity.Property(e => e.SsItem521)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM52_1");

                entity.Property(e => e.SsItem522)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM52_2");

                entity.Property(e => e.SsItem523)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM52_3");

                entity.Property(e => e.SsItem524)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM52");

                entity.Property(e => e.SsItem53)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM5_3");

                entity.Property(e => e.SsItem6)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM6");

                entity.Property(e => e.SsItem61)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM6_1");

                entity.Property(e => e.SsItem62)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM6_2");

                entity.Property(e => e.SsItem63)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM6_3");

                entity.Property(e => e.SsItem7)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM7");

                entity.Property(e => e.SsItem71)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM7_1");

                entity.Property(e => e.SsItem72)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM7_2");

                entity.Property(e => e.SsItem73)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM7_3");

                entity.Property(e => e.SsItem8)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM8");

                entity.Property(e => e.SsItem81)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM8_1");

                entity.Property(e => e.SsItem82)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM8_2");

                entity.Property(e => e.SsItem83)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM8_3");

                entity.Property(e => e.SsItem9)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM9");

                entity.Property(e => e.SsItem91)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM9_1");

                entity.Property(e => e.SsItem92)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM9_2");

                entity.Property(e => e.SsItem93)
                    .IsUnicode(false)
                    .HasColumnName("SS_ITEM9_3");

                entity.Property(e => e.SsType1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE1");

                entity.Property(e => e.SsType10)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE10");

                entity.Property(e => e.SsType100)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE100");

                entity.Property(e => e.SsType101)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE101");

                entity.Property(e => e.SsType102)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE102");

                entity.Property(e => e.SsType103)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE103");

                entity.Property(e => e.SsType104)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE104");

                entity.Property(e => e.SsType105)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE105");

                entity.Property(e => e.SsType106)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE106");

                entity.Property(e => e.SsType107)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE107");

                entity.Property(e => e.SsType108)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE108");

                entity.Property(e => e.SsType109)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE109");

                entity.Property(e => e.SsType11)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE11");

                entity.Property(e => e.SsType110)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE110");

                entity.Property(e => e.SsType111)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE111");

                entity.Property(e => e.SsType112)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE112");

                entity.Property(e => e.SsType113)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE113");

                entity.Property(e => e.SsType114)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE114");

                entity.Property(e => e.SsType115)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE115");

                entity.Property(e => e.SsType116)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE116");

                entity.Property(e => e.SsType117)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE117");

                entity.Property(e => e.SsType118)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE118");

                entity.Property(e => e.SsType119)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE119");

                entity.Property(e => e.SsType12)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE12");

                entity.Property(e => e.SsType120)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE120");

                entity.Property(e => e.SsType121)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE121");

                entity.Property(e => e.SsType122)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE122");

                entity.Property(e => e.SsType123)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE123");

                entity.Property(e => e.SsType124)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE124");

                entity.Property(e => e.SsType125)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE125");

                entity.Property(e => e.SsType126)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE126");

                entity.Property(e => e.SsType127)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE127");

                entity.Property(e => e.SsType128)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE128");

                entity.Property(e => e.SsType129)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE129");

                entity.Property(e => e.SsType13)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE13");

                entity.Property(e => e.SsType130)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE130");

                entity.Property(e => e.SsType131)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE131");

                entity.Property(e => e.SsType132)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE132");

                entity.Property(e => e.SsType133)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE133");

                entity.Property(e => e.SsType134)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE134");

                entity.Property(e => e.SsType135)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE135");

                entity.Property(e => e.SsType136)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE136");

                entity.Property(e => e.SsType137)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE137");

                entity.Property(e => e.SsType138)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE138");

                entity.Property(e => e.SsType139)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE139");

                entity.Property(e => e.SsType14)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE14");

                entity.Property(e => e.SsType140)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE140");

                entity.Property(e => e.SsType141)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE141");

                entity.Property(e => e.SsType142)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE142");

                entity.Property(e => e.SsType143)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE143");

                entity.Property(e => e.SsType144)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE144");

                entity.Property(e => e.SsType145)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE145");

                entity.Property(e => e.SsType146)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE146");

                entity.Property(e => e.SsType147)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE147");

                entity.Property(e => e.SsType148)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE148");

                entity.Property(e => e.SsType149)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE149");

                entity.Property(e => e.SsType15)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE15");

                entity.Property(e => e.SsType150)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE150");

                entity.Property(e => e.SsType151)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE151");

                entity.Property(e => e.SsType152)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE152");

                entity.Property(e => e.SsType153)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE153");

                entity.Property(e => e.SsType154)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE154");

                entity.Property(e => e.SsType155)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE155");

                entity.Property(e => e.SsType156)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE156");

                entity.Property(e => e.SsType157)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE157");

                entity.Property(e => e.SsType158)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE158");

                entity.Property(e => e.SsType159)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE159");

                entity.Property(e => e.SsType16)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE16");

                entity.Property(e => e.SsType160)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE160");

                entity.Property(e => e.SsType161)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE161");

                entity.Property(e => e.SsType162)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE162");

                entity.Property(e => e.SsType163)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE163");

                entity.Property(e => e.SsType164)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE164");

                entity.Property(e => e.SsType165)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE165");

                entity.Property(e => e.SsType166)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE166");

                entity.Property(e => e.SsType167)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE167");

                entity.Property(e => e.SsType168)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE168");

                entity.Property(e => e.SsType169)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE169");

                entity.Property(e => e.SsType17)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE17");

                entity.Property(e => e.SsType170)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE170");

                entity.Property(e => e.SsType171)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE171");

                entity.Property(e => e.SsType172)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE172");

                entity.Property(e => e.SsType173)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE173");

                entity.Property(e => e.SsType174)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE174");

                entity.Property(e => e.SsType175)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE175");

                entity.Property(e => e.SsType176)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE176");

                entity.Property(e => e.SsType177)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE177");

                entity.Property(e => e.SsType178)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE178");

                entity.Property(e => e.SsType179)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE179");

                entity.Property(e => e.SsType18)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE18");

                entity.Property(e => e.SsType180)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE180");

                entity.Property(e => e.SsType181)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE181");

                entity.Property(e => e.SsType182)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE182");

                entity.Property(e => e.SsType183)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE183");

                entity.Property(e => e.SsType184)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE184");

                entity.Property(e => e.SsType185)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE185");

                entity.Property(e => e.SsType186)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE186");

                entity.Property(e => e.SsType187)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE187");

                entity.Property(e => e.SsType188)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE188");

                entity.Property(e => e.SsType189)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE189");

                entity.Property(e => e.SsType19)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE19");

                entity.Property(e => e.SsType190)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE190");

                entity.Property(e => e.SsType191)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE191");

                entity.Property(e => e.SsType192)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE192");

                entity.Property(e => e.SsType193)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE193");

                entity.Property(e => e.SsType194)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE194");

                entity.Property(e => e.SsType195)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE195");

                entity.Property(e => e.SsType196)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE196");

                entity.Property(e => e.SsType197)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE197");

                entity.Property(e => e.SsType198)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE198");

                entity.Property(e => e.SsType199)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE199");

                entity.Property(e => e.SsType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE2");

                entity.Property(e => e.SsType20)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE20");

                entity.Property(e => e.SsType200)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE200");

                entity.Property(e => e.SsType201)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE201");

                entity.Property(e => e.SsType202)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE202");

                entity.Property(e => e.SsType203)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE203");

                entity.Property(e => e.SsType204)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE204");

                entity.Property(e => e.SsType205)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE205");

                entity.Property(e => e.SsType206)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE206");

                entity.Property(e => e.SsType207)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE207");

                entity.Property(e => e.SsType208)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE208");

                entity.Property(e => e.SsType21)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE21");

                entity.Property(e => e.SsType22)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE22");

                entity.Property(e => e.SsType23)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE23");

                entity.Property(e => e.SsType24)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE24");

                entity.Property(e => e.SsType25)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE25");

                entity.Property(e => e.SsType26)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE26");

                entity.Property(e => e.SsType27)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE27");

                entity.Property(e => e.SsType28)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE28");

                entity.Property(e => e.SsType29)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE29");

                entity.Property(e => e.SsType3)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE3");

                entity.Property(e => e.SsType30)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE30");

                entity.Property(e => e.SsType31)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE31");

                entity.Property(e => e.SsType32)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE32");

                entity.Property(e => e.SsType33)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE33");

                entity.Property(e => e.SsType34)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE34");

                entity.Property(e => e.SsType35)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE35");

                entity.Property(e => e.SsType36)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE36");

                entity.Property(e => e.SsType37)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE37");

                entity.Property(e => e.SsType38)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE38");

                entity.Property(e => e.SsType39)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE39");

                entity.Property(e => e.SsType4)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE4");

                entity.Property(e => e.SsType40)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE40");

                entity.Property(e => e.SsType41)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE41");

                entity.Property(e => e.SsType42)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE42");

                entity.Property(e => e.SsType43)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE43");

                entity.Property(e => e.SsType44)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE44");

                entity.Property(e => e.SsType45)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE45");

                entity.Property(e => e.SsType46)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE46");

                entity.Property(e => e.SsType47)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE47");

                entity.Property(e => e.SsType48)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE48");

                entity.Property(e => e.SsType49)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE49");

                entity.Property(e => e.SsType5)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE5");

                entity.Property(e => e.SsType50)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE50");

                entity.Property(e => e.SsType51)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE51");

                entity.Property(e => e.SsType52)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE52");

                entity.Property(e => e.SsType53)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE53");

                entity.Property(e => e.SsType54)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE54");

                entity.Property(e => e.SsType55)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE55");

                entity.Property(e => e.SsType56)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE56");

                entity.Property(e => e.SsType57)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE57");

                entity.Property(e => e.SsType58)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE58");

                entity.Property(e => e.SsType59)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE59");

                entity.Property(e => e.SsType6)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE6");

                entity.Property(e => e.SsType60)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE60");

                entity.Property(e => e.SsType61)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE61");

                entity.Property(e => e.SsType62)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE62");

                entity.Property(e => e.SsType63)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE63");

                entity.Property(e => e.SsType64)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE64");

                entity.Property(e => e.SsType65)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE65");

                entity.Property(e => e.SsType66)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE66");

                entity.Property(e => e.SsType67)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE67");

                entity.Property(e => e.SsType68)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE68");

                entity.Property(e => e.SsType69)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE69");

                entity.Property(e => e.SsType7)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE7");

                entity.Property(e => e.SsType70)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE70");

                entity.Property(e => e.SsType71)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE71");

                entity.Property(e => e.SsType72)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE72");

                entity.Property(e => e.SsType73)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE73");

                entity.Property(e => e.SsType74)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE74");

                entity.Property(e => e.SsType75)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE75");

                entity.Property(e => e.SsType76)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE76");

                entity.Property(e => e.SsType77)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE77");

                entity.Property(e => e.SsType78)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE78");

                entity.Property(e => e.SsType79)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE79");

                entity.Property(e => e.SsType8)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE8");

                entity.Property(e => e.SsType80)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE80");

                entity.Property(e => e.SsType81)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE81");

                entity.Property(e => e.SsType82)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE82");

                entity.Property(e => e.SsType83)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE83");

                entity.Property(e => e.SsType84)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE84");

                entity.Property(e => e.SsType85)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE85");

                entity.Property(e => e.SsType86)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE86");

                entity.Property(e => e.SsType87)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE87");

                entity.Property(e => e.SsType88)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE88");

                entity.Property(e => e.SsType89)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE89");

                entity.Property(e => e.SsType9)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE9");

                entity.Property(e => e.SsType90)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE90");

                entity.Property(e => e.SsType91)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE91");

                entity.Property(e => e.SsType92)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE92");

                entity.Property(e => e.SsType93)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE93");

                entity.Property(e => e.SsType94)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE94");

                entity.Property(e => e.SsType95)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE95");

                entity.Property(e => e.SsType96)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE96");

                entity.Property(e => e.SsType97)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE97");

                entity.Property(e => e.SsType98)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE98");

                entity.Property(e => e.SsType99)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SS_TYPE99");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.SubmissionType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("SUBMISSION_TYPE");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Ugenclustertname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCLUSTERTNAME");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenprojenddatedo)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENPROJENDDATEDO");

                entity.Property(e => e.Uregioncbuname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UREGIONCBUNAME");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_PROJECT_START_DATE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");
            });

            modelBuilder.Entity<UnifierUxncr>(entity =>
            {
                entity.ToTable("UNIFIER_UXNCR");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UXNCR_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UXNCR_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UXNCR_3");

                entity.HasIndex(e => e.NcrConsultantProposed, "UNIFIER_UXNCR__1");

                entity.HasIndex(e => e.NcrNameCorrective, "UNIFIER_UXNCR__2");

                entity.HasIndex(e => e.NcrNameResident, "UNIFIER_UXNCR__3");

                entity.HasIndex(e => e.NcrPositionResident, "UNIFIER_UXNCR__4");

                entity.HasIndex(e => e.NcrNameProposed, "UNIFIER_UXNCR__5");

                entity.HasIndex(e => e.NcrPositionProposed, "UNIFIER_UXNCR__6");

                entity.HasIndex(e => e.NcrPositionCorrective, "UNIFIER_UXNCR__7");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.BcProjectEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_COSTS");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCity)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CITY");

                entity.Property(e => e.FypNwcProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE");

                entity.Property(e => e.FypNwcProjectType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE2");

                entity.Property(e => e.FypPeriodPk)
                    .HasPrecision(10)
                    .HasColumnName("FYP_PERIOD_PK");

                entity.Property(e => e.MirSnAuto)
                    .HasMaxLength(1536)
                    .IsUnicode(false)
                    .HasColumnName("MIR_SN_AUTO");

                entity.Property(e => e.NcrAcd)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_ACD");

                entity.Property(e => e.NcrAppCoom)
                    .IsUnicode(false)
                    .HasColumnName("NCR_APP_COOM");

                entity.Property(e => e.NcrAttach1)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH1");

                entity.Property(e => e.NcrAttach2)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH2");

                entity.Property(e => e.NcrAttach3)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH3");

                entity.Property(e => e.NcrAttach4)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH4");

                entity.Property(e => e.NcrAttach5)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH5");

                entity.Property(e => e.NcrAttach6)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH6");

                entity.Property(e => e.NcrAttach7)
                    .HasPrecision(10)
                    .HasColumnName("NCR_ATTACH7");

                entity.Property(e => e.NcrAttch1)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_ATTCH1");

                entity.Property(e => e.NcrAttch2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_ATTCH2");

                entity.Property(e => e.NcrAudtirComme)
                    .IsUnicode(false)
                    .HasColumnName("NCR_AUDTIR_COMME");

                entity.Property(e => e.NcrComments)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_COMMENTS");

                entity.Property(e => e.NcrCons)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_CONS");

                entity.Property(e => e.NcrConsultantProposed)
                    .HasPrecision(10)
                    .HasColumnName("NCR_CONSULTANT_PROPOSED");

                entity.Property(e => e.NcrDate3)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_DATE3");

                entity.Property(e => e.NcrDateAuditor)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_DATE_AUDITOR");

                entity.Property(e => e.NcrDateCorrective)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_DATE_CORRECTIVE");

                entity.Property(e => e.NcrDateCorrective2)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_DATE_CORRECTIVE2");

                entity.Property(e => e.NcrDateProposed)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_DATE_PROPOSED");

                entity.Property(e => e.NcrDateResident)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_DATE_RESIDENT");

                entity.Property(e => e.NcrDescription)
                    .IsUnicode(false)
                    .HasColumnName("NCR_DESCRIPTION");

                entity.Property(e => e.NcrFounDur)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_FOUN_DUR");

                entity.Property(e => e.NcrHq)
                    .HasPrecision(10)
                    .HasColumnName("NCR_HQ");

                entity.Property(e => e.NcrHqComment)
                    .IsUnicode(false)
                    .HasColumnName("NCR_HQ_COMMENT");

                entity.Property(e => e.NcrHqDate)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_HQ_DATE");

                entity.Property(e => e.NcrNameAuditor)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NAME_AUDITOR");

                entity.Property(e => e.NcrNameCorrective)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NAME_CORRECTIVE");

                entity.Property(e => e.NcrNameCorrective2)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NAME_CORRECTIVE2");

                entity.Property(e => e.NcrNameProposed)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NAME_PROPOSED");

                entity.Property(e => e.NcrNameProposed2)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NAME_PROPOSED2");

                entity.Property(e => e.NcrNameResident)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NAME_RESIDENT");

                entity.Property(e => e.NcrNcrReference)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_NCR_REFERENCE");

                entity.Property(e => e.NcrNcrType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_NCR_TYPE");

                entity.Property(e => e.NcrNo)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_NO");

                entity.Property(e => e.NcrNonConformity)
                    .IsUnicode(false)
                    .HasColumnName("NCR_NON_CONFORMITY");

                entity.Property(e => e.NcrNracd)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_NRACD");

                entity.Property(e => e.NcrNwcPm)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NWC_PM");

                entity.Property(e => e.NcrPmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_PM_DATE");

                entity.Property(e => e.NcrPositionCorrective)
                    .HasPrecision(10)
                    .HasColumnName("NCR_POSITION_CORRECTIVE");

                entity.Property(e => e.NcrPositionProposed)
                    .HasPrecision(10)
                    .HasColumnName("NCR_POSITION_PROPOSED");

                entity.Property(e => e.NcrPositionResident)
                    .HasPrecision(10)
                    .HasColumnName("NCR_POSITION_RESIDENT");

                entity.Property(e => e.NcrProposed)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_PROPOSED");

                entity.Property(e => e.NcrProposedDes)
                    .IsUnicode(false)
                    .HasColumnName("NCR_PROPOSED_DES");

                entity.Property(e => e.NcrProposedNon)
                    .IsUnicode(false)
                    .HasColumnName("NCR_PROPOSED_NON");

                entity.Property(e => e.NcrRacd)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_RACD");

                entity.Property(e => e.NcrRoot)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCR_ROOT");

                entity.Property(e => e.NcrRootDes)
                    .IsUnicode(false)
                    .HasColumnName("NCR_ROOT_DES");

                entity.Property(e => e.NcrSnAuto)
                    .HasMaxLength(1536)
                    .IsUnicode(false)
                    .HasColumnName("NCR_SN_AUTO");

                entity.Property(e => e.NcrrAttachments)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("NCRR_ATTACHMENTS");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.PsProjectType)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PS_PROJECT_TYPE");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Ugenclustertname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCLUSTERTNAME");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenprojenddatedo)
                    .HasColumnType("DATE")
                    .HasColumnName("UGENPROJENDDATEDO");

                entity.Property(e => e.Uregionname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UREGIONNAME");

                entity.Property(e => e.UtrNwcCommentsAndApprov)
                    .IsUnicode(false)
                    .HasColumnName("UTR_NWC_COMMENTS_AND_APPROV");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_PROJECT_START_DATE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");

                entity.Property(e => e.Uvlcjscommentsmtl4000)
                    .IsUnicode(false)
                    .HasColumnName("UVLCJSCOMMENTSMTL4000");
            });

            modelBuilder.Entity<UnifierUxpa>(entity =>
            {
                entity.ToTable("UNIFIER_UXPA");

                entity.HasIndex(e => e.ProjectId, "UNIFIER_UXPA_1");

                entity.HasIndex(e => e.RecordNo, "UNIFIER_UXPA_2");

                entity.HasIndex(e => e.CreatorId, "UNIFIER_UXPA_3");

                entity.HasIndex(e => e.UuuContentId, "UNIFIER_UXPA__1");

                entity.HasIndex(e => e.Refid, "UNIFIER_UXPA__2");

                entity.HasIndex(e => e.Currencyid, "UNIFIER_UXPA__3");

                entity.Property(e => e.Id)
                    .HasPrecision(10)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AttachCnt)
                    .HasPrecision(10)
                    .HasColumnName("ATTACH_CNT");

                entity.Property(e => e.BcProjectEndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_END_DATE");

                entity.Property(e => e.BcProjectEstimatedCosts)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BC_PROJECT_ESTIMATED_COSTS");

                entity.Property(e => e.BcProjectStartDate)
                    .HasColumnType("DATE")
                    .HasColumnName("BC_PROJECT_START_DATE");

                entity.Property(e => e.CVat)
                    .HasColumnType("FLOAT")
                    .HasColumnName("C_VAT");

                entity.Property(e => e.CVatTotal)
                    .HasColumnType("FLOAT")
                    .HasColumnName("C_VAT_TOTAL");

                entity.Property(e => e.ComAdvpaymenperc)
                    .HasColumnType("FLOAT")
                    .HasColumnName("COM_ADVPAYMENPERC");

                entity.Property(e => e.ConAdvancedPayment)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_ADVANCED_PAYMENT");

                entity.Property(e => e.ConReadvancedPayment)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CON_READVANCED_PAYMENT");

                entity.Property(e => e.CreatorId)
                    .HasPrecision(10)
                    .HasColumnName("CREATOR_ID");

                entity.Property(e => e.Currencyid)
                    .HasPrecision(10)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Currencyrate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("CURRENCYRATE");

                entity.Property(e => e.DueDate)
                    .HasColumnType("DATE")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("DATE")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.FypNwcCity)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_CITY");

                entity.Property(e => e.FypNwcProjectType2)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("FYP_NWC_PROJECT_TYPE2");

                entity.Property(e => e.IaCoD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_CO_D");

                entity.Property(e => e.IaCoN)
                    .HasPrecision(10)
                    .HasColumnName("IA_CO_N");

                entity.Property(e => e.IaScD)
                    .HasColumnType("DATE")
                    .HasColumnName("IA_SC_D");

                entity.Property(e => e.IaScN)
                    .HasPrecision(10)
                    .HasColumnName("IA_SC_N");

                entity.Property(e => e.NcrNwcPm)
                    .HasPrecision(10)
                    .HasColumnName("NCR_NWC_PM");

                entity.Property(e => e.NcrPmDate)
                    .HasColumnType("DATE")
                    .HasColumnName("NCR_PM_DATE");

                entity.Property(e => e.OmCost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("OM_COST");

                entity.Property(e => e.PaAdvanceAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_ADVANCE_AMOUNT");

                entity.Property(e => e.PaAdvpayrec)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_ADVPAYREC");

                entity.Property(e => e.PaName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PA_NAME");

                entity.Property(e => e.PaPreredvadvAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_PREREDVADV_AMOUNT");

                entity.Property(e => e.PaPrevadvanceAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA__PREVADVANCE_AMOUNT");

                entity.Property(e => e.PaRedAdvanceAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_RED_ADVANCE_AMOUNT");

                entity.Property(e => e.PaRemaAdvanceAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_REMA_ADVANCE_AMOUNT");

                entity.Property(e => e.PaSeqNo)
                    .HasMaxLength(1536)
                    .IsUnicode(false)
                    .HasColumnName("PA_SEQ_NO");

                entity.Property(e => e.PaTotAdvanceAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_TOT_ADVANCE_AMOUNT");

                entity.Property(e => e.PaTotredvadvAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PA_TOTREDVADV_AMOUNT");

                entity.Property(e => e.PappReleaseAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAPP_RELEASE_AMOUNT");

                entity.Property(e => e.PappReleaseAmount1)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAPP_RELEASE_AMOUNT1");

                entity.Property(e => e.PayAdvacPayAmout)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAY_ADVAC_PAY_AMOUT");

                entity.Property(e => e.PayNoIn)
                    .HasPrecision(10)
                    .HasColumnName("PAY_NO_IN");

                entity.Property(e => e.PayOffAmount)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAY_OFF_AMOUNT");

                entity.Property(e => e.PayPen)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAY_PEN");

                entity.Property(e => e.PayPercIn)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAY_PERC_IN");

                entity.Property(e => e.PayScopeOfWork)
                    .IsUnicode(false)
                    .HasColumnName("PAY_SCOPE_OF_WORK");

                entity.Property(e => e.PayWorkEnd)
                    .HasColumnType("DATE")
                    .HasColumnName("PAY_WORK_END");

                entity.Property(e => e.PayWorkStart)
                    .HasColumnType("DATE")
                    .HasColumnName("PAY_WORK_START");

                entity.Property(e => e.PaymentAfterVat)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PAYMENT_AFTER_VAT");

                entity.Property(e => e.PiVendorName)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("PI_VENDOR_NAME");

                entity.Property(e => e.ProcessStatus)
                    .HasPrecision(10)
                    .HasColumnName("PROCESS_STATUS");

                entity.Property(e => e.ProjectId)
                    .HasPrecision(10)
                    .HasColumnName("PROJECT_ID");

                entity.Property(e => e.Reason)
                    .HasPrecision(10)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RECORD_NO");

                entity.Property(e => e.Refid)
                    .HasPrecision(10)
                    .HasColumnName("REFID");

                entity.Property(e => e.RevisionNo)
                    .HasColumnType("FLOAT")
                    .HasColumnName("REVISION_NO");

                entity.Property(e => e.RevisionSeq1)
                    .HasColumnType("FLOAT")
                    .HasColumnName("REVISION_SEQ1");

                entity.Property(e => e.RevisionSeq2)
                    .HasColumnType("FLOAT")
                    .HasColumnName("REVISION_SEQ2");

                entity.Property(e => e.RevisionSeq4)
                    .HasColumnType("FLOAT")
                    .HasColumnName("REVISION_SEQ4");

                entity.Property(e => e.RevisionTotal)
                    .HasColumnType("FLOAT")
                    .HasColumnName("REVISION_TOTAL");

                entity.Property(e => e.Status)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.TotalcontractAfterChange)
                    .HasColumnType("FLOAT")
                    .HasColumnName("TOTALCONTRACT_AFTER_CHANGE");

                entity.Property(e => e.Uconapprovedchangesamtqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONAPPROVEDCHANGESAMTQE");

                entity.Property(e => e.Uconapvdaddchgqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONAPVDADDCHGQE");

                entity.Property(e => e.Uconapvddeductchgqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONAPVDDEDUCTCHGQE");

                entity.Property(e => e.Uconcontractnumbertxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UCONCONTRACTNUMBERTXT16");

                entity.Property(e => e.Uconoriginalcontrctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONORIGINALCONTRCTAMTCA");

                entity.Property(e => e.Uconprvapvdaddchgqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONPRVAPVDADDCHGQE");

                entity.Property(e => e.Uconprvapvddeductchgqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONPRVAPVDDEDUCTCHGQE");

                entity.Property(e => e.Uconrevisedcontctamtca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONREVISEDCONTCTAMTCA");

                entity.Property(e => e.Ucontitlesd)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UCONTITLESD");

                entity.Property(e => e.Ucontpapvdaddchgqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONTPAPVDADDCHGQE");

                entity.Property(e => e.Ucontpapvddeductchgqe)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UCONTPAPVDDEDUCTCHGQE");

                entity.Property(e => e.Ugenaddress1txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS1TXT120");

                entity.Property(e => e.Ugenaddress2txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS2TXT120");

                entity.Property(e => e.Ugenaddress3txt120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UGENADDRESS3TXT120");

                entity.Property(e => e.Ugencitytxt50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCITYTXT50");

                entity.Property(e => e.Ugenclustertname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCLUSTERTNAME");

                entity.Property(e => e.Ugencontactnametb)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UGENCONTACTNAMETB");

                entity.Property(e => e.Ugencountrypd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENCOUNTRYPD")
                    .HasDefaultValueSql("'SA' ");

                entity.Property(e => e.Ugenprojectname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNAME");

                entity.Property(e => e.Ugenprojectnumber)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENPROJECTNUMBER");

                entity.Property(e => e.Ugenstatepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UGENSTATEPD");

                entity.Property(e => e.Ugenzipcodetxt16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UGENZIPCODETXT16");

                entity.Property(e => e.Upabaltofinishretainageca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPABALTOFINISHRETAINAGECA");

                entity.Property(e => e.Upacheckdatedop)
                    .HasColumnType("DATE")
                    .HasColumnName("UPACHECKDATEDOP");

                entity.Property(e => e.Upachecknotb50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UPACHECKNOTB50");

                entity.Property(e => e.Upacheckprocdatedop)
                    .HasColumnType("DATE")
                    .HasColumnName("UPACHECKPROCDATEDOP");

                entity.Property(e => e.Upacontractdatedp)
                    .HasColumnType("DATE")
                    .HasColumnName("UPACONTRACTDATEDP");

                entity.Property(e => e.Upacurrpaymentdueca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPACURRPAYMENTDUECA");

                entity.Property(e => e.Upainvoicedatedop)
                    .HasColumnType("DATE")
                    .HasColumnName("UPAINVOICEDATEDOP");

                entity.Property(e => e.Upapaymentduedatedop)
                    .HasColumnType("DATE")
                    .HasColumnName("UPAPAYMENTDUEDATEDOP");

                entity.Property(e => e.Uparetainagepctda)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPARETAINAGEPCTDA");

                entity.Property(e => e.Upasumofretainageca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPASUMOFRETAINAGECA");

                entity.Property(e => e.Upasumprevpayappca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPASUMPREVPAYAPPCA");

                entity.Property(e => e.Upatotalcompltodateca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPATOTALCOMPLTODATECA");

                entity.Property(e => e.Upatotearnlessretainageca)
                    .HasColumnType("FLOAT")
                    .HasColumnName("UPATOTEARNLESSRETAINAGECA");

                entity.Property(e => e.Upavendorpayappnotb120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UPAVENDORPAYAPPNOTB120");

                entity.Property(e => e.Upocontractdescmlt4000)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTDESCMLT4000");

                entity.Property(e => e.Upocontracttermsmlt4000)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTTERMSMLT4000");

                entity.Property(e => e.Upocontracttypepd)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UPOCONTRACTTYPEPD");

                entity.Property(e => e.Uregioncbuname)
                    .HasMaxLength(384)
                    .IsUnicode(false)
                    .HasColumnName("UREGIONCBUNAME");

                entity.Property(e => e.UsdCurrencyrate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("USD_CURRENCYRATE");

                entity.Property(e => e.UuuContentId)
                    .HasPrecision(10)
                    .HasColumnName("UUU_CONTENT_ID");

                entity.Property(e => e.UuuCreationDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_CREATION_DATE");

                entity.Property(e => e.UuuDmPublishPath)
                    .IsUnicode(false)
                    .HasColumnName("UUU_DM_PUBLISH_PATH");

                entity.Property(e => e.UuuEffectiveDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_EFFECTIVE_DATE");

                entity.Property(e => e.UuuRecordLastUpdateDate)
                    .HasColumnType("DATE")
                    .HasColumnName("UUU_RECORD_LAST_UPDATE_DATE");

                entity.Property(e => e.Uvedisadvantagedbuscb)
                    .HasPrecision(10)
                    .HasColumnName("UVEDISADVANTAGEDBUSCB");

                entity.Property(e => e.Uveemailtb120)
                    .HasMaxLength(360)
                    .IsUnicode(false)
                    .HasColumnName("UVEEMAILTB120");

                entity.Property(e => e.Uvefaxtb16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UVEFAXTB16");

                entity.Property(e => e.Uveminoritybuscb)
                    .HasPrecision(10)
                    .HasColumnName("UVEMINORITYBUSCB");

                entity.Property(e => e.Uvephonetb64)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UVEPHONETB64");

                entity.Property(e => e.Uveprimarycontacttb64)
                    .HasMaxLength(192)
                    .IsUnicode(false)
                    .HasColumnName("UVEPRIMARYCONTACTTB64");

                entity.Property(e => e.Uvevendoridtb16)
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("UVEVENDORIDTB16");

                entity.Property(e => e.Uvevendornametb50)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("UVEVENDORNAMETB50");

                entity.Property(e => e.Uvewomanownedcb)
                    .HasPrecision(10)
                    .HasColumnName("UVEWOMANOWNEDCB");

                entity.Property(e => e.Xid)
                    .HasPrecision(10)
                    .HasColumnName("XID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
