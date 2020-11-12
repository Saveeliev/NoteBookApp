using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NoteBookApp
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;

        public MainForm(IServiceProvider serviceProvider, IUserService userService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var _control = Controls.Find("MainPanel", false).FirstOrDefault();
            Controls.Remove(_control);

            var activeUser = _userService.GetAndSetActiveUserIfExist();

            if(activeUser != null)
            {
                _control = _serviceProvider.GetRequiredService<UserInterfaceControl>();
                Controls.Add(_control);
            }
            else
            {
                _control = _serviceProvider.GetRequiredService<LoginControl>();
                Controls.Add(_control);
            }
        }
    }
}