using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusScanner.Controller;
using VirusScanner.Model;

namespace VirusScanner.View
{
    public partial class MainWindow : Form
    {
        private DirsController dirs;
        private ScanFileController scanner;
        private Thread scan;
        public MainWindow()
        {
            InitializeComponent();
            dirs = new DirsController();
            scanner = new ScanFileController();
            StatusTextBox.Text = "Выберите директорию.";
        }
        private async void scanButton_Click(object sender, EventArgs e)
        {
            if (scan == null)
            {
                if (Path.MainPath != null)
                {
                    StatusTextBox.Text = "Идет поиск файлов, подождите.";
                    consoleTextBox.Text = string.Empty;
                    Path.PeFilesPath.Clear();
                    List<string> listFiles = await dirs.GetFiles(Path.MainPath);
                    scan = new Thread(async => check(listFiles));
                    scan.Start();
                }
                else
                {
                    MessageBox.Show("Выберите директорию.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Выолняется поиск файлов, подождите.", "Ошибка");
            }
            
        }
        private async void check(List<string> files)
        {
            int count = 0;
            foreach (string file in files)
            {
                if(await dirs.CheckFiles(file))
                {
                    consoleTextBox.AppendText(file + "\r\n");
                    count++;
                }
            }
            scan = null;
            StatusTextBox.Text = "Поиск завершен.";
            MessageBox.Show($"Найдено файлов - {count}.");
        } 

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            if (scan == null)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string result = folderBrowserDialog1.SelectedPath;
                    directoryTextBox.Text = result;
                    Path.MainPath = result;
                }
            }
            else
                MessageBox.Show("Выолняется поиск файлов, подождите.", "Ошибка");
        }

        private void chooseHexButton_Click(object sender, EventArgs e)
        {
            if (Path.MainPath != null)
            {
                if (scan != null)
                    MessageBox.Show("Выолняется поиск файлов, подождите.", "Ошибка");
                else if (StatusTextBox.Text == "Поиск завершен." || StatusTextBox.Text == "Сигнатура выбрана.")
                {
                    HexWindow hexwindow = new HexWindow();
                    hexwindow.ShowDialog();
                    StatusTextBox.Text = "Сигнатура выбрана.";
                }
                else
                {
                    MessageBox.Show("Выполните поиск файлов.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Выберите директорию.", "Ошибка");
            }
        }

        private async void scanFileButton_Click(object sender, EventArgs e)
        {
            if (Path.MainPath != null)
            {
                if (scan != null)
                    MessageBox.Show("Выолняется поиск файлов, подождите.", "Ошибка");
                else if (StatusTextBox.Text == "Сигнатура выбрана." || StatusTextBox.Text == "Поиск сигнатуры в файлах завершен.")
                {
                    StatusTextBox.Text = "Поиск сигнатуры в файлах...";
                    consoleTextBox.Text = string.Empty;
                    int count = 0;
                    foreach (string path in Path.PeFilesPath)
                    {
                        bool isVirus = await scanner.scanFiles(path);
                        if (isVirus)
                        {
                            consoleTextBox.AppendText(path + "\r\n");
                            count++;
                        }
                    }
                    StatusTextBox.Text = "Поиск сигнатуры в файлах завершен.";
                    MessageBox.Show($"Найдено {count} вредоносных файлов.", "Оповещение");
                }
                else if(StatusTextBox.Text == "Поиск завершен.")
                {
                    MessageBox.Show("Выберите сигнатуру.", "Ошибка");
                }
                else
                {
                    MessageBox.Show("Выполните поиск файлов.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Выберите директорию.", "Ошибка");
            }
        }
    }
}
