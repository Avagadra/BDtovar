
namespace WindowsFormsApp1
{
    partial class SpisokTovarov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpisokTovarov));
            this.dataGridSpisokTovarov = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNowItem = new System.Windows.Forms.Label();
            this.labelMaxItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSortV = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpisokTovarov)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSpisokTovarov
            // 
            this.dataGridSpisokTovarov.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSpisokTovarov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpisokTovarov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSpisokTovarov.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.dataGridSpisokTovarov.Location = new System.Drawing.Point(0, 0);
            this.dataGridSpisokTovarov.Name = "dataGridSpisokTovarov";
            this.dataGridSpisokTovarov.Size = new System.Drawing.Size(800, 405);
            this.dataGridSpisokTovarov.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNowItem);
            this.panel1.Controls.Add(this.labelMaxItem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxSortV);
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 122);
            this.panel1.TabIndex = 1;
            // 
            // labelNowItem
            // 
            this.labelNowItem.AutoSize = true;
            this.labelNowItem.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.labelNowItem.Location = new System.Drawing.Point(400, 86);
            this.labelNowItem.Name = "labelNowItem";
            this.labelNowItem.Size = new System.Drawing.Size(45, 26);
            this.labelNowItem.TabIndex = 23;
            this.labelNowItem.Text = "100";
            // 
            // labelMaxItem
            // 
            this.labelMaxItem.AutoSize = true;
            this.labelMaxItem.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.labelMaxItem.Location = new System.Drawing.Point(504, 88);
            this.labelMaxItem.Name = "labelMaxItem";
            this.labelMaxItem.Size = new System.Drawing.Size(45, 26);
            this.labelMaxItem.TabIndex = 22;
            this.labelMaxItem.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(291, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Выведено                  из";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(102, 33);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(159, 30);
            this.textBoxSearch.TabIndex = 14;
            // 
            // comboBoxSortV
            // 
            this.comboBoxSortV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortV.FormattingEnabled = true;
            this.comboBoxSortV.Location = new System.Drawing.Point(357, 33);
            this.comboBoxSortV.Name = "comboBoxSortV";
            this.comboBoxSortV.Size = new System.Drawing.Size(88, 31);
            this.comboBoxSortV.TabIndex = 20;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(553, 33);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(126, 31);
            this.comboBoxFilter.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(564, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Фильтрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите для поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сортировка по цене";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridSpisokTovarov);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 405);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonNext);
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 71);
            this.panel3.TabIndex = 1;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonNext.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(426, 16);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(187, 38);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Следующая страница";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(188, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(205, 38);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Предыдущая страница";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SpisokTovarov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpisokTovarov";
            this.Text = "Список товаров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpisokTovarov)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSpisokTovarov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNowItem;
        private System.Windows.Forms.Label labelMaxItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSortV;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
    }
}