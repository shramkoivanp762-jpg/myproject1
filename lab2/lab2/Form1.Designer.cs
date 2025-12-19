namespace HouseWinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Очищення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboBoxCompanies = new System.Windows.Forms.ComboBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCompanies (Вибір типу будівництва)
            // 
            this.comboBoxCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompanies.FormattingEnabled = true;
            this.comboBoxCompanies.Location = new System.Drawing.Point(20, 40);
            this.comboBoxCompanies.Name = "comboBoxCompanies";
            this.comboBoxCompanies.Size = new System.Drawing.Size(250, 24);
            this.comboBoxCompanies.TabIndex = 0;
            // 
            // btnBuild (Кнопка запуску будівництва)
            // 
            this.btnBuild.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuild.Location = new System.Drawing.Point(20, 80);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(250, 40);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Розпочати проект";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // txtLog (Поле для виведення результату з DLL)
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(20, 140);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(350, 120);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(20, 20);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(120, 17);
            this.labelSelect.TabIndex = 3;
            this.labelSelect.Text = "Оберіть компанію:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.comboBoxCompanies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управління будівництвом";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Оголошення контролів, які використовуються у вашому Form1.cs
        private System.Windows.Forms.ComboBox comboBoxCompanies;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label labelSelect;
    }
}