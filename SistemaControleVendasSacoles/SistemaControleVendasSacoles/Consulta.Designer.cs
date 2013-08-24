namespace SistemaControleVendasSacoles
{
    partial class Consulta
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
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_rr_sacolesDataSet1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1();
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager();
            this.tipoTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSacolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saborDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // banco_rr_sacolesDataSet1
            // 
            this.banco_rr_sacolesDataSet1.DataSetName = "banco_rr_sacolesDataSet1";
            this.banco_rr_sacolesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesitemTableAdapter = null;
            this.tableAdapterManager.sacolesTableAdapter = this.sacolesTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = this.tipoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSacolesDataGridViewTextBoxColumn,
            this.saborDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.quantDataGridViewTextBoxColumn,
            this.quantminDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sacolesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(48, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(604, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idSacolesDataGridViewTextBoxColumn
            // 
            this.idSacolesDataGridViewTextBoxColumn.DataPropertyName = "idSacoles";
            this.idSacolesDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idSacolesDataGridViewTextBoxColumn.Name = "idSacolesDataGridViewTextBoxColumn";
            // 
            // saborDataGridViewTextBoxColumn
            // 
            this.saborDataGridViewTextBoxColumn.DataPropertyName = "sabor";
            this.saborDataGridViewTextBoxColumn.HeaderText = "Sabor";
            this.saborDataGridViewTextBoxColumn.Name = "saborDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // quantDataGridViewTextBoxColumn
            // 
            this.quantDataGridViewTextBoxColumn.DataPropertyName = "quant";
            this.quantDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantDataGridViewTextBoxColumn.Name = "quantDataGridViewTextBoxColumn";
            // 
            // quantminDataGridViewTextBoxColumn
            // 
            this.quantminDataGridViewTextBoxColumn.DataPropertyName = "quantmin";
            this.quantminDataGridViewTextBoxColumn.HeaderText = "Quant. Mínima";
            this.quantminDataGridViewTextBoxColumn.Name = "quantminDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // sacolesBindingSource1
            // 
            this.sacolesBindingSource1.DataMember = "sacoles";
            this.sacolesBindingSource1.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 230);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private banco_rr_sacolesDataSet1 banco_rr_sacolesDataSet1;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter tipoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private System.Windows.Forms.BindingSource sacolesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSacolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saborDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
    }
}