namespace Responsi
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
            tb_nama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvData = new DataGridView();
            btn_insert = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            cb_dep = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(140, 37);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(177, 23);
            tb_nama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Dep. Karyawan    :";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(25, 189);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(589, 238);
            dgvData.TabIndex = 3;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(25, 142);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(111, 32);
            btn_insert.TabIndex = 4;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(503, 142);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(111, 32);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(255, 142);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(111, 32);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // cb_dep
            // 
            cb_dep.FormattingEnabled = true;
            cb_dep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cb_dep.Location = new Point(140, 81);
            cb_dep.Name = "cb_dep";
            cb_dep.Size = new Size(177, 23);
            cb_dep.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 27);
            label3.Name = "label3";
            label3.Size = new Size(90, 90);
            label3.TabIndex = 8;
            label3.Text = "ID Departemen\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(label3);
            Controls.Add(cb_dep);
            Controls.Add(btn_edit);
            Controls.Add(btn_delete);
            Controls.Add(btn_insert);
            Controls.Add(dgvData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nama);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nama;
        private Label label1;
        private Label label2;
        private DataGridView dgvData;
        private Button btn_insert;
        private Button btn_delete;
        private Button btn_edit;
        private ComboBox cb_dep;
        private Label label3;
    }
}