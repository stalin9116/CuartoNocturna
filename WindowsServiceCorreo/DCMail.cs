using System.Data.SqlClient;

namespace WindowsServiceCorreo
{
    partial class DCMailDataContext
    {
        public DCMailDataContext()
            : base("Data Source=.\\SQLEXPRESS;Initial Catalog=BDDUIOHELPDESK01; User ID=it; Password=Cordillera; Integrated Security=False; max pool size=1000;", mappingSource)
        {
            OnCreated();
        }        

    }
}