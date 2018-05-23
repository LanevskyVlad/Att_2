using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
using static Tools.StringConverter;
namespace _3._1
{
    public partial class Queue : Form
    {
        public Queue()
        {
            InitializeComponent();
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IntQueue queue = new IntQueue(StrToIntList(Input.Text));
                queue.RemoveAfterD((int)GetD.Value);
                Output.Text = IntListToString(queue.ToList());
                SaveOutputBtn.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("некорректный ввод", "Error");
            }
        }

        private void OpenInputBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(openFileDialog.FileName);
                    Input.Text = file.ReadText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void SaveOutputBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.WriteText(Output.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
