namespace MyApi
{
    partial class OrderBy
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
            radioButtonDate = new RadioButton();
            radioButtonName = new RadioButton();
            label1 = new Label();
            radioButtonVAT = new RadioButton();
            radioButtonAddress = new RadioButton();
            radioButtonValid = new RadioButton();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // radioButtonDate
            // 
            radioButtonDate.AutoSize = true;
            radioButtonDate.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonDate.Location = new Point(52, 152);
            radioButtonDate.Name = "radioButtonDate";
            radioButtonDate.Size = new Size(60, 24);
            radioButtonDate.TabIndex = 0;
            radioButtonDate.TabStop = true;
            radioButtonDate.Text = "date";
            radioButtonDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            radioButtonName.AutoSize = true;
            radioButtonName.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonName.Location = new Point(52, 32);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(70, 24);
            radioButtonName.TabIndex = 1;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "name";
            radioButtonName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Order by:";
            label1.Click += label1_Click;
            // 
            // radioButtonVAT
            // 
            radioButtonVAT.AutoSize = true;
            radioButtonVAT.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonVAT.Location = new Point(52, 62);
            radioButtonVAT.Name = "radioButtonVAT";
            radioButtonVAT.Size = new Size(128, 24);
            radioButtonVAT.TabIndex = 3;
            radioButtonVAT.TabStop = true;
            radioButtonVAT.Text = "VAT number";
            radioButtonVAT.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddress
            // 
            radioButtonAddress.AutoSize = true;
            radioButtonAddress.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonAddress.Location = new Point(52, 122);
            radioButtonAddress.Name = "radioButtonAddress";
            radioButtonAddress.Size = new Size(86, 24);
            radioButtonAddress.TabIndex = 4;
            radioButtonAddress.TabStop = true;
            radioButtonAddress.Text = "address";
            radioButtonAddress.UseVisualStyleBackColor = true;
            // 
            // radioButtonValid
            // 
            radioButtonValid.AutoSize = true;
            radioButtonValid.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonValid.Location = new Point(52, 92);
            radioButtonValid.Name = "radioButtonValid";
            radioButtonValid.Size = new Size(105, 24);
            radioButtonValid.TabIndex = 5;
            radioButtonValid.TabStop = true;
            radioButtonValid.Text = "validation";
            radioButtonValid.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(108, 180);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(86, 42);
            buttonOK.TabIndex = 6;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 234);
            Controls.Add(buttonOK);
            Controls.Add(radioButtonValid);
            Controls.Add(radioButtonAddress);
            Controls.Add(radioButtonVAT);
            Controls.Add(label1);
            Controls.Add(radioButtonName);
            Controls.Add(radioButtonDate);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonDate;
        private RadioButton radioButtonName;
        private Label label1;
        private RadioButton radioButtonVAT;
        private RadioButton radioButtonAddress;
        private RadioButton radioButtonValid;
        private Button buttonOK;
    }
}