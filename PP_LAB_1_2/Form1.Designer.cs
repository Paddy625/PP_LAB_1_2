namespace PP_LAB_1_2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.indexBox = new System.Windows.Forms.TextBox();
            this.iterValBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.randButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.costBox = new System.Windows.Forms.TextBox();
            this.loadBox = new System.Windows.Forms.TextBox();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iterPackedBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.iterWeightBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(12, 164);
            this.indexBox.Name = "indexBox";
            this.indexBox.ReadOnly = true;
            this.indexBox.Size = new System.Drawing.Size(776, 20);
            this.indexBox.TabIndex = 1;
            this.indexBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // iterValBox
            // 
            this.iterValBox.Location = new System.Drawing.Point(12, 237);
            this.iterValBox.Name = "iterValBox";
            this.iterValBox.ReadOnly = true;
            this.iterValBox.Size = new System.Drawing.Size(776, 20);
            this.iterValBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indeksy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wagi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wartości";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(17, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(29, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Ilość";
            this.countLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(220, 9);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(63, 13);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Zakres wag";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(487, 9);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(82, 13);
            this.valueLabel.TabIndex = 8;
            this.valueLabel.Text = "Zakres wartości";
            this.valueLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(20, 25);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 9;
            this.countBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(223, 25);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 10;
            this.weightBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(490, 25);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 20);
            this.valueBox.TabIndex = 11;
            // 
            // randButton
            // 
            this.randButton.Location = new System.Drawing.Point(288, 72);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(200, 52);
            this.randButton.TabIndex = 12;
            this.randButton.Text = "Losuj problem";
            this.randButton.UseVisualStyleBackColor = true;
            this.randButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Rozwiąż";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(223, 398);
            this.costBox.Name = "costBox";
            this.costBox.ReadOnly = true;
            this.costBox.Size = new System.Drawing.Size(100, 20);
            this.costBox.TabIndex = 14;
            this.costBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // loadBox
            // 
            this.loadBox.Location = new System.Drawing.Point(688, 398);
            this.loadBox.Name = "loadBox";
            this.loadBox.ReadOnly = true;
            this.loadBox.Size = new System.Drawing.Size(100, 20);
            this.loadBox.TabIndex = 15;
            this.loadBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(688, 25);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(100, 20);
            this.capacityBox.TabIndex = 12;
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(685, 9);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(100, 13);
            this.capacityLabel.TabIndex = 17;
            this.capacityLabel.Text = "Pojemność plecaka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Wybrane przedmioty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // iterPackedBox
            // 
            this.iterPackedBox.Location = new System.Drawing.Point(12, 351);
            this.iterPackedBox.Name = "iterPackedBox";
            this.iterPackedBox.ReadOnly = true;
            this.iterPackedBox.Size = new System.Drawing.Size(776, 20);
            this.iterPackedBox.TabIndex = 18;
            this.iterPackedBox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wartoś wybranych przedmiotów:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Waga wybranych przedmiotów:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // iterWeightBox
            // 
            this.iterWeightBox.Location = new System.Drawing.Point(12, 200);
            this.iterWeightBox.Name = "iterWeightBox";
            this.iterWeightBox.ReadOnly = true;
            this.iterWeightBox.Size = new System.Drawing.Size(776, 20);
            this.iterWeightBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iterPackedBox);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.loadBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.randButton);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterValBox);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.iterWeightBox);
            this.Name = "Form1";
            this.Text = "Rozwiazanie problemu plecakowego";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.TextBox iterValBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button randButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox loadBox;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iterPackedBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox iterWeightBox;
    }
}

