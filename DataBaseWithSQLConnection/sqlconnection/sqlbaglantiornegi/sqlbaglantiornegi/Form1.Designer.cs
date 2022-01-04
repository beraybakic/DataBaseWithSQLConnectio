
namespace sqlbaglantiornegi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kisiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyelerDataSet = new sqlbaglantiornegi.uyelerDataSet();
            this.kisiBilgisiTableAdapter = new sqlbaglantiornegi.uyelerDataSetTableAdapters.KisiBilgisiTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.kisiBilgisiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBilgisiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 193);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yaş";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İlçe";
            this.columnHeader5.Width = 189;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Meslek";
            this.columnHeader6.Width = 199;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1093, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verileri Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kisiIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.yasDataGridViewTextBoxColumn,
            this.ilceDataGridViewTextBoxColumn,
            this.meslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kisiBilgisiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 149);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kisiIDDataGridViewTextBoxColumn
            // 
            this.kisiIDDataGridViewTextBoxColumn.DataPropertyName = "KisiID";
            this.kisiIDDataGridViewTextBoxColumn.HeaderText = "KisiID";
            this.kisiIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kisiIDDataGridViewTextBoxColumn.Name = "kisiIDDataGridViewTextBoxColumn";
            this.kisiIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kisiIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            this.yasDataGridViewTextBoxColumn.DataPropertyName = "yas";
            this.yasDataGridViewTextBoxColumn.HeaderText = "yas";
            this.yasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            this.yasDataGridViewTextBoxColumn.Width = 125;
            // 
            // ilceDataGridViewTextBoxColumn
            // 
            this.ilceDataGridViewTextBoxColumn.DataPropertyName = "ilce";
            this.ilceDataGridViewTextBoxColumn.HeaderText = "ilce";
            this.ilceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilceDataGridViewTextBoxColumn.Name = "ilceDataGridViewTextBoxColumn";
            this.ilceDataGridViewTextBoxColumn.Width = 125;
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            this.meslekDataGridViewTextBoxColumn.DataPropertyName = "meslek";
            this.meslekDataGridViewTextBoxColumn.HeaderText = "meslek";
            this.meslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            this.meslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // kisiBilgisiBindingSource
            // 
            this.kisiBilgisiBindingSource.DataMember = "KisiBilgisi";
            this.kisiBilgisiBindingSource.DataSource = this.uyelerDataSet;
            // 
            // uyelerDataSet
            // 
            this.uyelerDataSet.DataSetName = "uyelerDataSet";
            this.uyelerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisiBilgisiTableAdapter
            // 
            this.kisiBilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(817, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(817, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(817, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 22);
            this.textBox4.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Akyurt",
            "Altındağ",
            "Ayaş",
            "Balâ",
            "Beypazarı",
            "Çamlıdere",
            "Çankaya",
            "Çubuk",
            "Elmadağ",
            "Etimesgut",
            "Evren",
            "Gölbaşı",
            "Güdül",
            "Haymana",
            "Kahramankazan",
            "Kalecik",
            "Keçiören",
            "Kızılcahamam",
            "Mamak",
            "Nallıhan",
            "Polatlı",
            "Pursaklar",
            "Sincan",
            "Şereflikoçhisar",
            "Yenimahalle"});
            this.comboBox1.Location = new System.Drawing.Point(817, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kürsü profesörü",
            "Emeritus profesör",
            "Profesör Dr",
            "Doçent",
            "Doçent Dr",
            "Kıdemli okutman",
            "Öğretim Görevlisi",
            "Yardımcı Öğretim Görevlisi"});
            this.comboBox2.Location = new System.Drawing.Point(817, 232);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1093, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1093, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1093, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Verileri Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kisiBilgisiBindingSource1
            // 
            this.kisiBilgisiBindingSource1.DataMember = "KisiBilgisi";
            this.kisiBilgisiBindingSource1.DataSource = this.uyelerDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 467);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBilgisiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private uyelerDataSet uyelerDataSet;
        private System.Windows.Forms.BindingSource kisiBilgisiBindingSource;
        private uyelerDataSetTableAdapters.KisiBilgisiTableAdapter kisiBilgisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource kisiBilgisiBindingSource1;
    }
}

