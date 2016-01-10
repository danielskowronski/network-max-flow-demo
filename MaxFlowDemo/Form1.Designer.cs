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
            this.comboBox_changeCap = new System.Windows.Forms.ComboBox();
            this.textBox_changeCap = new System.Windows.Forms.TextBox();
            this.button_changeCap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Optymalizuj widok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_redraw_Click);
            // 
            // textBox_newNodeName
            // 
            this.textBox_newNodeName.Location = new System.Drawing.Point(6, 21);
            this.textBox_newNodeName.Name = "textBox_newNodeName";
            this.textBox_newNodeName.Size = new System.Drawing.Size(91, 22);
            this.textBox_newNodeName.TabIndex = 1;
            // 
            // button_newNode
            // 
            this.button_newNode.Location = new System.Drawing.Point(103, 20);
            this.button_newNode.Name = "button_newNode";
            this.button_newNode.Size = new System.Drawing.Size(59, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Węzły";
            // 
            // comboBox_delNode
            // 
            this.comboBox_delNode.FormattingEnabled = true;
            this.comboBox_delNode.Location = new System.Drawing.Point(6, 49);
            this.comboBox_delNode.Name = "comboBox_delNode";
            this.comboBox_delNode.Size = new System.Drawing.Size(91, 24);
            this.comboBox_delNode.TabIndex = 6;
            // 
            // button_delNode
            // 
            this.button_delNode.Location = new System.Drawing.Point(103, 50);
            this.button_delNode.Name = "button_delNode";
            this.button_delNode.Size = new System.Drawing.Size(59, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Krawędzie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Od";
            // 
            // comboBox_delEdge
            // 
            this.comboBox_delEdge.FormattingEnabled = true;
            this.comboBox_delEdge.Location = new System.Drawing.Point(6, 82);
            this.comboBox_delEdge.Name = "comboBox_delEdge";
            this.comboBox_delEdge.Size = new System.Drawing.Size(91, 24);
            this.comboBox_delEdge.TabIndex = 8;
            // 
            // comboBox_newEdgeTrgt
            // 
            this.comboBox_newEdgeTrgt.FormattingEnabled = true;
            this.comboBox_newEdgeTrgt.Location = new System.Drawing.Point(38, 52);
            this.comboBox_newEdgeTrgt.Name = "comboBox_newEdgeTrgt";
            this.comboBox_newEdgeTrgt.Size = new System.Drawing.Size(59, 24);
            this.comboBox_newEdgeTrgt.TabIndex = 5;
            // 
            // button_delEdge
            // 
            this.button_delEdge.Location = new System.Drawing.Point(103, 82);
            this.button_delEdge.Name = "button_delEdge";
            this.button_delEdge.Size = new System.Drawing.Size(59, 23);
            this.button_delEdge.TabIndex = 7;
            this.button_delEdge.Text = "Usuń";
            this.button_delEdge.UseVisualStyleBackColor = true;
            this.button_delEdge.Click += new System.EventHandler(this.button_delEdge_Click);
            // 
            // comboBox_newEdgeSrc
            // 
            this.comboBox_newEdgeSrc.FormattingEnabled = true;
            this.comboBox_newEdgeSrc.Location = new System.Drawing.Point(38, 22);
            this.comboBox_newEdgeSrc.Name = "comboBox_newEdgeSrc";
            this.comboBox_newEdgeSrc.Size = new System.Drawing.Size(59, 24);
            this.comboBox_newEdgeSrc.TabIndex = 4;
            // 
            // button_newEdge
            // 
            this.button_newEdge.Location = new System.Drawing.Point(103, 21);
            this.button_newEdge.Name = "button_newEdge";
            this.button_newEdge.Size = new System.Drawing.Size(59, 51);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 89);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Przepływ";
            // 
            // button_calc
            // 
            this.button_calc.BackColor = System.Drawing.Color.Orange;
            this.button_calc.Location = new System.Drawing.Point(112, 21);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(50, 57);
            this.button_calc.TabIndex = 4;
            this.button_calc.Text = "Obl icz!";
            this.button_calc.UseVisualStyleBackColor = false;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // comboBox_selectSource
            // 
            this.comboBox_selectSource.FormattingEnabled = true;
            this.comboBox_selectSource.Location = new System.Drawing.Point(54, 21);
            this.comboBox_selectSource.Name = "comboBox_selectSource";
            this.comboBox_selectSource.Size = new System.Drawing.Size(52, 24);
            this.comboBox_selectSource.TabIndex = 4;
            this.comboBox_selectSource.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectSource_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Źródło";
            // 
            // comboBox_selectTarget
            // 
            this.comboBox_selectTarget.FormattingEnabled = true;
            this.comboBox_selectTarget.Location = new System.Drawing.Point(54, 54);
            this.comboBox_selectTarget.Name = "comboBox_selectTarget";
            this.comboBox_selectTarget.Size = new System.Drawing.Size(52, 24);
            this.comboBox_selectTarget.TabIndex = 5;
            this.comboBox_selectTarget.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectTarget_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(6, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 130);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sterowanie";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Demo 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Demo 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_changeCap
            // 
            this.comboBox_changeCap.FormattingEnabled = true;
            this.comboBox_changeCap.Location = new System.Drawing.Point(6, 122);
            this.comboBox_changeCap.Name = "comboBox_changeCap";
            this.comboBox_changeCap.Size = new System.Drawing.Size(91, 24);
            this.comboBox_changeCap.TabIndex = 11;
            // 
            // textBox_changeCap
            // 
            this.textBox_changeCap.Location = new System.Drawing.Point(6, 152);
            this.textBox_changeCap.Name = "textBox_changeCap";
            this.textBox_changeCap.Size = new System.Drawing.Size(91, 22);
            this.textBox_changeCap.TabIndex = 12;
            // 
            // button_changeCap
            // 
            this.button_changeCap.Location = new System.Drawing.Point(103, 122);
            this.button_changeCap.Name = "button_changeCap";
            this.button_changeCap.Size = new System.Drawing.Size(59, 51);
            this.button_changeCap.TabIndex = 13;
            this.button_changeCap.Text = "Zmień przepływ";
            this.button_changeCap.UseVisualStyleBackColor = true;
            this.button_changeCap.Click += new System.EventHandler(this.button_changeCap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
    }
}

