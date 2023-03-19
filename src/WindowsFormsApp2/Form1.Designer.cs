﻿namespace WindowsFormsApp2
{
    partial class Form1
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
            this.title_label = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.filename_label = new System.Windows.Forms.Label();
            this.algoritma_label = new System.Windows.Forms.Label();
            this.visualize_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.routes_label = new System.Windows.Forms.Label();
            this.nodes_label = new System.Windows.Forms.Label();
            this.steps_label = new System.Windows.Forms.Label();
            this.execution_time_label = new System.Windows.Forms.Label();
            this.routes_ans_label = new System.Windows.Forms.Label();
            this.nodes_ans_label = new System.Windows.Forms.Label();
            this.steps_ans_label = new System.Windows.Forms.Label();
            this.execution_time_ans_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_label = new System.Windows.Forms.Label();
            this.bfsButton = new System.Windows.Forms.RadioButton();
            this.dfsButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title_label.Location = new System.Drawing.Point(169, 33);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(481, 55);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Treasure Hunt Solver";
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label.Location = new System.Drawing.Point(116, 119);
            this.input_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(65, 29);
            this.input_label.TabIndex = 1;
            this.input_label.Text = "Input";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.Location = new System.Drawing.Point(485, 119);
            this.output_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(84, 29);
            this.output_label.TabIndex = 2;
            this.output_label.Text = "Output";
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_label.Location = new System.Drawing.Point(65, 202);
            this.filename_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(89, 24);
            this.filename_label.TabIndex = 3;
            this.filename_label.Text = "Filename";
            // 
            // algoritma_label
            // 
            this.algoritma_label.AutoSize = true;
            this.algoritma_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritma_label.Location = new System.Drawing.Point(65, 292);
            this.algoritma_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algoritma_label.Name = "algoritma_label";
            this.algoritma_label.Size = new System.Drawing.Size(89, 24);
            this.algoritma_label.TabIndex = 4;
            this.algoritma_label.Text = "Algoritma";
            // 
            // visualize_button
            // 
            this.visualize_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this.visualize_button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualize_button.Location = new System.Drawing.Point(19, 416);
            this.visualize_button.Margin = new System.Windows.Forms.Padding(2);
            this.visualize_button.Name = "visualize_button";
            this.visualize_button.Size = new System.Drawing.Size(260, 32);
            this.visualize_button.TabIndex = 7;
            this.visualize_button.Text = "Choose File and Visualize!";
            this.visualize_button.UseVisualStyleBackColor = false;
            this.visualize_button.Click += new System.EventHandler(this.visualize_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this.search_button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(466, 416);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(140, 32);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Search!";
            this.search_button.UseVisualStyleBackColor = false;
            // 
            // routes_label
            // 
            this.routes_label.AutoSize = true;
            this.routes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routes_label.Location = new System.Drawing.Point(406, 463);
            this.routes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.routes_label.Name = "routes_label";
            this.routes_label.Size = new System.Drawing.Size(52, 15);
            this.routes_label.TabIndex = 9;
            this.routes_label.Text = "Routes :";
            // 
            // nodes_label
            // 
            this.nodes_label.AutoSize = true;
            this.nodes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodes_label.Location = new System.Drawing.Point(406, 489);
            this.nodes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nodes_label.Name = "nodes_label";
            this.nodes_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nodes_label.Size = new System.Drawing.Size(49, 15);
            this.nodes_label.TabIndex = 10;
            this.nodes_label.Text = "Nodes :";
            // 
            // steps_label
            // 
            this.steps_label.AutoSize = true;
            this.steps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps_label.Location = new System.Drawing.Point(575, 462);
            this.steps_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.steps_label.Name = "steps_label";
            this.steps_label.Size = new System.Drawing.Size(44, 15);
            this.steps_label.TabIndex = 11;
            this.steps_label.Text = "Steps :";
            // 
            // execution_time_label
            // 
            this.execution_time_label.AutoSize = true;
            this.execution_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execution_time_label.Location = new System.Drawing.Point(575, 489);
            this.execution_time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.execution_time_label.Name = "execution_time_label";
            this.execution_time_label.Size = new System.Drawing.Size(98, 15);
            this.execution_time_label.TabIndex = 12;
            this.execution_time_label.Text = "Execution Time :";
            // 
            // routes_ans_label
            // 
            this.routes_ans_label.AutoSize = true;
            this.routes_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routes_ans_label.Location = new System.Drawing.Point(456, 460);
            this.routes_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.routes_ans_label.Name = "routes_ans_label";
            this.routes_ans_label.Size = new System.Drawing.Size(14, 17);
            this.routes_ans_label.TabIndex = 13;
            this.routes_ans_label.Text = "-";
            // 
            // nodes_ans_label
            // 
            this.nodes_ans_label.AutoSize = true;
            this.nodes_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodes_ans_label.Location = new System.Drawing.Point(456, 488);
            this.nodes_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nodes_ans_label.Name = "nodes_ans_label";
            this.nodes_ans_label.Size = new System.Drawing.Size(14, 17);
            this.nodes_ans_label.TabIndex = 14;
            this.nodes_ans_label.Text = "-";
            // 
            // steps_ans_label
            // 
            this.steps_ans_label.AutoSize = true;
            this.steps_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps_ans_label.Location = new System.Drawing.Point(620, 461);
            this.steps_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.steps_ans_label.Name = "steps_ans_label";
            this.steps_ans_label.Size = new System.Drawing.Size(14, 17);
            this.steps_ans_label.TabIndex = 15;
            this.steps_ans_label.Text = "-";
            // 
            // execution_time_ans_label
            // 
            this.execution_time_ans_label.AutoSize = true;
            this.execution_time_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execution_time_ans_label.Location = new System.Drawing.Point(671, 488);
            this.execution_time_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.execution_time_ans_label.Name = "execution_time_ans_label";
            this.execution_time_ans_label.Size = new System.Drawing.Size(14, 17);
            this.execution_time_ans_label.TabIndex = 16;
            this.execution_time_ans_label.Text = "-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.straight_black_thin_line_vertical;
            this.pictureBox2.Location = new System.Drawing.Point(-28, 107);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(680, 430);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.straight_black_thin_line;
            this.pictureBox1.Location = new System.Drawing.Point(-46, -292);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 251);
            this.dataGridView1.TabIndex = 20;
            // 
            // txt_label
            // 
            this.txt_label.AutoSize = true;
            this.txt_label.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txt_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_label.Location = new System.Drawing.Point(83, 232);
            this.txt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_label.Name = "txt_label";
            this.txt_label.Size = new System.Drawing.Size(18, 18);
            this.txt_label.TabIndex = 21;
            this.txt_label.Text = "-";
            // 
            // bfsButton
            // 
            this.bfsButton.AutoSize = true;
            this.bfsButton.Checked = true;
            this.bfsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.bfsButton.Location = new System.Drawing.Point(86, 319);
            this.bfsButton.Name = "bfsButton";
            this.bfsButton.Size = new System.Drawing.Size(73, 30);
            this.bfsButton.TabIndex = 22;
            this.bfsButton.TabStop = true;
            this.bfsButton.Text = "BFS";
            this.bfsButton.UseVisualStyleBackColor = true;
            // 
            // dfsButton
            // 
            this.dfsButton.AutoSize = true;
            this.dfsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dfsButton.Location = new System.Drawing.Point(86, 344);
            this.dfsButton.Name = "dfsButton";
            this.dfsButton.Size = new System.Drawing.Size(74, 30);
            this.dfsButton.TabIndex = 23;
            this.dfsButton.TabStop = true;
            this.dfsButton.Text = "DFS";
            this.dfsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(808, 531);
            this.Controls.Add(this.dfsButton);
            this.Controls.Add(this.bfsButton);
            this.Controls.Add(this.txt_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.execution_time_ans_label);
            this.Controls.Add(this.steps_ans_label);
            this.Controls.Add(this.nodes_ans_label);
            this.Controls.Add(this.routes_ans_label);
            this.Controls.Add(this.execution_time_label);
            this.Controls.Add(this.steps_label);
            this.Controls.Add(this.nodes_label);
            this.Controls.Add(this.routes_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.visualize_button);
            this.Controls.Add(this.algoritma_label);
            this.Controls.Add(this.filename_label);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Treasure Hunt Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Label algoritma_label;
        private System.Windows.Forms.Button visualize_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label routes_label;
        private System.Windows.Forms.Label nodes_label;
        private System.Windows.Forms.Label steps_label;
        private System.Windows.Forms.Label execution_time_label;
        private System.Windows.Forms.Label routes_ans_label;
        private System.Windows.Forms.Label nodes_ans_label;
        private System.Windows.Forms.Label steps_ans_label;
        private System.Windows.Forms.Label execution_time_ans_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_label;
        private System.Windows.Forms.RadioButton bfsButton;
        private System.Windows.Forms.RadioButton dfsButton;
    }
}

