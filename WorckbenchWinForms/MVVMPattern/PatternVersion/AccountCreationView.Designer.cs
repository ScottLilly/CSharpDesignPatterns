namespace WorckbenchWinForms.MVVMPattern.PatternVersion
{
    partial class AccountCreationView
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
            this.label_ValidationMessage = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_ValidatePassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ValidationMessage
            // 
            this.label_ValidationMessage.AutoSize = true;
            this.label_ValidationMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ValidationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValidationMessage.ForeColor = System.Drawing.Color.Red;
            this.label_ValidationMessage.Location = new System.Drawing.Point(126, 0);
            this.label_ValidationMessage.Name = "label_ValidationMessage";
            this.label_ValidationMessage.Size = new System.Drawing.Size(155, 70);
            this.label_ValidationMessage.TabIndex = 0;
            this.label_ValidationMessage.Text = "Validation Message";
            this.label_ValidationMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(126, 73);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(155, 22);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_ValidatePassword
            // 
            this.button_ValidatePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ValidatePassword.Location = new System.Drawing.Point(126, 118);
            this.button_ValidatePassword.Name = "button_ValidatePassword";
            this.button_ValidatePassword.Size = new System.Drawing.Size(155, 23);
            this.button_ValidatePassword.TabIndex = 2;
            this.button_ValidatePassword.Text = "Check Password";
            this.button_ValidatePassword.UseVisualStyleBackColor = true;
            this.button_ValidatePassword.Click += new System.EventHandler(this.OnClick_ValidatePassword);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30094F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.39812F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30094F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_ValidationMessage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_ValidatePassword, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.22581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.14516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62904F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(409, 249);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AccountCreationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountCreationView";
            this.Text = "AccountCreationView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ValidationMessage;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_ValidatePassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}