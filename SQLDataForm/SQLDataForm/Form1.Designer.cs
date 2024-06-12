namespace SQLDataForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            field_Name = new TextBox();
            field_Price = new TextBox();
            field_Supplier = new TextBox();
            btn_Insert = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Query = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 234);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Supplier:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 147);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // field_Name
            // 
            field_Name.BackColor = SystemColors.ScrollBar;
            field_Name.BorderStyle = BorderStyle.None;
            field_Name.ForeColor = SystemColors.Info;
            field_Name.Location = new Point(24, 77);
            field_Name.Name = "field_Name";
            field_Name.Size = new Size(100, 16);
            field_Name.TabIndex = 3;
            field_Name.TextChanged += textBox1_TextChanged;
            // 
            // field_Price
            // 
            field_Price.BackColor = SystemColors.ScrollBar;
            field_Price.BorderStyle = BorderStyle.None;
            field_Price.ForeColor = SystemColors.Info;
            field_Price.Location = new Point(24, 165);
            field_Price.Name = "field_Price";
            field_Price.Size = new Size(100, 16);
            field_Price.TabIndex = 4;
            // 
            // field_Supplier
            // 
            field_Supplier.BackColor = SystemColors.ScrollBar;
            field_Supplier.BorderStyle = BorderStyle.None;
            field_Supplier.ForeColor = SystemColors.Info;
            field_Supplier.Location = new Point(24, 252);
            field_Supplier.Name = "field_Supplier";
            field_Supplier.Size = new Size(100, 16);
            field_Supplier.TabIndex = 5;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(33, 296);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 6;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(141, 296);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 7;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(33, 339);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Query
            // 
            btn_Query.Location = new Point(141, 339);
            btn_Query.Name = "btn_Query";
            btn_Query.Size = new Size(75, 23);
            btn_Query.TabIndex = 9;
            btn_Query.Text = "Query";
            btn_Query.UseVisualStyleBackColor = true;
            btn_Query.Click += btn_Query_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(176, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(271, 191);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 378);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Query);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Insert);
            Controls.Add(field_Supplier);
            Controls.Add(field_Price);
            Controls.Add(field_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox field_Name;
        private TextBox field_Price;
        private TextBox field_Supplier;
        private Button btn_Insert;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Query;
        private DataGridView dataGridView1;
    }
}
