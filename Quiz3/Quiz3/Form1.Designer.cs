namespace Quiz3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.carRadioButton = new System.Windows.Forms.RadioButton();
            this.ownerRadioButton = new System.Windows.Forms.RadioButton();
            this.carRegistrationGroup = new System.Windows.Forms.GroupBox();
            this.ownerGroup = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.telephoneTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.carRegistrationGroup.SuspendLayout();
            this.ownerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // carRadioButton
            // 
            this.carRadioButton.AutoSize = true;
            this.carRadioButton.Location = new System.Drawing.Point(215, 92);
            this.carRadioButton.Name = "carRadioButton";
            this.carRadioButton.Size = new System.Drawing.Size(41, 17);
            this.carRadioButton.TabIndex = 0;
            this.carRadioButton.TabStop = true;
            this.carRadioButton.Text = "Car";
            this.carRadioButton.UseVisualStyleBackColor = true;
            this.carRadioButton.CheckedChanged += new System.EventHandler(this.carRadioButton_CheckedChanged);
            // 
            // ownerRadioButton
            // 
            this.ownerRadioButton.AutoSize = true;
            this.ownerRadioButton.Location = new System.Drawing.Point(478, 92);
            this.ownerRadioButton.Name = "ownerRadioButton";
            this.ownerRadioButton.Size = new System.Drawing.Size(56, 17);
            this.ownerRadioButton.TabIndex = 1;
            this.ownerRadioButton.TabStop = true;
            this.ownerRadioButton.Text = "Owner";
            this.ownerRadioButton.UseVisualStyleBackColor = true;
            this.ownerRadioButton.CheckedChanged += new System.EventHandler(this.ownerRadioButton_CheckedChanged);
            // 
            // carRegistrationGroup
            // 
            this.carRegistrationGroup.Controls.Add(this.label3);
            this.carRegistrationGroup.Controls.Add(this.label2);
            this.carRegistrationGroup.Controls.Add(this.label1);
            this.carRegistrationGroup.Controls.Add(this.yearComboBox);
            this.carRegistrationGroup.Controls.Add(this.modelComboBox);
            this.carRegistrationGroup.Controls.Add(this.makeComboBox);
            this.carRegistrationGroup.Location = new System.Drawing.Point(57, 131);
            this.carRegistrationGroup.Name = "carRegistrationGroup";
            this.carRegistrationGroup.Size = new System.Drawing.Size(295, 228);
            this.carRegistrationGroup.TabIndex = 2;
            this.carRegistrationGroup.TabStop = false;
            this.carRegistrationGroup.Text = "Car Registration";
            // 
            // ownerGroup
            // 
            this.ownerGroup.Controls.Add(this.telephoneLabel);
            this.ownerGroup.Controls.Add(this.lastNameLabel);
            this.ownerGroup.Controls.Add(this.firstNameLabel);
            this.ownerGroup.Controls.Add(this.telephoneTxtBox);
            this.ownerGroup.Controls.Add(this.lastNameTxtBox);
            this.ownerGroup.Controls.Add(this.firstNameTxtBox);
            this.ownerGroup.Location = new System.Drawing.Point(432, 131);
            this.ownerGroup.Name = "ownerGroup";
            this.ownerGroup.Size = new System.Drawing.Size(295, 228);
            this.ownerGroup.TabIndex = 3;
            this.ownerGroup.TabStop = false;
            this.ownerGroup.Text = "Owner";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(169, 365);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(154, 38);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(478, 365);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 38);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // makeComboBox
            // 
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Hyundai"});
            this.makeComboBox.Location = new System.Drawing.Point(112, 19);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(121, 21);
            this.makeComboBox.TabIndex = 0;
            this.makeComboBox.SelectedIndexChanged += new System.EventHandler(this.makeComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(112, 91);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelComboBox.TabIndex = 1;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(112, 168);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(114, 42);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxtBox.TabIndex = 0;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(114, 111);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxtBox.TabIndex = 1;
            // 
            // telephoneTxtBox
            // 
            this.telephoneTxtBox.Location = new System.Drawing.Point(114, 176);
            this.telephoneTxtBox.Name = "telephoneTxtBox";
            this.telephoneTxtBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTxtBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(17, 42);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(17, 111);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(17, 183);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(58, 13);
            this.telephoneLabel.TabIndex = 5;
            this.telephoneLabel.Text = "Telephone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ownerGroup);
            this.Controls.Add(this.carRegistrationGroup);
            this.Controls.Add(this.ownerRadioButton);
            this.Controls.Add(this.carRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.carRegistrationGroup.ResumeLayout(false);
            this.carRegistrationGroup.PerformLayout();
            this.ownerGroup.ResumeLayout(false);
            this.ownerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton carRadioButton;
        private System.Windows.Forms.RadioButton ownerRadioButton;
        private System.Windows.Forms.GroupBox carRegistrationGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.GroupBox ownerGroup;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox telephoneTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
    }
}

