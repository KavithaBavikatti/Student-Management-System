namespace TAFESystem1
{
    partial class StudentEnrolFormProtoType
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
            this.cmbLocationId = new System.Windows.Forms.ComboBox();
            this.cmbCourseId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.lblCourseDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLocationId
            // 
            this.cmbLocationId.FormattingEnabled = true;
            this.cmbLocationId.Location = new System.Drawing.Point(131, 62);
            this.cmbLocationId.Name = "cmbLocationId";
            this.cmbLocationId.Size = new System.Drawing.Size(243, 21);
            this.cmbLocationId.TabIndex = 0;
            this.cmbLocationId.SelectedIndexChanged += new System.EventHandler(this.cmbLocationId_SelectedIndexChanged);
            // 
            // cmbCourseId
            // 
            this.cmbCourseId.FormattingEnabled = true;
            this.cmbCourseId.Location = new System.Drawing.Point(131, 132);
            this.cmbCourseId.Name = "cmbCourseId";
            this.cmbCourseId.Size = new System.Drawing.Size(243, 21);
            this.cmbCourseId.TabIndex = 1;
            this.cmbCourseId.SelectedIndexChanged += new System.EventHandler(this.cmbCourseId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course";
            // 
            // btnEnrol
            // 
            this.btnEnrol.Location = new System.Drawing.Point(450, 135);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(75, 23);
            this.btnEnrol.TabIndex = 4;
            this.btnEnrol.Text = "Enrol";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // lblCourseDescription
            // 
            this.lblCourseDescription.AutoSize = true;
            this.lblCourseDescription.Location = new System.Drawing.Point(196, 223);
            this.lblCourseDescription.Name = "lblCourseDescription";
            this.lblCourseDescription.Size = new System.Drawing.Size(35, 13);
            this.lblCourseDescription.TabIndex = 5;
            this.lblCourseDescription.Text = "label3";
            // 
            // StudentEnrolFormProtoType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCourseDescription);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCourseId);
            this.Controls.Add(this.cmbLocationId);
            this.Name = "StudentEnrolFormProtoType";
            this.Text = "StudentEnrolFormProtoType";
            this.Load += new System.EventHandler(this.StudentEnrolFormProtoType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocationId;
        private System.Windows.Forms.ComboBox cmbCourseId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Label lblCourseDescription;
    }
}