using applications.Forms;
using applications.User;

namespace applications
{
    internal static class Program
    {
        public static Instance Instance;


        [STAThread]
        static void Main()
        {
            Instance = new Instance();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormUserManager());
        }
    }
    
    internal class Instance
    {
        public User.User currentUser = null;
        public UserManager UserManager {  get; }

        public Instance()
        {
            this.UserManager = new UserManager();
        }
    }
}