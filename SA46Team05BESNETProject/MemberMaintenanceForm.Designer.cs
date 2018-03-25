namespace SA46Team05BESNETProject
{
    partial class MemberMaintenanceForm
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
            this.components = new System.ComponentModel.Container();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.FINLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.NRICTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameLabel.Location = new System.Drawing.Point(165, 57);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(113, 20);
            this.MemberNameLabel.TabIndex = 0;
            this.MemberNameLabel.Text = "Member Name";
            // 
            // FINLabel
            // 
            this.FINLabel.AutoSize = true;
            this.FINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINLabel.Location = new System.Drawing.Point(165, 137);
            this.FINLabel.Name = "FINLabel";
            this.FINLabel.Size = new System.Drawing.Size(78, 20);
            this.FINLabel.TabIndex = 1;
            this.FINLabel.Text = "NRIC/FIN";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(162, 382);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(165, 228);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(63, 20);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "Gender";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(165, 300);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 20);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Age";
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Location = new System.Drawing.Point(384, 57);
            this.MemberNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(316, 26);
            this.MemberNameTextBox.TabIndex = 5;
            // 
            // NRICTextBox
            // 
            this.NRICTextBox.Location = new System.Drawing.Point(384, 137);
            this.NRICTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NRICTextBox.Name = "NRICTextBox";
            this.NRICTextBox.Size = new System.Drawing.Size(271, 26);
            this.NRICTextBox.TabIndex = 6;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(381, 377);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(271, 26);
            this.PhoneNumberTextBox.TabIndex = 7;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(384, 294);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(150, 26);
            this.AgeTextBox.TabIndex = 9;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.GenderComboBox.Location = new System.Drawing.Point(384, 223);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(180, 28);
            this.GenderComboBox.TabIndex = 10;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(168, 482);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(70, 54);
            this.PreviousButton.TabIndex = 11;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(348, 482);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 54);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(540, 482);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(116, 54);
            this.InsertButton.TabIndex = 13;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(746, 482);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 54);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(966, 482);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(70, 54);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(168, 577);
            this.FirstButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(70, 55);
            this.FirstButton.TabIndex = 16;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(394, 38);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 55);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(966, 577);
            this.LastButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(70, 55);
            this.LastButton.TabIndex = 18;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(54, 45);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(271, 26);
            this.SearchTextBox.TabIndex = 19;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(348, 546);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchGroupBox.Size = new System.Drawing.Size(542, 120);
            this.SearchGroupBox.TabIndex = 20;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search by NRIC/FIN";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // MemberMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.NRICTextBox);
            this.Controls.Add(this.MemberNameTextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.FINLabel);
            this.Controls.Add(this.MemberNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MemberMaintenanceForm";
            this.Text = "Member Maintenance Form";
            this.Load += new System.EventHandler(this.MemberMaintenanceForm_Load);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label FINLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.TextBox NRICTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

