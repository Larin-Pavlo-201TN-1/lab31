using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            processList.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                processList.Items.Add(item);
            }

        }

        private void rebtn_Click(object sender, EventArgs e)
        {
            processList.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                processList.Items.Add(item);
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (ListViewItem item in processList.Items)
                        {
                            writer.WriteLine($"Process Name: {item.Text}\tID: {item.SubItems[1].Text}");
                        }
                    }
                    MessageBox.Show("Process list exported successfully.",
                                    "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void InformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processList.SelectedItems.Count > 0)
            {
                string processName = processList.SelectedItems[0].Text;
                Process process = Process.GetProcessesByName(processName)[0];

                string processInfo = $"Process Name: {process.ProcessName}\n" +
                                     $"ID: {process.Id}\n" +
                                     $"Start Time: {process.StartTime}\n" +
                                     $"Responding: {process.Responding}\n" +
                                     $"Threads: {process.Threads.Count}\n" +
                                     $"Modules: {process.Modules.Count}\n\n";

                processInfo += "Threads:\n";
                foreach (ProcessThread thread in process.Threads)
                {
                    processInfo += $"Thread ID: {thread.Id}\tState: {thread.ThreadState}\n";
                }

                processInfo += "\nModules:\n";
                foreach (ProcessModule module in process.Modules)
                {
                    processInfo += $"Module Name: {module.ModuleName}\tFile Name: {module.FileName}\n";
                }

                MessageBox.Show(processInfo, "Process Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processList.SelectedItems.Count > 0)
            {
                string processName = processList.SelectedItems[0].Text;
                Process process = Process.GetProcessesByName(processName)[0];
                try
                {
                    process.Kill();
                    MessageBox.Show($"Процес '{process.ProcessName}' зупинений.",
                                    "Process Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка в зупиненні процесу.\nПомилка: {ex.Message}",
                                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
