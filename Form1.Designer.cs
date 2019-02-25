namespace Programming2
{
    partial class IceCreamOrderForm
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
            this.flavorGroupBox = new System.Windows.Forms.GroupBox();
            this.vanillaRadioButton = new System.Windows.Forms.RadioButton();
            this.chocolateRadioButton = new System.Windows.Forms.RadioButton();
            this.strawberryRadioButton = new System.Windows.Forms.RadioButton();
            this.toppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.whipCreamCheckBox = new System.Windows.Forms.CheckBox();
            this.brownieCheckBox = new System.Windows.Forms.CheckBox();
            this.bananaCheckBox = new System.Windows.Forms.CheckBox();
            this.cherriesCheckBox = new System.Windows.Forms.CheckBox();
            this.oreosCheckBox = new System.Windows.Forms.CheckBox();
            this.sprinklesCheckBox = new System.Windows.Forms.CheckBox();
            this.nutsCheckBox = new System.Windows.Forms.CheckBox();
            this.syrupListBox = new System.Windows.Forms.ListBox();
            this.yourIceCreamLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iceCreamSelectButton = new System.Windows.Forms.Button();
            this.flavorLabel = new System.Windows.Forms.Label();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.applySyrupButton = new System.Windows.Forms.Button();
            this.syrupLabel = new System.Windows.Forms.Label();
            this.flavorGroupBox.SuspendLayout();
            this.toppingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flavorGroupBox
            // 
            this.flavorGroupBox.Controls.Add(this.vanillaRadioButton);
            this.flavorGroupBox.Controls.Add(this.chocolateRadioButton);
            this.flavorGroupBox.Controls.Add(this.strawberryRadioButton);
            this.flavorGroupBox.Location = new System.Drawing.Point(13, 13);
            this.flavorGroupBox.Name = "flavorGroupBox";
            this.flavorGroupBox.Size = new System.Drawing.Size(200, 117);
            this.flavorGroupBox.TabIndex = 0;
            this.flavorGroupBox.TabStop = false;
            this.flavorGroupBox.Text = "Select your flavor";
            // 
            // vanillaRadioButton
            // 
            this.vanillaRadioButton.AutoSize = true;
            this.vanillaRadioButton.Location = new System.Drawing.Point(7, 22);
            this.vanillaRadioButton.Name = "vanillaRadioButton";
            this.vanillaRadioButton.Size = new System.Drawing.Size(56, 17);
            this.vanillaRadioButton.TabIndex = 2;
            this.vanillaRadioButton.TabStop = true;
            this.vanillaRadioButton.Text = "Vanilla";
            this.vanillaRadioButton.UseVisualStyleBackColor = true;
            this.vanillaRadioButton.CheckedChanged += new System.EventHandler(this.vanillaRadioButton_CheckedChanged);
            // 
            // chocolateRadioButton
            // 
            this.chocolateRadioButton.AutoSize = true;
            this.chocolateRadioButton.Location = new System.Drawing.Point(7, 50);
            this.chocolateRadioButton.Name = "chocolateRadioButton";
            this.chocolateRadioButton.Size = new System.Drawing.Size(73, 17);
            this.chocolateRadioButton.TabIndex = 1;
            this.chocolateRadioButton.TabStop = true;
            this.chocolateRadioButton.Text = "Chocolate";
            this.chocolateRadioButton.UseVisualStyleBackColor = true;
            this.chocolateRadioButton.CheckedChanged += new System.EventHandler(this.chocolateRadioButton_CheckedChanged);
            // 
            // strawberryRadioButton
            // 
            this.strawberryRadioButton.AutoSize = true;
            this.strawberryRadioButton.Location = new System.Drawing.Point(7, 78);
            this.strawberryRadioButton.Name = "strawberryRadioButton";
            this.strawberryRadioButton.Size = new System.Drawing.Size(75, 17);
            this.strawberryRadioButton.TabIndex = 0;
            this.strawberryRadioButton.TabStop = true;
            this.strawberryRadioButton.Text = "Strawberry";
            this.strawberryRadioButton.UseVisualStyleBackColor = true;
            this.strawberryRadioButton.CheckedChanged += new System.EventHandler(this.strawberryRadioButton_CheckedChanged);
            // 
            // toppingsGroupBox
            // 
            this.toppingsGroupBox.Controls.Add(this.whipCreamCheckBox);
            this.toppingsGroupBox.Controls.Add(this.brownieCheckBox);
            this.toppingsGroupBox.Controls.Add(this.bananaCheckBox);
            this.toppingsGroupBox.Controls.Add(this.cherriesCheckBox);
            this.toppingsGroupBox.Controls.Add(this.oreosCheckBox);
            this.toppingsGroupBox.Controls.Add(this.sprinklesCheckBox);
            this.toppingsGroupBox.Controls.Add(this.nutsCheckBox);
            this.toppingsGroupBox.Location = new System.Drawing.Point(13, 137);
            this.toppingsGroupBox.Name = "toppingsGroupBox";
            this.toppingsGroupBox.Size = new System.Drawing.Size(200, 211);
            this.toppingsGroupBox.TabIndex = 1;
            this.toppingsGroupBox.TabStop = false;
            this.toppingsGroupBox.Text = "Select your toppings";
            // 
            // whipCreamCheckBox
            // 
            this.whipCreamCheckBox.AutoSize = true;
            this.whipCreamCheckBox.Location = new System.Drawing.Point(7, 21);
            this.whipCreamCheckBox.Name = "whipCreamCheckBox";
            this.whipCreamCheckBox.Size = new System.Drawing.Size(84, 17);
            this.whipCreamCheckBox.TabIndex = 5;
            this.whipCreamCheckBox.Text = "Whip Cream";
            this.whipCreamCheckBox.UseVisualStyleBackColor = true;
            // 
            // brownieCheckBox
            // 
            this.brownieCheckBox.AutoSize = true;
            this.brownieCheckBox.Location = new System.Drawing.Point(7, 47);
            this.brownieCheckBox.Name = "brownieCheckBox";
            this.brownieCheckBox.Size = new System.Drawing.Size(69, 17);
            this.brownieCheckBox.TabIndex = 2;
            this.brownieCheckBox.Text = "Brownies";
            this.brownieCheckBox.UseVisualStyleBackColor = true;
            // 
            // bananaCheckBox
            // 
            this.bananaCheckBox.AutoSize = true;
            this.bananaCheckBox.Location = new System.Drawing.Point(7, 100);
            this.bananaCheckBox.Name = "bananaCheckBox";
            this.bananaCheckBox.Size = new System.Drawing.Size(68, 17);
            this.bananaCheckBox.TabIndex = 4;
            this.bananaCheckBox.Text = "Bananas";
            this.bananaCheckBox.UseVisualStyleBackColor = true;
            // 
            // cherriesCheckBox
            // 
            this.cherriesCheckBox.AutoSize = true;
            this.cherriesCheckBox.Location = new System.Drawing.Point(7, 73);
            this.cherriesCheckBox.Name = "cherriesCheckBox";
            this.cherriesCheckBox.Size = new System.Drawing.Size(64, 17);
            this.cherriesCheckBox.TabIndex = 3;
            this.cherriesCheckBox.Text = "Cherries";
            this.cherriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // oreosCheckBox
            // 
            this.oreosCheckBox.AutoSize = true;
            this.oreosCheckBox.Location = new System.Drawing.Point(7, 127);
            this.oreosCheckBox.Name = "oreosCheckBox";
            this.oreosCheckBox.Size = new System.Drawing.Size(54, 17);
            this.oreosCheckBox.TabIndex = 2;
            this.oreosCheckBox.Text = "Oreos";
            this.oreosCheckBox.UseVisualStyleBackColor = true;
            // 
            // sprinklesCheckBox
            // 
            this.sprinklesCheckBox.AutoSize = true;
            this.sprinklesCheckBox.Location = new System.Drawing.Point(7, 155);
            this.sprinklesCheckBox.Name = "sprinklesCheckBox";
            this.sprinklesCheckBox.Size = new System.Drawing.Size(69, 17);
            this.sprinklesCheckBox.TabIndex = 1;
            this.sprinklesCheckBox.Text = "Sprinkles";
            this.sprinklesCheckBox.UseVisualStyleBackColor = true;
            // 
            // nutsCheckBox
            // 
            this.nutsCheckBox.AutoSize = true;
            this.nutsCheckBox.Location = new System.Drawing.Point(7, 183);
            this.nutsCheckBox.Name = "nutsCheckBox";
            this.nutsCheckBox.Size = new System.Drawing.Size(48, 17);
            this.nutsCheckBox.TabIndex = 0;
            this.nutsCheckBox.Text = "Nuts";
            this.nutsCheckBox.UseVisualStyleBackColor = true;
            // 
            // syrupListBox
            // 
            this.syrupListBox.FormattingEnabled = true;
            this.syrupListBox.Items.AddRange(new object[] {
            "Caramel",
            "Chocolate",
            "Fudge",
            "Strawberry"});
            this.syrupListBox.Location = new System.Drawing.Point(13, 394);
            this.syrupListBox.Name = "syrupListBox";
            this.syrupListBox.Size = new System.Drawing.Size(187, 56);
            this.syrupListBox.TabIndex = 6;
            // 
            // yourIceCreamLabel
            // 
            this.yourIceCreamLabel.AutoSize = true;
            this.yourIceCreamLabel.Location = new System.Drawing.Point(273, 13);
            this.yourIceCreamLabel.Name = "yourIceCreamLabel";
            this.yourIceCreamLabel.Size = new System.Drawing.Size(83, 13);
            this.yourIceCreamLabel.TabIndex = 7;
            this.yourIceCreamLabel.Text = "Your Ice Cream:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // iceCreamSelectButton
            // 
            this.iceCreamSelectButton.Location = new System.Drawing.Point(12, 354);
            this.iceCreamSelectButton.Name = "iceCreamSelectButton";
            this.iceCreamSelectButton.Size = new System.Drawing.Size(119, 23);
            this.iceCreamSelectButton.TabIndex = 9;
            this.iceCreamSelectButton.Text = "Apply your toppings";
            this.iceCreamSelectButton.UseVisualStyleBackColor = true;
            this.iceCreamSelectButton.Click += new System.EventHandler(this.iceCreamSelectButton_Click);
            // 
            // flavorLabel
            // 
            this.flavorLabel.AutoSize = true;
            this.flavorLabel.Location = new System.Drawing.Point(273, 37);
            this.flavorLabel.Name = "flavorLabel";
            this.flavorLabel.Size = new System.Drawing.Size(20, 13);
            this.flavorLabel.TabIndex = 10;
            this.flavorLabel.Text = "\" \"";
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(273, 67);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(23, 13);
            this.toppingsLabel.TabIndex = 11;
            this.toppingsLabel.Text = "\"  \"";
            // 
            // applySyrupButton
            // 
            this.applySyrupButton.Location = new System.Drawing.Point(14, 457);
            this.applySyrupButton.Name = "applySyrupButton";
            this.applySyrupButton.Size = new System.Drawing.Size(117, 23);
            this.applySyrupButton.TabIndex = 12;
            this.applySyrupButton.Text = "Apply your syrup";
            this.applySyrupButton.UseVisualStyleBackColor = true;
            this.applySyrupButton.Click += new System.EventHandler(this.applySyrupButton_Click);
            // 
            // syrupLabel
            // 
            this.syrupLabel.AutoSize = true;
            this.syrupLabel.Location = new System.Drawing.Point(273, 50);
            this.syrupLabel.Name = "syrupLabel";
            this.syrupLabel.Size = new System.Drawing.Size(20, 13);
            this.syrupLabel.TabIndex = 13;
            this.syrupLabel.Text = "\" \"";
            // 
            // IceCreamOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 492);
            this.Controls.Add(this.syrupLabel);
            this.Controls.Add(this.applySyrupButton);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.flavorLabel);
            this.Controls.Add(this.iceCreamSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yourIceCreamLabel);
            this.Controls.Add(this.syrupListBox);
            this.Controls.Add(this.toppingsGroupBox);
            this.Controls.Add(this.flavorGroupBox);
            this.Name = "IceCreamOrderForm";
            this.Text = "Ice Cream Order Form";
            this.Load += new System.EventHandler(this.IceCreamOrderForm_Load);
            this.flavorGroupBox.ResumeLayout(false);
            this.flavorGroupBox.PerformLayout();
            this.toppingsGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox flavorGroupBox;
        private System.Windows.Forms.RadioButton vanillaRadioButton;
        private System.Windows.Forms.RadioButton chocolateRadioButton;
        private System.Windows.Forms.RadioButton strawberryRadioButton;
        private System.Windows.Forms.GroupBox toppingsGroupBox;
        private System.Windows.Forms.CheckBox bananaCheckBox;
        private System.Windows.Forms.CheckBox cherriesCheckBox;
        private System.Windows.Forms.CheckBox oreosCheckBox;
        private System.Windows.Forms.CheckBox sprinklesCheckBox;
        private System.Windows.Forms.CheckBox nutsCheckBox;
        private System.Windows.Forms.CheckBox whipCreamCheckBox;
        private System.Windows.Forms.CheckBox brownieCheckBox;
        private System.Windows.Forms.ListBox syrupListBox;
        private System.Windows.Forms.Label yourIceCreamLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iceCreamSelectButton;
        private System.Windows.Forms.Label flavorLabel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.Button applySyrupButton;
        private System.Windows.Forms.Label syrupLabel;
    }
}

