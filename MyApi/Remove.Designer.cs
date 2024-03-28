namespace MyApi
{
    partial class Remove
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
            label1 = new Label();
            buttonCancel = new Button();
            buttonOK = new Button();
            textBoxID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(270, 29);
            label1.TabIndex = 0;
            label1.Text = "Remove by ID number:";
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancel.Location = new Point(198, 188);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 47);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(33, 188);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(96, 47);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxID.Location = new Point(112, 112);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 28);
            textBoxID.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 272);
            Controls.Add(textBoxID);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Removal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCancel;
        private Button buttonOK;
        private TextBox textBoxID;
    }
}