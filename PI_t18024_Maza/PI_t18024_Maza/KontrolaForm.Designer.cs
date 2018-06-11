namespace PI_t18024_Maza
{
    partial class KontrolaForm
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
            System.Windows.Forms.Label iD_kontrolaLabel;
            System.Windows.Forms.Label datum_kontroleLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label opisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolaForm));
            System.Windows.Forms.Label zivotinjaLabel;
            System.Windows.Forms.Label veterinarLabel;
            this.kontrolaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.kontrolaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_kontrolaTextBox = new System.Windows.Forms.TextBox();
            this.datum_kontroleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.kontrolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._18024_DBDataSet = new PI_t18024_Maza._18024_DBDataSet();
            this.kontrolaTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.kontrolaTableAdapter();
            this.tableAdapterManager = new PI_t18024_Maza._18024_DBDataSetTableAdapters.TableAdapterManager();
            this.cjepivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjepivoTableAdapter = new PI_t18024_Maza._18024_DBDataSetTableAdapters.cjepivoTableAdapter();
            this.zivotinjaTextBox = new System.Windows.Forms.TextBox();
            this.veterinarTextBox = new System.Windows.Forms.TextBox();
            iD_kontrolaLabel = new System.Windows.Forms.Label();
            datum_kontroleLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            zivotinjaLabel = new System.Windows.Forms.Label();
            veterinarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaBindingNavigator)).BeginInit();
            this.kontrolaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjepivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_kontrolaLabel
            // 
            iD_kontrolaLabel.AutoSize = true;
            iD_kontrolaLabel.Location = new System.Drawing.Point(196, 119);
            iD_kontrolaLabel.Name = "iD_kontrolaLabel";
            iD_kontrolaLabel.Size = new System.Drawing.Size(69, 13);
            iD_kontrolaLabel.TabIndex = 3;
            iD_kontrolaLabel.Text = "Broj kontrole:";
            // 
            // datum_kontroleLabel
            // 
            datum_kontroleLabel.AutoSize = true;
            datum_kontroleLabel.Location = new System.Drawing.Point(731, 120);
            datum_kontroleLabel.Name = "datum_kontroleLabel";
            datum_kontroleLabel.Size = new System.Drawing.Size(41, 13);
            datum_kontroleLabel.TabIndex = 9;
            datum_kontroleLabel.Text = "Datum:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(220, 150);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(405, 150);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(31, 13);
            opisLabel.TabIndex = 13;
            opisLabel.Text = "Opis:";
            // 
            // kontrolaBindingNavigator
            // 
            this.kontrolaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kontrolaBindingNavigator.BindingSource = this.kontrolaBindingSource;
            this.kontrolaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kontrolaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kontrolaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kontrolaBindingNavigatorSaveItem});
            this.kontrolaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kontrolaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kontrolaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kontrolaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kontrolaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kontrolaBindingNavigator.Name = "kontrolaBindingNavigator";
            this.kontrolaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kontrolaBindingNavigator.Size = new System.Drawing.Size(1075, 25);
            this.kontrolaBindingNavigator.TabIndex = 2;
            this.kontrolaBindingNavigator.Text = "bindingNavigator1";
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
            // kontrolaBindingNavigatorSaveItem
            // 
            this.kontrolaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kontrolaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kontrolaBindingNavigatorSaveItem.Image")));
            this.kontrolaBindingNavigatorSaveItem.Name = "kontrolaBindingNavigatorSaveItem";
            this.kontrolaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kontrolaBindingNavigatorSaveItem.Text = "Save Data";
            this.kontrolaBindingNavigatorSaveItem.Click += new System.EventHandler(this.kontrolaBindingNavigatorSaveItem_Click);
            // 
            // iD_kontrolaTextBox
            // 
            this.iD_kontrolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrolaBindingSource, "ID_kontrola", true));
            this.iD_kontrolaTextBox.Location = new System.Drawing.Point(264, 116);
            this.iD_kontrolaTextBox.Name = "iD_kontrolaTextBox";
            this.iD_kontrolaTextBox.ReadOnly = true;
            this.iD_kontrolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_kontrolaTextBox.TabIndex = 4;
            // 
            // datum_kontroleDateTimePicker
            // 
            this.datum_kontroleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kontrolaBindingSource, "datum_kontrole", true));
            this.datum_kontroleDateTimePicker.Location = new System.Drawing.Point(775, 116);
            this.datum_kontroleDateTimePicker.Name = "datum_kontroleDateTimePicker";
            this.datum_kontroleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datum_kontroleDateTimePicker.TabIndex = 10;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrolaBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(264, 147);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 12;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrolaBindingSource, "opis", true));
            this.opisTextBox.Location = new System.Drawing.Point(440, 147);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(100, 20);
            this.opisTextBox.TabIndex = 14;
            // 
            // kontrolaBindingSource
            // 
            this.kontrolaBindingSource.DataMember = "kontrola";
            this.kontrolaBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // _18024_DBDataSet
            // 
            this._18024_DBDataSet.DataSetName = "_18024_DBDataSet";
            this._18024_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kontrolaTableAdapter
            // 
            this.kontrolaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bolestTableAdapter = null;
            this.tableAdapterManager.cjepivo_za_zivotinjuTableAdapter = null;
            this.tableAdapterManager.cjepivoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.dijagnozaTableAdapter = null;
            this.tableAdapterManager.LijekTableAdapter = null;
            this.tableAdapterManager.operacijaTableAdapter = null;
            this.tableAdapterManager.propisani_lijekTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PI_t18024_Maza._18024_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veterinarTableAdapter = null;
            this.tableAdapterManager.vlasnikTableAdapter = null;
            this.tableAdapterManager.zivotinjaTableAdapter = null;
            // 
            // cjepivoBindingSource
            // 
            this.cjepivoBindingSource.DataMember = "cjepivo";
            this.cjepivoBindingSource.DataSource = this._18024_DBDataSet;
            // 
            // cjepivoTableAdapter
            // 
            this.cjepivoTableAdapter.ClearBeforeFill = true;
            // 
            // zivotinjaTextBox
            // 
            this.zivotinjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrolaBindingSource, "zivotinja", true));
            this.zivotinjaTextBox.Location = new System.Drawing.Point(609, 116);
            this.zivotinjaTextBox.Name = "zivotinjaTextBox";
            this.zivotinjaTextBox.Size = new System.Drawing.Size(100, 20);
            this.zivotinjaTextBox.TabIndex = 16;
            // 
            // zivotinjaLabel
            // 
            zivotinjaLabel.AutoSize = true;
            zivotinjaLabel.Location = new System.Drawing.Point(555, 119);
            zivotinjaLabel.Name = "zivotinjaLabel";
            zivotinjaLabel.Size = new System.Drawing.Size(50, 13);
            zivotinjaLabel.TabIndex = 15;
            zivotinjaLabel.Text = "Životinja:";
            // 
            // veterinarTextBox
            // 
            this.veterinarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kontrolaBindingSource, "Veterinar", true));
            this.veterinarTextBox.Location = new System.Drawing.Point(440, 117);
            this.veterinarTextBox.Name = "veterinarTextBox";
            this.veterinarTextBox.Size = new System.Drawing.Size(100, 20);
            this.veterinarTextBox.TabIndex = 15;
            // 
            // veterinarLabel
            // 
            veterinarLabel.AutoSize = true;
            veterinarLabel.Location = new System.Drawing.Point(382, 120);
            veterinarLabel.Name = "veterinarLabel";
            veterinarLabel.Size = new System.Drawing.Size(52, 13);
            veterinarLabel.TabIndex = 14;
            veterinarLabel.Text = "Veterinar:";
            // 
            // KontrolaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 632);
            this.Controls.Add(zivotinjaLabel);
            this.Controls.Add(this.zivotinjaTextBox);
            this.Controls.Add(veterinarLabel);
            this.Controls.Add(this.veterinarTextBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(datum_kontroleLabel);
            this.Controls.Add(this.datum_kontroleDateTimePicker);
            this.Controls.Add(iD_kontrolaLabel);
            this.Controls.Add(this.iD_kontrolaTextBox);
            this.Controls.Add(this.kontrolaBindingNavigator);
            this.Name = "KontrolaForm";
            this.Text = "Kontrola";
            this.Load += new System.EventHandler(this.KontrolaForm_Load);
            this.Controls.SetChildIndex(this.kontrolaBindingNavigator, 0);
            this.Controls.SetChildIndex(this.iD_kontrolaTextBox, 0);
            this.Controls.SetChildIndex(iD_kontrolaLabel, 0);
            this.Controls.SetChildIndex(this.datum_kontroleDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_kontroleLabel, 0);
            this.Controls.SetChildIndex(this.statusTextBox, 0);
            this.Controls.SetChildIndex(statusLabel, 0);
            this.Controls.SetChildIndex(this.opisTextBox, 0);
            this.Controls.SetChildIndex(opisLabel, 0);
            this.Controls.SetChildIndex(this.veterinarTextBox, 0);
            this.Controls.SetChildIndex(veterinarLabel, 0);
            this.Controls.SetChildIndex(this.zivotinjaTextBox, 0);
            this.Controls.SetChildIndex(zivotinjaLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaBindingNavigator)).EndInit();
            this.kontrolaBindingNavigator.ResumeLayout(false);
            this.kontrolaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._18024_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjepivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _18024_DBDataSet _18024_DBDataSet;
        private System.Windows.Forms.BindingSource kontrolaBindingSource;
        private _18024_DBDataSetTableAdapters.kontrolaTableAdapter kontrolaTableAdapter;
        private _18024_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kontrolaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kontrolaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_kontrolaTextBox;
        private System.Windows.Forms.DateTimePicker datum_kontroleDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.BindingSource cjepivoBindingSource;
        private _18024_DBDataSetTableAdapters.cjepivoTableAdapter cjepivoTableAdapter;
        private System.Windows.Forms.TextBox zivotinjaTextBox;
        private System.Windows.Forms.TextBox veterinarTextBox;
    }
}