namespace SistemaControleVendasSacoles
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            System.Windows.Forms.Label idvendasLabel;
            System.Windows.Forms.Label usuarios_idusuariosLabel;
            System.Windows.Forms.Label totalvendaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label vendas_idvendasLabel;
            System.Windows.Forms.Label sacoles_idsacolesLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            this.banco_rr_sacolesDataSet = new SistemaControleVendasSacoles.banco_rr_sacolesDataSet();
            this.vendas_sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_sacolesTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSetTableAdapters.vendas_sacolesTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.banco_rr_sacolesDataSetTableAdapters.TableAdapterManager();
            this.vendas_sacolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vendas_sacolesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSetTableAdapters.vendasTableAdapter();
            this.idvendasTextBox = new System.Windows.Forms.TextBox();
            this.usuarios_idusuariosComboBox = new System.Windows.Forms.ComboBox();
            this.totalvendaTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.vendas_sacolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_idvendasTextBox = new System.Windows.Forms.TextBox();
            this.sacoles_idsacolesComboBox = new System.Windows.Forms.ComboBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sacolesTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSetTableAdapters.sacolesTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new SistemaControleVendasSacoles.banco_rr_sacolesDataSetTableAdapters.usuariosTableAdapter();
            idvendasLabel = new System.Windows.Forms.Label();
            usuarios_idusuariosLabel = new System.Windows.Forms.Label();
            totalvendaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            vendas_idvendasLabel = new System.Windows.Forms.Label();
            sacoles_idsacolesLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingNavigator)).BeginInit();
            this.vendas_sacolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // banco_rr_sacolesDataSet
            // 
            this.banco_rr_sacolesDataSet.DataSetName = "banco_rr_sacolesDataSet";
            this.banco_rr_sacolesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendas_sacolesBindingSource
            // 
            this.vendas_sacolesBindingSource.DataMember = "vendas_sacoles";
            this.vendas_sacolesBindingSource.DataSource = this.banco_rr_sacolesDataSet;
            // 
            // vendas_sacolesTableAdapter
            // 
            this.vendas_sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesTableAdapter = this.sacolesTableAdapter;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.banco_rr_sacolesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            this.tableAdapterManager.vendas_sacolesTableAdapter = this.vendas_sacolesTableAdapter;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // vendas_sacolesBindingNavigator
            // 
            this.vendas_sacolesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendas_sacolesBindingNavigator.BindingSource = this.vendas_sacolesBindingSource;
            this.vendas_sacolesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendas_sacolesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendas_sacolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendas_sacolesBindingNavigatorSaveItem});
            this.vendas_sacolesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendas_sacolesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendas_sacolesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendas_sacolesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendas_sacolesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendas_sacolesBindingNavigator.Name = "vendas_sacolesBindingNavigator";
            this.vendas_sacolesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendas_sacolesBindingNavigator.Size = new System.Drawing.Size(764, 25);
            this.vendas_sacolesBindingNavigator.TabIndex = 0;
            this.vendas_sacolesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vendas_sacolesBindingNavigatorSaveItem
            // 
            this.vendas_sacolesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendas_sacolesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendas_sacolesBindingNavigatorSaveItem.Image")));
            this.vendas_sacolesBindingNavigatorSaveItem.Name = "vendas_sacolesBindingNavigatorSaveItem";
            this.vendas_sacolesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vendas_sacolesBindingNavigatorSaveItem.Text = "Save Data";
            this.vendas_sacolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendas_sacolesBindingNavigatorSaveItem_Click);
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.banco_rr_sacolesDataSet;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // idvendasLabel
            // 
            idvendasLabel.AutoSize = true;
            idvendasLabel.Location = new System.Drawing.Point(28, 66);
            idvendasLabel.Name = "idvendasLabel";
            idvendasLabel.Size = new System.Drawing.Size(53, 13);
            idvendasLabel.TabIndex = 1;
            idvendasLabel.Text = "idvendas:";
            // 
            // idvendasTextBox
            // 
            this.idvendasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "idvendas", true));
            this.idvendasTextBox.Location = new System.Drawing.Point(87, 63);
            this.idvendasTextBox.Name = "idvendasTextBox";
            this.idvendasTextBox.Size = new System.Drawing.Size(100, 20);
            this.idvendasTextBox.TabIndex = 2;
            // 
            // usuarios_idusuariosLabel
            // 
            usuarios_idusuariosLabel.AutoSize = true;
            usuarios_idusuariosLabel.Location = new System.Drawing.Point(30, 114);
            usuarios_idusuariosLabel.Name = "usuarios_idusuariosLabel";
            usuarios_idusuariosLabel.Size = new System.Drawing.Size(99, 13);
            usuarios_idusuariosLabel.TabIndex = 3;
            usuarios_idusuariosLabel.Text = "usuarios idusuarios:";
            // 
            // usuarios_idusuariosComboBox
            // 
            this.usuarios_idusuariosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendasBindingSource, "usuarios_idusuarios", true));
            this.usuarios_idusuariosComboBox.DataSource = this.usuariosBindingSource;
            this.usuarios_idusuariosComboBox.DisplayMember = "nome";
            this.usuarios_idusuariosComboBox.FormattingEnabled = true;
            this.usuarios_idusuariosComboBox.Location = new System.Drawing.Point(135, 111);
            this.usuarios_idusuariosComboBox.Name = "usuarios_idusuariosComboBox";
            this.usuarios_idusuariosComboBox.Size = new System.Drawing.Size(121, 21);
            this.usuarios_idusuariosComboBox.TabIndex = 4;
            this.usuarios_idusuariosComboBox.ValueMember = "idusuarios";
            // 
            // totalvendaLabel
            // 
            totalvendaLabel.AutoSize = true;
            totalvendaLabel.Location = new System.Drawing.Point(35, 151);
            totalvendaLabel.Name = "totalvendaLabel";
            totalvendaLabel.Size = new System.Drawing.Size(60, 13);
            totalvendaLabel.TabIndex = 5;
            totalvendaLabel.Text = "totalvenda:";
            // 
            // totalvendaTextBox
            // 
            this.totalvendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "totalvenda", true));
            this.totalvendaTextBox.Location = new System.Drawing.Point(101, 148);
            this.totalvendaTextBox.Name = "totalvendaTextBox";
            this.totalvendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalvendaTextBox.TabIndex = 6;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(39, 190);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendasBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(76, 186);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 8;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(45, 233);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(31, 13);
            horaLabel.TabIndex = 9;
            horaLabel.Text = "hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(82, 230);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaTextBox.TabIndex = 10;
            // 
            // vendas_sacolesBindingSource1
            // 
            this.vendas_sacolesBindingSource1.DataMember = "vendas_vendas_sacoles";
            this.vendas_sacolesBindingSource1.DataSource = this.vendasBindingSource;
            // 
            // vendas_idvendasLabel
            // 
            vendas_idvendasLabel.AutoSize = true;
            vendas_idvendasLabel.Location = new System.Drawing.Point(379, 59);
            vendas_idvendasLabel.Name = "vendas_idvendasLabel";
            vendas_idvendasLabel.Size = new System.Drawing.Size(91, 13);
            vendas_idvendasLabel.TabIndex = 11;
            vendas_idvendasLabel.Text = "vendas idvendas:";
            // 
            // vendas_idvendasTextBox
            // 
            this.vendas_idvendasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource1, "vendas_idvendas", true));
            this.vendas_idvendasTextBox.Location = new System.Drawing.Point(476, 56);
            this.vendas_idvendasTextBox.Name = "vendas_idvendasTextBox";
            this.vendas_idvendasTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendas_idvendasTextBox.TabIndex = 12;
            // 
            // sacoles_idsacolesLabel
            // 
            sacoles_idsacolesLabel.AutoSize = true;
            sacoles_idsacolesLabel.Location = new System.Drawing.Point(395, 104);
            sacoles_idsacolesLabel.Name = "sacoles_idsacolesLabel";
            sacoles_idsacolesLabel.Size = new System.Drawing.Size(93, 13);
            sacoles_idsacolesLabel.TabIndex = 13;
            sacoles_idsacolesLabel.Text = "sacoles idsacoles:";
            // 
            // sacoles_idsacolesComboBox
            // 
            this.sacoles_idsacolesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendas_sacolesBindingSource1, "sacoles_idsacoles", true));
            this.sacoles_idsacolesComboBox.DataSource = this.sacolesBindingSource;
            this.sacoles_idsacolesComboBox.DisplayMember = "sabor";
            this.sacoles_idsacolesComboBox.FormattingEnabled = true;
            this.sacoles_idsacolesComboBox.Location = new System.Drawing.Point(494, 101);
            this.sacoles_idsacolesComboBox.Name = "sacoles_idsacolesComboBox";
            this.sacoles_idsacolesComboBox.Size = new System.Drawing.Size(121, 21);
            this.sacoles_idsacolesComboBox.TabIndex = 14;
            this.sacoles_idsacolesComboBox.ValueMember = "idSacoles";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(396, 160);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 15;
            quantidadeLabel.Text = "quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource1, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(465, 157);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 16;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(405, 216);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 17;
            valorLabel.Text = "valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource1, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(444, 213);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 18;
            // 
            // sacolesBindingSource
            // 
            this.sacolesBindingSource.DataMember = "sacoles";
            this.sacolesBindingSource.DataSource = this.banco_rr_sacolesDataSet;
            // 
            // sacolesTableAdapter
            // 
            this.sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.banco_rr_sacolesDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 317);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(sacoles_idsacolesLabel);
            this.Controls.Add(this.sacoles_idsacolesComboBox);
            this.Controls.Add(vendas_idvendasLabel);
            this.Controls.Add(this.vendas_idvendasTextBox);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(totalvendaLabel);
            this.Controls.Add(this.totalvendaTextBox);
            this.Controls.Add(usuarios_idusuariosLabel);
            this.Controls.Add(this.usuarios_idusuariosComboBox);
            this.Controls.Add(idvendasLabel);
            this.Controls.Add(this.idvendasTextBox);
            this.Controls.Add(this.vendas_sacolesBindingNavigator);
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_rr_sacolesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingNavigator)).EndInit();
            this.vendas_sacolesBindingNavigator.ResumeLayout(false);
            this.vendas_sacolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banco_rr_sacolesDataSet banco_rr_sacolesDataSet;
        private System.Windows.Forms.BindingSource vendas_sacolesBindingSource;
        private banco_rr_sacolesDataSetTableAdapters.vendas_sacolesTableAdapter vendas_sacolesTableAdapter;
        private banco_rr_sacolesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendas_sacolesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton vendas_sacolesBindingNavigatorSaveItem;
        private banco_rr_sacolesDataSetTableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private banco_rr_sacolesDataSetTableAdapters.sacolesTableAdapter sacolesTableAdapter;
        private System.Windows.Forms.TextBox idvendasTextBox;
        private System.Windows.Forms.ComboBox usuarios_idusuariosComboBox;
        private System.Windows.Forms.TextBox totalvendaTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.BindingSource vendas_sacolesBindingSource1;
        private System.Windows.Forms.TextBox vendas_idvendasTextBox;
        private System.Windows.Forms.ComboBox sacoles_idsacolesComboBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource sacolesBindingSource;
        private banco_rr_sacolesDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;

    }
}