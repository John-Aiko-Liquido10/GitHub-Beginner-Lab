namespace StudentProfile
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
            lblName = new Label();
            lblCourse = new Label();
            label1 = new Label();
            btnSearch = new Button();
            txtID = new TextBox();
            lblSection = new Label();
            lblYear = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(176, 118);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 0;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(176, 158);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(0, 20);
            lblCourse.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 44);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Student ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(222, 287);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(176, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(233, 27);
            txtID.TabIndex = 4;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Location = new Point(176, 198);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(0, 20);
            lblSection.TabIndex = 5;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(176, 239);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(0, 20);
            lblYear.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 239);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 10;
            label2.Text = "Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 198);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Section:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 158);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 118);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Name: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 367);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblYear);
            Controls.Add(lblSection);
            Controls.Add(txtID);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(lblCourse);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCourse;
        private Label label1;
        private Button btnSearch;
        private TextBox txtID;
        private Label lblSection;
        private Label lblYear;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
