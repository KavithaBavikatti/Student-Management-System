namespace TAFESystem1
{
    partial class StudentMainMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.cmbCourseId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLocationId = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcStudentInfo = new System.Windows.Forms.TabControl();
            this.tpCurrent = new System.Windows.Forms.TabPage();
            this.dgvClusterUnit = new System.Windows.Forms.DataGridView();
            this.ClusterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClusterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPast = new System.Windows.Forms.TabPage();
            this.tpPersonalDetails = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tcStudentInfo.SuspendLayout();
            this.tpCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClusterUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.tpPersonalDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnEnrol);
            this.panel2.Controls.Add(this.cmbCourseId);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbLocationId);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1908, 219);
            this.panel2.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(1725, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 51);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEnrol
            // 
            this.btnEnrol.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnrol.Location = new System.Drawing.Point(1150, 160);
            this.btnEnrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(124, 51);
            this.btnEnrol.TabIndex = 22;
            this.btnEnrol.Text = "Enrol";
            this.btnEnrol.UseVisualStyleBackColor = false;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // cmbCourseId
            // 
            this.cmbCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseId.FormattingEnabled = true;
            this.cmbCourseId.Location = new System.Drawing.Point(242, 168);
            this.cmbCourseId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCourseId.Name = "cmbCourseId";
            this.cmbCourseId.Size = new System.Drawing.Size(362, 37);
            this.cmbCourseId.TabIndex = 10;
            this.cmbCourseId.SelectedIndexChanged += new System.EventHandler(this.cmbCourseId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Search Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(618, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Location";
            // 
            // cmbLocationId
            // 
            this.cmbLocationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocationId.FormattingEnabled = true;
            this.cmbLocationId.Location = new System.Drawing.Point(760, 168);
            this.cmbLocationId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLocationId.Name = "cmbLocationId";
            this.cmbLocationId.Size = new System.Drawing.Size(362, 37);
            this.cmbLocationId.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(1512, 148);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(54, 55);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "T";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(573, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(683, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Management System";
            // 
            // tcStudentInfo
            // 
            this.tcStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcStudentInfo.Controls.Add(this.tpCurrent);
            this.tcStudentInfo.Controls.Add(this.tpPast);
            this.tcStudentInfo.Controls.Add(this.tpPersonalDetails);
            this.tcStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStudentInfo.Location = new System.Drawing.Point(18, 232);
            this.tcStudentInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcStudentInfo.Name = "tcStudentInfo";
            this.tcStudentInfo.SelectedIndex = 0;
            this.tcStudentInfo.Size = new System.Drawing.Size(1884, 665);
            this.tcStudentInfo.TabIndex = 16;
            // 
            // tpCurrent
            // 
            this.tpCurrent.Controls.Add(this.dgvClusterUnit);
            this.tpCurrent.Controls.Add(this.dgvCourse);
            this.tpCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCurrent.Location = new System.Drawing.Point(4, 34);
            this.tpCurrent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCurrent.Name = "tpCurrent";
            this.tpCurrent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCurrent.Size = new System.Drawing.Size(1876, 627);
            this.tpCurrent.TabIndex = 2;
            this.tpCurrent.Text = "Current Course";
            this.tpCurrent.UseVisualStyleBackColor = true;
            // 
            // dgvClusterUnit
            // 
            this.dgvClusterUnit.AllowUserToDeleteRows = false;
            this.dgvClusterUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClusterUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClusterId,
            this.ClusterName,
            this.UnitName,
            this.UnitType});
            this.dgvClusterUnit.Location = new System.Drawing.Point(634, 9);
            this.dgvClusterUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClusterUnit.Name = "dgvClusterUnit";
            this.dgvClusterUnit.ReadOnly = true;
            this.dgvClusterUnit.RowHeadersWidth = 62;
            this.dgvClusterUnit.Size = new System.Drawing.Size(818, 463);
            this.dgvClusterUnit.TabIndex = 1;
            this.dgvClusterUnit.Visible = false;
            // 
            // ClusterId
            // 
            this.ClusterId.DataPropertyName = "ClusterId";
            this.ClusterId.HeaderText = "ClusterId";
            this.ClusterId.MinimumWidth = 8;
            this.ClusterId.Name = "ClusterId";
            this.ClusterId.ReadOnly = true;
            this.ClusterId.Width = 150;
            // 
            // ClusterName
            // 
            this.ClusterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClusterName.DataPropertyName = "ClusterName";
            this.ClusterName.HeaderText = "ClusterName";
            this.ClusterName.MinimumWidth = 8;
            this.ClusterName.Name = "ClusterName";
            this.ClusterName.ReadOnly = true;
            this.ClusterName.Width = 201;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "UnitName";
            this.UnitName.MinimumWidth = 8;
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 150;
            // 
            // UnitType
            // 
            this.UnitType.DataPropertyName = "UnitType";
            this.UnitType.HeaderText = "UnitType";
            this.UnitType.MinimumWidth = 8;
            this.UnitType.Name = "UnitType";
            this.UnitType.ReadOnly = true;
            this.UnitType.Width = 150;
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseName});
            this.dgvCourse.Location = new System.Drawing.Point(4, 9);
            this.dgvCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersWidth = 62;
            this.dgvCourse.Size = new System.Drawing.Size(604, 463);
            this.dgvCourse.TabIndex = 0;
            this.dgvCourse.DoubleClick += new System.EventHandler(this.dgvCourse_DoubleClick);
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "CourseId";
            this.CourseId.MinimumWidth = 8;
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Width = 150;
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.MinimumWidth = 8;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // tpPast
            // 
            this.tpPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPast.Location = new System.Drawing.Point(4, 34);
            this.tpPast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPast.Name = "tpPast";
            this.tpPast.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPast.Size = new System.Drawing.Size(1876, 627);
            this.tpPast.TabIndex = 1;
            this.tpPast.Text = "Past";
            this.tpPast.UseVisualStyleBackColor = true;
            // 
            // tpPersonalDetails
            // 
            this.tpPersonalDetails.Controls.Add(this.panel1);
            this.tpPersonalDetails.Location = new System.Drawing.Point(4, 34);
            this.tpPersonalDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPersonalDetails.Name = "tpPersonalDetails";
            this.tpPersonalDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPersonalDetails.Size = new System.Drawing.Size(1876, 627);
            this.tpPersonalDetails.TabIndex = 3;
            this.tpPersonalDetails.Text = "Personal Details";
            this.tpPersonalDetails.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-6, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1874, 615);
            this.panel1.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(609, 463);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 57);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 77);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(207, 195);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 95);
            this.txtAddress.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(114, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 46);
            this.label8.TabIndex = 59;
            this.label8.Text = "Student Information";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(207, 118);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(310, 30);
            this.txtStudentName.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 443);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 30);
            this.txtEmail.TabIndex = 52;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(207, 343);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(310, 30);
            this.txtMobile.TabIndex = 51;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1192, 57);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(310, 30);
            this.txtId.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 445);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mobile:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1054, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 44;
            this.label9.Text = "Student Id:";
            // 
            // StudentMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1911, 894);
            this.Controls.Add(this.tcStudentInfo);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentMainMenu";
            this.Text = "Student Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentMainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcStudentInfo.ResumeLayout(false);
            this.tpCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClusterUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.tpPersonalDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tcStudentInfo;
        private System.Windows.Forms.TabPage tpCurrent;
        private System.Windows.Forms.TabPage tpPast;
        private System.Windows.Forms.TabPage tpPersonalDetails;
        private System.Windows.Forms.ComboBox cmbCourseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLocationId;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridView dgvClusterUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClusterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClusterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogout;
    }
}