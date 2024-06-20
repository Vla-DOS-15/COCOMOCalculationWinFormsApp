namespace COCOMOCalculationWinFormsApp
{
    partial class MainForm
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
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtCodeSize = new System.Windows.Forms.TextBox();
            this.lblEfforts = new System.Windows.Forms.Label();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.lblDevelopers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Location = new System.Drawing.Point(40, 58);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(318, 33);
            this.cmbProjectType.TabIndex = 0;
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetData.Location = new System.Drawing.Point(40, 189);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(318, 44);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Розрахувати";
            this.btnGetData.UseVisualStyleBackColor = true;
            // 
            // txtCodeSize
            // 
            this.txtCodeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCodeSize.Location = new System.Drawing.Point(40, 142);
            this.txtCodeSize.Name = "txtCodeSize";
            this.txtCodeSize.Size = new System.Drawing.Size(318, 30);
            this.txtCodeSize.TabIndex = 2;
            // 
            // lblEfforts
            // 
            this.lblEfforts.AutoSize = true;
            this.lblEfforts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEfforts.Location = new System.Drawing.Point(410, 61);
            this.lblEfforts.Name = "lblEfforts";
            this.lblEfforts.Size = new System.Drawing.Size(160, 25);
            this.lblEfforts.TabIndex = 3;
            this.lblEfforts.Text = "Трудоємність:";
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeTo.Location = new System.Drawing.Point(439, 103);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(131, 25);
            this.lblTimeTo.TabIndex = 4;
            this.lblTimeTo.Text = "Тривалість:";
            // 
            // lblDevelopers
            // 
            this.lblDevelopers.AutoSize = true;
            this.lblDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDevelopers.Location = new System.Drawing.Point(427, 145);
            this.lblDevelopers.Name = "lblDevelopers";
            this.lblDevelopers.Size = new System.Drawing.Size(143, 25);
            this.lblDevelopers.TabIndex = 5;
            this.lblDevelopers.Text = "Розробників:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип проєкта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кількість рядків коду (тисяч):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDevelopers);
            this.Controls.Add(this.lblTimeTo);
            this.Controls.Add(this.lblEfforts);
            this.Controls.Add(this.txtCodeSize);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.cmbProjectType);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox txtCodeSize;
        private System.Windows.Forms.Label lblEfforts;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.Label lblDevelopers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

