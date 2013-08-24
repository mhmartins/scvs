namespace SistemaControleVendasSacoles
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            System.Windows.Forms.Label vendas_sacIDLabel;
            System.Windows.Forms.Label vendas_idvendasLabel;
            System.Windows.Forms.Label sacoles_idsacolesLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label idvendasLabel;
            System.Windows.Forms.Label usuarios_idusuariosLabel;
            System.Windows.Forms.Label dataLabel;
            this.banco = new SistemaControleVendasSacoles.banco();
            this.vendas_sacolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_sacolesTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.vendas_sacolesTableAdapter();
            this.tableAdapterManager = new SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager();
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
            this.vendas_sacIDTextBox = new System.Windows.Forms.TextBox();
            this.vendas_idvendasTextBox = new System.Windows.Forms.TextBox();
            this.sacoles_idsacolesComboBox = new System.Windows.Forms.ComboBox();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new SistemaControleVendasSacoles.bancoTableAdapters.vendasTableAdapter();
            this.idvendasTextBox = new System.Windows.Forms.TextBox();
            this.usuarios_idusuariosComboBox = new System.Windows.Forms.ComboBox();
            this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            vendas_sacIDLabel = new System.Windows.Forms.Label();
            vendas_idvendasLabel = new System.Windows.Forms.Label();
            sacoles_idsacolesLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            idvendasLabel = new System.Windows.Forms.Label();
            usuarios_idusuariosLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingNavigator)).BeginInit();
            this.vendas_sacolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // banco
            // 
            this.banco.DataSetName = "banco";
            this.banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendas_sacolesBindingSource
            // 
            this.vendas_sacolesBindingSource.DataMember = "vendas_sacoles";
            this.vendas_sacolesBindingSource.DataSource = this.banco;
            // 
            // vendas_sacolesTableAdapter
            // 
            this.vendas_sacolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sacolesTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaControleVendasSacoles.bancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
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
            this.vendas_sacolesBindingNavigator.Size = new System.Drawing.Size(766, 25);
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
            this.vendas_sacolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendas_sacolesBindingNavigatorSaveItem_Click_2);
            // 
            // vendas_sacIDLabel
            // 
            vendas_sacIDLabel.AutoSize = true;
            vendas_sacIDLabel.Location = new System.Drawing.Point(288, 25);
            vendas_sacIDLabel.Name = "vendas_sacIDLabel";
            vendas_sacIDLabel.Size = new System.Drawing.Size(79, 13);
            vendas_sacIDLabel.TabIndex = 1;
            vendas_sacIDLabel.Text = "vendas sac ID:";
            // 
            // vendas_sacIDTextBox
            // 
            this.vendas_sacIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource, "vendas_sacID", true));
            this.vendas_sacIDTextBox.Location = new System.Drawing.Point(387, 22);
            this.vendas_sacIDTextBox.Name = "vendas_sacIDTextBox";
            this.vendas_sacIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendas_sacIDTextBox.TabIndex = 2;
            // 
            // vendas_idvendasLabel
            // 
            vendas_idvendasLabel.AutoSize = true;
            vendas_idvendasLabel.Location = new System.Drawing.Point(288, 51);
            vendas_idvendasLabel.Name = "vendas_idvendasLabel";
            vendas_idvendasLabel.Size = new System.Drawing.Size(91, 13);
            vendas_idvendasLabel.TabIndex = 3;
            vendas_idvendasLabel.Text = "vendas idvendas:";
            // 
            // vendas_idvendasTextBox
            // 
            this.vendas_idvendasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource, "vendas_idvendas", true));
            this.vendas_idvendasTextBox.Location = new System.Drawing.Point(387, 48);
            this.vendas_idvendasTextBox.Name = "vendas_idvendasTextBox";
            this.vendas_idvendasTextBox.Size = new System.Drawing.Size(121, 20);
            this.vendas_idvendasTextBox.TabIndex = 4;
            // 
            // sacoles_idsacolesLabel
            // 
            sacoles_idsacolesLabel.AutoSize = true;
            sacoles_idsacolesLabel.Location = new System.Drawing.Point(288, 77);
            sacoles_idsacolesLabel.Name = "sacoles_idsacolesLabel";
            sacoles_idsacolesLabel.Size = new System.Drawing.Size(93, 13);
            sacoles_idsacolesLabel.TabIndex = 5;
            sacoles_idsacolesLabel.Text = "sacoles idsacoles:";
            // 
            // sacoles_idsacolesComboBox
            // 
            this.sacoles_idsacolesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource, "sacoles_idsacoles", true));
            this.sacoles_idsacolesComboBox.FormattingEnabled = true;
            this.sacoles_idsacolesComboBox.Location = new System.Drawing.Point(387, 74);
            this.sacoles_idsacolesComboBox.Name = "sacoles_idsacolesComboBox";
            this.sacoles_idsacolesComboBox.Size = new System.Drawing.Size(121, 21);
            this.sacoles_idsacolesComboBox.TabIndex = 6;
            this.sacoles_idsacolesComboBox.SelectedIndexChanged += new System.EventHandler(this.sacoles_idsacolesComboBox_SelectedIndexChanged_1);
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(288, 101);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 7;
            quantidadeLabel.Text = "quantidade:";
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendas_sacolesBindingSource, "quantidade", true));
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(387, 101);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.quantidadeNumericUpDown.TabIndex = 8;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(288, 130);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendas_sacolesBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(387, 127);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 10;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.banco;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // idvendasLabel
            // 
            idvendasLabel.AutoSize = true;
            idvendasLabel.Location = new System.Drawing.Point(32, 51);
            idvendasLabel.Name = "idvendasLabel";
            idvendasLabel.Size = new System.Drawing.Size(53, 13);
            idvendasLabel.TabIndex = 11;
            idvendasLabel.Text = "idvendas:";
            // 
            // idvendasTextBox
            // 
            this.idvendasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "idvendas", true));
            this.idvendasTextBox.Location = new System.Drawing.Point(137, 48);
            this.idvendasTextBox.Name = "idvendasTextBox";
            this.idvendasTextBox.Size = new System.Drawing.Size(121, 20);
            this.idvendasTextBox.TabIndex = 12;
            // 
            // usuarios_idusuariosLabel
            // 
            usuarios_idusuariosLabel.AutoSize = true;
            usuarios_idusuariosLabel.Location = new System.Drawing.Point(32, 77);
            usuarios_idusuariosLabel.Name = "usuarios_idusuariosLabel";
            usuarios_idusuariosLabel.Size = new System.Drawing.Size(99, 13);
            usuarios_idusuariosLabel.TabIndex = 13;
            usuarios_idusuariosLabel.Text = "usuarios idusuarios:";
            // 
            // usuarios_idusuariosComboBox
            // 
            this.usuarios_idusuariosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "usuarios_idusuarios", true));
            this.usuarios_idusuariosComboBox.FormattingEnabled = true;
            this.usuarios_idusuariosComboBox.Location = new System.Drawing.Point(137, 74);
            this.usuarios_idusuariosComboBox.Name = "usuarios_idusuariosComboBox";
            this.usuarios_idusuariosComboBox.Size = new System.Drawing.Size(121, 21);
            this.usuarios_idusuariosComboBox.TabIndex = 14;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(32, 104);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 15;
            dataLabel.Text = "data:";
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "data", true));
            this.dataMaskedTextBox.Location = new System.Drawing.Point(137, 101);
            this.dataMaskedTextBox.Name = "dataMaskedTextBox";
            this.dataMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.dataMaskedTextBox.TabIndex = 16;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 354);
            this.Controls.Add(idvendasLabel);
            this.Controls.Add(this.idvendasTextBox);
            this.Controls.Add(usuarios_idusuariosLabel);
            this.Controls.Add(this.usuarios_idusuariosComboBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataMaskedTextBox);
            this.Controls.Add(vendas_sacIDLabel);
            this.Controls.Add(this.vendas_sacIDTextBox);
            this.Controls.Add(vendas_idvendasLabel);
            this.Controls.Add(this.vendas_idvendasTextBox);
            this.Controls.Add(sacoles_idsacolesLabel);
            this.Controls.Add(this.sacoles_idsacolesComboBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeNumericUpDown);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.vendas_sacolesBindingNavigator);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_sacolesBindingNavigator)).EndInit();
            this.vendas_sacolesBindingNavigator.ResumeLayout(false);
            this.vendas_sacolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banco banco;
        private System.Windows.Forms.BindingSource vendas_sacolesBindingSource;
        private bancoTableAdapters.vendas_sacolesTableAdapter vendas_sacolesTableAdapter;
        private bancoTableAdapters.TableAdapterManager tableAdapterManager;
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
        private bancoTableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.TextBox vendas_sacIDTextBox;
        private System.Windows.Forms.TextBox vendas_idvendasTextBox;
        private System.Windows.Forms.ComboBox sacoles_idsacolesComboBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.TextBox idvendasTextBox;
        private System.Windows.Forms.ComboBox usuarios_idusuariosComboBox;
        private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;

    }
}