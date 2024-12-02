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
            label1 = new Label();
            lbNamaKar = new Label();
            lbDep = new Label();
            tbKaryawan = new TextBox();
            cbDep = new ComboBox();
            btInsert = new Button();
            btEdit = new Button();
            btDelete = new Button();
            dgvData = new DataGridView();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            btLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // lbNamaKar
            // 
            lbNamaKar.AutoSize = true;
            lbNamaKar.Location = new Point(45, 73);
            lbNamaKar.Name = "lbNamaKar";
            lbNamaKar.Size = new Size(93, 15);
            lbNamaKar.TabIndex = 1;
            lbNamaKar.Text = "Nama Karyawan";
            // 
            // lbDep
            // 
            lbDep.AutoSize = true;
            lbDep.Location = new Point(45, 98);
            lbDep.Name = "lbDep";
            lbDep.Size = new Size(85, 15);
            lbDep.TabIndex = 2;
            lbDep.Text = "Dep. Karyawan";
            // 
            // tbKaryawan
            // 
            tbKaryawan.Location = new Point(144, 70);
            tbKaryawan.Name = "tbKaryawan";
            tbKaryawan.Size = new Size(169, 23);
            tbKaryawan.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(144, 99);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(169, 23);
            cbDep.TabIndex = 4;
            // 
            // btInsert
            // 
            btInsert.Location = new Point(45, 145);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(75, 23);
            btInsert.TabIndex = 5;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(126, 145);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 23);
            btEdit.TabIndex = 6;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(207, 145);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 7;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(45, 192);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(662, 243);
            dgvData.TabIndex = 8;
            dgvData.CellClick += dgvData_cellClick;
            dgvData.CellContentClick += dgvData_cellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID DEPARTEMEN:", "", "HR: HR", "ENG : Engineer", "DEV : Developer", "PM : Project Manager", "FIN : Finance" });
            listBox1.Location = new Point(567, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 124);
            listBox1.TabIndex = 10;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(288, 145);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(75, 23);
            btLoad.TabIndex = 11;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 473);
            Controls.Add(btLoad);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvData);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btInsert);
            Controls.Add(cbDep);
            Controls.Add(tbKaryawan);
            Controls.Add(lbDep);
            Controls.Add(lbNamaKar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbNamaKar;
        private Label lbDep;
        private TextBox tbKaryawan;
        private ComboBox cbDep;
        private Button btInsert;
        private Button btEdit;
        private Button btDelete;
        private DataGridView dgvData;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button btLoad;
    }
}