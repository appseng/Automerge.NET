namespace Automerge.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Threading;

    public partial class MainForm : Form
    
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_source_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                txt_source.Text = ofd.FileName;
        }

        private void btn_1st_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                txt_1st.Text = ofd.FileName;
        }

        private void btn_2nd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                txt_2nd.Text = ofd.FileName;
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                txt_output.Text = sfd.FileName;
        }

        private Thread thread = null;

        private void btn_automerge_Click(object sender, EventArgs e)
        {
            if (this.thread != null && this.thread.ThreadState == ThreadState.Running)
                return;

            Work w = new Work();
            this.thread = new Thread(new ThreadStart(w.AutoMerge));
            w.SourceInput = txt_source.Text;
            w.Source1st = txt_1st.Text;
            w.Source2nd = txt_2nd.Text;
            w.SourceOuput = txt_output.Text;
            this.thread.Start();
        }
    }
}
