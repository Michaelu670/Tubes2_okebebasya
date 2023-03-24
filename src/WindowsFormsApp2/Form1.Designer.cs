namespace WindowsFormsApp2
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
            title_label = new System.Windows.Forms.Label();
            input_label = new System.Windows.Forms.Label();
            output_label = new System.Windows.Forms.Label();
            filename_label = new System.Windows.Forms.Label();
            algoritma_label = new System.Windows.Forms.Label();
            visualize_button = new System.Windows.Forms.Button();
            search_button = new System.Windows.Forms.Button();
            routes_label = new System.Windows.Forms.Label();
            nodes_label = new System.Windows.Forms.Label();
            steps_label = new System.Windows.Forms.Label();
            execution_time_label = new System.Windows.Forms.Label();
            routes_ans_label = new System.Windows.Forms.Label();
            nodes_ans_label = new System.Windows.Forms.Label();
            steps_ans_label = new System.Windows.Forms.Label();
            execution_time_ans_label = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txt_label = new System.Windows.Forms.Label();
            bfsButton = new System.Windows.Forms.RadioButton();
            SpeedBar = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            SpeedLabel = new System.Windows.Forms.Label();
            algorithm_panel = new System.Windows.Forms.Panel();
            tspButton = new System.Windows.Forms.RadioButton();
            dfsButton = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            copyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedBar).BeginInit();
            algorithm_panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.BackColor = System.Drawing.Color.Transparent;
            title_label.Font = new System.Drawing.Font("Trajan Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            title_label.Location = new System.Drawing.Point(135, 72);
            title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(804, 75);
            title_label.TabIndex = 0;
            title_label.Text = "Treasure Hunt Solver";
            // 
            // input_label
            // 
            input_label.AutoSize = true;
            input_label.BackColor = System.Drawing.Color.Transparent;
            input_label.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            input_label.Location = new System.Drawing.Point(154, 183);
            input_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            input_label.Name = "input_label";
            input_label.Size = new System.Drawing.Size(118, 26);
            input_label.TabIndex = 1;
            input_label.Text = "Input";
            // 
            // output_label
            // 
            output_label.AutoSize = true;
            output_label.BackColor = System.Drawing.Color.Transparent;
            output_label.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            output_label.Location = new System.Drawing.Point(622, 183);
            output_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            output_label.Name = "output_label";
            output_label.Size = new System.Drawing.Size(162, 26);
            output_label.TabIndex = 2;
            output_label.Text = "Output";
            output_label.Click += output_label_Click;
            // 
            // filename_label
            // 
            filename_label.AutoSize = true;
            filename_label.BackColor = System.Drawing.Color.Transparent;
            filename_label.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            filename_label.Location = new System.Drawing.Point(87, 269);
            filename_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            filename_label.Name = "filename_label";
            filename_label.Size = new System.Drawing.Size(130, 20);
            filename_label.TabIndex = 3;
            filename_label.Text = "Filename";
            // 
            // algoritma_label
            // 
            algoritma_label.AutoSize = true;
            algoritma_label.BackColor = System.Drawing.Color.Transparent;
            algoritma_label.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            algoritma_label.Location = new System.Drawing.Point(87, 405);
            algoritma_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            algoritma_label.Name = "algoritma_label";
            algoritma_label.Size = new System.Drawing.Size(167, 20);
            algoritma_label.TabIndex = 4;
            algoritma_label.Text = "Algoritma";
            // 
            // visualize_button
            // 
            visualize_button.BackColor = System.Drawing.Color.NavajoWhite;
            visualize_button.BackgroundImage = Properties.Resources.ocean_beach;
            visualize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            visualize_button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            visualize_button.ForeColor = System.Drawing.Color.SaddleBrown;
            visualize_button.Location = new System.Drawing.Point(27, 696);
            visualize_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            visualize_button.Name = "visualize_button";
            visualize_button.Size = new System.Drawing.Size(346, 49);
            visualize_button.TabIndex = 7;
            visualize_button.Text = "Choose File and Visualize!";
            visualize_button.UseVisualStyleBackColor = false;
            visualize_button.Click += visualize_button_Click;
            // 
            // search_button
            // 
            search_button.BackColor = System.Drawing.Color.NavajoWhite;
            search_button.BackgroundImage = Properties.Resources.ocean_beach;
            search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            search_button.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            search_button.ForeColor = System.Drawing.Color.SaddleBrown;
            search_button.Location = new System.Drawing.Point(622, 640);
            search_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            search_button.Name = "search_button";
            search_button.Size = new System.Drawing.Size(186, 49);
            search_button.TabIndex = 8;
            search_button.Text = "Search!";
            search_button.UseVisualStyleBackColor = false;
            search_button.Click += search_button_Click;
            // 
            // routes_label
            // 
            routes_label.AutoSize = true;
            routes_label.BackColor = System.Drawing.Color.Transparent;
            routes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            routes_label.Location = new System.Drawing.Point(542, 712);
            routes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            routes_label.Name = "routes_label";
            routes_label.Size = new System.Drawing.Size(64, 18);
            routes_label.TabIndex = 9;
            routes_label.Text = "Routes :";
            // 
            // nodes_label
            // 
            nodes_label.AutoSize = true;
            nodes_label.BackColor = System.Drawing.Color.Transparent;
            nodes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nodes_label.Location = new System.Drawing.Point(542, 764);
            nodes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nodes_label.Name = "nodes_label";
            nodes_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nodes_label.Size = new System.Drawing.Size(60, 18);
            nodes_label.TabIndex = 10;
            nodes_label.Text = "Nodes :";
            // 
            // steps_label
            // 
            steps_label.AutoSize = true;
            steps_label.BackColor = System.Drawing.Color.Transparent;
            steps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            steps_label.Location = new System.Drawing.Point(767, 711);
            steps_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            steps_label.Name = "steps_label";
            steps_label.Size = new System.Drawing.Size(54, 18);
            steps_label.TabIndex = 11;
            steps_label.Text = "Steps :";
            // 
            // execution_time_label
            // 
            execution_time_label.AutoSize = true;
            execution_time_label.BackColor = System.Drawing.Color.Transparent;
            execution_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            execution_time_label.Location = new System.Drawing.Point(767, 764);
            execution_time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            execution_time_label.Name = "execution_time_label";
            execution_time_label.Size = new System.Drawing.Size(118, 18);
            execution_time_label.TabIndex = 12;
            execution_time_label.Text = "Execution Time :";
            // 
            // routes_ans_label
            // 
            routes_ans_label.AutoSize = true;
            routes_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            routes_ans_label.Location = new System.Drawing.Point(5, 4);
            routes_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            routes_ans_label.Name = "routes_ans_label";
            routes_ans_label.Size = new System.Drawing.Size(16, 20);
            routes_ans_label.TabIndex = 13;
            routes_ans_label.Text = "-";
            // 
            // nodes_ans_label
            // 
            nodes_ans_label.AutoSize = true;
            nodes_ans_label.BackColor = System.Drawing.Color.Transparent;
            nodes_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nodes_ans_label.Location = new System.Drawing.Point(608, 763);
            nodes_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nodes_ans_label.Name = "nodes_ans_label";
            nodes_ans_label.Size = new System.Drawing.Size(16, 20);
            nodes_ans_label.TabIndex = 14;
            nodes_ans_label.Text = "-";
            // 
            // steps_ans_label
            // 
            steps_ans_label.AutoSize = true;
            steps_ans_label.BackColor = System.Drawing.Color.Transparent;
            steps_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            steps_ans_label.Location = new System.Drawing.Point(826, 709);
            steps_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            steps_ans_label.Name = "steps_ans_label";
            steps_ans_label.Size = new System.Drawing.Size(16, 20);
            steps_ans_label.TabIndex = 15;
            steps_ans_label.Text = "-";
            // 
            // execution_time_ans_label
            // 
            execution_time_ans_label.AutoSize = true;
            execution_time_ans_label.BackColor = System.Drawing.Color.Transparent;
            execution_time_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            execution_time_ans_label.Location = new System.Drawing.Point(895, 763);
            execution_time_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            execution_time_ans_label.Name = "execution_time_ans_label";
            execution_time_ans_label.Size = new System.Drawing.Size(16, 20);
            execution_time_ans_label.TabIndex = 16;
            execution_time_ans_label.Text = "-";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.straight_black_thin_line_vertical;
            pictureBox2.Location = new System.Drawing.Point(-38, 164);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(906, 661);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.straight_black_thin_line;
            pictureBox1.Location = new System.Drawing.Point(-62, -449);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1146, 1153);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(446, 247);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(530, 387);
            dataGridView1.TabIndex = 20;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txt_label
            // 
            txt_label.AutoSize = true;
            txt_label.BackColor = System.Drawing.Color.AntiqueWhite;
            txt_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_label.Location = new System.Drawing.Point(116, 305);
            txt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            txt_label.Name = "txt_label";
            txt_label.Size = new System.Drawing.Size(22, 22);
            txt_label.TabIndex = 21;
            txt_label.Text = "-";
            // 
            // bfsButton
            // 
            bfsButton.AutoSize = true;
            bfsButton.Checked = true;
            bfsButton.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bfsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            bfsButton.Location = new System.Drawing.Point(27, 4);
            bfsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new System.Drawing.Size(92, 28);
            bfsButton.TabIndex = 22;
            bfsButton.TabStop = true;
            bfsButton.Text = "BFS";
            bfsButton.UseVisualStyleBackColor = true;
            // 
            // SpeedBar
            // 
            SpeedBar.BackColor = System.Drawing.Color.NavajoWhite;
            SpeedBar.Location = new System.Drawing.Point(88, 602);
            SpeedBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SpeedBar.Maximum = 250;
            SpeedBar.Name = "SpeedBar";
            SpeedBar.Size = new System.Drawing.Size(119, 56);
            SpeedBar.TabIndex = 24;
            SpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            SpeedBar.Scroll += SpeedBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(87, 573);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 25;
            label1.Text = "Speed";
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.BackColor = System.Drawing.Color.Transparent;
            SpeedLabel.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SpeedLabel.Location = new System.Drawing.Point(212, 640);
            SpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new System.Drawing.Size(169, 20);
            SpeedLabel.TabIndex = 26;
            SpeedLabel.Text = "0.2/second";
            // 
            // algorithm_panel
            // 
            algorithm_panel.AutoScroll = true;
            algorithm_panel.BackColor = System.Drawing.Color.Transparent;
            algorithm_panel.BackgroundImage = Properties.Resources.ocean_beach_II;
            algorithm_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            algorithm_panel.Controls.Add(tspButton);
            algorithm_panel.Controls.Add(bfsButton);
            algorithm_panel.Controls.Add(dfsButton);
            algorithm_panel.Location = new System.Drawing.Point(87, 439);
            algorithm_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            algorithm_panel.Name = "algorithm_panel";
            algorithm_panel.Size = new System.Drawing.Size(229, 104);
            algorithm_panel.TabIndex = 27;
            // 
            // tspButton
            // 
            tspButton.AutoSize = true;
            tspButton.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tspButton.Location = new System.Drawing.Point(27, 72);
            tspButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tspButton.Name = "tspButton";
            tspButton.Size = new System.Drawing.Size(93, 28);
            tspButton.TabIndex = 24;
            tspButton.TabStop = true;
            tspButton.Text = "TSP";
            tspButton.UseVisualStyleBackColor = true;
            // 
            // dfsButton
            // 
            dfsButton.AutoSize = true;
            dfsButton.Font = new System.Drawing.Font("TOMMY HILFIGER AF", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dfsButton.Location = new System.Drawing.Point(27, 36);
            dfsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new System.Drawing.Size(91, 28);
            dfsButton.TabIndex = 23;
            dfsButton.TabStop = true;
            dfsButton.Text = "DFS";
            dfsButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(routes_ans_label);
            panel1.Location = new System.Drawing.Point(605, 709);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(135, 49);
            panel1.TabIndex = 28;
            // 
            // copyButton
            // 
            copyButton.BackgroundImage = Properties.Resources.clipboard;
            copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            copyButton.Location = new System.Drawing.Point(496, 702);
            copyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            copyButton.Name = "copyButton";
            copyButton.Size = new System.Drawing.Size(41, 43);
            copyButton.TabIndex = 29;
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.NavajoWhite;
            BackgroundImage = Properties.Resources.Treasure_Hunt_II;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1078, 817);
            Controls.Add(copyButton);
            Controls.Add(panel1);
            Controls.Add(algorithm_panel);
            Controls.Add(SpeedLabel);
            Controls.Add(label1);
            Controls.Add(SpeedBar);
            Controls.Add(txt_label);
            Controls.Add(dataGridView1);
            Controls.Add(execution_time_ans_label);
            Controls.Add(steps_ans_label);
            Controls.Add(nodes_ans_label);
            Controls.Add(execution_time_label);
            Controls.Add(steps_label);
            Controls.Add(nodes_label);
            Controls.Add(routes_label);
            Controls.Add(search_button);
            Controls.Add(visualize_button);
            Controls.Add(algoritma_label);
            Controls.Add(filename_label);
            Controls.Add(output_label);
            Controls.Add(input_label);
            Controls.Add(title_label);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Treasure Hunt Solver";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedBar).EndInit();
            algorithm_panel.ResumeLayout(false);
            algorithm_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Panel algorithm_panel;
        private System.Windows.Forms.RadioButton tspButton;
        private System.Windows.Forms.RadioButton dfsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button copyButton;
    }
}

