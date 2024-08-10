using App.New;
using App.New.App.User;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace app;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// 
    public static Instance Instance;

    [STAThread]
    static void Main()
    {
        Instance = new Instance();
        ApplicationConfiguration.Initialize();
        Application.Run(new FormWelcome());
    }

}
public class Instance
{
    public UserManager UserManager { get; set; }

    public Instance()
    {
        this.UserManager = new UserManager(new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString));
    }
}