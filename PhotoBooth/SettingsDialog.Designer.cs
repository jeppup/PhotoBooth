namespace PhotoBooth
{
    partial class SettingsDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayTime_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cooldown_textbox = new System.Windows.Forms.TextBox();
            this.BaseImageDirectory_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseImageDirectory_modifyButton = new System.Windows.Forms.Button();
            this.CameraImagesDirectory_modifyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CameraImagesDirectory_textbox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayMode_dropdown = new System.Windows.Forms.ComboBox();
            this.DisplayScreen_dropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExternalDevice_dropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image display time in seconds:";
            // 
            // DisplayTime_textbox
            // 
            this.DisplayTime_textbox.Location = new System.Drawing.Point(203, 37);
            this.DisplayTime_textbox.Name = "DisplayTime_textbox";
            this.DisplayTime_textbox.Size = new System.Drawing.Size(100, 20);
            this.DisplayTime_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image show cooldown in seconds:";
            // 
            // Cooldown_textbox
            // 
            this.Cooldown_textbox.Location = new System.Drawing.Point(203, 64);
            this.Cooldown_textbox.Name = "Cooldown_textbox";
            this.Cooldown_textbox.Size = new System.Drawing.Size(100, 20);
            this.Cooldown_textbox.TabIndex = 3;
            // 
            // BaseImageDirectory_textbox
            // 
            this.BaseImageDirectory_textbox.Enabled = false;
            this.BaseImageDirectory_textbox.Location = new System.Drawing.Point(203, 90);
            this.BaseImageDirectory_textbox.Name = "BaseImageDirectory_textbox";
            this.BaseImageDirectory_textbox.Size = new System.Drawing.Size(100, 20);
            this.BaseImageDirectory_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base images directory:";
            // 
            // BaseImageDirectory_modifyButton
            // 
            this.BaseImageDirectory_modifyButton.Location = new System.Drawing.Point(319, 85);
            this.BaseImageDirectory_modifyButton.Name = "BaseImageDirectory_modifyButton";
            this.BaseImageDirectory_modifyButton.Size = new System.Drawing.Size(75, 23);
            this.BaseImageDirectory_modifyButton.TabIndex = 6;
            this.BaseImageDirectory_modifyButton.Text = "Change";
            this.BaseImageDirectory_modifyButton.UseVisualStyleBackColor = true;
            this.BaseImageDirectory_modifyButton.Click += new System.EventHandler(this.BaseImageDirectory_modifyButton_Click);
            // 
            // CameraImagesDirectory_modifyButton
            // 
            this.CameraImagesDirectory_modifyButton.Location = new System.Drawing.Point(319, 111);
            this.CameraImagesDirectory_modifyButton.Name = "CameraImagesDirectory_modifyButton";
            this.CameraImagesDirectory_modifyButton.Size = new System.Drawing.Size(75, 23);
            this.CameraImagesDirectory_modifyButton.TabIndex = 9;
            this.CameraImagesDirectory_modifyButton.Text = "Change";
            this.CameraImagesDirectory_modifyButton.UseVisualStyleBackColor = true;
            this.CameraImagesDirectory_modifyButton.Click += new System.EventHandler(this.CameraImagesDirectory_modifyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Camera images directory:";
            // 
            // CameraImagesDirectory_textbox
            // 
            this.CameraImagesDirectory_textbox.Enabled = false;
            this.CameraImagesDirectory_textbox.Location = new System.Drawing.Point(203, 116);
            this.CameraImagesDirectory_textbox.Name = "CameraImagesDirectory_textbox";
            this.CameraImagesDirectory_textbox.Size = new System.Drawing.Size(100, 20);
            this.CameraImagesDirectory_textbox.TabIndex = 7;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(381, 272);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 10;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(288, 272);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 11;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Picture display mode:";
            // 
            // DisplayMode_dropdown
            // 
            this.DisplayMode_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplayMode_dropdown.FormattingEnabled = true;
            this.DisplayMode_dropdown.Location = new System.Drawing.Point(203, 142);
            this.DisplayMode_dropdown.Name = "DisplayMode_dropdown";
            this.DisplayMode_dropdown.Size = new System.Drawing.Size(100, 21);
            this.DisplayMode_dropdown.TabIndex = 13;
            // 
            // DisplayScreen_dropdown
            // 
            this.DisplayScreen_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplayScreen_dropdown.FormattingEnabled = true;
            this.DisplayScreen_dropdown.Location = new System.Drawing.Point(203, 169);
            this.DisplayScreen_dropdown.Name = "DisplayScreen_dropdown";
            this.DisplayScreen_dropdown.Size = new System.Drawing.Size(100, 21);
            this.DisplayScreen_dropdown.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Display screen:";
            // 
            // ExternalDevice_dropdown
            // 
            this.ExternalDevice_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExternalDevice_dropdown.FormattingEnabled = true;
            this.ExternalDevice_dropdown.Location = new System.Drawing.Point(203, 195);
            this.ExternalDevice_dropdown.Name = "ExternalDevice_dropdown";
            this.ExternalDevice_dropdown.Size = new System.Drawing.Size(100, 21);
            this.ExternalDevice_dropdown.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "External device:";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(468, 307);
            this.Controls.Add(this.ExternalDevice_dropdown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DisplayScreen_dropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DisplayMode_dropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.CameraImagesDirectory_modifyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CameraImagesDirectory_textbox);
            this.Controls.Add(this.BaseImageDirectory_modifyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BaseImageDirectory_textbox);
            this.Controls.Add(this.Cooldown_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayTime_textbox);
            this.Controls.Add(this.label1);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DisplayTime_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cooldown_textbox;
        private System.Windows.Forms.TextBox BaseImageDirectory_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BaseImageDirectory_modifyButton;
        private System.Windows.Forms.Button CameraImagesDirectory_modifyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CameraImagesDirectory_textbox;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DisplayMode_dropdown;
        private System.Windows.Forms.ComboBox DisplayScreen_dropdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ExternalDevice_dropdown;
        private System.Windows.Forms.Label label7;
    }
}