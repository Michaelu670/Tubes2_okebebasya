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
            dptspButton = new System.Windows.Forms.RadioButton();
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
            title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            title_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            title_label.Location = new System.Drawing.Point(118, 54);
            title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            title_label.Name = "title_label";
            title_label.Size = new System.Drawing.Size(501, 55);
            title_label.TabIndex = 0;
            title_label.Text = "Treasure Hunt Solver";
            // 
            // input_label
            // 
            input_label.AutoSize = true;
            input_label.BackColor = System.Drawing.Color.Transparent;
            input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            input_label.Location = new System.Drawing.Point(135, 137);
            input_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            input_label.Name = "input_label";
            input_label.Size = new System.Drawing.Size(70, 29);
            input_label.TabIndex = 1;
            input_label.Text = "Input";
            // 
            // output_label
            // 
            output_label.AutoSize = true;
            output_label.BackColor = System.Drawing.Color.Transparent;
            output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            output_label.Location = new System.Drawing.Point(544, 137);
            output_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            output_label.Name = "output_label";
            output_label.Size = new System.Drawing.Size(90, 29);
            output_label.TabIndex = 2;
            output_label.Text = "Output";
            output_label.Click += output_label_Click;
            // 
            // filename_label
            // 
            filename_label.AutoSize = true;
            filename_label.BackColor = System.Drawing.Color.Transparent;
            filename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            filename_label.Location = new System.Drawing.Point(76, 202);
            filename_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            filename_label.Name = "filename_label";
            filename_label.Size = new System.Drawing.Size(89, 24);
            filename_label.TabIndex = 3;
            filename_label.Text = "Filename";
            // 
            // algoritma_label
            // 
            algoritma_label.AutoSize = true;
            algoritma_label.BackColor = System.Drawing.Color.Transparent;
            algoritma_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            algoritma_label.Location = new System.Drawing.Point(76, 304);
            algoritma_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            algoritma_label.Name = "algoritma_label";
            algoritma_label.Size = new System.Drawing.Size(89, 24);
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
            visualize_button.Location = new System.Drawing.Point(24, 522);
            visualize_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            visualize_button.Name = "visualize_button";
            visualize_button.Size = new System.Drawing.Size(303, 37);
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
            search_button.Location = new System.Drawing.Point(544, 480);
            search_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            search_button.Name = "search_button";
            search_button.Size = new System.Drawing.Size(163, 37);
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
            routes_label.Location = new System.Drawing.Point(474, 534);
            routes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            routes_label.Name = "routes_label";
            routes_label.Size = new System.Drawing.Size(52, 15);
            routes_label.TabIndex = 9;
            routes_label.Text = "Routes :";
            // 
            // nodes_label
            // 
            nodes_label.AutoSize = true;
            nodes_label.BackColor = System.Drawing.Color.Transparent;
            nodes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nodes_label.Location = new System.Drawing.Point(474, 573);
            nodes_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nodes_label.Name = "nodes_label";
            nodes_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nodes_label.Size = new System.Drawing.Size(49, 15);
            nodes_label.TabIndex = 10;
            nodes_label.Text = "Nodes :";
            // 
            // steps_label
            // 
            steps_label.AutoSize = true;
            steps_label.BackColor = System.Drawing.Color.Transparent;
            steps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            steps_label.Location = new System.Drawing.Point(671, 533);
            steps_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            steps_label.Name = "steps_label";
            steps_label.Size = new System.Drawing.Size(44, 15);
            steps_label.TabIndex = 11;
            steps_label.Text = "Steps :";
            // 
            // execution_time_label
            // 
            execution_time_label.AutoSize = true;
            execution_time_label.BackColor = System.Drawing.Color.Transparent;
            execution_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            execution_time_label.Location = new System.Drawing.Point(671, 573);
            execution_time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            execution_time_label.Name = "execution_time_label";
            execution_time_label.Size = new System.Drawing.Size(98, 15);
            execution_time_label.TabIndex = 12;
            execution_time_label.Text = "Execution Time :";
            // 
            // routes_ans_label
            // 
            routes_ans_label.AutoSize = true;
            routes_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            routes_ans_label.Location = new System.Drawing.Point(4, 3);
            routes_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            routes_ans_label.Name = "routes_ans_label";
            routes_ans_label.Size = new System.Drawing.Size(14, 17);
            routes_ans_label.TabIndex = 13;
            routes_ans_label.Text = "-";
            // 
            // nodes_ans_label
            // 
            nodes_ans_label.AutoSize = true;
            nodes_ans_label.BackColor = System.Drawing.Color.Transparent;
            nodes_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nodes_ans_label.Location = new System.Drawing.Point(532, 572);
            nodes_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nodes_ans_label.Name = "nodes_ans_label";
            nodes_ans_label.Size = new System.Drawing.Size(14, 17);
            nodes_ans_label.TabIndex = 14;
            nodes_ans_label.Text = "-";
            // 
            // steps_ans_label
            // 
            steps_ans_label.AutoSize = true;
            steps_ans_label.BackColor = System.Drawing.Color.Transparent;
            steps_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            steps_ans_label.Location = new System.Drawing.Point(723, 532);
            steps_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            steps_ans_label.Name = "steps_ans_label";
            steps_ans_label.Size = new System.Drawing.Size(14, 17);
            steps_ans_label.TabIndex = 15;
            steps_ans_label.Text = "-";
            // 
            // execution_time_ans_label
            // 
            execution_time_ans_label.AutoSize = true;
            execution_time_ans_label.BackColor = System.Drawing.Color.Transparent;
            execution_time_ans_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            execution_time_ans_label.Location = new System.Drawing.Point(783, 572);
            execution_time_ans_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            execution_time_ans_label.Name = "execution_time_ans_label";
            execution_time_ans_label.Size = new System.Drawing.Size(14, 17);
            execution_time_ans_label.TabIndex = 16;
            execution_time_ans_label.Text = "-";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.straight_black_thin_line_vertical;
            pictureBox2.Location = new System.Drawing.Point(-33, 123);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(793, 496);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.straight_black_thin_line;
            pictureBox1.Location = new System.Drawing.Point(-54, -337);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1003, 865);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(390, 185);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(464, 290);
            dataGridView1.TabIndex = 20;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txt_label
            // 
            txt_label.AutoSize = true;
            txt_label.BackColor = System.Drawing.Color.AntiqueWhite;
            txt_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_label.Location = new System.Drawing.Point(102, 229);
            txt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            txt_label.Name = "txt_label";
            txt_label.Size = new System.Drawing.Size(18, 18);
            txt_label.TabIndex = 21;
            txt_label.Text = "-";
            // 
            // bfsButton
            // 
            bfsButton.AutoSize = true;
            bfsButton.Checked = true;
            bfsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bfsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            bfsButton.Location = new System.Drawing.Point(24, 3);
            bfsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new System.Drawing.Size(76, 30);
            bfsButton.TabIndex = 22;
            bfsButton.TabStop = true;
            bfsButton.Text = "BFS";
            bfsButton.UseVisualStyleBackColor = true;
            // 
            // SpeedBar
            // 
            SpeedBar.BackColor = System.Drawing.Color.NavajoWhite;
            SpeedBar.Location = new System.Drawing.Point(77, 452);
            SpeedBar.Maximum = 250;
            SpeedBar.Name = "SpeedBar";
            SpeedBar.Size = new System.Drawing.Size(104, 45);
            SpeedBar.TabIndex = 24;
            SpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            SpeedBar.Scroll += SpeedBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(76, 430);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 24);
            label1.TabIndex = 25;
            label1.Text = "Speed";
            // 
            // SpeedLabel
            // 
            SpeedLabel.AutoSize = true;
            SpeedLabel.BackColor = System.Drawing.Color.Transparent;
            SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SpeedLabel.Location = new System.Drawing.Point(186, 480);
            SpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            SpeedLabel.Name = "SpeedLabel";
            SpeedLabel.Size = new System.Drawing.Size(103, 24);
            SpeedLabel.TabIndex = 26;
            SpeedLabel.Text = "0.2/second";
            // 
            // algorithm_panel
            // 
            algorithm_panel.AutoScroll = true;
            algorithm_panel.BackColor = System.Drawing.Color.Transparent;
            algorithm_panel.BackgroundImage = Properties.Resources.ocean_beach_II;
            algorithm_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            algorithm_panel.Controls.Add(dptspButton);
            algorithm_panel.Controls.Add(tspButton);
            algorithm_panel.Controls.Add(bfsButton);
            algorithm_panel.Controls.Add(dfsButton);
            algorithm_panel.Location = new System.Drawing.Point(76, 329);
            algorithm_panel.Name = "algorithm_panel";
            algorithm_panel.Size = new System.Drawing.Size(200, 78);
            algorithm_panel.TabIndex = 27;
            // 
            // tspButton
            // 
            tspButton.AutoSize = true;
            tspButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tspButton.Location = new System.Drawing.Point(24, 51);
            tspButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tspButton.Name = "tspButton";
            tspButton.Size = new System.Drawing.Size(208, 30);
            tspButton.TabIndex = 24;
            tspButton.TabStop = true;
            tspButton.Text = "TSP (Bruteforce)";
            tspButton.UseVisualStyleBackColor = true;
            // 
            // dfsButton
            // 
            dfsButton.AutoSize = true;
            dfsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dfsButton.Location = new System.Drawing.Point(24, 27);
            dfsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new System.Drawing.Size(77, 30);
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
            panel1.Location = new System.Drawing.Point(529, 532);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(118, 37);
            panel1.TabIndex = 28;
            // 
            // copyButton
            // 
            copyButton.BackgroundImage = Properties.Resources.clipboard;
            copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            copyButton.Location = new System.Drawing.Point(434, 526);
            copyButton.Name = "copyButton";
            copyButton.Size = new System.Drawing.Size(36, 32);
            copyButton.TabIndex = 29;
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // dptspButton
            // 
            dptspButton.AutoSize = true;
            dptspButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dptspButton.Location = new System.Drawing.Point(24, 75);
            dptspButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dptspButton.Name = "dptspButton";
            dptspButton.Size = new System.Drawing.Size(131, 30);
            dptspButton.TabIndex = 25;
            dptspButton.TabStop = true;
            dptspButton.Text = "TSP (DP)";
            dptspButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.NavajoWhite;
            BackgroundImage = Properties.Resources.Treasure_Hunt_II;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(943, 602);
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
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.RadioButton dptspButton;
    }
}

