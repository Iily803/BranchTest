namespace FirstTry
{
    partial class Form1
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
            butSelect = new Button();
            butUpdate = new Button();
            butDel = new Button();
            butInsert = new Button();
            labName = new Label();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            butTestCon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // butSelect
            // 
            butSelect.Location = new Point(264, 36);
            butSelect.Name = "butSelect";
            butSelect.Size = new Size(94, 29);
            butSelect.TabIndex = 0;
            butSelect.Text = "查询";
            butSelect.UseVisualStyleBackColor = true;
            // 
            // butUpdate
            // 
            butUpdate.Location = new Point(432, 36);
            butUpdate.Name = "butUpdate";
            butUpdate.Size = new Size(94, 29);
            butUpdate.TabIndex = 1;
            butUpdate.Text = "修改";
            butUpdate.UseVisualStyleBackColor = true;
            butUpdate.Click += butUpdate_Click;
            // 
            // butDel
            // 
            butDel.Location = new Point(562, 36);
            butDel.Name = "butDel";
            butDel.Size = new Size(94, 29);
            butDel.TabIndex = 2;
            butDel.Text = "删除";
            butDel.UseVisualStyleBackColor = true;
            // 
            // butInsert
            // 
            butInsert.Location = new Point(694, 36);
            butInsert.Name = "butInsert";
            butInsert.Size = new Size(94, 29);
            butInsert.TabIndex = 3;
            butInsert.Text = "新增";
            butInsert.UseVisualStyleBackColor = true;
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Location = new Point(25, 40);
            labName.Name = "labName";
            labName.Size = new Size(88, 20);
            labName.TabIndex = 4;
            labName.Text = "请输入姓名:";
            labName.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 338);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // butTestCon
            // 
            butTestCon.Location = new Point(352, 1);
            butTestCon.Name = "butTestCon";
            butTestCon.Size = new Size(94, 29);
            butTestCon.TabIndex = 7;
            butTestCon.Text = "测试连接数据库";
            butTestCon.UseVisualStyleBackColor = true;
            butTestCon.Click += butTestCon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butTestCon);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(labName);
            Controls.Add(butInsert);
            Controls.Add(butDel);
            Controls.Add(butUpdate);
            Controls.Add(butSelect);
            Name = "Form1";
            Text = "主界面";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butSelect;
        private Button butUpdate;
        private Button butDel;
        private Button butInsert;
        private Label labName;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private Button butTestCon;
    }
}
