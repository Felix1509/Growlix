using NHibernate;
using Entities;

namespace Growlix
{
    partial class WinNewSpending
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvSpendingsToAdd = new DataGridView();
            btSaveAndBack = new Button();
            btBackNoSave = new Button();
            laName = new Label();
            tbName = new TextBox();
            laPcsPrice = new Label();
            tbPcsPrice = new TextBox();
            cbSpendingCategory = new ComboBox();
            laCategory = new Label();
            laAmount = new Label();
            numAmount = new NumericUpDown();
            laShop = new Label();
            tbShop = new TextBox();
            cbDateToday = new CheckBox();
            dtpDate = new DateTimePicker();
            tbComment = new TextBox();
            laComment = new Label();
            spendingCategoryBindingSource = new BindingSource(components);
            ColName = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewComboBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColAmount = new DataGridViewTextBoxColumn();
            ColShop = new DataGridViewTextBoxColumn();
            ColDate = new DataGridViewTextBoxColumn();
            ColComment = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSpendingsToAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spendingCategoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvSpendingsToAdd
            // 
            dgvSpendingsToAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSpendingsToAdd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvSpendingsToAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpendingsToAdd.Columns.AddRange(new DataGridViewColumn[] { ColName, ColCategory, ColPrice, ColAmount, ColShop, ColDate, ColComment });
            dgvSpendingsToAdd.Location = new Point(12, 392);
            dgvSpendingsToAdd.Name = "dgvSpendingsToAdd";
            dgvSpendingsToAdd.RowHeadersWidth = 62;
            dgvSpendingsToAdd.Size = new Size(1870, 519);
            dgvSpendingsToAdd.TabIndex = 0;
            // 
            // btSaveAndBack
            // 
            btSaveAndBack.Location = new Point(1712, 934);
            btSaveAndBack.Name = "btSaveAndBack";
            btSaveAndBack.Size = new Size(170, 74);
            btSaveAndBack.TabIndex = 1;
            btSaveAndBack.Text = "Go back\nand Save";
            btSaveAndBack.UseVisualStyleBackColor = true;
            btSaveAndBack.Click += btSaveAndBack_Click;
            // 
            // btBackNoSave
            // 
            btBackNoSave.Location = new Point(12, 934);
            btBackNoSave.Name = "btBackNoSave";
            btBackNoSave.Size = new Size(170, 74);
            btBackNoSave.TabIndex = 2;
            btBackNoSave.Text = "Discard\nChanges";
            btBackNoSave.UseVisualStyleBackColor = true;
            // 
            // laName
            // 
            laName.AutoSize = true;
            laName.Location = new Point(22, 203);
            laName.Name = "laName";
            laName.Size = new Size(63, 25);
            laName.TabIndex = 0;
            laName.Text = "Name:";
            // 
            // tbName
            // 
            tbName.Location = new Point(140, 200);
            tbName.Name = "tbName";
            tbName.Size = new Size(150, 31);
            tbName.TabIndex = 1;
            tbName.KeyPress += WhileEditing_KeyPress;
            // 
            // laPcsPrice
            // 
            laPcsPrice.AutoSize = true;
            laPcsPrice.Location = new Point(411, 200);
            laPcsPrice.Name = "laPcsPrice";
            laPcsPrice.Size = new Size(130, 25);
            laPcsPrice.TabIndex = 1;
            laPcsPrice.Text = "Price (per pcs.):";
            // 
            // tbPcsPrice
            // 
            tbPcsPrice.Location = new Point(563, 200);
            tbPcsPrice.Name = "tbPcsPrice";
            tbPcsPrice.Size = new Size(150, 31);
            tbPcsPrice.TabIndex = 0;
            tbPcsPrice.KeyPress += WhileEditing_KeyPress;
            // 
            // cbSpendingCategory
            // 
            cbSpendingCategory.FormattingEnabled = true;
            cbSpendingCategory.Location = new Point(140, 265);
            cbSpendingCategory.Name = "cbSpendingCategory";
            cbSpendingCategory.Size = new Size(182, 33);
            cbSpendingCategory.TabIndex = 7;
            cbSpendingCategory.KeyPress += WhileEditing_KeyPress;
            // 
            // laCategory
            // 
            laCategory.AutoSize = true;
            laCategory.Location = new Point(22, 265);
            laCategory.Name = "laCategory";
            laCategory.Size = new Size(88, 25);
            laCategory.TabIndex = 0;
            laCategory.Text = "Category:";
            // 
            // laAmount
            // 
            laAmount.AutoSize = true;
            laAmount.Location = new Point(411, 268);
            laAmount.Name = "laAmount";
            laAmount.Size = new Size(81, 25);
            laAmount.TabIndex = 0;
            laAmount.Text = "Amount:";
            // 
            // numAmount
            // 
            numAmount.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAmount.Location = new Point(563, 260);
            numAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(122, 50);
            numAmount.TabIndex = 10;
            numAmount.Tag = "";
            numAmount.TextAlign = HorizontalAlignment.Center;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numAmount.KeyPress += WhileEditing_KeyPress;
            // 
            // laShop
            // 
            laShop.AutoSize = true;
            laShop.Location = new Point(764, 206);
            laShop.Name = "laShop";
            laShop.Size = new Size(58, 25);
            laShop.TabIndex = 0;
            laShop.Text = "Shop:";
            // 
            // tbShop
            // 
            tbShop.Location = new Point(874, 206);
            tbShop.Name = "tbShop";
            tbShop.Size = new Size(150, 31);
            tbShop.TabIndex = 12;
            tbShop.Text = "Online - ";
            tbShop.KeyPress += WhileEditing_KeyPress;
            // 
            // cbDateToday
            // 
            cbDateToday.AutoSize = true;
            cbDateToday.Checked = true;
            cbDateToday.CheckState = CheckState.Checked;
            cbDateToday.Location = new Point(764, 267);
            cbDateToday.Name = "cbDateToday";
            cbDateToday.Size = new Size(93, 29);
            cbDateToday.TabIndex = 13;
            cbDateToday.Text = "Today?";
            cbDateToday.UseVisualStyleBackColor = true;
            cbDateToday.CheckedChanged += cbDateToday_CheckedChanged;
            // 
            // dtpDate
            // 
            dtpDate.Enabled = false;
            dtpDate.Location = new Point(874, 267);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 31);
            dtpDate.TabIndex = 14;
            dtpDate.KeyPress += WhileEditing_KeyPress;
            // 
            // tbComment
            // 
            tbComment.Location = new Point(140, 337);
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(1034, 31);
            tbComment.TabIndex = 15;
            tbComment.KeyPress += WhileEditing_KeyPress;
            // 
            // laComment
            // 
            laComment.AutoSize = true;
            laComment.Location = new Point(22, 340);
            laComment.Name = "laComment";
            laComment.Size = new Size(95, 25);
            laComment.TabIndex = 0;
            laComment.Text = "Comment:";
            // 
            // spendingCategoryBindingSource
            // 
            spendingCategoryBindingSource.DataSource = typeof(SpendingCategory);
            // 
            // ColName
            // 
            ColName.HeaderText = "Name";
            ColName.MinimumWidth = 95;
            ColName.Name = "ColName";
            ColName.Width = 95;
            // 
            // ColCategory
            // 
            ColCategory.DataSource = spendingCategoryBindingSource;
            ColCategory.HeaderText = "Category";
            ColCategory.MinimumWidth = 8;
            ColCategory.Name = "ColCategory";
            ColCategory.Width = 90;
            // 
            // ColPrice
            // 
            ColPrice.HeaderText = "Price";
            ColPrice.MinimumWidth = 8;
            ColPrice.Name = "ColPrice";
            ColPrice.Width = 85;
            // 
            // ColAmount
            // 
            ColAmount.HeaderText = "Amount";
            ColAmount.MinimumWidth = 8;
            ColAmount.Name = "ColAmount";
            ColAmount.Width = 113;
            // 
            // ColShop
            // 
            ColShop.HeaderText = "Shop";
            ColShop.MinimumWidth = 8;
            ColShop.Name = "ColShop";
            ColShop.Width = 90;
            // 
            // ColDate
            // 
            ColDate.HeaderText = "Date";
            ColDate.MinimumWidth = 8;
            ColDate.Name = "ColDate";
            ColDate.Width = 85;
            // 
            // ColComment
            // 
            ColComment.HeaderText = "Comment";
            ColComment.MinimumWidth = 8;
            ColComment.Name = "ColComment";
            ColComment.Width = 127;
            // 
            // WinNewSpending
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1020);
            Controls.Add(laComment);
            Controls.Add(tbComment);
            Controls.Add(dtpDate);
            Controls.Add(cbDateToday);
            Controls.Add(tbShop);
            Controls.Add(laShop);
            Controls.Add(numAmount);
            Controls.Add(laAmount);
            Controls.Add(laCategory);
            Controls.Add(cbSpendingCategory);
            Controls.Add(tbPcsPrice);
            Controls.Add(laPcsPrice);
            Controls.Add(tbName);
            Controls.Add(laName);
            Controls.Add(btBackNoSave);
            Controls.Add(btSaveAndBack);
            Controls.Add(dgvSpendingsToAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "WinNewSpending";
            ((System.ComponentModel.ISupportInitialize)dgvSpendingsToAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)spendingCategoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSpendingsToAdd;
        private Button btSaveAndBack;
        private Button btBackNoSave;
        private Label laName;
        private TextBox tbName;
        private Label laPcsPrice;
        private TextBox tbPcsPrice;
        private ComboBox cbSpendingCategory;
        private Label laCategory;
        private Label laAmount;
        private NumericUpDown numAmount;
        private Label laShop;
        private TextBox tbShop;
        private CheckBox cbDateToday;
        private DateTimePicker dtpDate;
        private TextBox tbComment;
        private Label laComment;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewComboBoxColumn ColCategory;
        private BindingSource spendingCategoryBindingSource;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColAmount;
        private DataGridViewTextBoxColumn ColShop;
        private DataGridViewTextBoxColumn ColDate;
        private DataGridViewTextBoxColumn ColComment;
    }
}
