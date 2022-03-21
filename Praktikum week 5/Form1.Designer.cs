
namespace Praktikum_week_5
{
    partial class Form1
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
            this.Data = new System.Windows.Forms.Label();
            this.txtBoxInputData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHasilOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(48, 26);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(48, 20);
            this.Data.TabIndex = 0;
            this.Data.Text = "Data:";
            // 
            // txtBoxInputData
            // 
            this.txtBoxInputData.Location = new System.Drawing.Point(102, 20);
            this.txtBoxInputData.Name = "txtBoxInputData";
            this.txtBoxInputData.Size = new System.Drawing.Size(358, 26);
            this.txtBoxInputData.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koleksi:";
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 20;
            this.listBoxKoleksi.Location = new System.Drawing.Point(52, 113);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(177, 304);
            this.listBoxKoleksi.TabIndex = 3;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(525, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Setting:";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(470, 83);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(67, 24);
            this.checkBoxAktif.TabIndex = 6;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Checked = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(422, 113);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(130, 24);
            this.radioButtonMerah.TabIndex = 7;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(422, 143);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(113, 24);
            this.radioButtonBiru.TabIndex = 8;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            this.radioButtonBiru.CheckedChanged += new System.EventHandler(this.radioButtonBiru_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output:";
            // 
            // labelHasilOutput
            // 
            this.labelHasilOutput.AutoSize = true;
            this.labelHasilOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilOutput.Location = new System.Drawing.Point(461, 264);
            this.labelHasilOutput.Name = "labelHasilOutput";
            this.labelHasilOutput.Size = new System.Drawing.Size(0, 82);
            this.labelHasilOutput.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(361, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelHasilOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxInputData);
            this.Controls.Add(this.Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox txtBoxInputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxKoleksi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.RadioButton radioButtonMerah;
        private System.Windows.Forms.RadioButton radioButtonBiru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHasilOutput;
        private System.Windows.Forms.Button btnClear;
    }
}

