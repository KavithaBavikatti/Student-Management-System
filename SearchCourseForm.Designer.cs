namespace TAFESystem1
{
    partial class SearchCourseForm
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
            this.panelCourseInfo = new System.Windows.Forms.Panel();
            this.lblSemester = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbCourseId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLocationId = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCourseInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCourseInfo
            // 
            this.panelCourseInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCourseInfo.Controls.Add(this.lblSemester);
            this.panelCourseInfo.Controls.Add(this.label12);
            this.panelCourseInfo.Controls.Add(this.btnEnrol);
            this.panelCourseInfo.Controls.Add(this.richTextDescription);
            this.panelCourseInfo.Controls.Add(this.lblFees);
            this.panelCourseInfo.Controls.Add(this.lblStartDate);
            this.panelCourseInfo.Controls.Add(this.lblCourseType);
            this.panelCourseInfo.Controls.Add(this.label11);
            this.panelCourseInfo.Controls.Add(this.label10);
            this.panelCourseInfo.Controls.Add(this.label9);
            this.panelCourseInfo.Controls.Add(this.label8);
            this.panelCourseInfo.Controls.Add(this.label7);
            this.panelCourseInfo.Location = new System.Drawing.Point(18, 282);
            this.panelCourseInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCourseInfo.Name = "panelCourseInfo";
            this.panelCourseInfo.Size = new System.Drawing.Size(1782, 504);
            this.panelCourseInfo.TabIndex = 10;
            this.panelCourseInfo.Visible = false;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.Blue;
            this.lblSemester.Location = new System.Drawing.Point(994, 58);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(89, 37);
            this.lblSemester.TabIndex = 23;
            this.lblSemester.Text = "label";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(796, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 32);
            this.label12.TabIndex = 22;
            this.label12.Text = "Semester:";
            // 
            // btnEnrol
            // 
            this.btnEnrol.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnrol.Location = new System.Drawing.Point(724, 412);
            this.btnEnrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(208, 72);
            this.btnEnrol.TabIndex = 21;
            this.btnEnrol.Text = "Enrol";
            this.btnEnrol.UseVisualStyleBackColor = false;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(204, 54);
            this.richTextDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.ReadOnly = true;
            this.richTextDescription.Size = new System.Drawing.Size(476, 132);
            this.richTextDescription.TabIndex = 20;
            this.richTextDescription.Text = "";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Blue;
            this.lblFees.Location = new System.Drawing.Point(1508, 48);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(98, 40);
            this.lblFees.TabIndex = 19;
            this.lblFees.Text = "label";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Blue;
            this.lblStartDate.Location = new System.Drawing.Point(994, 212);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 40);
            this.lblStartDate.TabIndex = 18;
            this.lblStartDate.Text = "label";
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseType.ForeColor = System.Drawing.Color.Blue;
            this.lblCourseType.Location = new System.Drawing.Point(226, 220);
            this.lblCourseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(89, 37);
            this.lblCourseType.TabIndex = 17;
            this.lblCourseType.Text = "label";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1390, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fees :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(784, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Start Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "CourseType :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(196, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(340, 40);
            this.label8.TabIndex = 13;
            this.label8.Text = "Course Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description :";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1660, 108);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 72);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbCourseId
            // 
            this.cmbCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseId.FormattingEnabled = true;
            this.cmbCourseId.Location = new System.Drawing.Point(254, 229);
            this.cmbCourseId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCourseId.Name = "cmbCourseId";
            this.cmbCourseId.Size = new System.Drawing.Size(362, 37);
            this.cmbCourseId.TabIndex = 12;
            this.cmbCourseId.SelectedIndexChanged += new System.EventHandler(this.cmbCourseId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(686, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Location";
            // 
            // cmbLocationId
            // 
            this.cmbLocationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocationId.FormattingEnabled = true;
            this.cmbLocationId.Location = new System.Drawing.Point(926, 232);
            this.cmbLocationId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLocationId.Name = "cmbLocationId";
            this.cmbLocationId.Size = new System.Drawing.Size(362, 37);
            this.cmbLocationId.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1878, 181);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(556, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(683, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Management System";
            // 
            // SearchCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1874, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbCourseId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLocationId);
            this.Controls.Add(this.panelCourseInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchCourseForm";
            this.Text = "SearchCourseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SearchCourseForm_Load);
            this.panelCourseInfo.ResumeLayout(false);
            this.panelCourseInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCourseInfo;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCourseId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLocationId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}