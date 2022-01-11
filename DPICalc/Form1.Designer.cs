namespace DPICalc
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
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
         this.btnCalc = new System.Windows.Forms.Button();
         this.tbxInch = new System.Windows.Forms.TextBox();
         this.tbxXres = new System.Windows.Forms.TextBox();
         this.tbxYres = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.listView1 = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.SuspendLayout();
         // 
         // btnCalc
         // 
         this.btnCalc.Location = new System.Drawing.Point(330, 22);
         this.btnCalc.Name = "btnCalc";
         this.btnCalc.Size = new System.Drawing.Size(75, 23);
         this.btnCalc.TabIndex = 0;
         this.btnCalc.Text = "calc";
         this.btnCalc.UseVisualStyleBackColor = true;
         this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
         // 
         // tbxInch
         // 
         this.tbxInch.Location = new System.Drawing.Point(12, 24);
         this.tbxInch.Name = "tbxInch";
         this.tbxInch.Size = new System.Drawing.Size(100, 21);
         this.tbxInch.TabIndex = 1;
         // 
         // tbxXres
         // 
         this.tbxXres.Location = new System.Drawing.Point(118, 24);
         this.tbxXres.Name = "tbxXres";
         this.tbxXres.Size = new System.Drawing.Size(100, 21);
         this.tbxXres.TabIndex = 2;
         // 
         // tbxYres
         // 
         this.tbxYres.Location = new System.Drawing.Point(224, 24);
         this.tbxYres.Name = "tbxYres";
         this.tbxYres.Size = new System.Drawing.Size(100, 21);
         this.tbxYres.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(29, 12);
         this.label1.TabIndex = 3;
         this.label1.Text = "inch";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(116, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(30, 12);
         this.label2.TabIndex = 3;
         this.label2.Text = "xres";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(222, 9);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(30, 12);
         this.label3.TabIndex = 3;
         this.label3.Text = "yres";
         // 
         // listView1
         // 
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
         this.listView1.Location = new System.Drawing.Point(12, 51);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(758, 554);
         this.listView1.TabIndex = 4;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "inch";
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "xres";
         // 
         // columnHeader3
         // 
         this.columnHeader3.Text = "yres";
         // 
         // columnHeader4
         // 
         this.columnHeader4.Text = "dpi";
         // 
         // columnHeader5
         // 
         this.columnHeader5.Text = "xinch";
         // 
         // columnHeader6
         // 
         this.columnHeader6.Text = "yinch";
         // 
         // columnHeader7
         // 
         this.columnHeader7.Text = "area";
         // 
         // columnHeader8
         // 
         this.columnHeader8.Text = "dist(cm)";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(782, 617);
         this.Controls.Add(this.listView1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.tbxYres);
         this.Controls.Add(this.tbxXres);
         this.Controls.Add(this.tbxInch);
         this.Controls.Add(this.btnCalc);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.TextBox tbxInch;
		private System.Windows.Forms.TextBox tbxXres;
		private System.Windows.Forms.TextBox tbxYres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
      private System.Windows.Forms.ColumnHeader columnHeader8;
	}
}

