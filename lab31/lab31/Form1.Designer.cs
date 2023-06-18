namespace lab31
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
            this.components = new System.ComponentModel.Container();
            this.processList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.ContextMenuStrip = this.contextMenuStrip1;
            this.processList.HideSelection = false;
            this.processList.Location = new System.Drawing.Point(150, 12);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(638, 426);
            this.processList.TabIndex = 0;
            this.processList.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformToolStripMenuItem,
            this.StopToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 52);
            // 
            // InformToolStripMenuItem
            // 
            this.InformToolStripMenuItem.Name = "InformToolStripMenuItem";
            this.InformToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.InformToolStripMenuItem.Text = "Інформація про процес";
            this.InformToolStripMenuItem.Click += new System.EventHandler(this.InformToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.StopToolStripMenuItem.Text = "Зупинка процесу";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // rebtn
            // 
            this.rebtn.Location = new System.Drawing.Point(12, 125);
            this.rebtn.Name = "rebtn";
            this.rebtn.Size = new System.Drawing.Size(132, 37);
            this.rebtn.TabIndex = 1;
            this.rebtn.Text = "Оновити";
            this.rebtn.UseVisualStyleBackColor = true;
            this.rebtn.Click += new System.EventHandler(this.rebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(12, 260);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(132, 45);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Зберегти список";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.rebtn);
            this.Controls.Add(this.processList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView processList;
        private System.Windows.Forms.Button rebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
    }
}

