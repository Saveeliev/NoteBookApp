using Dto.User;
using DTO.Responses;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class LoginControl : UserControl
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public LoginControl(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        private async void ButtonToLogin_Click(object sender, EventArgs e)
        {
            var request = new LoginRequest { Login = EnterLogin.Text, Password = EnterPassword.Text };
            var result = await _userService.Login(request);

            if (result is Success)
            {
                await _userService.SetActiveUser(request);
                var userInterfaceControl = _serviceProvider.GetRequiredService<UserInterfaceControl>();
                var activeForm = Application.OpenForms[0];
                activeForm.Controls.Clear();
                activeForm.Controls.Add(userInterfaceControl);
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void LinkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var activeForm = Application.OpenForms[0];
            activeForm.Controls.Clear();
            var regControl = _serviceProvider.GetRequiredService<RegisterControl>();
            FormEditor.ClearForm(regControl);
            activeForm.Controls.Add(regControl);
        }

        private void LabelToNick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnterLogin.Text = "Nick";
            EnterPassword.Text = "123";
        }

        private void LabelToBob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnterLogin.Text = "Bob";
            EnterPassword.Text = "122";
        }
    }
}