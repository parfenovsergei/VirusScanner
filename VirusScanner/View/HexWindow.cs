using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusScanner.Model;
using VirusScanner.Controller;

namespace VirusScanner.View
{
    
    public partial class HexWindow : Form
    {
        private SequnceController seq;
        public HexWindow()
        {
            InitializeComponent();
            seq = new SequnceController();
        }
        private void HexWindow_Load(object sender, EventArgs e)
        {
            sequncesСomboBox.Items.AddRange(seq.SetComboBox());
        }

        private void addBytesButton_Click(object sender, EventArgs e)
        {
            string sequnce = addSequnceTextBox.Text;
            if (sequnce != "")
            {
                seq.addSequnce(sequnce);
                MessageBox.Show($"Последовательность {sequnce} добавлена в БД.");
                addSequnceTextBox.Clear();
            }
            else
                MessageBox.Show("Введите последовательность.", "Ошибка");
            sequncesСomboBox.Items.Add(sequnce);
        }

        private void chooseBytesButton_Click(object sender, EventArgs e)
        {
            string selectedBytes;
            if (sequncesСomboBox.SelectedItem != null && sequncesСomboBox.SelectedItem.ToString() != "")
            {
                selectedBytes = sequncesСomboBox.SelectedItem.ToString();
                Model.Path.SelectedBytesSuqence = selectedBytes;
                Close();
            }
            else
                MessageBox.Show("Последовательность байт не выбрана.", "Ошибка");
        }
    }
}

