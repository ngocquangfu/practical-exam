
namespace project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnCase = new System.Windows.Forms.Button();
            this.txtPaper = new System.Windows.Forms.TextBox();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExe = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.prssBar = new System.Windows.Forms.ProgressBar();
            this.lblProcess = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder chứa toàn bộ bài làm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folder chứa đáp án";
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(455, 86);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(171, 23);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Chọn Folder Bài Làm";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnCase
            // 
            this.btnCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCase.Location = new System.Drawing.Point(455, 127);
            this.btnCase.Name = "btnCase";
            this.btnCase.Size = new System.Drawing.Size(171, 23);
            this.btnCase.TabIndex = 3;
            this.btnCase.Text = "Chọn Folder Đáp Án";
            this.btnCase.UseVisualStyleBackColor = true;
            this.btnCase.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // txtPaper
            // 
            this.txtPaper.Location = new System.Drawing.Point(17, 88);
            this.txtPaper.Name = "txtPaper";
            this.txtPaper.Size = new System.Drawing.Size(409, 20);
            this.txtPaper.TabIndex = 4;
            // 
            // txtCase
            // 
            this.txtCase.Location = new System.Drawing.Point(17, 127);
            this.txtCase.Name = "txtCase";
            this.txtCase.Size = new System.Drawing.Size(409, 20);
            this.txtCase.TabIndex = 5;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(17, 159);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(173, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Chấm Theo File .exe";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExe
            // 
            this.btnExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe.Location = new System.Drawing.Point(217, 159);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(156, 23);
            this.btnExe.TabIndex = 8;
            this.btnExe.Text = "Chấm Theo File .c";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(217, 248);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(156, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Xuất Điểm Ra Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // prssBar
            // 
            this.prssBar.Location = new System.Drawing.Point(455, 201);
            this.prssBar.Name = "prssBar";
            this.prssBar.Size = new System.Drawing.Size(117, 23);
            this.prssBar.TabIndex = 16;
            this.prssBar.Click += new System.EventHandler(this.prssBar_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(526, 185);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(23, 13);
            this.lblProcess.TabIndex = 17;
            this.lblProcess.Text = "0%";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 218);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 90);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bài Làm Học Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(103, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phần Mềm Chấm Thi Tự Động Môn PRF192";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tiến Trình:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(664, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.prssBar);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtCase);
            this.Controls.Add(this.txtPaper);
            this.Controls.Add(this.btnCase);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Phần mềm chấm thi prf192 tự động";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.TextBox txtPaper;
        private System.Windows.Forms.TextBox txtCase;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar prssBar;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

