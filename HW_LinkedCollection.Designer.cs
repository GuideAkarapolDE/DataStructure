namespace HW_LinkedCollection
{
    partial class HW_LinkedCollection
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.DelBox = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.DisplayLabel1 = new System.Windows.Forms.Label();
            this.DisplayLabel2 = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(454, 152);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 24);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "เพิ่มชื่อ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(257, 154);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(157, 22);
            this.AddBox.TabIndex = 1;
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(257, 214);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(157, 22);
            this.FindBox.TabIndex = 3;
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(454, 212);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(74, 24);
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "ค้นหาชื่อ";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // DelBox
            // 
            this.DelBox.Location = new System.Drawing.Point(257, 274);
            this.DelBox.Name = "DelBox";
            this.DelBox.Size = new System.Drawing.Size(157, 22);
            this.DelBox.TabIndex = 5;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(454, 272);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(74, 24);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "ลบชื่อ";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // DisplayLabel1
            // 
            this.DisplayLabel1.AutoSize = true;
            this.DisplayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel1.Location = new System.Drawing.Point(636, 416);
            this.DisplayLabel1.Name = "DisplayLabel1";
            this.DisplayLabel1.Size = new System.Drawing.Size(63, 25);
            this.DisplayLabel1.TabIndex = 6;
            this.DisplayLabel1.Text = "จำนวน";
            // 
            // DisplayLabel2
            // 
            this.DisplayLabel2.AutoSize = true;
            this.DisplayLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel2.Location = new System.Drawing.Point(752, 416);
            this.DisplayLabel2.Name = "DisplayLabel2";
            this.DisplayLabel2.Size = new System.Drawing.Size(36, 25);
            this.DisplayLabel2.TabIndex = 7;
            this.DisplayLabel2.Text = "คน";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.Location = new System.Drawing.Point(713, 416);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(23, 25);
            this.ListLabel.TabIndex = 8;
            this.ListLabel.Text = "0";
            // 
            // HW_LinkedCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.DisplayLabel2);
            this.Controls.Add(this.DisplayLabel1);
            this.Controls.Add(this.DelBox);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.AddBtn);
            this.Name = "HW_LinkedCollection";
            this.Text = "LinkedCollection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.TextBox DelBox;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label DisplayLabel1;
        private System.Windows.Forms.Label DisplayLabel2;
        private System.Windows.Forms.Label ListLabel;
    }
}

