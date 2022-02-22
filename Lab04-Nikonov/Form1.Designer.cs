namespace Lab04_Nikonov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Element = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Show = new System.Windows.Forms.Button();
            this.pb_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_box)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Element
            // 
            this.cb_Element.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Element.FormattingEnabled = true;
            this.cb_Element.Location = new System.Drawing.Point(130, 16);
            this.cb_Element.Name = "cb_Element";
            this.cb_Element.Size = new System.Drawing.Size(183, 29);
            this.cb_Element.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Elements";
            // 
            // tb_Show
            // 
            this.tb_Show.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Show.Location = new System.Drawing.Point(319, 12);
            this.tb_Show.Name = "tb_Show";
            this.tb_Show.Size = new System.Drawing.Size(222, 34);
            this.tb_Show.TabIndex = 12;
            this.tb_Show.Text = "Show";
            this.tb_Show.UseVisualStyleBackColor = true;
            this.tb_Show.Click += new System.EventHandler(this.tb_Show_Click);
            // 
            // pb_box
            // 
            this.pb_box.Location = new System.Drawing.Point(21, 59);
            this.pb_box.Name = "pb_box";
            this.pb_box.Size = new System.Drawing.Size(520, 379);
            this.pb_box.TabIndex = 15;
            this.pb_box.TabStop = false;
            this.pb_box.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_box_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.pb_box);
            this.Controls.Add(this.cb_Element);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Element;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_Show;
        private System.Windows.Forms.PictureBox pb_box;
    }
}

