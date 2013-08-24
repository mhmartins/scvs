namespace SistemaControleVendasSacoles
{
    partial class AlterareExcluir
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
            System.Windows.Forms.Label idSacolesLabel;
            System.Windows.Forms.Label saborLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label quantLabel;
            System.Windows.Forms.Label quantminLabel;
            System.Windows.Forms.Label precoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterareExcluir));
            this.banco_rr_sacolesDataSet1 = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager();
            this.sacolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sacolesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idSacolesLabel1 = new System.Windows.Forms.Label();
            this.saborTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantTextBox = new System.Windows.Forms.TextBox();
            this.quantminTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter();
            idSacolesLabel = new System.Windows.Forms.Label();
            saborLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            quantLabel = new System.Windows.Forms.Label();
            quantminLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingNavigator)).BeginInit();
            this.sacolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idSacolesLabel
            // 
            idSacolesLabel.AutoSize = true;
            idSacolesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            idSacolesLabel.Location = new System.Drawing.Point(34, 69);
            idSacolesLabel.Name = "idSacolesLabel";
            idSacolesLabel.Size = new System.Drawing.Size(76, 24);
            idSacolesLabel.TabIndex = 1;
            idSacolesLabel.Text = "Código:";
            // 
            // saborLabel
            // 
            saborLabel.AutoSize = true;
            saborLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            saborLabel.Location = new System.Drawing.Point(34, 107);
            saborLabel.Name = "saborLabel";
            saborLabel.Size = new System.Drawing.Size(65, 24);
            saborLabel.TabIndex = 3;
            saborLabel.Text = "Sabor:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            tipoLabel.Location = new System.Drawing.Point(34, 145);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(53, 24);
            tipoLabel.TabIndex = 5;
            tipoLabel.Text = "Tipo:";
            // 
            // quantLabel
            // 
            quantLabel.AutoSize = true;
            quantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            quantLabel.Location = new System.Drawing.Point(34, 183);
            quantLabel.Name = "quantLabel";
            quantLabel.Size = new System.Drawing.Size(113, 24);
            quantLabel.TabIndex = 7;
            quantLabel.Text = "Quantidade:";
            // 
            // quantminLabel
            // 
            quantminLabel.AutoSize = true;
            quantminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            quantminLabel.Location = new System.Drawing.Point(34, 221);
            quantminLabel.Name = "quantminLabel";
            quantminLabel.Size = new System.Drawing.Size(179, 24);
            quantminLabel.TabIndex = 9;
            quantminLabel.Text = "Quantidade Mínima:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            precoLabel.Location = new System.Drawing.Point(34, 259);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(59, 24);
            precoLabel.TabIndex = 11;
            precoLabel.Text = "Valor:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesitemTableAdapter = null;
            this.tableAdapterManager.sacolesTableAdapter = this.sacolesTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // sacolesBindingNavigator
            // 
            this.sacolesBindingNavigator.AddNewItem = null;
            this.sacolesBindingNavigator.BindingSource = this.sacolesBindingSource;
            this.sacolesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sacolesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sacolesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sacolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.sacolesBindingNavigatorSaveItem});
            this.sacolesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sacolesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sacolesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sacolesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sacolesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sacolesBindingNavigator.Name = "sacolesBindingNavigator";
            this.sacolesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sacolesBindingNavigator.Size = new System.Drawing.Size(682, 25);
            this.sacolesBindingNavigator.TabIndex = 0;
            this.sacolesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sacolesBindingNavigatorSaveItem
            // 
            this.sacolesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sacolesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sacolesBindingNavigatorSaveItem.Image")));
            this.sacolesBindingNavigatorSaveItem.Name = "sacolesBindingNavigatorSaveItem";
            this.sacolesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sacolesBindingNavigatorSaveItem.Text = "Save Data";
            this.sacolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.sacolesBindingNavigatorSaveItem_Click);
            // 
            // idSacolesLabel1
            // 
            this.idSacolesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "idSacoles", true));
            this.idSacolesLabel1.Location = new System.Drawing.Point(219, 77);
            this.idSacolesLabel1.Name = "idSacolesLabel1";
            this.idSacolesLabel1.Size = new System.Drawing.Size(100, 23);
            this.idSacolesLabel1.TabIndex = 2;
            // 
            // saborTextBox
            // 
            this.saborTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "sabor", true));
            this.saborTextBox.Location = new System.Drawing.Point(219, 112);
            this.saborTextBox.Name = "saborTextBox";
            this.saborTextBox.Size = new System.Drawing.Size(100, 20);
            this.saborTextBox.TabIndex = 4;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sacolesBindingSource, "tipo", true));
            this.tipoComboBox.DataSource = this.tipoBindingSource;
            this.tipoComboBox.DisplayMember = "tipo";
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(219, 150);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoComboBox.TabIndex = 6;
            this.tipoComboBox.ValueMember = "idtipo";
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.banco_rr_sacolesDataSet1;
            // 
            // quantTextBox
            // 
            this.quantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "quant", true));
            this.quantTextBox.Location = new System.Drawing.Point(219, 188);
            this.quantTextBox.Name = "quantTextBox";
            this.quantTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantTextBox.TabIndex = 8;
            // 
            // quantminTextBox
            // 
            this.quantminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "quantmin", true));
            this.quantminTextBox.Enabled = false;
            this.quantminTextBox.Location = new System.Drawing.Point(219, 226);
            this.quantminTextBox.Name = "quantminTextBox";
            this.quantminTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantminTextBox.TabIndex = 10;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sacolesBindingSource, "preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(219, 264);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 12;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // AlterareExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 335);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(quantminLabel);
            this.Controls.Add(this.quantminTextBox);
            this.Controls.Add(quantLabel);
            this.Controls.Add(this.quantTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(saborLabel);
            this.Controls.Add(this.saborTextBox);
            this.Controls.Add(idSacolesLabel);
            this.Controls.Add(this.idSacolesLabel1);
            this.Controls.Add(this.sacolesBindingNavigator);
            this.Name = "AlterareExcluir";
            this.Text = "Editar ou Excluir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingNavigator)).EndInit();
            this.sacolesBindingNavigator.ResumeLayout(false);
            this.sacolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banco_rr_sacolesDataSet1 banco_rr_sacolesDataSet1;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private banco_rr_sacolesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sacolesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sacolesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idSacolesLabel1;
        private System.Windows.Forms.TextBox saborTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox quantTextBox;
        private System.Windows.Forms.TextBox quantminTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private banco_rr_sacolesDataSet1TableAdapters.tipoTableAdapter tipoTableAdapter;
    }
}