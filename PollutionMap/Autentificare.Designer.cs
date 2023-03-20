namespace PollutionMap
{
    partial class Autentificare
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
            this.masurareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poluareDataSet = new PollutionMap.PoluareDataSet();
            this.hartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hartiTableAdapter = new PollutionMap.PoluareDataSetTableAdapters.HartiTableAdapter();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new PollutionMap.PoluareDataSetTableAdapters.UtilizatoriTableAdapter();
            this.masurareTableAdapter = new PollutionMap.PoluareDataSetTableAdapters.MasurareTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masurareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poluareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masurareBindingSource
            // 
            this.masurareBindingSource.DataMember = "Masurare";
            this.masurareBindingSource.DataSource = this.poluareDataSet;
            // 
            // poluareDataSet
            // 
            this.poluareDataSet.DataSetName = "PoluareDataSet";
            this.poluareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hartiBindingSource
            // 
            this.hartiBindingSource.DataMember = "Harti";
            this.hartiBindingSource.DataSource = this.poluareDataSet;
            // 
            // hartiTableAdapter
            // 
            this.hartiTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.poluareDataSet;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // masurareTableAdapter
            // 
            this.masurareTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(235, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Utilizator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 26);
            this.textBox1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(200, 418);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(300, 26);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cont nou";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masurareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poluareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PoluareDataSet poluareDataSet;
        private System.Windows.Forms.BindingSource hartiBindingSource;
        private PoluareDataSetTableAdapters.HartiTableAdapter hartiTableAdapter;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private PoluareDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource masurareBindingSource;
        private PoluareDataSetTableAdapters.MasurareTableAdapter masurareTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}