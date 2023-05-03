using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ProgForDB
{
    public partial class Form1 : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        
        readonly ClientService service;
        public int SelectedID = -1;
        private ReportService reportService = new ReportService();

        public Form1()
        {
            InitializeComponent();
            service = new ClientService(this);
            this.dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
        }


        private void Form1_Load(object sender, EventArgs e) { service.DisplayAdvertiserData(); }

        //ЛР9

        private void CreateDB(string databaseName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("CREATE DATABASE " + databaseName, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("База данных" + databaseNameField.Text + " - создана", "Уведомление");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }
        private void CreateTable(string tableName, string tableIdName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("CREATE TABLE " + tableName + "(" + tableIdName + " int NOT NULL PRIMARY KEY IDENTITY (1, 1) )", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Таблица " + tableNameField.Text + " - создана", "Уведомление");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }
        private void DropTable(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DROP TABLE " + tableName, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Таблица " + tableNameField.Text + " - удалена", "Уведомление");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }
        private void AddColumn(string tableName, string columnName, string columnType)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ALTER TABLE " + tableName + " ADD " + columnName + " " + columnType, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("В таблицу " + tableNameField.Text + " добавлен столбец " + columnNameField.Text, "Уведомление");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }
        private void DropColumn(string tableName, string columnName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ALTER TABLE " + tableName + " DROP COLUMN " + columnName, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Из таблицы " + tableNameField.Text + " удален столбец " + columnNameField.Text, "Уведомление");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void CreateDB_button_Click(object sender, EventArgs e) => CreateDB(databaseNameField.Text);
        private void CreateTable_button_Click(object sender, EventArgs e) => CreateTable(tableNameField.Text, tableIdField.Text);
        private void DropTable_button_Click(object sender, EventArgs e) => DropTable(tableNameField.Text);
        private void AddColumn_button_Click(object sender, EventArgs e) => AddColumn(tableNameField.Text, columnNameField.Text, columnTypeField.Text);
        private void DelColumn_button_Click(object sender, EventArgs e) => DropColumn(tableNameField.Text, columnNameField.Text);

        //ЛР10
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                SelectedID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                TableTitle_Field.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TableSurname_Field.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TableName_Field.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TablePatronymic_Field.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                TableCity_Field.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                TableTel_Field.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void ADDbutton_Click(object sender, EventArgs e) => service.AddAdvertiser();

        private void REbutton_Click(object sender, EventArgs e) => service.ChangeAdvertiser();

        private void DELbutton_Click(object sender, EventArgs e) => service.DelAdvertiser(SelectedID.ToString());

        private void button_Excel_Click(object sender, EventArgs e) => reportService.ExportExcel(reportDataGrid);

        private void button1_Click(object sender, EventArgs e) => reportService.DisplayDefaultReport(reportDataGrid);

        private void button2_Click(object sender, EventArgs e) => reportService.DisplayBCReport(reportDataGrid, reportYear.Text);

        private void button_Word_Click(object sender, EventArgs e) => reportService.ExportWord(reportDataGrid);
     }
}
