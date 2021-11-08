
namespace Loan_Calculator
{
    partial class FrmLoanCalc
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
            this.LblMonto = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.LblTipoPrestamo = new System.Windows.Forms.Label();
            this.CbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.LblCuota = new System.Windows.Forms.Label();
            this.CbxCuota = new System.Windows.Forms.ComboBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.LblTasaInteres = new System.Windows.Forms.Label();
            this.TxtTasaInteres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblMonto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMonto.Location = new System.Drawing.Point(51, 56);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(63, 19);
            this.LblMonto.TabIndex = 0;
            this.LblMonto.Text = "Monto: ";
            this.LblMonto.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(209, 52);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(146, 23);
            this.TxtMonto.TabIndex = 1;
            // 
            // LblTipoPrestamo
            // 
            this.LblTipoPrestamo.AutoSize = true;
            this.LblTipoPrestamo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTipoPrestamo.Location = new System.Drawing.Point(51, 102);
            this.LblTipoPrestamo.Name = "LblTipoPrestamo";
            this.LblTipoPrestamo.Size = new System.Drawing.Size(134, 19);
            this.LblTipoPrestamo.TabIndex = 2;
            this.LblTipoPrestamo.Text = "Tipo de prestamo: ";
            this.LblTipoPrestamo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CbxTipoPrestamo
            // 
            this.CbxTipoPrestamo.FormattingEnabled = true;
            this.CbxTipoPrestamo.Location = new System.Drawing.Point(209, 98);
            this.CbxTipoPrestamo.Name = "CbxTipoPrestamo";
            this.CbxTipoPrestamo.Size = new System.Drawing.Size(146, 23);
            this.CbxTipoPrestamo.TabIndex = 3;
            this.CbxTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.CbxTipoPrestamo_SelectedIndexChanged);
            // 
            // LblCuota
            // 
            this.LblCuota.AutoSize = true;
            this.LblCuota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCuota.Location = new System.Drawing.Point(42, 199);
            this.LblCuota.Name = "LblCuota";
            this.LblCuota.Size = new System.Drawing.Size(143, 19);
            this.LblCuota.TabIndex = 4;
            this.LblCuota.Text = "Cuotas Mensuales: ";
            // 
            // CbxCuota
            // 
            this.CbxCuota.FormattingEnabled = true;
            this.CbxCuota.Location = new System.Drawing.Point(209, 195);
            this.CbxCuota.Name = "CbxCuota";
            this.CbxCuota.Size = new System.Drawing.Size(146, 23);
            this.CbxCuota.TabIndex = 5;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalc.Location = new System.Drawing.Point(209, 245);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(146, 43);
            this.BtnCalc.TabIndex = 6;
            this.BtnCalc.Text = "Calcular";
            this.BtnCalc.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblResult.Location = new System.Drawing.Point(51, 310);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(85, 19);
            this.LblResult.TabIndex = 7;
            this.LblResult.Text = "Resultado: ";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(209, 306);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(146, 23);
            this.TxtResult.TabIndex = 8;
            // 
            // LblTasaInteres
            // 
            this.LblTasaInteres.AutoSize = true;
            this.LblTasaInteres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTasaInteres.Location = new System.Drawing.Point(51, 149);
            this.LblTasaInteres.Name = "LblTasaInteres";
            this.LblTasaInteres.Size = new System.Drawing.Size(120, 19);
            this.LblTasaInteres.TabIndex = 9;
            this.LblTasaInteres.Text = "Tasa de interes: ";
            // 
            // TxtTasaInteres
            // 
            this.TxtTasaInteres.Location = new System.Drawing.Point(209, 149);
            this.TxtTasaInteres.Name = "TxtTasaInteres";
            this.TxtTasaInteres.ReadOnly = true;
            this.TxtTasaInteres.Size = new System.Drawing.Size(146, 23);
            this.TxtTasaInteres.TabIndex = 10;
            // 
            // FrmLoanCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 412);
            this.Controls.Add(this.TxtTasaInteres);
            this.Controls.Add(this.LblTasaInteres);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.CbxCuota);
            this.Controls.Add(this.LblCuota);
            this.Controls.Add(this.CbxTipoPrestamo);
            this.Controls.Add(this.LblTipoPrestamo);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.LblMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmLoanCalc";
            this.Text = "Loan Calculator";
            this.Load += new System.EventHandler(this.FrmLoanCalc_Load);
            this.Click += new System.EventHandler(this.FrmLoanCalc_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label LblTipoPrestamo;
        private System.Windows.Forms.ComboBox CbxTipoPrestamo;
        private System.Windows.Forms.Label LblCuota;
        private System.Windows.Forms.ComboBox CbxCuota;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label LblTasaInteres;
        private System.Windows.Forms.TextBox TxtTasaInteres;
    }
}

