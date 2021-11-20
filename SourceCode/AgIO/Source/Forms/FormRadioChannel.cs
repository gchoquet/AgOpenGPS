using System;
using System.Windows.Forms;

namespace AgIO
{
    public partial class FormRadioChannel : Form
    {
        private readonly FormLoop mf;

        public CRadioChannel Channel { get; set; } = new CRadioChannel();

        public FormRadioChannel(FormLoop mainForm)
        {
            mf = mainForm;
            InitializeComponent();

            // Set the icon, it is not shown on top. But it is in the taskbar
            Icon = mf.Icon;
        }

        private void FormRadioChannel_Load(object sender, EventArgs e)
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
            toolTip1.SetToolTip(this.btnSerialCancel, gStr.gsCancel);
            toolTip1.SetToolTip(this.btnSerialOK, gStr.gsClose);

            tbId.Text = Channel.Id.ToString();
            tbName.Text = Channel.Name;
            tbFrequency.Text = Channel.Frequency;

            if (!string.IsNullOrEmpty(Channel.Location))
            {
                var locationArray = Channel.Location.Split(' ');

                if (locationArray.Length >= 2)
                {
                    tbLat.Text = locationArray[0];
                    tbLon.Text = locationArray[1];
                }
            }
        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(tbId.Text, out int channelId))
            {
                mf.TimedMessageBox(2000, gStr.gsInvalid + " Id", "Id " + tbId.Text + gStr.gsNotValidNumber);
                DialogResult = DialogResult.None;
                return;
            }

            if (string.IsNullOrEmpty(tbName.Text))
            {
                mf.TimedMessageBox(2000, gStr.gsInvalidName, gStr.gsName + " " + gStr.gsNotFilled);
                DialogResult = DialogResult.None;
                return;
            }

            if (string.IsNullOrEmpty(tbFrequency.Text))
            {
                mf.TimedMessageBox(2000, gStr.gsInvalid + " " + gStr.gsFrequency, gStr.gsFrequency + " " + gStr.gsFrequency);
                DialogResult = DialogResult.None;
                return;
            }

            Channel.Id = channelId;
            Channel.Name = tbName.Text;
            Channel.Frequency = tbFrequency.Text;

            if (!string.IsNullOrEmpty(tbLat.Text) && !string.IsNullOrEmpty(tbLon.Text))
            {
                Channel.Location = $"{tbLat.Text} {tbLon.Text}";
            }
        }

        private void tbox_Click(object sender, EventArgs e)
        {
            if (mf.isKeyboardOn)
            {
                mf.KeyboardToText((TextBox)sender, this);
            }
        }
    }
}
