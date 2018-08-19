namespace areaCalculation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.triLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.triHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diameter = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recLength = new System.Windows.Forms.TextBox();
            this.recWide = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recBox = new System.Windows.Forms.GroupBox();
            this.squareBox = new System.Windows.Forms.GroupBox();
            this.triBox = new System.Windows.Forms.GroupBox();
            this.circleBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.recBox.SuspendLayout();
            this.squareBox.SuspendLayout();
            this.triBox.SuspendLayout();
            this.circleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入底：";
            // 
            // triLength
            // 
            this.triLength.Location = new System.Drawing.Point(81, 18);
            this.triLength.Name = "triLength";
            this.triLength.Size = new System.Drawing.Size(100, 21);
            this.triLength.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入高：";
            // 
            // triHeight
            // 
            this.triHeight.Location = new System.Drawing.Point(281, 18);
            this.triHeight.Name = "triHeight";
            this.triHeight.Size = new System.Drawing.Size(100, 21);
            this.triHeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入直径：";
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(81, 18);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(100, 21);
            this.diameter.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "三角形",
            "圆形",
            "正方形",
            "矩形"});
            this.comboBox1.Location = new System.Drawing.Point(142, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "输入边长：";
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(81, 18);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(100, 21);
            this.square.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "输入长：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "输入宽：";
            // 
            // recLength
            // 
            this.recLength.Location = new System.Drawing.Point(81, 18);
            this.recLength.Name = "recLength";
            this.recLength.Size = new System.Drawing.Size(100, 21);
            this.recLength.TabIndex = 12;
            // 
            // recWide
            // 
            this.recWide.Location = new System.Drawing.Point(281, 18);
            this.recWide.Name = "recWide";
            this.recWide.Size = new System.Drawing.Size(100, 21);
            this.recWide.TabIndex = 13;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(81, 53);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 21);
            this.area.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "面积：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "选择图形类型：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "厘米(cm)",
            "英寸(inch)"});
            this.comboBox2.Location = new System.Drawing.Point(81, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 20);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "选择单位：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(192, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "cm^2";
            this.label10.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.area);
            this.groupBox1.Location = new System.Drawing.Point(44, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 86);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // recBox
            // 
            this.recBox.Controls.Add(this.recWide);
            this.recBox.Controls.Add(this.recLength);
            this.recBox.Controls.Add(this.label6);
            this.recBox.Controls.Add(this.label5);
            this.recBox.Location = new System.Drawing.Point(44, 63);
            this.recBox.Name = "recBox";
            this.recBox.Size = new System.Drawing.Size(400, 53);
            this.recBox.TabIndex = 22;
            this.recBox.TabStop = false;
            this.recBox.Visible = false;
            // 
            // squareBox
            // 
            this.squareBox.Controls.Add(this.square);
            this.squareBox.Controls.Add(this.label4);
            this.squareBox.Location = new System.Drawing.Point(44, 60);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(200, 52);
            this.squareBox.TabIndex = 23;
            this.squareBox.TabStop = false;
            this.squareBox.Visible = false;
            // 
            // triBox
            // 
            this.triBox.Controls.Add(this.triHeight);
            this.triBox.Controls.Add(this.label2);
            this.triBox.Controls.Add(this.label1);
            this.triBox.Controls.Add(this.triLength);
            this.triBox.Location = new System.Drawing.Point(44, 63);
            this.triBox.Name = "triBox";
            this.triBox.Size = new System.Drawing.Size(400, 50);
            this.triBox.TabIndex = 24;
            this.triBox.TabStop = false;
            this.triBox.Visible = false;
            // 
            // circleBox
            // 
            this.circleBox.Controls.Add(this.diameter);
            this.circleBox.Controls.Add(this.label3);
            this.circleBox.Location = new System.Drawing.Point(44, 63);
            this.circleBox.Name = "circleBox";
            this.circleBox.Size = new System.Drawing.Size(200, 51);
            this.circleBox.TabIndex = 25;
            this.circleBox.TabStop = false;
            this.circleBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 280);
            this.Controls.Add(this.circleBox);
            this.Controls.Add(this.triBox);
            this.Controls.Add(this.recBox);
            this.Controls.Add(this.squareBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Location = new System.Drawing.Point(81, 18);
            this.Name = "Form1";
            this.Text = "面积计算器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.recBox.ResumeLayout(false);
            this.recBox.PerformLayout();
            this.squareBox.ResumeLayout(false);
            this.squareBox.PerformLayout();
            this.triBox.ResumeLayout(false);
            this.triBox.PerformLayout();
            this.circleBox.ResumeLayout(false);
            this.circleBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox triLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox triHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox square;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recLength;
        private System.Windows.Forms.TextBox recWide;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox recBox;
        private System.Windows.Forms.GroupBox squareBox;
        private System.Windows.Forms.GroupBox triBox;
        private System.Windows.Forms.GroupBox circleBox;
    }
}

