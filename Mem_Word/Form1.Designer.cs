namespace Mem_Word
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
            this.Word = new System.Windows.Forms.TextBox();
            this.Prct = new System.Windows.Forms.TextBox();
            this.Meaning = new System.Windows.Forms.TextBox();
            this.Example = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(206, 80);
            this.Word.Margin = new System.Windows.Forms.Padding(4);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(115, 23);
            this.Word.TabIndex = 0;
            // 
            // Prct
            // 
            this.Prct.Location = new System.Drawing.Point(339, 80);
            this.Prct.Margin = new System.Windows.Forms.Padding(4);
            this.Prct.Name = "Prct";
            this.Prct.Size = new System.Drawing.Size(115, 23);
            this.Prct.TabIndex = 0;
            // 
            // Meaning
            // 
            this.Meaning.Location = new System.Drawing.Point(206, 111);
            this.Meaning.Margin = new System.Windows.Forms.Padding(4);
            this.Meaning.Name = "Meaning";
            this.Meaning.Size = new System.Drawing.Size(248, 23);
            this.Meaning.TabIndex = 0;
            // 
            // Example
            // 
            this.Example.Location = new System.Drawing.Point(206, 142);
            this.Example.Margin = new System.Windows.Forms.Padding(4);
            this.Example.Multiline = true;
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(248, 134);
            this.Example.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prct";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "存入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "复习";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 344);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Example);
            this.Controls.Add(this.Meaning);
            this.Controls.Add(this.Prct);
            this.Controls.Add(this.Word);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.TextBox Prct;
        private System.Windows.Forms.TextBox Meaning;
        private System.Windows.Forms.TextBox Example;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

