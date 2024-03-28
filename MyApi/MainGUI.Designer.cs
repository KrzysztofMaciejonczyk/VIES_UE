namespace MyApi
{
    partial class FormAPI
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
            buttonDownload = new Button();
            textBoxResponse = new TextBox();
            listBox1 = new ListBox();
            textBoxCountry = new TextBox();
            textBoxVAT = new TextBox();
            labelVAT = new Label();
            labelCountry = new Label();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonRemoveAll = new Button();
            buttonOrderBy = new Button();
            buttonDisplayAll = new Button();
            buttonStatistics = new Button();
            labelCompanyInfo = new Label();
            labelDatabaseInfo = new Label();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.BackColor = SystemColors.Control;
            buttonDownload.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonDownload.ForeColor = SystemColors.Desktop;
            buttonDownload.Location = new Point(689, 23);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(99, 51);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += buttonDownload_ClickAsync;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(12, 34);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.Size = new Size(671, 156);
            textBoxResponse.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalExtent = 1500;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 219);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(671, 139);
            listBox1.TabIndex = 2;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCountry.Location = new Point(12, 393);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(211, 30);
            textBoxCountry.TabIndex = 3;
            // 
            // textBoxVAT
            // 
            textBoxVAT.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVAT.Location = new Point(246, 393);
            textBoxVAT.Name = "textBoxVAT";
            textBoxVAT.Size = new Size(211, 30);
            textBoxVAT.TabIndex = 4;
            // 
            // labelVAT
            // 
            labelVAT.AutoSize = true;
            labelVAT.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVAT.Location = new Point(246, 365);
            labelVAT.Name = "labelVAT";
            labelVAT.Size = new Size(52, 22);
            labelVAT.TabIndex = 5;
            labelVAT.Text = "VAT:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountry.Location = new Point(12, 365);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(86, 22);
            labelCountry.TabIndex = 6;
            labelCountry.Text = "Country:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.Control;
            buttonAdd.Enabled = false;
            buttonAdd.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.Desktop;
            buttonAdd.Location = new Point(689, 80);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(99, 51);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = SystemColors.Control;
            buttonRemove.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.Desktop;
            buttonRemove.Location = new Point(689, 251);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(99, 51);
            buttonRemove.TabIndex = 8;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.BackColor = SystemColors.Control;
            buttonRemoveAll.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonRemoveAll.ForeColor = SystemColors.Desktop;
            buttonRemoveAll.Location = new Point(689, 308);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(99, 51);
            buttonRemoveAll.TabIndex = 9;
            buttonRemoveAll.Text = "Remove all";
            buttonRemoveAll.UseVisualStyleBackColor = false;
            buttonRemoveAll.Click += buttonRemoveAll_Click;
            // 
            // buttonOrderBy
            // 
            buttonOrderBy.BackColor = SystemColors.Control;
            buttonOrderBy.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonOrderBy.ForeColor = SystemColors.Desktop;
            buttonOrderBy.Location = new Point(689, 194);
            buttonOrderBy.Name = "buttonOrderBy";
            buttonOrderBy.Size = new Size(99, 51);
            buttonOrderBy.TabIndex = 10;
            buttonOrderBy.Text = "Order by";
            buttonOrderBy.UseVisualStyleBackColor = false;
            buttonOrderBy.Click += buttonOrderBy_Click;
            // 
            // buttonDisplayAll
            // 
            buttonDisplayAll.BackColor = SystemColors.Control;
            buttonDisplayAll.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonDisplayAll.ForeColor = SystemColors.Desktop;
            buttonDisplayAll.Location = new Point(689, 137);
            buttonDisplayAll.Name = "buttonDisplayAll";
            buttonDisplayAll.Size = new Size(99, 51);
            buttonDisplayAll.TabIndex = 11;
            buttonDisplayAll.Text = "Display all";
            buttonDisplayAll.UseVisualStyleBackColor = false;
            buttonDisplayAll.Click += buttonDisplayAll_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.BackColor = SystemColors.Control;
            buttonStatistics.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonStatistics.ForeColor = SystemColors.Desktop;
            buttonStatistics.Location = new Point(689, 365);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(99, 51);
            buttonStatistics.TabIndex = 12;
            buttonStatistics.Text = "Statistics";
            buttonStatistics.UseVisualStyleBackColor = false;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // labelCompanyInfo
            // 
            labelCompanyInfo.AutoSize = true;
            labelCompanyInfo.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyInfo.Location = new Point(12, 9);
            labelCompanyInfo.Name = "labelCompanyInfo";
            labelCompanyInfo.Size = new Size(373, 22);
            labelCompanyInfo.TabIndex = 13;
            labelCompanyInfo.Text = "Downloaded company's basic information";
            // 
            // labelDatabaseInfo
            // 
            labelDatabaseInfo.AutoSize = true;
            labelDatabaseInfo.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDatabaseInfo.Location = new Point(12, 194);
            labelDatabaseInfo.Name = "labelDatabaseInfo";
            labelDatabaseInfo.Size = new Size(162, 22);
            labelDatabaseInfo.TabIndex = 14;
            labelDatabaseInfo.Text = "Current Database";
            // 
            // FormAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDatabaseInfo);
            Controls.Add(labelCompanyInfo);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonDisplayAll);
            Controls.Add(buttonOrderBy);
            Controls.Add(buttonRemoveAll);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(labelCountry);
            Controls.Add(labelVAT);
            Controls.Add(textBoxVAT);
            Controls.Add(textBoxCountry);
            Controls.Add(listBox1);
            Controls.Add(textBoxResponse);
            Controls.Add(buttonDownload);
            Name = "FormAPI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += FormAPI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private TextBox textBoxResponse;
        private ListBox listBox1;
        private TextBox textBoxCountry;
        private TextBox textBoxVAT;
        private Label labelVAT;
        private Label labelCountry;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonRemoveAll;
        private Button buttonOrderBy;
        private Button buttonDisplayAll;
        private Button buttonStatistics;
        private Label labelCompanyInfo;
        private Label labelDatabaseInfo;
    }
}
