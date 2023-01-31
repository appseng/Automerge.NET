namespace Automerge.NET
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_source = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_2nd = new System.Windows.Forms.Button();
            this.btn_1st = new System.Windows.Forms.Button();
            this.btn_source = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_2nd = new System.Windows.Forms.TextBox();
            this.txt_1st = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_automerge = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(75, 19);
            this.txt_source.Name = "txt_source";
            this.txt_source.ReadOnly = true;
            this.txt_source.Size = new System.Drawing.Size(100, 20);
            this.txt_source.TabIndex = 0;
            this.txt_source.Text = "TestData\\source.cs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_2nd);
            this.groupBox1.Controls.Add(this.btn_1st);
            this.groupBox1.Controls.Add(this.btn_source);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_2nd);
            this.groupBox1.Controls.Add(this.txt_1st);
            this.groupBox1.Controls.Add(this.txt_source);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btn_2nd
            // 
            this.btn_2nd.Location = new System.Drawing.Point(181, 69);
            this.btn_2nd.Name = "btn_2nd";
            this.btn_2nd.Size = new System.Drawing.Size(52, 23);
            this.btn_2nd.TabIndex = 7;
            this.btn_2nd.Text = "...";
            this.btn_2nd.UseVisualStyleBackColor = true;
            this.btn_2nd.Click += new System.EventHandler(this.btn_2nd_Click);
            // 
            // btn_1st
            // 
            this.btn_1st.Location = new System.Drawing.Point(181, 43);
            this.btn_1st.Name = "btn_1st";
            this.btn_1st.Size = new System.Drawing.Size(52, 23);
            this.btn_1st.TabIndex = 6;
            this.btn_1st.Text = "...";
            this.btn_1st.UseVisualStyleBackColor = true;
            this.btn_1st.Click += new System.EventHandler(this.btn_1st_Click);
            // 
            // btn_source
            // 
            this.btn_source.Location = new System.Drawing.Point(181, 17);
            this.btn_source.Name = "btn_source";
            this.btn_source.Size = new System.Drawing.Size(52, 23);
            this.btn_source.TabIndex = 2;
            this.btn_source.Text = "...";
            this.btn_source.UseVisualStyleBackColor = true;
            this.btn_source.Click += new System.EventHandler(this.btn_source_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2nd variant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1st variant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source";
            // 
            // txt_2nd
            // 
            this.txt_2nd.Location = new System.Drawing.Point(75, 71);
            this.txt_2nd.Name = "txt_2nd";
            this.txt_2nd.ReadOnly = true;
            this.txt_2nd.Size = new System.Drawing.Size(100, 20);
            this.txt_2nd.TabIndex = 2;
            this.txt_2nd.Text = "TestData\\2nd.cs";
            // 
            // txt_1st
            // 
            this.txt_1st.Location = new System.Drawing.Point(75, 45);
            this.txt_1st.Name = "txt_1st";
            this.txt_1st.ReadOnly = true;
            this.txt_1st.Size = new System.Drawing.Size(100, 20);
            this.txt_1st.TabIndex = 1;
            this.txt_1st.Text = "TestData\\1st.cs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_automerge);
            this.groupBox2.Controls.Add(this.btn_output);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_output);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // btn_automerge
            // 
            this.btn_automerge.Location = new System.Drawing.Point(158, 62);
            this.btn_automerge.Name = "btn_automerge";
            this.btn_automerge.Size = new System.Drawing.Size(75, 23);
            this.btn_automerge.TabIndex = 9;
            this.btn_automerge.Text = "AutoMerge";
            this.btn_automerge.UseVisualStyleBackColor = true;
            this.btn_automerge.Click += new System.EventHandler(this.btn_automerge_Click);
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(181, 24);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(52, 23);
            this.btn_output.TabIndex = 8;
            this.btn_output.Text = "...";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "OutputFile";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(75, 24);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(100, 20);
            this.txt_output.TabIndex = 0;
            this.txt_output.Text = "TestData\\output.cs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 231);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutoMerge.NET";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_2nd;
        private System.Windows.Forms.Button btn_1st;
        private System.Windows.Forms.Button btn_source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_2nd;
        private System.Windows.Forms.TextBox txt_1st;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_automerge;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_output;
    }
}

