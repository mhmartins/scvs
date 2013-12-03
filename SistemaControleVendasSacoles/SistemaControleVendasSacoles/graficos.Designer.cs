namespace SistemaControleVendasSacoles
{
    partial class graficos
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sacolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grafoEstCremoso = new SistemaControleVendasSacoles.GrafoEstCremoso();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafo_Estoque = new SistemaControleVendasSacoles.Grafo_Estoque();
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.Grafo_EstoqueTableAdapters.sacolesTableAdapter();
            this.sacolesTableAdapter1 = new SistemaControleVendasSacoles.GrafoEstCremosoTableAdapters.sacolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafoEstCremoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafo_Estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Lime;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Lime;
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin5;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.sacolesBindingSource1;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 8);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Quantidade";
            series1.XValueMember = "sabor";
            series1.YValueMembers = "quant";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1025, 525);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gráfico do Estoque dos Sacolés Cremosos";
            this.chart1.Titles.Add(title1);
            // 
            // sacolesBindingSource1
            // 
            this.sacolesBindingSource1.DataMember = "sacoles";
            this.sacolesBindingSource1.DataSource = this.grafoEstCremoso;
            // 
            // grafoEstCremoso
            // 
            this.grafoEstCremoso.DataSetName = "GrafoEstCremoso";
            this.grafoEstCremoso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.grafo_Estoque;
            // 
            // grafo_Estoque
            // 
            this.grafo_Estoque.DataSetName = "Grafo_Estoque";
            this.grafo_Estoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // sacolesTableAdapter1
            // 
            this.sacolesTableAdapter1.ClearBeforeFill = true;
            // 
            // graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 541);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "graficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico do Estoque do Sacolés Cremosos";
            this.Load += new System.EventHandler(this.graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafoEstCremoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafo_Estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Grafo_Estoque grafo_Estoque;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private Grafo_EstoqueTableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private GrafoEstCremoso grafoEstCremoso;
        private System.Windows.Forms.BindingSource sacolesBindingSource1;
        private GrafoEstCremosoTableAdapters.sacolesTableAdapter sacolesTableAdapter1;
    }
}