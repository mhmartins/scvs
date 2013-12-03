namespace SistemaControleVendasSacoles
{
    partial class Form4
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
            this.graficovendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.graficoFULLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficoFULL = new SistemaControleVendasSacoles.GraficoFULL();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafoEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafo_Estoque = new SistemaControleVendasSacoles.Grafo_Estoque();
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.Grafo_EstoqueTableAdapters.sacolesTableAdapter();
            this.graficovendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficovendasTableAdapter = new SistemaControleVendasSacoles.GraficoFULLTableAdapters.graficovendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficovendasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFULLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFULL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafoEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafo_Estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficovendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin2;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.graficovendasBindingSource1;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.MarkerSize = 20;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Sacolés";
            series1.XValueMember = "sabor";
            series1.YValueMembers = "quantidade";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1079, 551);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gráfico de vendas dos sacolés";
            this.chart1.Titles.Add(title1);
            // 
            // graficovendasBindingSource1
            // 
            this.graficovendasBindingSource1.DataMember = "graficovendas";
            this.graficovendasBindingSource1.DataSource = this.graficoFULLBindingSource;
            // 
            // graficoFULLBindingSource
            // 
            this.graficoFULLBindingSource.DataSource = this.graficoFULL;
            this.graficoFULLBindingSource.Position = 0;
            // 
            // graficoFULL
            // 
            this.graficoFULL.DataSetName = "GraficoFULL";
            this.graficoFULL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.grafoEstoqueBindingSource;
            // 
            // grafoEstoqueBindingSource
            // 
            this.grafoEstoqueBindingSource.DataSource = this.grafo_Estoque;
            this.grafoEstoqueBindingSource.Position = 0;
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
            // graficovendasBindingSource
            // 
            this.graficovendasBindingSource.DataMember = "graficovendas";
            this.graficovendasBindingSource.DataSource = this.graficoFULLBindingSource;
            // 
            // graficovendasTableAdapter
            // 
            this.graficovendasTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico de Saída de Sacolés";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficovendasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFULLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFULL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafoEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafo_Estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficovendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource grafoEstoqueBindingSource;
        private Grafo_Estoque grafo_Estoque;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private Grafo_EstoqueTableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private System.Windows.Forms.BindingSource graficoFULLBindingSource;
        private GraficoFULL graficoFULL;
        private System.Windows.Forms.BindingSource graficovendasBindingSource;
        private GraficoFULLTableAdapters.graficovendasTableAdapter graficovendasTableAdapter;
        private System.Windows.Forms.BindingSource graficovendasBindingSource1;
    }
}