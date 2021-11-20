using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormCommSaver : Form
    {
        //class variables
        private readonly FormLoop mf = null;

        public FormCommSaver(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormLoop;
            InitializeComponent();

            //this.bntOK.Text = gStr.gsForNow;
            //this.btnSave.Text = gStr.gsToFile;

            //this.Text = gStr.gsSaveEnvironment;
        }

        private void FormCommSaver_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the form container.
            ToolTip toolTip1 = new ToolTip();
            // Set tooltip default parameters
            
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = false;
            toolTip1.Active = true;

            // set tooltip values on related controls
            toolTip1.SetToolTip(this.btnSave, gStr.gsSave);
            toolTip1.SetToolTip(this.tboxName, gStr.gsName);

            lblLast.Text = gStr.gsCurrent + " " + mf.commFileName;
            DirectoryInfo dinfo = new DirectoryInfo(mf.commDirectory);
            FileInfo[] Files = dinfo.GetFiles("*.xml");

            if (Files.Length == 0)
            {
                cboxEnv.Enabled = false;
            }

            foreach (FileInfo file in Files)
            {
                cboxEnv.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }
        }

        private void cboxVeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show(
                gStr.gsOverwrite + ": " + cboxEnv.SelectedItem.ToString() + ".xml",
                gStr.gsSaveAndReturn,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (result3 == DialogResult.Yes)
            {
                SettingsIO.ExportSettings(mf.commDirectory + cboxEnv.SelectedItem.ToString() + ".xml");
                Close();
            }
        }

        private void tboxName_TextChanged(object sender, EventArgs e)
        {
            TextBox textboxSender = (TextBox)sender;
            int cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, glm.fileRegex, "");

            textboxSender.SelectionStart = cursorPosition;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tboxName.Text.Trim().Length > 0)
            {
                SettingsIO.ExportSettings(mf.commDirectory + tboxName.Text.Trim() + ".xml");
                Close();
            }
        }

        private void tboxName_Click(object sender, EventArgs e)
        {
            if (mf.isKeyboardOn)
            {
                mf.KeyboardToText((TextBox)sender, this);
                btnSave.Focus();
            }
        }
    }
}