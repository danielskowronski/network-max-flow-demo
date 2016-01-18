namespace MaxFlowDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_newNodeName = new System.Windows.Forms.TextBox();
            this.button_newNode = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_delNode = new System.Windows.Forms.ComboBox();
            this.button_delNode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_changeCap = new System.Windows.Forms.Button();
            this.textBox_changeCap = new System.Windows.Forms.TextBox();
            this.comboBox_changeCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_delEdge = new System.Windows.Forms.ComboBox();
            this.comboBox_newEdgeTrgt = new System.Windows.Forms.ComboBox();
            this.button_delEdge = new System.Windows.Forms.Button();
            this.comboBox_newEdgeSrc = new System.Windows.Forms.ComboBox();
            this.button_newEdge = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_calc = new System.Windows.Forms.Button();
            this.comboBox_selectSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_selectTarget = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_flow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Optymalizuj widok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_redraw_Click);
            // 
            // textBox_newNodeName
            // 
            this.textBox_newNodeName.Location = new System.Drawing.Point(4, 17);
            this.textBox_newNodeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_newNodeName.Name = "textBox_newNodeName";
            this.textBox_newNodeName.Size = new System.Drawing.Size(69, 20);
            this.textBox_newNodeName.TabIndex = 1;
            // 
            // button_newNode
            // 
            this.button_newNode.Location = new System.Drawing.Point(77, 16);
            this.button_newNode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_newNode.Name = "button_newNode";
            this.button_newNode.Size = new System.Drawing.Size(44, 19);
            this.button_newNode.TabIndex = 3;
            this.button_newNode.Text = "Dodaj";
            this.button_newNode.UseVisualStyleBackColor = true;
            this.button_newNode.Click += new System.EventHandler(this.button_newNode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_delNode);
            this.groupBox1.Controls.Add(this.button_delNode);
            this.groupBox1.Controls.Add(this.button_newNode);
            this.groupBox1.Controls.Add(this.textBox_newNodeName);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(126, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Węzły";
            // 
            // comboBox_delNode
            // 
            this.comboBox_delNode.FormattingEnabled = true;
            this.comboBox_delNode.Location = new System.Drawing.Point(4, 40);
            this.comboBox_delNode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_delNode.Name = "comboBox_delNode";
            this.comboBox_delNode.Size = new System.Drawing.Size(69, 21);
            this.comboBox_delNode.TabIndex = 6;
            // 
            // button_delNode
            // 
            this.button_delNode.Location = new System.Drawing.Point(77, 41);
            this.button_delNode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delNode.Name = "button_delNode";
            this.button_delNode.Size = new System.Drawing.Size(44, 19);
            this.button_delNode.TabIndex = 4;
            this.button_delNode.Text = "Usuń";
            this.button_delNode.UseVisualStyleBackColor = true;
            this.button_delNode.Click += new System.EventHandler(this.button_delNode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_changeCap);
            this.groupBox2.Controls.Add(this.textBox_changeCap);
            this.groupBox2.Controls.Add(this.comboBox_changeCap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_delEdge);
            this.groupBox2.Controls.Add(this.comboBox_newEdgeTrgt);
            this.groupBox2.Controls.Add(this.button_delEdge);
            this.groupBox2.Controls.Add(this.comboBox_newEdgeSrc);
            this.groupBox2.Controls.Add(this.button_newEdge);
            this.groupBox2.Location = new System.Drawing.Point(9, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(126, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Krawędzie";
            // 
            // button_changeCap
            // 
            this.button_changeCap.Location = new System.Drawing.Point(77, 99);
            this.button_changeCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_changeCap.Name = "button_changeCap";
            this.button_changeCap.Size = new System.Drawing.Size(44, 41);
            this.button_changeCap.TabIndex = 13;
            this.button_changeCap.Text = "Zmień przepływ";
            this.button_changeCap.UseVisualStyleBackColor = true;
            this.button_changeCap.Click += new System.EventHandler(this.button_changeCap_Click);
            // 
            // textBox_changeCap
            // 
            this.textBox_changeCap.Location = new System.Drawing.Point(4, 124);
            this.textBox_changeCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_changeCap.Name = "textBox_changeCap";
            this.textBox_changeCap.Size = new System.Drawing.Size(69, 20);
            this.textBox_changeCap.TabIndex = 12;
            // 
            // comboBox_changeCap
            // 
            this.comboBox_changeCap.FormattingEnabled = true;
            this.comboBox_changeCap.Location = new System.Drawing.Point(4, 99);
            this.comboBox_changeCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_changeCap.Name = "comboBox_changeCap";
            this.comboBox_changeCap.Size = new System.Drawing.Size(69, 21);
            this.comboBox_changeCap.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Od";
            // 
            // comboBox_delEdge
            // 
            this.comboBox_delEdge.FormattingEnabled = true;
            this.comboBox_delEdge.Location = new System.Drawing.Point(4, 67);
            this.comboBox_delEdge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_delEdge.Name = "comboBox_delEdge";
            this.comboBox_delEdge.Size = new System.Drawing.Size(69, 21);
            this.comboBox_delEdge.TabIndex = 8;
            // 
            // comboBox_newEdgeTrgt
            // 
            this.comboBox_newEdgeTrgt.FormattingEnabled = true;
            this.comboBox_newEdgeTrgt.Location = new System.Drawing.Point(28, 42);
            this.comboBox_newEdgeTrgt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_newEdgeTrgt.Name = "comboBox_newEdgeTrgt";
            this.comboBox_newEdgeTrgt.Size = new System.Drawing.Size(45, 21);
            this.comboBox_newEdgeTrgt.TabIndex = 5;
            // 
            // button_delEdge
            // 
            this.button_delEdge.Location = new System.Drawing.Point(77, 67);
            this.button_delEdge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_delEdge.Name = "button_delEdge";
            this.button_delEdge.Size = new System.Drawing.Size(44, 19);
            this.button_delEdge.TabIndex = 7;
            this.button_delEdge.Text = "Usuń";
            this.button_delEdge.UseVisualStyleBackColor = true;
            this.button_delEdge.Click += new System.EventHandler(this.button_delEdge_Click);
            // 
            // comboBox_newEdgeSrc
            // 
            this.comboBox_newEdgeSrc.FormattingEnabled = true;
            this.comboBox_newEdgeSrc.Location = new System.Drawing.Point(28, 18);
            this.comboBox_newEdgeSrc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_newEdgeSrc.Name = "comboBox_newEdgeSrc";
            this.comboBox_newEdgeSrc.Size = new System.Drawing.Size(45, 21);
            this.comboBox_newEdgeSrc.TabIndex = 4;
            // 
            // button_newEdge
            // 
            this.button_newEdge.Location = new System.Drawing.Point(77, 17);
            this.button_newEdge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_newEdge.Name = "button_newEdge";
            this.button_newEdge.Size = new System.Drawing.Size(44, 41);
            this.button_newEdge.TabIndex = 3;
            this.button_newEdge.Text = "Dodaj";
            this.button_newEdge.UseVisualStyleBackColor = true;
            this.button_newEdge.Click += new System.EventHandler(this.button_newEdge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_calc);
            this.groupBox3.Controls.Add(this.comboBox_selectSource);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox_selectTarget);
            this.groupBox3.Location = new System.Drawing.Point(4, 238);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(126, 72);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Przepływ";
            // 
            // button_calc
            // 
            this.button_calc.BackColor = System.Drawing.Color.Orange;
            this.button_calc.Location = new System.Drawing.Point(84, 17);
            this.button_calc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(38, 46);
            this.button_calc.TabIndex = 4;
            this.button_calc.Text = "Obl icz!";
            this.button_calc.UseVisualStyleBackColor = false;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // comboBox_selectSource
            // 
            this.comboBox_selectSource.FormattingEnabled = true;
            this.comboBox_selectSource.Location = new System.Drawing.Point(40, 17);
            this.comboBox_selectSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_selectSource.Name = "comboBox_selectSource";
            this.comboBox_selectSource.Size = new System.Drawing.Size(40, 21);
            this.comboBox_selectSource.TabIndex = 4;
            this.comboBox_selectSource.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectSource_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Źródło";
            // 
            // comboBox_selectTarget
            // 
            this.comboBox_selectTarget.FormattingEnabled = true;
            this.comboBox_selectTarget.Location = new System.Drawing.Point(40, 44);
            this.comboBox_selectTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_selectTarget.Name = "comboBox_selectTarget";
            this.comboBox_selectTarget.Size = new System.Drawing.Size(40, 21);
            this.comboBox_selectTarget.TabIndex = 5;
            this.comboBox_selectTarget.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectTarget_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(4, 315);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(126, 106);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sterowanie";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(65, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "Demo 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 71);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "Demo 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_flow
            // 
            this.label_flow.AutoSize = true;
            this.label_flow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_flow.Location = new System.Drawing.Point(10, 423);
            this.label_flow.Name = "label_flow";
            this.label_flow.Size = new System.Drawing.Size(98, 20);
            this.label_flow.TabIndex = 9;
            this.label_flow.Text = "Przepływ = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 497);
            this.Controls.Add(this.label_flow);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Network Max Flow Demo";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_newNodeName;
        private System.Windows.Forms.Button button_newNode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_newEdgeTrgt;
        private System.Windows.Forms.ComboBox comboBox_newEdgeSrc;
        private System.Windows.Forms.Button button_newEdge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_selectTarget;
        private System.Windows.Forms.ComboBox comboBox_selectSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.ComboBox comboBox_delNode;
        private System.Windows.Forms.Button button_delNode;
        private System.Windows.Forms.ComboBox comboBox_delEdge;
        private System.Windows.Forms.Button button_delEdge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_changeCap;
        private System.Windows.Forms.TextBox textBox_changeCap;
        private System.Windows.Forms.ComboBox comboBox_changeCap;
        private System.Windows.Forms.Label label_flow;
    }
}

