using System.ComponentModel;

namespace App1.ViewModels
{
    using Plugin.Connectivity;
    using MySql.Data.MySqlClient;
    using Infrastructure;
    using App1.ViewsMaestros;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {

        #region Atributos
        private string matricula;
        private string password;
        private bool isrunning;
        private bool isenabled;

        #endregion

        #region Propiedades
        public string Matricula
        {
            get { return this.matricula; }
            set { SetValue(ref this.matricula, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRinning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }
        public bool IsRemember
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get { return this.isenabled; }
            set { SetValue(ref this.isenabled, value); }
        }

        #endregion

        #region Constructor
            public LoginViewModel()
        {
            this.IsRemember = true;
            this.IsEnabled = true;

            this.Matricula = "361610";
            this.Password = "1234";
        }
        #endregion

        #region Comandos
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Matricula))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar una matricula",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar una contraseña",
                    "Aceptar");
                return;
            }
            this.IsRinning = true;
            this.IsEnabled = false;

            if (CrossConnectivity.Current.IsConnected)
            {
                if (this.Matricula != "361610" || this.Password != "1234")
                {
                    this.IsRinning = false;
                    this.IsEnabled = true;
                    await Application.Current.MainPage.DisplayAlert(
                        "Error",
                        "Matricula o Contraseña incorrecta",
                        "Aceptar");
                    this.Matricula = string.Empty;
                    this.Password = string.Empty;
                    return;
                }
                this.IsRinning = false;
                this.IsEnabled = true;
                this.Matricula = string.Empty;
                this.Password = string.Empty;
                MainViewModel.GetInstans().maestro = new MasterDetailMaestro();
                await Application.Current.MainPage.Navigation.PushAsync(new MasterDetailMaestro());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(
                        "Error",
                        "No hay conexion",
                        "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                
            }
            this.IsRinning = false;
            this.IsEnabled = true;
        }
        #endregion
    }
}
