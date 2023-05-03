namespace ProgForDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CreateDB_button = new System.Windows.Forms.Button();
            this.databaseNameField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DelColumn_button = new System.Windows.Forms.Button();
            this.AddColumn_button = new System.Windows.Forms.Button();
            this.columnTypeField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DropTable_button = new System.Windows.Forms.Button();
            this.CreateTable_button = new System.Windows.Forms.Button();
            this.tableIdField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.DELbutton = new System.Windows.Forms.Button();
            this.REbutton = new System.Windows.Forms.Button();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.TableTel_Field = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TableCity_Field = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TablePatronymic_Field = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TableSurname_Field = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TableName_Field = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TableTitle_Field = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.reportYear = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Word = new System.Windows.Forms.Button();
            this.button_Excel = new System.Windows.Forms.Button();
            this.reportDataGrid = new System.Windows.Forms.DataGridView();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateDB_button
            // 
            this.CreateDB_button.Location = new System.Drawing.Point(4, 40);
            this.CreateDB_button.Margin = new System.Windows.Forms.Padding(2);
            this.CreateDB_button.Name = "CreateDB_button";
            this.CreateDB_button.Size = new System.Drawing.Size(163, 21);
            this.CreateDB_button.TabIndex = 0;
            this.CreateDB_button.Text = "Создать БД";
            this.CreateDB_button.UseVisualStyleBackColor = true;
            this.CreateDB_button.Click += new System.EventHandler(this.CreateDB_button_Click);
            // 
            // databaseNameField
            // 
            this.databaseNameField.Location = new System.Drawing.Point(4, 17);
            this.databaseNameField.Margin = new System.Windows.Forms.Padding(2);
            this.databaseNameField.Name = "databaseNameField";
            this.databaseNameField.Size = new System.Drawing.Size(164, 20);
            this.databaseNameField.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.databaseNameField);
            this.groupBox1.Controls.Add(this.CreateDB_button);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(176, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.DelColumn_button);
            this.groupBox2.Controls.Add(this.AddColumn_button);
            this.groupBox2.Controls.Add(this.columnTypeField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.columnNameField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DropTable_button);
            this.groupBox2.Controls.Add(this.CreateTable_button);
            this.groupBox2.Controls.Add(this.tableIdField);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tableNameField);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(176, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица Создание/Удаление";
            // 
            // DelColumn_button
            // 
            this.DelColumn_button.Location = new System.Drawing.Point(4, 275);
            this.DelColumn_button.Margin = new System.Windows.Forms.Padding(2);
            this.DelColumn_button.Name = "DelColumn_button";
            this.DelColumn_button.Size = new System.Drawing.Size(163, 21);
            this.DelColumn_button.TabIndex = 15;
            this.DelColumn_button.Text = "Удалить Столбец";
            this.DelColumn_button.UseVisualStyleBackColor = true;
            this.DelColumn_button.Click += new System.EventHandler(this.DelColumn_button_Click);
            // 
            // AddColumn_button
            // 
            this.AddColumn_button.Location = new System.Drawing.Point(4, 249);
            this.AddColumn_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddColumn_button.Name = "AddColumn_button";
            this.AddColumn_button.Size = new System.Drawing.Size(163, 21);
            this.AddColumn_button.TabIndex = 14;
            this.AddColumn_button.Text = "Добавить Столбец";
            this.AddColumn_button.UseVisualStyleBackColor = true;
            this.AddColumn_button.Click += new System.EventHandler(this.AddColumn_button_Click);
            // 
            // columnTypeField
            // 
            this.columnTypeField.Location = new System.Drawing.Point(4, 220);
            this.columnTypeField.Margin = new System.Windows.Forms.Padding(2);
            this.columnTypeField.Name = "columnTypeField";
            this.columnTypeField.Size = new System.Drawing.Size(164, 20);
            this.columnTypeField.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тип Данных";
            // 
            // columnNameField
            // 
            this.columnNameField.Location = new System.Drawing.Point(4, 183);
            this.columnNameField.Margin = new System.Windows.Forms.Padding(2);
            this.columnNameField.Name = "columnNameField";
            this.columnNameField.Size = new System.Drawing.Size(164, 20);
            this.columnNameField.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя Столбца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_______________________________";
            // 
            // DropTable_button
            // 
            this.DropTable_button.Location = new System.Drawing.Point(4, 128);
            this.DropTable_button.Margin = new System.Windows.Forms.Padding(2);
            this.DropTable_button.Name = "DropTable_button";
            this.DropTable_button.Size = new System.Drawing.Size(163, 21);
            this.DropTable_button.TabIndex = 8;
            this.DropTable_button.Text = "Удалить Таблицу";
            this.DropTable_button.UseVisualStyleBackColor = true;
            this.DropTable_button.Click += new System.EventHandler(this.DropTable_button_Click);
            // 
            // CreateTable_button
            // 
            this.CreateTable_button.Location = new System.Drawing.Point(4, 102);
            this.CreateTable_button.Margin = new System.Windows.Forms.Padding(2);
            this.CreateTable_button.Name = "CreateTable_button";
            this.CreateTable_button.Size = new System.Drawing.Size(163, 21);
            this.CreateTable_button.TabIndex = 2;
            this.CreateTable_button.Text = "Создать Таблицу";
            this.CreateTable_button.UseVisualStyleBackColor = true;
            this.CreateTable_button.Click += new System.EventHandler(this.CreateTable_button_Click);
            // 
            // tableIdField
            // 
            this.tableIdField.Location = new System.Drawing.Point(4, 72);
            this.tableIdField.Margin = new System.Windows.Forms.Padding(2);
            this.tableIdField.Name = "tableIdField";
            this.tableIdField.Size = new System.Drawing.Size(164, 20);
            this.tableIdField.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID таблицы";
            // 
            // tableNameField
            // 
            this.tableNameField.Location = new System.Drawing.Point(4, 36);
            this.tableNameField.Margin = new System.Windows.Forms.Padding(2);
            this.tableNameField.Name = "tableNameField";
            this.tableNameField.Size = new System.Drawing.Size(164, 20);
            this.tableNameField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя таблицы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(182, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 390);
            this.label6.TabIndex = 5;
            this.label6.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.DELbutton);
            this.groupBox3.Controls.Add(this.REbutton);
            this.groupBox3.Controls.Add(this.ADDbutton);
            this.groupBox3.Controls.Add(this.TableTel_Field);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TableCity_Field);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TablePatronymic_Field);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TableSurname_Field);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TableName_Field);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TableTitle_Field);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(195, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(764, 380);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 264);
            this.dataGridView1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(59, 83);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(661, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "_________________________________________________________________________________" +
    "____________________________\r\n";
            // 
            // DELbutton
            // 
            this.DELbutton.Location = new System.Drawing.Point(538, 58);
            this.DELbutton.Margin = new System.Windows.Forms.Padding(2);
            this.DELbutton.Name = "DELbutton";
            this.DELbutton.Size = new System.Drawing.Size(163, 21);
            this.DELbutton.TabIndex = 17;
            this.DELbutton.Text = "Удалить";
            this.DELbutton.UseVisualStyleBackColor = true;
            this.DELbutton.Click += new System.EventHandler(this.DELbutton_Click);
            // 
            // REbutton
            // 
            this.REbutton.Location = new System.Drawing.Point(538, 35);
            this.REbutton.Margin = new System.Windows.Forms.Padding(2);
            this.REbutton.Name = "REbutton";
            this.REbutton.Size = new System.Drawing.Size(163, 21);
            this.REbutton.TabIndex = 16;
            this.REbutton.Text = "Изменить";
            this.REbutton.UseVisualStyleBackColor = true;
            this.REbutton.Click += new System.EventHandler(this.REbutton_Click);
            // 
            // ADDbutton
            // 
            this.ADDbutton.Location = new System.Drawing.Point(538, 12);
            this.ADDbutton.Margin = new System.Windows.Forms.Padding(2);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(163, 21);
            this.ADDbutton.TabIndex = 15;
            this.ADDbutton.Text = "Добавить";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // TableTel_Field
            // 
            this.TableTel_Field.Location = new System.Drawing.Point(62, 61);
            this.TableTel_Field.Margin = new System.Windows.Forms.Padding(2);
            this.TableTel_Field.Name = "TableTel_Field";
            this.TableTel_Field.Size = new System.Drawing.Size(164, 20);
            this.TableTel_Field.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Телефон";
            // 
            // TableCity_Field
            // 
            this.TableCity_Field.Location = new System.Drawing.Point(62, 38);
            this.TableCity_Field.Margin = new System.Windows.Forms.Padding(2);
            this.TableCity_Field.Name = "TableCity_Field";
            this.TableCity_Field.Size = new System.Drawing.Size(164, 20);
            this.TableCity_Field.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Город";
            // 
            // TablePatronymic_Field
            // 
            this.TablePatronymic_Field.Location = new System.Drawing.Point(305, 61);
            this.TablePatronymic_Field.Margin = new System.Windows.Forms.Padding(2);
            this.TablePatronymic_Field.Name = "TablePatronymic_Field";
            this.TablePatronymic_Field.Size = new System.Drawing.Size(164, 20);
            this.TablePatronymic_Field.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Отчество";
            // 
            // TableSurname_Field
            // 
            this.TableSurname_Field.Location = new System.Drawing.Point(305, 15);
            this.TableSurname_Field.Margin = new System.Windows.Forms.Padding(2);
            this.TableSurname_Field.Name = "TableSurname_Field";
            this.TableSurname_Field.Size = new System.Drawing.Size(164, 20);
            this.TableSurname_Field.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Фамилия";
            // 
            // TableName_Field
            // 
            this.TableName_Field.Location = new System.Drawing.Point(306, 38);
            this.TableName_Field.Margin = new System.Windows.Forms.Padding(2);
            this.TableName_Field.Name = "TableName_Field";
            this.TableName_Field.Size = new System.Drawing.Size(164, 20);
            this.TableName_Field.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Имя";
            // 
            // TableTitle_Field
            // 
            this.TableTitle_Field.Location = new System.Drawing.Point(62, 16);
            this.TableTitle_Field.Margin = new System.Windows.Forms.Padding(2);
            this.TableTitle_Field.Name = "TableTitle_Field";
            this.TableTitle_Field.Size = new System.Drawing.Size(164, 20);
            this.TableTitle_Field.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Компания";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 426);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "9-10";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.reportYear);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button_Word);
            this.tabPage2.Controls.Add(this.button_Excel);
            this.tabPage2.Controls.Add(this.reportDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "11-12";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Год";
            // 
            // reportYear
            // 
            this.reportYear.Location = new System.Drawing.Point(7, 286);
            this.reportYear.Name = "reportYear";
            this.reportYear.Size = new System.Drawing.Size(202, 20);
            this.reportYear.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Запрос 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Запрос 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Word
            // 
            this.button_Word.Location = new System.Drawing.Point(7, 51);
            this.button_Word.Name = "button_Word";
            this.button_Word.Size = new System.Drawing.Size(203, 38);
            this.button_Word.TabIndex = 2;
            this.button_Word.Text = "Word";
            this.button_Word.UseVisualStyleBackColor = true;
            this.button_Word.Click += new System.EventHandler(this.button_Word_Click);
            // 
            // button_Excel
            // 
            this.button_Excel.Location = new System.Drawing.Point(7, 7);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(203, 38);
            this.button_Excel.TabIndex = 1;
            this.button_Excel.Text = "Excel";
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // reportDataGrid
            // 
            this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGrid.Location = new System.Drawing.Point(216, 7);
            this.reportDataGrid.Name = "reportDataGrid";
            this.reportDataGrid.Size = new System.Drawing.Size(746, 387);
            this.reportDataGrid.TabIndex = 0;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(ProgForDB.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 452);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ЛР9-10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

    

        #endregion

        private System.Windows.Forms.Button CreateDB_button;
        private System.Windows.Forms.TextBox databaseNameField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateTable_button;
        private System.Windows.Forms.TextBox tableIdField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DropTable_button;
        private System.Windows.Forms.Button DelColumn_button;
        private System.Windows.Forms.Button AddColumn_button;
        private System.Windows.Forms.TextBox columnTypeField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox columnNameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DELbutton;
        private System.Windows.Forms.Button REbutton;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource programBindingSource;
        public System.Windows.Forms.TextBox TableSurname_Field;
        public System.Windows.Forms.TextBox TableTitle_Field;
        public System.Windows.Forms.TextBox TableTel_Field;
        public System.Windows.Forms.TextBox TableCity_Field;
        public System.Windows.Forms.TextBox TablePatronymic_Field;
        public System.Windows.Forms.TextBox TableName_Field;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Word;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox reportYear;
    }
}

