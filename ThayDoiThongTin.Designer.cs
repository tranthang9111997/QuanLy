namespace QuanLyNhanSu
{
    partial class ThayDoiThongTin
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
            this.btnThemPC = new System.Windows.Forms.Button();
            this.btnXoaPC = new System.Windows.Forms.Button();
            this.btnChuyenPC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwPCTTNV = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwPC = new System.Windows.Forms.ListView();
            this.tvwTenDA = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemPC
            // 
            this.btnThemPC.Location = new System.Drawing.Point(310, 325);
            this.btnThemPC.Name = "btnThemPC";
            this.btnThemPC.Size = new System.Drawing.Size(75, 23);
            this.btnThemPC.TabIndex = 0;
            this.btnThemPC.Text = "Thêm";
            this.btnThemPC.UseVisualStyleBackColor = true;
            // 
            // btnXoaPC
            // 
            this.btnXoaPC.Location = new System.Drawing.Point(405, 325);
            this.btnXoaPC.Name = "btnXoaPC";
            this.btnXoaPC.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPC.TabIndex = 0;
            this.btnXoaPC.Text = "Xóa";
            this.btnXoaPC.UseVisualStyleBackColor = true;
            // 
            // btnChuyenPC
            // 
            this.btnChuyenPC.Location = new System.Drawing.Point(502, 325);
            this.btnChuyenPC.Name = "btnChuyenPC";
            this.btnChuyenPC.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenPC.TabIndex = 0;
            this.btnChuyenPC.Text = "Chuyển";
            this.btnChuyenPC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvwTenDA);
            this.groupBox1.Location = new System.Drawing.Point(21, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 361);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên Dự Án";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwPCTTNV);
            this.groupBox2.Location = new System.Drawing.Point(226, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 153);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Viên";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lvwPCTTNV
            // 
            this.lvwPCTTNV.HideSelection = false;
            this.lvwPCTTNV.Location = new System.Drawing.Point(9, 17);
            this.lvwPCTTNV.Name = "lvwPCTTNV";
            this.lvwPCTTNV.Size = new System.Drawing.Size(453, 135);
            this.lvwPCTTNV.TabIndex = 0;
            this.lvwPCTTNV.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwPC);
            this.groupBox3.Location = new System.Drawing.Point(226, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phân Công";
            // 
            // lvwPC
            // 
            this.lvwPC.HideSelection = false;
            this.lvwPC.Location = new System.Drawing.Point(9, 17);
            this.lvwPC.Name = "lvwPC";
            this.lvwPC.Size = new System.Drawing.Size(453, 135);
            this.lvwPC.TabIndex = 0;
            this.lvwPC.UseCompatibleStateImageBehavior = false;
            // 
            // tvwTenDA
            // 
            this.tvwTenDA.Location = new System.Drawing.Point(10, 19);
            this.tvwTenDA.Name = "tvwTenDA";
            this.tvwTenDA.Size = new System.Drawing.Size(169, 330);
            this.tvwTenDA.TabIndex = 0;
            // 
            // ThayDoiThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChuyenPC);
            this.Controls.Add(this.btnXoaPC);
            this.Controls.Add(this.btnThemPC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThayDoiThongTin";
            this.Text = "Phân Công";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemPC;
        private System.Windows.Forms.Button btnXoaPC;
        private System.Windows.Forms.Button btnChuyenPC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwPCTTNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvwPC;
        private System.Windows.Forms.TreeView tvwTenDA;
    }
}