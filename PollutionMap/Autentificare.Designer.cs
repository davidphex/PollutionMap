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
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 534);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masurareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poluareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PoluareDataSet poluareDataSet;
        private System.Windows.Forms.BindingSource hartiBindingSource;
        private PoluareDataSetTableAdapters.HartiTableAdapter hartiTableAdapter;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private PoluareDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource masurareBindingSource;
        private PoluareDataSetTableAdapters.MasurareTableAdapter masurareTableAdapter;
    }
}