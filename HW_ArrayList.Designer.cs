namespace HW_ArrayList
{
    partial class ArrayForm
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
            this.FillBox = new System.Windows.Forms.RichTextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.FindIndexBox = new System.Windows.Forms.RichTextBox();
            this.FindIndexBtn = new System.Windows.Forms.Button();
            this.IndexEditBox = new System.Windows.Forms.RichTextBox();
            this.IndexEditBtn = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.ListShowBtn = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FillBox
            // 
            this.FillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillBox.Location = new System.Drawing.Point(21, 23);
            this.FillBox.Name = "FillBox";
            this.FillBox.Size = new System.Drawing.Size(407, 34);
            this.FillBox.TabIndex = 0;
            this.FillBox.Text = "";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(460, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(88, 39);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "เพิ่มชื่อ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(579, 19);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(88, 39);
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "ค้นหาชื่อ";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(691, 19);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(88, 39);
            this.DelBtn.TabIndex = 3;
            this.DelBtn.Text = "ลบชื่อ";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // FindIndexBox
            // 
            this.FindIndexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindIndexBox.Location = new System.Drawing.Point(21, 88);
            this.FindIndexBox.Name = "FindIndexBox";
            this.FindIndexBox.Size = new System.Drawing.Size(68, 34);
            this.FindIndexBox.TabIndex = 4;
            this.FindIndexBox.Text = "";
            // 
            // FindIndexBtn
            // 
            this.FindIndexBtn.Location = new System.Drawing.Point(107, 85);
            this.FindIndexBtn.Name = "FindIndexBtn";
            this.FindIndexBtn.Size = new System.Drawing.Size(198, 39);
            this.FindIndexBtn.TabIndex = 5;
            this.FindIndexBtn.Text = "ค้นหาชื่อจากลำดับที่";
            this.FindIndexBtn.UseVisualStyleBackColor = true;
            this.FindIndexBtn.Click += new System.EventHandler(this.FindIndexBtn_Click);
            // 
            // IndexEditBox
            // 
            this.IndexEditBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexEditBox.Location = new System.Drawing.Point(325, 88);
            this.IndexEditBox.Name = "IndexEditBox";
            this.IndexEditBox.Size = new System.Drawing.Size(342, 34);
            this.IndexEditBox.TabIndex = 6;
            this.IndexEditBox.Text = "";
            // 
            // IndexEditBtn
            // 
            this.IndexEditBtn.Location = new System.Drawing.Point(691, 85);
            this.IndexEditBtn.Name = "IndexEditBtn";
            this.IndexEditBtn.Size = new System.Drawing.Size(88, 39);
            this.IndexEditBtn.TabIndex = 7;
            this.IndexEditBtn.Text = "แก้ไขชื่อ";
            this.IndexEditBtn.UseVisualStyleBackColor = true;
            this.IndexEditBtn.Click += new System.EventHandler(this.IndexEditBtn_Click);
            // 
            // ListView
            // 
            this.ListView.BackColor = System.Drawing.SystemColors.Window;
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(21, 163);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(646, 264);
            this.ListView.TabIndex = 8;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.List;
            // 
            // ListShowBtn
            // 
            this.ListShowBtn.Location = new System.Drawing.Point(691, 163);
            this.ListShowBtn.Name = "ListShowBtn";
            this.ListShowBtn.Size = new System.Drawing.Size(88, 77);
            this.ListShowBtn.TabIndex = 9;
            this.ListShowBtn.Text = "แสดงรายชื่อทั้งหมด";
            this.ListShowBtn.UseVisualStyleBackColor = true;
            this.ListShowBtn.Click += new System.EventHandler(this.ListShowBtn_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(673, 404);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 22);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "จำนวน";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListLabel.Location = new System.Drawing.Point(736, 404);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(20, 22);
            this.ListLabel.TabIndex = 11;
            this.ListLabel.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(763, 404);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 22);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "คน";
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListShowBtn);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.IndexEditBtn);
            this.Controls.Add(this.IndexEditBox);
            this.Controls.Add(this.FindIndexBtn);
            this.Controls.Add(this.FindIndexBox);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FillBox);
            this.Name = "ArrayForm";
            this.Text = "ArrayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FillBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.RichTextBox FindIndexBox;
        private System.Windows.Forms.Button FindIndexBtn;
        private System.Windows.Forms.RichTextBox IndexEditBox;
        private System.Windows.Forms.Button IndexEditBtn;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button ListShowBtn;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label Label2;
    }
}

