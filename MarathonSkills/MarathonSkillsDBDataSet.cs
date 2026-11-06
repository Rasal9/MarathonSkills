// Набор данных «MarathonSkillsDBDataSet» (аналог файла MarathonSkillsDBDataSet.xsd,
// который Visual Studio создаёт мастером «Добавить новый источник данных», ПР 4).
// Содержит таблицы/представления БД и адаптеры таблиц (TableAdapter) для их заполнения.
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace MarathonSkills
{
    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class MarathonSkillsDBDataSet : DataSet
    {
        public MarathonSkillsDBDataSet()
        {
            this.DataSetName = "MarathonSkillsDBDataSet";
            DataTable tCharity = this.Tables.Add("Charity");
            tCharity.Columns.Add("CharityId", typeof(int));
            tCharity.Columns.Add("CharityName", typeof(string));
            tCharity.Columns.Add("CharityDescription", typeof(string));
            tCharity.Columns.Add("CharityLogo", typeof(string));
            DataTable tCountry = this.Tables.Add("Country");
            tCountry.Columns.Add("CountryCode", typeof(string));
            tCountry.Columns.Add("CountryName", typeof(string));
            tCountry.Columns.Add("CountryFlag", typeof(string));
            DataTable tGender = this.Tables.Add("Gender");
            tGender.Columns.Add("Gender", typeof(string));
            DataTable tRunner = this.Tables.Add("Runner");
            tRunner.Columns.Add("RunnerId", typeof(int));
            tRunner.Columns.Add("Email", typeof(string));
            tRunner.Columns.Add("Gender", typeof(string));
            tRunner.Columns.Add("DateOfBirth", typeof(System.DateTime));
            tRunner.Columns.Add("CountryCode", typeof(string));
            DataTable tUser = this.Tables.Add("User");
            tUser.Columns.Add("Email", typeof(string));
            tUser.Columns.Add("Password", typeof(string));
            tUser.Columns.Add("FirstName", typeof(string));
            tUser.Columns.Add("LastName", typeof(string));
            tUser.Columns.Add("RoleId", typeof(string));
            DataTable tRole = this.Tables.Add("Role");
            tRole.Columns.Add("RoleId", typeof(string));
            tRole.Columns.Add("RoleName", typeof(string));
            DataTable tSponsorship = this.Tables.Add("Sponsorship");
            tSponsorship.Columns.Add("SponsorshipId", typeof(int));
            tSponsorship.Columns.Add("SponsorName", typeof(string));
            tSponsorship.Columns.Add("RegistrationId", typeof(int));
            tSponsorship.Columns.Add("Amount", typeof(decimal));
            DataTable tRegistration = this.Tables.Add("Registration");
            tRegistration.Columns.Add("RegistrationId", typeof(int));
            tRegistration.Columns.Add("RunnerId", typeof(int));
            tRegistration.Columns.Add("RegistrationDateTime", typeof(System.DateTime));
            tRegistration.Columns.Add("RaceKitOptionId", typeof(string));
            tRegistration.Columns.Add("RegistrationStatusId", typeof(byte));
            tRegistration.Columns.Add("Cost", typeof(decimal));
            tRegistration.Columns.Add("CharityId", typeof(int));
            tRegistration.Columns.Add("SponsorshipTarget", typeof(decimal));
            DataTable tRegistrationEvent = this.Tables.Add("RegistrationEvent");
            tRegistrationEvent.Columns.Add("RegistrationEventId", typeof(int));
            tRegistrationEvent.Columns.Add("RegistrationId", typeof(int));
            tRegistrationEvent.Columns.Add("EventId", typeof(string));
            tRegistrationEvent.Columns.Add("BibNumber", typeof(short));
            tRegistrationEvent.Columns.Add("RaceTime", typeof(int));
            DataTable tRegistrationStatus = this.Tables.Add("RegistrationStatus");
            tRegistrationStatus.Columns.Add("RegistrationStatusId", typeof(byte));
            tRegistrationStatus.Columns.Add("RegistrationStatus", typeof(string));
            DataTable tRaceKitOption = this.Tables.Add("RaceKitOption");
            tRaceKitOption.Columns.Add("RaceKitOptionId", typeof(string));
            tRaceKitOption.Columns.Add("RaceKitOption", typeof(string));
            tRaceKitOption.Columns.Add("Cost", typeof(decimal));
            DataTable tEventType = this.Tables.Add("EventType");
            tEventType.Columns.Add("EventTypeId", typeof(string));
            tEventType.Columns.Add("EventTypeName", typeof(string));
            DataTable tMarathon = this.Tables.Add("Marathon");
            tMarathon.Columns.Add("MarathonId", typeof(byte));
            tMarathon.Columns.Add("MarathonName", typeof(string));
            tMarathon.Columns.Add("CityName", typeof(string));
            tMarathon.Columns.Add("CountryCode", typeof(string));
            tMarathon.Columns.Add("YearHeld", typeof(short));
            DataTable tМои_результаты = this.Tables.Add("Мои_результаты");
            tМои_результаты.Columns.Add("MarathonName", typeof(string));
            tМои_результаты.Columns.Add("EventTypeName", typeof(string));
            tМои_результаты.Columns.Add("RaceTime", typeof(int));
            tМои_результаты.Columns.Add("RunnerId", typeof(int));
            tМои_результаты.Columns.Add("MarathonId", typeof(byte));
            tМои_результаты.Columns.Add("EventId", typeof(string));
            DataTable trunnerManage = this.Tables.Add("runnerManage");
            trunnerManage.Columns.Add("FirstName", typeof(string));
            trunnerManage.Columns.Add("LastName", typeof(string));
            trunnerManage.Columns.Add("Email", typeof(string));
            trunnerManage.Columns.Add("RegistrationStatus", typeof(string));
            trunnerManage.Columns.Add("RunnerId", typeof(int));
            trunnerManage.Columns.Add("MarathonId", typeof(byte));
            trunnerManage.Columns.Add("RegistrationStatusId", typeof(byte));
            trunnerManage.Columns.Add("Gender", typeof(string));
            trunnerManage.Columns.Add("EventId", typeof(string));
            trunnerManage.Columns.Add("EventTypeId", typeof(string));
            trunnerManage.Columns.Add("EventTypeName", typeof(string));
            // связь «User → Runners» (используется в форме 16 «Редактирование профиля»)
            this.Relations.Add("FK_Runner_User", tUser.Columns["Email"], tRunner.Columns["Email"], false);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Charity { get { return this.Tables["Charity"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Country { get { return this.Tables["Country"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Gender { get { return this.Tables["Gender"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Runner { get { return this.Tables["Runner"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable User { get { return this.Tables["User"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Role { get { return this.Tables["Role"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Sponsorship { get { return this.Tables["Sponsorship"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Registration { get { return this.Tables["Registration"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable RegistrationEvent { get { return this.Tables["RegistrationEvent"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable RegistrationStatus { get { return this.Tables["RegistrationStatus"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable RaceKitOption { get { return this.Tables["RaceKitOption"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable EventType { get { return this.Tables["EventType"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Marathon { get { return this.Tables["Marathon"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable Мои_результаты { get { return this.Tables["Мои_результаты"]; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataTable runnerManage { get { return this.Tables["runnerManage"]; } }
    }
}

namespace MarathonSkills.MarathonSkillsDBDataSetTableAdapters
{
    /// <summary>Базовый адаптер таблицы: заполняет DataTable данными из БД.</summary>
    [DesignerCategory("code")]
    public abstract class TableAdapterBase : Component
    {
        private bool clearBeforeFill = true;

        [DefaultValue(true)]
        public bool ClearBeforeFill { get { return clearBeforeFill; } set { clearBeforeFill = value; } }

        protected abstract string SelectCommandText { get; }

        public virtual int Fill(DataTable dataTable)
        {
            if (this.ClearBeforeFill) dataTable.Clear();
            using (SqlConnection con = new SqlConnection(global::MarathonSkills.Properties.Settings.Default.Wow_MeowConnectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(this.SelectCommandText, con))
            {
                return da.Fill(dataTable);
            }
        }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class CharityTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Charity"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class CountryTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Country"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class GenderTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Gender"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class RunnerTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Runner"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class UserTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.[User]"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class RoleTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Role"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class SponsorshipTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Sponsorship"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class RegistrationTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Registration"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class RegistrationEventTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.RegistrationEvent"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class RegistrationStatusTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.RegistrationStatus"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class RaceKitOptionTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.RaceKitOption"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class EventTypeTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.EventType"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class MarathonTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.Marathon"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class Мои_результатыTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.[Мои результаты]"; } }
    }

    [DesignerCategory("code")]
    [ToolboxItem(true)]
    public partial class runnerManageTableAdapter : TableAdapterBase
    {
        protected override string SelectCommandText { get { return "SELECT * FROM dbo.runnerManage"; } }
    }
}
