namespace PollutionMap
{
    partial class Vizualizare
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poluareDataSet = new PollutionMap.PoluareDataSet();
            this.hartiTableAdapter = new PollutionMap.PoluareDataSetTableAdapters.HartiTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VeziHarta = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Traseu = new System.Windows.Forms.TabPage();
            this.masurareTableAdapter = new PollutionMap.PoluareDataSetTableAdapters.MasurareTableAdapter();
            this.masurareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poluareDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.VeziHarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masurareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hartiBindingSource;
            this.comboBox1.DisplayMember = "NumeHarta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hartiBindingSource
            // 
            this.hartiBindingSource.DataMember = "Harti";
            this.hartiBindingSource.DataSource = this.poluareDataSet;
            // 
            // poluareDataSet
            // 
            this.poluareDataSet.DataSetName = "PoluareDataSet";
            this.poluareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hartiTableAdapter
            // 
            this.hartiTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VeziHarta);
            this.tabControl1.Controls.Add(this.Traseu);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 557);
            this.tabControl1.TabIndex = 1;
            // 
            // VeziHarta
            // 
            this.VeziHarta.Controls.Add(this.button3);
            this.VeziHarta.Controls.Add(this.button2);
            this.VeziHarta.Controls.Add(this.button1);
            this.VeziHarta.Controls.Add(this.comboBox2);
            this.VeziHarta.Controls.Add(this.label3);
            this.VeziHarta.Controls.Add(this.label2);
            this.VeziHarta.Controls.Add(this.dateTimePicker1);
            this.VeziHarta.Controls.Add(this.label1);
            this.VeziHarta.Controls.Add(this.pictureBox1);
            this.VeziHarta.Controls.Add(this.comboBox1);
            this.VeziHarta.Location = new System.Drawing.Point(4, 22);
            this.VeziHarta.Name = "VeziHarta";
            this.VeziHarta.Padding = new System.Windows.Forms.Padding(3);
            this.VeziHarta.Size = new System.Drawing.Size(1020, 531);
            this.VeziHarta.TabIndex = 0;
            this.VeziHarta.Text = "VeziHarta";
            this.VeziHarta.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(54, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Iesire";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(121, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Resetare filtru";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filtru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Niciun filtru",
            "Valoarea < 20",
            "20 <= Valoarea <= 40",
            "Valoarea > 40"});
            this.comboBox2.Location = new System.Drawing.Point(6, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alege Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alege Harta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Traseu
            // 
            this.Traseu.Location = new System.Drawing.Point(4, 22);
            this.Traseu.Name = "Traseu";
            this.Traseu.Padding = new System.Windows.Forms.Padding(3);
            this.Traseu.Size = new System.Drawing.Size(1020, 531);
            this.Traseu.TabIndex = 1;
            this.Traseu.Text = "Traseu";
            this.Traseu.UseVisualStyleBackColor = true;
            // 
            // masurareTableAdapter
            // 
            this.masurareTableAdapter.ClearBeforeFill = true;
            // 
            // masurareBindingSource
            // 
            this.masurareBindingSource.DataMember = "Masurare";
            this.masurareBindingSource.DataSource = this.poluareDataSet;
            // 
            // Vizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "Vizualizare";
            this.Text = "Vizualizare";
            this.Load += new System.EventHandler(this.Vizualizare_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Vizualizare_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poluareDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.VeziHarta.ResumeLayout(false);
            this.VeziHarta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masurareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private PoluareDataSet poluareDataSet;
        private System.Windows.Forms.BindingSource hartiBindingSource;
        private PoluareDataSetTableAdapters.HartiTableAdapter hartiTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage VeziHarta;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Traseu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private PoluareDataSetTableAdapters.MasurareTableAdapter masurareTableAdapter;
        private System.Windows.Forms.BindingSource masurareBindingSource;
    }
}