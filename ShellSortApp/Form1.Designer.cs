namespace ShellSortApp
{
    partial class Form1
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
            btnSort = new Button();
            labelInput = new Label();
            txtInput = new TextBox();
            labelOutput = new Label();
            txtOutput = new TextBox();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(192, 255, 192);
            btnSort.Location = new Point(85, 120);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(239, 31);
            btnSort.TabIndex = 0;
            btnSort.Text = "Ordenar";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(22, 30);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(239, 15);
            labelInput.TabIndex = 1;
            labelInput.Text = "Ingrese los números (separados por comas):";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(22, 75);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(356, 23);
            txtInput.TabIndex = 2;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(85, 171);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(118, 15);
            labelOutput.TabIndex = 1;
            labelOutput.Text = "Números ordenados:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(22, 218);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(356, 23);
            txtOutput.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 255, 192);
            btnReset.Location = new Point(102, 261);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(199, 32);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(404, 552);
            Controls.Add(btnReset);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Shell Sort App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private Label labelInput;
        private TextBox txtInput;
        private Label labelOutput;
        private TextBox txtOutput;
        private Button btnReset;
    }
}
