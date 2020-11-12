using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure;
using Dto.User;
using DTO.Responses;

namespace NoteBookApp
{
    public partial class RegisterControl : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;

        public RegisterControl(IServiceProvider serviceProvider, IUserService userService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        private void LinkToBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var activeForm = Application.OpenForms[0];
            activeForm.Controls.Clear();
            var loginControl = _serviceProvider.GetRequiredService<LoginControl>();
            FormEditor.ClearForm(loginControl);
            activeForm.Controls.Add(loginControl);
        }

        private async void ButtonToRegister_Click(object sender, EventArgs e)
        {
            var request = new RegisterRequest { Login = EnterLogin.Text, Name = EnterName.Text, Password = EnterPassword.Text, PasswordConfirm = EnterConfPassword.Text };
            var result = await _userService.Register(request);

            if (result is Success)
            {
                var activeForm = Application.OpenForms[0];
                activeForm.Controls.Clear();
                var loginControl = _serviceProvider.GetRequiredService<LoginControl>();
                activeForm.Controls.Add(loginControl);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}