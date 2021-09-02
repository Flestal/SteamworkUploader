
namespace SteamworkUploader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_tag = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_log_newitem = new System.Windows.Forms.TextBox();
            this.tb_workshopItemAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_updateTitle = new System.Windows.Forms.TextBox();
            this.tb_updateTag = new System.Windows.Forms.TextBox();
            this.tb_updateDesc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_updatePath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_log_update = new System.Windows.Forms.TextBox();
            this.tb_whatNew = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "여기로 모드 폴더 드래그";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "폴더 경로 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "미리보기 이미지 : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 180);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(264, 16);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(411, 25);
            this.tb_title.TabIndex = 5;
            // 
            // tb_tag
            // 
            this.tb_tag.Location = new System.Drawing.Point(264, 49);
            this.tb_tag.Name = "tb_tag";
            this.tb_tag.Size = new System.Drawing.Size(411, 25);
            this.tb_tag.TabIndex = 6;
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(264, 80);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_desc.Size = new System.Drawing.Size(411, 89);
            this.tb_desc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "제목 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "태그 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "설명 : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 401);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_path);
            this.tabPage1.Controls.Add(this.tb_log_newitem);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tb_desc);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.tb_tag);
            this.tabPage1.Controls.Add(this.tb_title);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "새 아이템 등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tb_whatNew);
            this.tabPage2.Controls.Add(this.tb_log_update);
            this.tabPage2.Controls.Add(this.tb_updatePath);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.tb_updateDesc);
            this.tabPage2.Controls.Add(this.tb_updateTag);
            this.tabPage2.Controls.Add(this.tb_updateTitle);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_workshopItemAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "기존 아이템 업데이트";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_log_newitem
            // 
            this.tb_log_newitem.Location = new System.Drawing.Point(386, 176);
            this.tb_log_newitem.Multiline = true;
            this.tb_log_newitem.Name = "tb_log_newitem";
            this.tb_log_newitem.ReadOnly = true;
            this.tb_log_newitem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log_newitem.Size = new System.Drawing.Size(289, 180);
            this.tb_log_newitem.TabIndex = 12;
            // 
            // tb_workshopItemAddress
            // 
            this.tb_workshopItemAddress.Location = new System.Drawing.Point(114, 6);
            this.tb_workshopItemAddress.Name = "tb_workshopItemAddress";
            this.tb_workshopItemAddress.Size = new System.Drawing.Size(374, 25);
            this.tb_workshopItemAddress.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "창작마당 주소 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "URL 복사 하고 그대로 붙여넣기";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(84, 121);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(174, 25);
            this.tb_path.TabIndex = 13;
            // 
            // tb_updateTitle
            // 
            this.tb_updateTitle.Location = new System.Drawing.Point(329, 46);
            this.tb_updateTitle.Name = "tb_updateTitle";
            this.tb_updateTitle.Size = new System.Drawing.Size(328, 25);
            this.tb_updateTitle.TabIndex = 3;
            // 
            // tb_updateTag
            // 
            this.tb_updateTag.Location = new System.Drawing.Point(329, 77);
            this.tb_updateTag.Name = "tb_updateTag";
            this.tb_updateTag.Size = new System.Drawing.Size(328, 25);
            this.tb_updateTag.TabIndex = 4;
            // 
            // tb_updateDesc
            // 
            this.tb_updateDesc.Location = new System.Drawing.Point(329, 108);
            this.tb_updateDesc.Multiline = true;
            this.tb_updateDesc.Name = "tb_updateDesc";
            this.tb_updateDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_updateDesc.Size = new System.Drawing.Size(328, 74);
            this.tb_updateDesc.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox2_DragDrop);
            this.groupBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox2_DragEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "여기로 모드 폴더 드래그";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "제목 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "태그 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "설명 : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "업데이트";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "미리보기 이미지 : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 180);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // tb_updatePath
            // 
            this.tb_updatePath.Location = new System.Drawing.Point(78, 137);
            this.tb_updatePath.Name = "tb_updatePath";
            this.tb_updatePath.ReadOnly = true;
            this.tb_updatePath.Size = new System.Drawing.Size(174, 25);
            this.tb_updatePath.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "폴더 경로 : ";
            // 
            // tb_log_update
            // 
            this.tb_log_update.Location = new System.Drawing.Point(385, 218);
            this.tb_log_update.Multiline = true;
            this.tb_log_update.Name = "tb_log_update";
            this.tb_log_update.ReadOnly = true;
            this.tb_log_update.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log_update.Size = new System.Drawing.Size(272, 147);
            this.tb_log_update.TabIndex = 16;
            // 
            // tb_whatNew
            // 
            this.tb_whatNew.Location = new System.Drawing.Point(329, 187);
            this.tb_whatNew.Name = "tb_whatNew";
            this.tb_whatNew.Size = new System.Drawing.Size(328, 25);
            this.tb_whatNew.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "변경점 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 425);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "창작마당툴";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_tag;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_log_newitem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_workshopItemAddress;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_updateDesc;
        private System.Windows.Forms.TextBox tb_updateTag;
        private System.Windows.Forms.TextBox tb_updateTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_updatePath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_log_update;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_whatNew;
    }
}

