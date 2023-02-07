namespace LAB_IN402105_7_2_66
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblCo = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtXs = new System.Windows.Forms.TextBox();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.txtYs = new System.Windows.Forms.TextBox();
            this.txtYe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.rdbRect = new System.Windows.Forms.RadioButton();
            this.rdbCir = new System.Windows.Forms.RadioButton();
            this.chkMouseDraw = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDraw.Location = new System.Drawing.Point(513, 211);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(94, 39);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "วาดรูป";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCo.Location = new System.Drawing.Point(8, 553);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(67, 20);
            this.lblCo.TabIndex = 1;
            this.lblCo.Text = "จุดพิกัด =";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnColor.Location = new System.Drawing.Point(513, 76);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(94, 39);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblColor.Location = new System.Drawing.Point(633, 85);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(66, 20);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "แสดงค่าสี";
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtW.Location = new System.Drawing.Point(728, 82);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(60, 26);
            this.txtW.TabIndex = 4;
            this.txtW.Text = "5";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClear.Location = new System.Drawing.Point(513, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtXs
            // 
            this.txtXs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtXs.Location = new System.Drawing.Point(582, 12);
            this.txtXs.Name = "txtXs";
            this.txtXs.Size = new System.Drawing.Size(100, 26);
            this.txtXs.TabIndex = 6;
            this.txtXs.Text = "50";
            // 
            // txtXe
            // 
            this.txtXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtXe.Location = new System.Drawing.Point(582, 44);
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(100, 26);
            this.txtXe.TabIndex = 7;
            this.txtXe.Text = "204";
            // 
            // txtYs
            // 
            this.txtYs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtYs.Location = new System.Drawing.Point(688, 12);
            this.txtYs.Name = "txtYs";
            this.txtYs.Size = new System.Drawing.Size(100, 26);
            this.txtYs.TabIndex = 8;
            this.txtYs.Text = "305";
            // 
            // txtYe
            // 
            this.txtYe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtYe.Location = new System.Drawing.Point(688, 44);
            this.txtYe.Name = "txtYe";
            this.txtYe.Size = new System.Drawing.Size(100, 26);
            this.txtYe.TabIndex = 9;
            this.txtYe.Text = "102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(509, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "จุดเริ่มต้น";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(509, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "สุดสินสุด";
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearData.Location = new System.Drawing.Point(513, 166);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(94, 39);
            this.btnClearData.TabIndex = 12;
            this.btnClearData.Text = "ClearData";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCir);
            this.groupBox1.Controls.Add(this.rdbRect);
            this.groupBox1.Controls.Add(this.rdbLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 103);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกประเภท";
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Location = new System.Drawing.Point(6, 19);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(73, 24);
            this.rdbLine.TabIndex = 14;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "เส้นตรง";
            this.rdbLine.UseVisualStyleBackColor = true;
            // 
            // rdbRect
            // 
            this.rdbRect.AutoSize = true;
            this.rdbRect.Location = new System.Drawing.Point(6, 49);
            this.rdbRect.Name = "rdbRect";
            this.rdbRect.Size = new System.Drawing.Size(76, 24);
            this.rdbRect.TabIndex = 15;
            this.rdbRect.TabStop = true;
            this.rdbRect.Text = "สีเหลี่ยม";
            this.rdbRect.UseVisualStyleBackColor = true;
            // 
            // rdbCir
            // 
            this.rdbCir.AutoSize = true;
            this.rdbCir.Location = new System.Drawing.Point(6, 79);
            this.rdbCir.Name = "rdbCir";
            this.rdbCir.Size = new System.Drawing.Size(93, 24);
            this.rdbCir.TabIndex = 16;
            this.rdbCir.TabStop = true;
            this.rdbCir.Text = "วงกลม/วงรี";
            this.rdbCir.UseVisualStyleBackColor = true;
            // 
            // chkMouseDraw
            // 
            this.chkMouseDraw.AutoSize = true;
            this.chkMouseDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkMouseDraw.Location = new System.Drawing.Point(121, 18);
            this.chkMouseDraw.Name = "chkMouseDraw";
            this.chkMouseDraw.Size = new System.Drawing.Size(129, 24);
            this.chkMouseDraw.TabIndex = 14;
            this.chkMouseDraw.Text = "วาดเส้นด้วยเมาส์";
            this.chkMouseDraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.chkMouseDraw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYe);
            this.Controls.Add(this.txtYs);
            this.Controls.Add(this.txtXe);
            this.Controls.Add(this.txtXs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtXs;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.TextBox txtYs;
        private System.Windows.Forms.TextBox txtYe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCir;
        private System.Windows.Forms.RadioButton rdbRect;
        private System.Windows.Forms.RadioButton rdbLine;
        private System.Windows.Forms.CheckBox chkMouseDraw;
    }
}

