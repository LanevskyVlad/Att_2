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

namespace _5
{
    public partial class BinTree : Form
    {
        public BinTree()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(openFileDialog.FileName);
                    if (sender == OpenBtnA)
                        InputA.Text = file.ReadText();
                    else
                        InputB.Text = file.ReadText();
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка чтения", "Error");
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.WriteText(OutputC.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("ошибка записи", "Error");
                }
            }
        }

        private void FiltrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TextTools text = new TextTools(StrToStrList(InputA.Text), StrToStrList(InputB.Text));
                List<string> textC = text.GetTextC();
                OutputC.Text = StrListToStr(textC);
                SaveBtn.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("некорректный ввод", "Error");
            }
        }
    }
}
