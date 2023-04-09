using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ProgForDB
{
    internal class ClientService
    {
        Form1 form;
        SqlConnection connection;
        string connection_string;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        public ClientService(Form1 form1)
        {
                this.form = form1;
                this.connection_string = form.connectionString;
                connection = new SqlConnection(form.connectionString);
        }

        public void DisplayAdvertiserData()
        {
                connection.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Advertiser", connection);
                adapter.Fill(dt);
                form.dataGridView1.DataSource = dt;
                connection.Close();
        }

        public void ClearData()
        {
            form.TableTitle_Field.Text = "";
            form.TableSurname_Field.Text = "";
            form.TableName_Field.Text = "";
            form.TablePatronymic_Field.Text = "";
            form.TableCity_Field.Text = "";
            form.TableTel_Field.Text = "";
            form.SelectedID = -1;
        }

        public void AddAdvertiser()
        {
            using (var connection = new SqlConnection(this.connection_string))
            {
                if (form.TableTitle_Field.Text != "" && form.TableSurname_Field.Text != "" && form.TableName_Field.Text != "" && form.TablePatronymic_Field.Text != "" && form.TableCity_Field.Text != "" && form.TableTel_Field.Text != "")
                {
                    command = new SqlCommand("INSERT INTO Advertiser (Title, Surname, Name, Patronymic, City, Telephone) " + "VALUES (@title, @surname, @name, @patronymic, @city, @telephone)", connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@title", form.TableTitle_Field.Text.Trim());
                    command.Parameters.AddWithValue("@surname", form.TableSurname_Field.Text.Trim());
                    command.Parameters.AddWithValue("@name", form.TableName_Field.Text.Trim());
                    command.Parameters.AddWithValue("@patronymic", form.TablePatronymic_Field.Text.Trim());
                    command.Parameters.AddWithValue("@city", form.TableCity_Field.Text.Trim());
                    command.Parameters.AddWithValue("@telephone", form.TableTel_Field.Text.Trim());
                    command.ExecuteNonQuery();
                    DisplayAdvertiserData();
                    ClearData();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Введите данные");
                }
            }
            
        }

        public void DelAdvertiser(string id)
        {
            using (var connection = new SqlConnection(this.connection_string))
            {
                if (id != "")
                {
                    connection.Open();
                    command = new SqlCommand("DELETE Advertiser WHERE ID_Advertiser = @id", connection);
                    command.Parameters.AddWithValue("@id", form.SelectedID);
                    command.ExecuteNonQuery();
                    connection.Close();
                    System.Windows.Forms.MessageBox.Show("Клиент удален");
                    DisplayAdvertiserData();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Клиент не выбран");
                }
            }
        }

        public void ChangeAdvertiser()
        {
            
                if (form.SelectedID != -1 && form.TableTitle_Field.Text != "" && form.TableSurname_Field.Text != "" && form.TableName_Field.Text != "" && form.TablePatronymic_Field.Text != "" && form.TableCity_Field.Text != "" && form.TableTel_Field.Text != "")
                {
                    using (var connection = new SqlConnection(this.connection_string))
                    {
                        connection.Open();
                        command = new SqlCommand("UPDATE Advertiser SET Title = @title, Surname = @surname, Name = @name, Patronymic = @patronymic, " +
                            "City = @city, Telephone = @telephone WHERE @id = ID_Advertiser", connection);
                        command.Parameters.AddWithValue("@id", form.SelectedID);
                        command.Parameters.AddWithValue("@title", form.TableTitle_Field.Text.Trim());
                        command.Parameters.AddWithValue("@surname", form.TableSurname_Field.Text.Trim());
                        command.Parameters.AddWithValue("@name", form.TableName_Field.Text.Trim());
                        command.Parameters.AddWithValue("@patronymic", form.TablePatronymic_Field.Text.Trim());
                        command.Parameters.AddWithValue("@city", form.TableCity_Field.Text.Trim());
                        command.Parameters.AddWithValue("@telephone", form.TableTel_Field.Text.Trim());
                        command.ExecuteNonQuery();
                        connection.Close();
                        System.Windows.Forms.MessageBox.Show("Рекламодатель обновлен");
                        DisplayAdvertiserData();
                        ClearData();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Введите данные");
                }
            
        }
    }
}
