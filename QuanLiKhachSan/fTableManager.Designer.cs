namespace QuanLiKhachSan
{
    partial class fTableManager
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbDTB = new System.Windows.Forms.Label();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbNu = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.grThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSo,
            this.clHoTen,
            this.clGioiTinh,
            this.clDTB,
            this.clKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(407, 112);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(660, 350);
            this.dgvStudent.TabIndex = 0;
            // 
            // clMaSo
            // 
            this.clMaSo.HeaderText = "MSSV";
            this.clMaSo.MinimumWidth = 6;
            this.clMaSo.Name = "clMaSo";
            this.clMaSo.Width = 125;
            // 
            // clHoTen
            // 
            this.clHoTen.HeaderText = "Họ Tên";
            this.clHoTen.MinimumWidth = 6;
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.Width = 125;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.HeaderText = "Giới Tính";
            this.clGioiTinh.MinimumWidth = 6;
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.Width = 125;
            // 
            // clDTB
            // 
            this.clDTB.HeaderText = "ĐTB";
            this.clDTB.MinimumWidth = 6;
            this.clDTB.Name = "clDTB";
            this.clDTB.Width = 125;
            // 
            // clKhoa
            // 
            this.clKhoa.HeaderText = "Khoa";
            this.clKhoa.MinimumWidth = 6;
            this.clKhoa.Name = "clKhoa";
            this.clKhoa.Width = 125;
            // 
            // lbThongTin
            // 
            this.lbThongTin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTin.Location = new System.Drawing.Point(586, 68);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(149, 20);
            this.lbThongTin.TabIndex = 1;
            this.lbThongTin.Text = "Thông tin sinh viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTen.Location = new System.Drawing.Point(16, 87);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(64, 20);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.Location = new System.Drawing.Point(16, 133);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.lbGioiTinh.TabIndex = 1;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbDTB
            // 
            this.lbDTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbDTB.AutoSize = true;
            this.lbDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDTB.Location = new System.Drawing.Point(16, 178);
            this.lbDTB.Name = "lbDTB";
            this.lbDTB.Size = new System.Drawing.Size(75, 20);
            this.lbDTB.TabIndex = 1;
            this.lbDTB.Text = "Điểm TB";
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChuyenNganh.Location = new System.Drawing.Point(16, 228);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(118, 20);
            this.lbChuyenNganh.TabIndex = 1;
            this.lbChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lbNam
            // 
            this.lbNam.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNam.Location = new System.Drawing.Point(709, 495);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(113, 20);
            this.lbNam.TabIndex = 1;
            this.lbNam.Text = "Tổng SV Nam";
            // 
            // lbNu
            // 
            this.lbNu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbNu.AutoSize = true;
            this.lbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNu.Location = new System.Drawing.Point(923, 495);
            this.lbNu.Name = "lbNu";
            this.lbNu.Size = new System.Drawing.Size(30, 20);
            this.lbNu.TabIndex = 1;
            this.lbNu.Text = "Nữ";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMSSV.Location = new System.Drawing.Point(16, 43);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(108, 20);
            this.lbMSSV.TabIndex = 1;
            this.lbMSSV.Text = "Mã Sinh Viên";
            // 
            // grThongTin
            // 
            this.grThongTin.Controls.Add(this.cmbFaculty);
            this.grThongTin.Controls.Add(this.txtAverageScore);
            this.grThongTin.Controls.Add(this.txtStudentID);
            this.grThongTin.Controls.Add(this.txtFullName);
            this.grThongTin.Controls.Add(this.optFemale);
            this.grThongTin.Controls.Add(this.optMale);
            this.grThongTin.Controls.Add(this.lbMSSV);
            this.grThongTin.Controls.Add(this.lbHoTen);
            this.grThongTin.Controls.Add(this.lbGioiTinh);
            this.grThongTin.Controls.Add(this.lbChuyenNganh);
            this.grThongTin.Controls.Add(this.lbDTB);
            this.grThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTin.Location = new System.Drawing.Point(27, 103);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(362, 318);
            this.grThongTin.TabIndex = 2;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông Tin Sinh Viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(145, 220);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(121, 28);
            this.cmbFaculty.TabIndex = 4;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(145, 171);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(74, 27);
            this.txtAverageScore.TabIndex = 3;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(145, 36);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(162, 27);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(145, 80);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(201, 27);
            this.txtFullName.TabIndex = 3;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Checked = true;
            this.optFemale.Location = new System.Drawing.Point(223, 129);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(51, 24);
            this.optFemale.TabIndex = 2;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(145, 131);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(65, 24);
            this.optMale.TabIndex = 2;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(172, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(297, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grThongTin);
            this.Controls.Add(this.lbNu);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTableManager";
            this.Text = "Quản lý thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.Load += new System.EventHandler(this.fTableManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhoa;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbDTB;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbNu;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}