using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SemenovIA.Task1.V6
{
    public partial class VrachiFormSemenovIA : Form
    {
        private DataTable table = new DataTable();
        public VrachiFormSemenovIA()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonCloseSemenovIA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VrachiFormSemenovIA_Load(object sender, EventArgs e)
        {
            string filePath = "vrachi.csv";

            try
            {
                Encoding encoding = Encoding.GetEncoding("windows-1251");
                using (StreamReader sr = new StreamReader(filePath, encoding))
                {
                    string line;

      
                    if ((line = sr.ReadLine()) != null)
                    {
                        string[] headers = line.Split(',');
                        foreach (string header in headers)
                        {
                            table.Columns.Add(header);
                        }
                    }

            
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        table.Rows.Add(data);
                    }
                }

                dataGridViewSemenovIA.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных из CSV файла: " + ex.Message);
            }
        }

        private void buttonPoiskSemenovIA_Click(object sender, EventArgs e)
        {
            string productName = textBoxSemenovIA.Text.Trim();

            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Введите ФИО врача");
                return;
            }

            var filteredRows = table.AsEnumerable()
                                     .Where(row => row.Field<string>("ФИО").Contains(Name))
                                     .ToList();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("Такого врача нет в базе ");
            }
            else
            {
                DataTable filteredTable = filteredRows.CopyToDataTable();
                dataGridViewSemenovIA.DataSource = filteredTable;
            }
        }

        private void buttonAllSemenovIA_Click(object sender, EventArgs e)
        {
            dataGridViewSemenovIA.DataSource = table;
        }

        private void labelTextSemenovIA_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSemenovIA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

