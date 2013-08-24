namespace SistemaControleVendasSacoles
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.banco_rr_sacolesDataSet1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.banco_rr_sacolesDataSet1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(406, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // banco_rr_sacolesDataSet1
            // 
            this.banco_rr_sacolesDataSet1.DataSetName = "banco_rr_sacolesDataSet1";
            this.banco_rr_sacolesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 309);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private banco_rr_sacolesDataSet1 banco_rr_sacolesDataSet1;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter sacolesTableAdapter;
    }
}