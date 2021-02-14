using System;
using System.Linq;
using System.Windows.Forms;
using ControleRemotoBot.Model;

namespace ControleRemotoBot
{
    public partial class FrmNewCommand : Form
    {
        public Command _cmd;
        public FrmNewCommand()
        {
            InitializeComponent();
        }

        public FrmNewCommand(Command cmd) : this()
        {
            _cmd = cmd;
        }

        private void FrmNewCommand_Load(object sender, EventArgs e)
        {
            cbbCommand.Items.Clear();
            cbbCommand.Items.AddRange(Constants.AvailableCommands.Keys.ToArray());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Validations
            if (string.IsNullOrEmpty(cbbCommand.Text))
            {
                MessageBox.Show("Favor informar o comando do botão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var cmdDictValue = Constants.AvailableCommands[cbbCommand.Text];

            _cmd ??= new();            

            _cmd.Name = cbbCommand.Text;
            _cmd.Alias = txtCommandCaption.Text;
            _cmd.CommandAction = cmdDictValue;

            DialogResult = DialogResult.OK;     
            Close();
        }
    }
}