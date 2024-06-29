namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            label2 = new Label();
            btSomar = new Button();
            btSubtrair = new Button();
            btMultiplicar = new Button();
            btDividir = new Button();
            label3 = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Primeiro numero";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(186, 57);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(81, 23);
            TextBox1.TabIndex = 1;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(186, 114);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(81, 23);
            TextBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 2;
            label2.Text = "Segundo numero";
            // 
            // btSomar
            // 
            btSomar.Location = new Point(12, 152);
            btSomar.Name = "btSomar";
            btSomar.Size = new Size(255, 42);
            btSomar.TabIndex = 4;
            btSomar.Text = "Somar";
            btSomar.UseVisualStyleBackColor = true;
            btSomar.Click += btSomar_Click;
            // 
            // btSubtrair
            // 
            btSubtrair.Location = new Point(12, 200);
            btSubtrair.Name = "btSubtrair";
            btSubtrair.Size = new Size(255, 42);
            btSubtrair.TabIndex = 5;
            btSubtrair.Text = "Subtrair";
            btSubtrair.UseVisualStyleBackColor = true;
            btSubtrair.Click += btSubtrair_Click;
            // 
            // btMultiplicar
            // 
            btMultiplicar.Location = new Point(12, 248);
            btMultiplicar.Name = "btMultiplicar";
            btMultiplicar.Size = new Size(255, 42);
            btMultiplicar.TabIndex = 6;
            btMultiplicar.Text = "Multiplicar";
            btMultiplicar.UseVisualStyleBackColor = true;
            btMultiplicar.Click += btMultiplicar_Click;
            // 
            // btDividir
            // 
            btDividir.Location = new Point(12, 296);
            btDividir.Name = "btDividir";
            btDividir.Size = new Size(255, 42);
            btDividir.TabIndex = 7;
            btDividir.Text = "Dividir";
            btDividir.UseVisualStyleBackColor = true;
            btDividir.Click += btDividir_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 341);
            label3.Name = "label3";
            label3.Size = new Size(165, 30);
            label3.TabIndex = 8;
            label3.Text = "O RESULTADO É";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(124, 380);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(25, 30);
            labelResult.TabIndex = 9;
            labelResult.Text = "X";
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 436);
            Controls.Add(labelResult);
            Controls.Add(label3);
            Controls.Add(btDividir);
            Controls.Add(btMultiplicar);
            Controls.Add(btSubtrair);
            Controls.Add(btSomar);
            Controls.Add(TextBox2);
            Controls.Add(label2);
            Controls.Add(TextBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora simples";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBox1;
        private TextBox TextBox2;
        private Label label2;
        private Button btSomar;
        private Button btSubtrair;
        private Button btMultiplicar;
        private Button btDividir;
        private Label label3;
        private Label labelResult;
    }
}
