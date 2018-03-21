using Microsoft.EntityFrameworkCore;
using DomainModelLibrary;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccessLibrary
{
    public class WorkpackDBContext : DbContext
    {
        public WorkpackDBContext(DbContextOptions<WorkpackDBContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectsAdmin> ProjectsAdmin { get; set; }
        public DbSet<ProjectTypes> ProjectTypes { get; set; }
        public DbSet<ProjectStatu> ProjectStatu { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<SimilarProject> SimilarProject { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<usp_getUserList_Result> usp_getUserList_Result { get; set; }
        public DbSet<usp_getUserRoleAssigned_Result> usp_getUserRoleAssigned_Result { get; set; }


        public virtual IQueryable<usp_getUserList_Result> usp_getUserList(Nullable<int> userId, Nullable<int> projectid, Nullable<int> companyId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            var projectidParameter = projectid.HasValue ?
                new SqlParameter("Projectid", projectid) :
                new SqlParameter("Projectid", typeof(int));

            var companyIdParameter = companyId.HasValue ?
                new SqlParameter("CompanyId", companyId) :
                new SqlParameter("CompanyId", typeof(int));

            return usp_getUserList_Result
                .FromSql("EXECUTE usp_getUserList @UserId, @Projectid, @CompanyId", userIdParameter, projectidParameter, companyIdParameter)
                .AsNoTracking();
        }

        public virtual IQueryable<usp_getUserRoleAssigned_Result> usp_getUserRoleAssigned(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new SqlParameter("UserId", userId) :
                new SqlParameter("UserId", typeof(int));

            return usp_getUserRoleAssigned_Result
                .FromSql("EXECUTE usp_getUserRoleAssigned @UserId", userIdParameter)
                .AsNoTracking();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<ProjectsAdmin>().ToTable("ProjectsAdmin");
            modelBuilder.Entity<ProjectTypes>().ToTable("ProjectType");
            modelBuilder.Entity<ProjectStatu>().ToTable("ProjectStatus");
            modelBuilder.Entity<Priority>().ToTable("Priority");
            modelBuilder.Entity<Currency>().ToTable("Currency");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<SimilarProject>().ToTable("SimilarProject");
            modelBuilder.Entity<Designation>().ToTable("Designation");
            modelBuilder.Entity<Department>().ToTable("Department");
          
        }



        //static WorkpackDBContext()
        //{
        //    Database.SetInitializer<WorkpackDBContext>(null);
        //}
        //public WorkpackDBContext()
        //    : base("name=WorkpackDBContext")
        //{
        //}
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<WorkpackDBContext>(null);
        //    modelBuilder.Entity<Users>().ToTable("Users").HasKey(c => c.UserID);
        //    modelBuilder.Entity<Project>().ToTable("Project").HasKey(c => c.ProjectID);
        //    modelBuilder.Entity<Priority>().ToTable("Priority").HasKey(c => c.PriorityID);
        //    modelBuilder.Entity<ProjectType>().ToTable("ProjectType").HasKey(c => c.ProjectTypeID);
        //    modelBuilder.Entity<ContentTemplate>().ToTable("ContentTemplate").HasKey(c => c.ContentTemplateID);
        //    modelBuilder.Entity<Client>().ToTable("Client").HasKey(c => c.ClientID);
        //    modelBuilder.Entity<Vendor>().ToTable("Vendor").HasKey(c => c.VendorID);
        //    modelBuilder.Entity<SimilarProject>().ToTable("SimilarProject").HasKey(c => c.ID);
        //    modelBuilder.Entity<UserRole>().ToTable("UserRole").HasKey(c => c.UserRolesID);
        //    modelBuilder.Entity<Role>().ToTable("Role").HasKey(c => c.RoleID);
        //    modelBuilder.Entity<Department>().ToTable("Department").HasKey(c => c.DepartmentID);
        //    modelBuilder.Entity<Designation>().ToTable("Designation").HasKey(c => c.DesignationID);
        //    modelBuilder.Entity<ConfigFile>().ToTable("ConfigFile").HasKey(c => c.ConfigID);
        //    modelBuilder.Entity<EmailTemplate>().ToTable("EmailTemplate").HasKey(c => c.EmailTemplateID);
        //    modelBuilder.Entity<ProjectsAdmin>().ToTable("ProjectsAdmin").HasKey(c => c.ProjectsAdminID);
        //    modelBuilder.Entity<ProjectItem>().ToTable("ProjectItem").HasKey(c => c.ProjectItemsID);
        //    modelBuilder.Entity<DocumentType>().ToTable("DocumentType").HasKey(c => c.DocumentTypeID);
        //    modelBuilder.Entity<Item>().ToTable("ItemType").HasKey(c => c.ItemTypeID);
        //    modelBuilder.Entity<TemplateType>().ToTable("TemplateType").HasKey(c => c.TemplateTypeID);
        //    modelBuilder.Entity<ProjectPR>().ToTable("ProjectPR").HasKey(c => c.PRId);
        //    modelBuilder.Entity<ApproverType>().ToTable("ApproverType").HasKey(c => c.AprroveTypeId);
        //    modelBuilder.Entity<PRApprover>().ToTable("PRApprover").HasKey(c => c.PRApproverID);
        //    modelBuilder.Entity<PRVendor>().ToTable("PRVendor").HasKey(c => c.PRVendorId);
        //    modelBuilder.Entity<PR_ProjectItemRate>().ToTable("PR_ProjectItemRate").HasKey(c => c.PR_ProjectItemRateID);
        //    modelBuilder.Entity<Currency>().ToTable("Currency").HasKey(c => c.CurrencyID);
        //    modelBuilder.Entity<ProjectItemColumnsSetting>().ToTable("ProjectItemColumnsSetting").HasKey(c => c.ProjectItemColumnsSettingID);
        //    modelBuilder.Entity<HideColumnSetting>().ToTable("HideColumnSetting").HasKey(c => c.HideColSettingID);
        //    modelBuilder.Entity<Tax>().ToTable("Tax").HasKey(c => c.TaxID);
        //    modelBuilder.Entity<DomesticInternational>().ToTable("DomesticInternational").HasKey(c => c.DomesticInternationalID);
        //    modelBuilder.Entity<SupplyInstall>().ToTable("SupplyInstall").HasKey(c => c.SupplyInstallID);
        //    modelBuilder.Entity<ProjectPO>().ToTable("PO_ProjectPO").HasKey(c => c.ProjectPOID);
        //    modelBuilder.Entity<POItemDetails>().ToTable("PO_ItemDetails").HasKey(c => c.PO_ItemDetailsID);
        //    modelBuilder.Entity<ProjectItemColumnsSettingTemplate>().ToTable("ProjectItemColumnsSettingTemplate").HasKey(c => c.ProjectItemColumnsSettingTemplateID);
        //    modelBuilder.Entity<ProjectItemColumnsSettingTemplateDetail>().ToTable("ProjectItemColumnsSettingTemplateDetail").HasKey(c => c.ProjectItemColumnsSettingDetailID);
        //    modelBuilder.Entity<TaxType>().ToTable("TaxType").HasKey(c => c.TaxTypeId);
        //    modelBuilder.Entity<TaxCodes>().ToTable("TaxCode").HasKey(c => c.TaxCodeID);
        //    modelBuilder.Entity<Comment>().ToTable("Comment").HasKey(c => c.CommentID);
        //    modelBuilder.Entity<FileStatusUser>().ToTable("FileStatusUser").HasKey(c => c.FileStatusUserID);
        //    modelBuilder.Entity<Message>().ToTable("Message").HasKey(c => c.MessageID);
        //    modelBuilder.Entity<DocStatus>().ToTable("DocStatus").HasKey(c => c.DocStatusId);
        //    modelBuilder.Entity<Additional_Approver_PO>().ToTable("Additional_Approver_PO").HasKey(c => c.Additional_PO_Approver_id);
        //    modelBuilder.Entity<ProjectGRN>().ToTable("ProjectGRN").HasKey(c => c.GRNId);
        //    modelBuilder.Entity<ProjectGRNItemDetail>().ToTable("ProjectGRNItemDetail").HasKey(c => c.GRNItemDetailId);
        //    modelBuilder.Entity<PurchaseProposalsave>().ToTable("PurchaseProposalSave").HasKey(c => c.PurchaseProposalID);
        //    modelBuilder.Entity<Attachment>().ToTable("Attachment").HasKey(c => c.AttachmentId);
        //    modelBuilder.Entity<Approver_PurchaseProposal>().ToTable("Approver_PurchaseProposal").HasKey(c => c.Approver_PurchaseProposalID);
        //    modelBuilder.Entity<UOM>().ToTable("UOM").HasKey(c => c.UOMId);
        //    modelBuilder.Entity<CostCategory>().ToTable("CostCategory").HasKey(c => c.CostCategoryID);
        //    modelBuilder.Entity<SalesInvoice>().ToTable("SalesInvoice").HasKey(c => c.SalesInvoiceID);
        //    modelBuilder.Entity<SalesInvoiceItemDetails>().ToTable("SalesInvoiceItemDetails").HasKey(c => c.SalesInvoiceItemDetailsId);
        //    modelBuilder.Entity<Note>().ToTable("Note").HasKey(c => c.NoteID);
        //    modelBuilder.Entity<ProjectServices>().ToTable("ProjectServices").HasKey(c => c.ProjectServiceId);
        //    modelBuilder.Entity<ServiceCC>().ToTable("ServiceCC").HasKey(c => c.ServiceCCId);
        //    modelBuilder.Entity<VehicleType>().ToTable("VehicleType").HasKey(c => c.VehicleTypeId);


        //    modelBuilder.Entity<PO_ItemDetails_RevisionBkp>().ToTable("PO_ItemDetails_RevisionBkp").HasKey(c => c.PO_ItemDetailsReviosnBkpID);
        //    modelBuilder.Entity<InvoiceChecklist>().ToTable("InvoiceChecklist").HasKey(c => c.InvoiceChecklistId);
        //    modelBuilder.Entity<ProjectSRN>().ToTable("ProjectSRN").HasKey(c => c.ProjectSRNId);
        //    modelBuilder.Entity<SRNCourier>().ToTable("SRNCourier").HasKey(c => c.SRNCourierId);
        //    modelBuilder.Entity<SRNItemDetails>().ToTable("SRNItemDetails").HasKey(c => c.SRNItemDetailId);
        //    modelBuilder.Entity<SRNDebit>().ToTable("SRNDebit").HasKey(c => c.SRNDebitID);
        //    modelBuilder.Entity<SRNDebitItemDetails>().ToTable("SRNDebitItemDetails").HasKey(c => c.SRNDebitItemId);
        //    modelBuilder.Entity<SRNInvoiceCheckList>().ToTable("SRNInvoiceCheckList").HasKey(c => c.SRNInvoiceCheckListId);
        //    modelBuilder.Entity<SRNPartialPayment>().ToTable("SRNPartialPayment").HasKey(c => c.SRNPartialPaymentId);
        //    modelBuilder.Entity<SRNPartialPaymentItemDetails>().ToTable("SRNPartialPaymentItemDetails").HasKey(c => c.SRNPartialPaymentItemID);

        //    modelBuilder.Entity<Po_ProjectPo_RevisionBkp>().ToTable("Po_ProjectPo_RevisionBkp").HasKey(c => c.PO_RevisionBkpID);
        //    modelBuilder.Entity<FileStatusUser_Revision_Bkp>().ToTable("FileStatusUser_Revision_Bkp").HasKey(c => c.FileStatusUser_Revision_BkpID);

        //    modelBuilder.Entity<PurchaseProposalItemDetailsSave>().ToTable("PurchaseProposalItemDetailsSave").HasKey(c => c.PurchaseProposalItemdetailsID);

        //    modelBuilder.Entity<ServiceInvoice>().ToTable("ServiceInvoice").HasKey(c => c.ServiceInvoiceID);
        //    modelBuilder.Entity<WorkFlow>().ToTable("WorkFlow").HasKey(c => c.WorkFlowId);
        //    modelBuilder.Entity<ServiceInvoiceItemDetails>().ToTable("ServiceInvoiceItemDetails").HasKey(c => c.ServiceInvoiceItemDetailsId);

        //    modelBuilder.Entity<ProformaInvoice>().ToTable("ProformaInvoice").HasKey(c => c.ProformaInvoiceID);
        //    modelBuilder.Entity<ProformaInvoiceItemDetails>().ToTable("ProformaInvoiceItemDetails").HasKey(c => c.ProformaInvoiceItemDetailsId);


        //    modelBuilder.Entity<WOAdvancedPayment>().ToTable("WOAdvancedPayment").HasKey(c => c.WOAdvancedPaymentId);
        //    modelBuilder.Entity<DashboardFilter>().ToTable("DashboardFilter").HasKey(c => c.DashboardFilterId);
        //    modelBuilder.Entity<ProjectPR_Revision_Bkp>().ToTable("ProjectPR_Revision_Bkp").HasKey(c => c.PrBackupId);
        //    modelBuilder.Entity<PR_ProjectItemRate_RevisionBkp>().ToTable("PR_ProjectItemRate_RevisionBkp").HasKey(c => c.PR_ProjectItemRateID);
        //    modelBuilder.Entity<QtyType>().ToTable("QtyType").HasKey(c => c.QtyTypeID);
        //    modelBuilder.Entity<WBSCode>().ToTable("WBSCode").HasKey(c => c.WBSCodeId);
        //    modelBuilder.Entity<Project_ClientFocalPoint>().ToTable("Project_ClientFocalPoint").HasKey(c => c.ClientFocalPointID);
        //    modelBuilder.Entity<CurrencyConversion>().ToTable("CurrencyConversion").HasKey(c => c.CurrencyConversionID);
        //    modelBuilder.Entity<RoleRight>().ToTable("RoleRights").HasKey(c => c.RoleRightsID);
        //    modelBuilder.Entity<Modules>().ToTable("Modules").HasKey(c => c.ModuleID);
        //    modelBuilder.Entity<NoteRevesionbkp>().ToTable("NoteRevesionbkp").HasKey(c => c.NotebkpID);
        //    modelBuilder.Entity<ProjectGRNRevision>().ToTable("ProjectGRNRevision").HasKey(c => c.GRNRevisionId);
        //    modelBuilder.Entity<ProjectGRNItemDetailRevision>().ToTable("ProjectGRNItemDetailRevision").HasKey(c => c.GRNItemDetailRevisionId);
        //    modelBuilder.Entity<ModeOfTransport>().ToTable("ModeOfTransport").HasKey(c => c.ModeOfTransportID);
        //    modelBuilder.Entity<PO_ProjectPOPR>().ToTable("PO_ProjectPOPR").HasKey(c => c.PO_ProjectPOPRID);
        //    modelBuilder.Entity<PO_ProjectPOPRReviosnBkp>().ToTable("PO_ProjectPOPRReviosnBkp").HasKey(c => c.PO_ProjectPOPRReviosnBkpID);
        //    modelBuilder.Entity<Contract>().ToTable("Contract").HasKey(c => c.ContractID);



        //    //modelBuilder.Entity<getpodata_asperprnum>().MapToStoredProcedures("getpodata_asperprnum");
        //}
        //public DbSet<Users> Users { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<Priority> Priorities { get; set; }
        //public DbSet<ProjectsAdmin> ProjectsAdmins { get; set; }
        //public DbSet<ProjectType> ProjectTypes { get; set; }
        //public DbSet<QtyType> QtyType { get; set; }
        //public DbSet<WBSCode> WBSCode { get; set; }
        //public DbSet<ContentTemplate> ContentTemplates { get; set; }
        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Vendor> Vendor { get; set; }
        //public DbSet<SimilarProject> SimilarProjects { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<Department> Departments { get; set; }
        //public DbSet<Designation> Designations { get; set; }
        //public DbSet<ConfigFile> ConfigFiles { get; set; }
        //public DbSet<EmailTemplate> EmailTemplates { get; set; }
        //public DbSet<ProjectItem> ProjectItems { get; set; }
        //public DbSet<DocumentType> DocumentType { get; set; }
        //public DbSet<Item> Item { get; set; }
        //public DbSet<TemplateType> TemplateType { get; set; }
        //public DbSet<ProjectPR> ProjectPR { get; set; }
        //public DbSet<ApproverType> ApproverType { get; set; }
        //public DbSet<PRApprover> PRApprover { get; set; }
        //public DbSet<PRVendor> PRVendor { get; set; }
        //public DbSet<PR_ProjectItemRate> PR_ProjectItemRate { get; set; }
        //public DbSet<Currency> Currency { get; set; }
        //public DbSet<ProjectItemColumnsSetting> ProjectItemColumnsSetting { get; set; }
        //public DbSet<HideColumnSetting> HideColumnSettings { get; set; }
        //public DbSet<Tax> Tax { get; set; }
        //public DbSet<DomesticInternational> DomesticInternational { get; set; }
        //public DbSet<SupplyInstall> SupplyInstall { get; set; }
        //public DbSet<PO_ProjectPOPR> PO_ProjectPOPR { get; set; }
        //public DbSet<ProjectPO> ProjectPO { get; set; }

        //public DbSet<POItemDetails> POItemDetails { get; set; }
        //public DbSet<ProjectItemColumnsSettingTemplate> ProjectItemColumnsSettingTemplate { get; set; }
        //public DbSet<ProjectItemColumnsSettingTemplateDetail> ProjectItemColumnsSettingTemplateDetails { get; set; }

        //public DbSet<TaxCodes> TaxCodes { get; set; }
        //public DbSet<TaxType> TaxType { get; set; }
        //public DbSet<Comment> Comment { get; set; }
        //public DbSet<Dashboard> Dashboard { get; set; }
        //public DbSet<BillingBreakUpReport> BillingBreakUpReport { get; set; }        
        //public DbSet<DashboardFilter> DashboardFilter { get; set; }
        //public DbSet<FileStatusUser> FileStatusUser { get; set; }
        //public DbSet<Message> Message { get; set; }
        //public DbSet<DocStatus> DocStatus { get; set; }
        //public DbSet<Additional_Approver_PO> Additional_Approver_PO { get; set; }
        //public DbSet<ProjectGRN> ProjectGRN { get; set; }
        //public DbSet<ProjectGRNItemDetail> ProjectGRNItemDetail { get; set; }

        //public DbSet<PurchaseProposalsave> PurchaseProposalsave { get; set; }

        //public DbSet<Attachment> Attachment { get; set; }

        //public DbSet<Approver_PurchaseProposal> Approver_PurchaseProposal { get; set; }
        //public DbSet<UOM> UOM { get; set; }
        //public DbSet<CostCategory> CostCategory { get; set; }
        //public DbSet<SalesInvoice> SalesInvoice { get; set; }
        //public DbSet<SalesInvoiceItemDetails> SalesInvoiceItemDetails { get; set; }
        //public DbSet<Note> Note { get; set; }
        //public DbSet<ProjectServices> ProjectServices { get; set; }

        //public DbSet<ServiceCC> ServiceCC { get; set; }
        //public DbSet<VehicleType> VehicleType { get; set; }



        //public DbSet<Po_ProjectPo_RevisionBkp> Po_ProjectPo_RevisionBkp { get; set; }
        //public DbSet<PO_ItemDetails_RevisionBkp> PO_ItemDetails_RevisionBkp { get; set; }

        //public DbSet<FileStatusUser_Revision_Bkp> FileStatusUser_Revision_Bkp { get; set; }

        //public DbSet<PurchaseProposalItemDetailsSave> PurchaseProposalItemDetailsSave { get; set; }
        //public DbSet<InvoiceChecklist> InvoiceChecklist { get; set; }
        //public DbSet<SRNInvoiceCheckList> SRNInvoiceCheckList { get; set; }
        //public DbSet<ProjectSRN> ProjectSRN { get; set; }
        //public DbSet<SRNCourier> SRNCourier { get; set; }
        //public DbSet<SRNItemDetails> SRNItemDetails { get; set; }
        //public DbSet<SRNDebitItemDetails> SRNDebitItemDetails { get; set; }
        //public DbSet<SRNDebit> SRNDebit { get; set; }

        //public DbSet<ServiceInvoice> ServiceInvoice { get; set; }
        //public DbSet<WorkFlow> WorkFlow { get; set; }

        //public DbSet<ServiceInvoiceItemDetails> ServiceInvoiceItemDetails { get; set; }
        //public DbSet<ProformaInvoiceItemDetails> ProformaInvoiceItemDetails { get; set; }
        //public DbSet<ProformaInvoice> ProformaInvoice { get; set; }
        //public DbSet<WOAdvancedPayment> WOAdvancedPayment { get; set; }
        //public DbSet<SRNPartialPayment> SRNPartialPayment { get; set; }
        //public DbSet<SRNPartialPaymentItemDetails> SRNPartialPaymentItemDetails { get; set; }
        //public DbSet<ProjectPR_Revision_Bkp> ProjectPR_Revision_Bkp { get; set; }
        //public DbSet<PR_ProjectItemRate_RevisionBkp> PR_ProjectItemRate_RevisionBkp { get; set; }

        //public DbSet<Project_ClientFocalPoint> Project_ClientFocalPoint { get; set; }
        //public DbSet<CurrencyConversion> CurrencyConversion { get; set; }
        //public DbSet<RoleRight> RoleRight { get; set; }
        //public DbSet<Modules> Modules { get; set; }

        //public DbSet<NoteRevesionbkp> NoteRevesionbkp { get; set; }
        //public DbSet<ProjectGRNRevision> ProjectGRNRevision { get; set; }
        //public DbSet<ProjectGRNItemDetailRevision> ProjectGRNItemDetailRevision { get; set; }
        //public DbSet<ModeOfTransport> ModeOfTransport { get; set; }
        //public DbSet<PO_ProjectPOPRReviosnBkp> PO_ProjectPOPRReviosnBkp { get; set; }
        //public DbSet<Contract> Contract { get; set; }
        //public DbSet<TaxCodesDetails> TaxCodesDetails { get; set; }

    }
}
