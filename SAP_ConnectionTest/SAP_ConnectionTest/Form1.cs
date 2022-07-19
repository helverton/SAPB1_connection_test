using System;
using SAPbobsCOM;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SAP_ConnectionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            InitCompany();
            //Company company = new Company();
            //company.Server = "database";
            //company.CompanyDB = "SBO_BEAUTYBIZ_PRD";
            //company.UserName = "manager";
            //company.Password = "easy@123";
            //company.DbServerType = BoDataServerTypes.dst_MSSQL2017;
            //company.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;
            //company.Connect();

            //if (company.GetLastErrorCode() != 0)
            //{
            //    Console.WriteLine(company.GetLastErrorDescription());
            //}
            //else
            //{
            //    Console.WriteLine("company.Server = \"database\";");
            //    Console.WriteLine("company.CompanyDB = \"SBO_BEAUTYBIZ_PRD\";");
            //    Console.WriteLine("company.UserName = \"manager\";");
            //    Console.WriteLine("company.Password = \"easy@123\";");
            //    Console.WriteLine("company.DbServerType = BoDataServerTypes.dst_MSSQL2017;");
            //    Console.WriteLine("company.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;");

            //    Console.WriteLine($"Result: Connection made successfully in the company {company.CompanyDB}");

            //    Recordset oRecordset = (Recordset)company.GetBusinessObject(BoObjectTypes.BoRecordset);
            //    string query = "SELECT TOP 5 ItemCode FROM OITM";
            //    oRecordset.DoQuery(query);
            //    Console.WriteLine("SELECT TOP 5 ItemCode FROM OITM");
            //    while (!oRecordset.EoF)
            //    {
            //        Console.WriteLine(oRecordset.Fields.Item("ItemCode").Value.ToString());

            //        oRecordset.MoveNext();
            //    }
            //}
        }
      
        private void InitCompany()
        {
            Company Company = null;
            try
            {
                try
                {
                    Company = (Company)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("632F4591-AA62-4219-8FB6-22BCF5F60100")));
                    string serverType = this.txtServerType.Text.ToLower();
                    string licenseServer = this.txtLicense.Text.ToLower();
                    string server = this.txtServer.Text.ToLower();
                    string companyDb = this.txtCompanyDb.Text;
                    string companyUser = this.txtCompanyUser.Text.ToLower();
                    string companyPass = this.txtCompanyPass.Text.ToLower();

                    if (serverType.Equals("2000"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL;
                    }
                    else if (serverType.Equals("2005"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2005;
                    }
                    else if (serverType.Equals("2008"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2008;
                    }
                    else if (serverType.Equals("2012"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2012;
                    }
                    else if (serverType.Equals("2014"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2014;
                    }
                    else if (serverType.Equals("2016"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2016;
                    }
                    else if (serverType.Equals("2017"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2017;
                    }
                    else if (serverType.Equals("2019"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_MSSQL2019;
                    }
                    else if (serverType.Equals("hana"))
                    {
                        Company.DbServerType = BoDataServerTypes.dst_HANADB;
                    }

                    if (licenseServer.Contains("http"))
                    {
                        Company.SLDServer = licenseServer;
                    }
                    else if (!string.IsNullOrEmpty(licenseServer))
                    {
                        Company.LicenseServer = licenseServer;
                    }

                    Company.Server = server;
                    Company.CompanyDB = companyDb;
                    Company.UserName = companyUser;
                    Company.Password = companyPass;
                    Company.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;
                    int code = Company.Connect();
                    if (code != 0)
                    {
                        MessageBox.Show(string.Concat("NO connection! error code=", code.ToString()));
                        MessageBox.Show(string.Concat("Error description: ", Company.GetLastErrorDescription()));
                    }
                    else
                    {
                        MessageBox.Show("connection is OK");
                    }
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat("NO connection! error =", ex.ToString()));
                }
            }
            finally
            {
                if (Company != null)
                {
                    Marshal.FinalReleaseComObject(Company);
                }
            }
        }
    }
}
