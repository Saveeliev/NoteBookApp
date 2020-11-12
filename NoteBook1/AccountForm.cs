using DataBase;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class AccountForm : Form
    {
        private readonly IDataProvider _dataProvider;
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public AccountForm(IDataProvider dataProvider, IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _dataProvider = dataProvider;
            _userService = userService;
            _serviceProvider = serviceProvider;
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var activeUser = _userService.GetAndSetActiveUserIfExist();
            var user = _dataProvider.Get<UserDb>(i => i.Id == activeUser.Id).SingleOrDefault();

            await _dataProvider.Delete(user);

            _userService.DeleteActiveUser();
            var activeForm = Application.OpenForms[0];
            activeForm.Controls.Clear();
            var loginControl = _serviceProvider.GetRequiredService<LoginControl>();
            FormEditor.ClearForm(loginControl);
            activeForm.Controls.Add(loginControl);

            Hide();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            var activeUser = _userService.GetAndSetActiveUserIfExist();
            var user = _dataProvider.Get<UserDb>(i => i.Id == activeUser.Id).SingleOrDefault();

            LabelUserLogin.Text = user.Login;
            LabelUserName.Text = user.Name;
        }
    }
}
