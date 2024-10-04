namespace WinFormsFileCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSourceDir_Click(object sender, EventArgs e)
        {
            //alternativ Dialog selber anlegen
            //FolderBrowserDialog dialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                cboSource.Text = folderBrowserDialog1.SelectedPath;
                listBox1.Items.Add("gewählter Sourcepfad: " + cboSource.Text);
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnDestDir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                cboDest.Text = folderBrowserDialog1.SelectedPath;
                listBox1.Items.Add("gewählter Destinationpfad: " + cboDest.Text);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(cboSource.Text, cboFilter.Text);
        }
    }
}