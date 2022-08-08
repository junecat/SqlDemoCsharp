using Microsoft.Data.SqlClient;
using System.IO;

string fPath = Path.Combine("Logs", "Logfile.log");

if (!Directory.Exists("Logs"))
    Directory.CreateDirectory("Logs");

using (StreamWriter w = File.AppendText(fPath))
    w.WriteLine("Hello, from SQL test program...");


const string sqlCnStr = "Password=SixStars;Persist Security Info=True;User ID=konst;Initial Catalog=TestDB;Data Source=89.179.244.127,2595;Encrypt=False";

try
{
    using (SqlConnection conn = new SqlConnection(sqlCnStr))
    {
        conn.Open();

        using (StreamWriter w = File.AppendText(fPath))
            w.WriteLine("Conection opened!");

        const string sqlSel = "select count(*) from Table1";
        using (SqlCommand cmd = new SqlCommand(sqlSel, conn))
        {
            int rez = (int)cmd.ExecuteScalar();

            using (StreamWriter w = File.AppendText(fPath))
                w.WriteLine($"count = {rez}");
        }
    }
}
catch (Exception ex)
{
    using (StreamWriter w = File.AppendText(fPath))
        w.WriteLine($"ERROR = {ex.Message}");
}