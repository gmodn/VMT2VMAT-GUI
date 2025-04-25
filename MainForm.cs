using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VMT2VMAT_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                fbd.Filter = "VMT files (*.vmt)|*.vmt|All files (*.*)|*.*";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = fbd.FileName;
                }
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text) || string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                MessageBox.Show("Please provide both input and output paths.");
                return;
            }

            string version = comboVMATVer.SelectedItem.Equals("Half-Life: Alyx") ? "hla" : comboVMATVer.SelectedItem.Equals("Counter-Strike 2") ? "cs2" : "sbox";

            string filetype = comboTexExt.SelectedItem.Equals("TGA") ? "tga" : comboTexExt.SelectedItem.Equals("PNG") ? "png" : "jpg";

            var startInfo = new ProcessStartInfo
            {
                FileName = "VMT2VMAT.exe",
                Arguments = $"-input \"{txtInput.Text}\" -output \"{txtOutput.Text}\" -version {version} -fileextension {filetype}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (var process = Process.Start(startInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    txtLog.Text = output + (string.IsNullOrEmpty(error) ? "" : "\nERROR:\n" + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void comboVMATVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVersion = comboVMATVer.SelectedItem.ToString();
        }

        private void comboTexExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVersion = comboTexExt.SelectedItem.ToString();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}