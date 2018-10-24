using App1.Views;
using App1.ViewsAdmin;
using App1.ViewsMaestros;

namespace App1.ViewModels
{
    class MainViewModel
    {
        public LoginViewModel Login
        {
            get;
            set;
        }
        public MasterDetailPage1 master
        {
            get;
            set;
        }
        public MasterDetailMaestro maestro
        {
            get;
            set;
        }
        public MasterDetailAdmin admin
        {
            get;
            set;
        }
        public Accesos Enlaces
        {
            get;
            set;
        }

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        private static MainViewModel instance;
        public static MainViewModel GetInstans()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
    }
}
