
namespace Kursova_rabota
{
    partial class AddItems
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
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label nomerLabel;
            System.Windows.Forms.Label sumaLabel;
            System.Windows.Forms.Label tipLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItems));
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hotelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.nomerTextBox = new System.Windows.Forms.TextBox();
            this.sumaTextBox = new System.Windows.Forms.TextBox();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            dniLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            nomerLabel = new System.Windows.Forms.Label();
            sumaLabel = new System.Windows.Forms.Label();
            tipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingNavigator)).BeginInit();
            this.hotelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(12, 183);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(72, 13);
            dniLabel.TabIndex = 1;
            dniLabel.Text = "Дни престой";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(36, 70);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(29, 13);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Име";
            // 
            // nomerLabel
            // 
            nomerLabel.AutoSize = true;
            nomerLabel.Location = new System.Drawing.Point(36, 105);
            nomerLabel.Name = "nomerLabel";
            nomerLabel.Size = new System.Drawing.Size(44, 13);
            nomerLabel.TabIndex = 5;
            nomerLabel.Text = "№ стая";
            // 
            // sumaLabel
            // 
            sumaLabel.AutoSize = true;
            sumaLabel.Location = new System.Drawing.Point(36, 225);
            sumaLabel.Name = "sumaLabel";
            sumaLabel.Size = new System.Drawing.Size(33, 13);
            sumaLabel.TabIndex = 7;
            sumaLabel.Text = "Сума";
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.Location = new System.Drawing.Point(32, 145);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new System.Drawing.Size(52, 13);
            tipLabel.TabIndex = 9;
            tipLabel.Text = "Тип стая";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(Kursova_rabota.Hotel);
            // 
            // hotelBindingNavigator
            // 
            this.hotelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotelBindingNavigator.BindingSource = this.hotelBindingSource;
            this.hotelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hotelBindingNavigatorSaveItem});
            this.hotelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelBindingNavigator.Name = "hotelBindingNavigator";
            this.hotelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelBindingNavigator.Size = new System.Drawing.Size(306, 25);
            this.hotelBindingNavigator.TabIndex = 0;
            this.hotelBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // hotelBindingNavigatorSaveItem
            // 
            this.hotelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelBindingNavigatorSaveItem.Image")));
            this.hotelBindingNavigatorSaveItem.Name = "hotelBindingNavigatorSaveItem";
            this.hotelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotelBindingNavigatorSaveItem.Text = "Save Data";
            this.hotelBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotelBindingNavigatorSaveItem_Click);
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(90, 180);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 2;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(90, 70);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 4;
            // 
            // nomerTextBox
            // 
            this.nomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "nomer", true));
            this.nomerTextBox.Location = new System.Drawing.Point(90, 105);
            this.nomerTextBox.Name = "nomerTextBox";
            this.nomerTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomerTextBox.TabIndex = 6;
            // 
            // sumaTextBox
            // 
            this.sumaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "suma", true));
            this.sumaTextBox.Location = new System.Drawing.Point(90, 222);
            this.sumaTextBox.Name = "sumaTextBox";
            this.sumaTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumaTextBox.TabIndex = 8;
            // 
            // tipTextBox
            // 
            this.tipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "tip", true));
            this.tipTextBox.Location = new System.Drawing.Point(90, 142);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipTextBox.TabIndex = 10;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(nomerLabel);
            this.Controls.Add(this.nomerTextBox);
            this.Controls.Add(sumaLabel);
            this.Controls.Add(this.sumaTextBox);
            this.Controls.Add(tipLabel);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.hotelBindingNavigator);
            this.Name = "AddItems";
            this.Text = "AddItems";
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingNavigator)).EndInit();
            this.hotelBindingNavigator.ResumeLayout(false);
            this.hotelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.BindingNavigator hotelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hotelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox nomerTextBox;
        private System.Windows.Forms.TextBox sumaTextBox;
        private System.Windows.Forms.TextBox tipTextBox;
    }
}