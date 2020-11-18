
namespace WF_P1_2
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
            this.TekstBoks_Fornavn = new System.Windows.Forms.TextBox();
            this.Label_KontaktFormular = new System.Windows.Forms.Label();
            this.Label_Fornavn = new System.Windows.Forms.Label();
            this.Label_Efternavn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TekstBoks_Efternavn = new System.Windows.Forms.TextBox();
            this.Label_TfN = new System.Windows.Forms.Label();
            this.TekstBoks_TfN = new System.Windows.Forms.TextBox();
            this.Knap_VisListe = new System.Windows.Forms.Button();
            this.Knap_Tilfoj = new System.Windows.Forms.Button();
            this.Knap_Fjern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TekstBoks_Fornavn
            // 
            this.TekstBoks_Fornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstBoks_Fornavn.Location = new System.Drawing.Point(37, 174);
            this.TekstBoks_Fornavn.Name = "TekstBoks_Fornavn";
            this.TekstBoks_Fornavn.Size = new System.Drawing.Size(302, 26);
            this.TekstBoks_Fornavn.TabIndex = 0;
            this.TekstBoks_Fornavn.TextChanged += new System.EventHandler(this.TekstBoks_Fornavn_TextChanged);
            // 
            // Label_KontaktFormular
            // 
            this.Label_KontaktFormular.AutoSize = true;
            this.Label_KontaktFormular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_KontaktFormular.Location = new System.Drawing.Point(32, 34);
            this.Label_KontaktFormular.Name = "Label_KontaktFormular";
            this.Label_KontaktFormular.Size = new System.Drawing.Size(196, 29);
            this.Label_KontaktFormular.TabIndex = 1;
            this.Label_KontaktFormular.Text = "Kontakt Formular";
            this.Label_KontaktFormular.Click += new System.EventHandler(this.Label_KontaktFormular_Click);
            // 
            // Label_Fornavn
            // 
            this.Label_Fornavn.AutoSize = true;
            this.Label_Fornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Fornavn.Location = new System.Drawing.Point(33, 147);
            this.Label_Fornavn.Name = "Label_Fornavn";
            this.Label_Fornavn.Size = new System.Drawing.Size(80, 24);
            this.Label_Fornavn.TabIndex = 2;
            this.Label_Fornavn.Text = "Fornavn";
            this.Label_Fornavn.Click += new System.EventHandler(this.Label_Fornavn_Click);
            // 
            // Label_Efternavn
            // 
            this.Label_Efternavn.AutoSize = true;
            this.Label_Efternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Efternavn.Location = new System.Drawing.Point(399, 147);
            this.Label_Efternavn.Name = "Label_Efternavn";
            this.Label_Efternavn.Size = new System.Drawing.Size(89, 24);
            this.Label_Efternavn.TabIndex = 3;
            this.Label_Efternavn.Text = "Efternavn";
            this.Label_Efternavn.Click += new System.EventHandler(this.Label_Efternavn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // TekstBoks_Efternavn
            // 
            this.TekstBoks_Efternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstBoks_Efternavn.Location = new System.Drawing.Point(403, 174);
            this.TekstBoks_Efternavn.Name = "TekstBoks_Efternavn";
            this.TekstBoks_Efternavn.Size = new System.Drawing.Size(302, 26);
            this.TekstBoks_Efternavn.TabIndex = 5;
            this.TekstBoks_Efternavn.TextChanged += new System.EventHandler(this.TekstBoks_Efternavn_TextChanged);
            // 
            // Label_TfN
            // 
            this.Label_TfN.AutoSize = true;
            this.Label_TfN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TfN.Location = new System.Drawing.Point(33, 213);
            this.Label_TfN.Name = "Label_TfN";
            this.Label_TfN.Size = new System.Drawing.Size(157, 24);
            this.Label_TfN.TabIndex = 6;
            this.Label_TfN.Text = "Tellefon Nummer";
            this.Label_TfN.Click += new System.EventHandler(this.Label_TfN_Click);
            // 
            // TekstBoks_TfN
            // 
            this.TekstBoks_TfN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekstBoks_TfN.Location = new System.Drawing.Point(37, 240);
            this.TekstBoks_TfN.Name = "TekstBoks_TfN";
            this.TekstBoks_TfN.Size = new System.Drawing.Size(302, 26);
            this.TekstBoks_TfN.TabIndex = 7;
            this.TekstBoks_TfN.TextChanged += new System.EventHandler(this.TekstBoks_TfN_TextChanged);
            // 
            // Knap_VisListe
            // 
            this.Knap_VisListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knap_VisListe.Location = new System.Drawing.Point(501, 321);
            this.Knap_VisListe.Name = "Knap_VisListe";
            this.Knap_VisListe.Size = new System.Drawing.Size(107, 43);
            this.Knap_VisListe.TabIndex = 8;
            this.Knap_VisListe.Text = "Vis Liste";
            this.Knap_VisListe.UseVisualStyleBackColor = true;
            this.Knap_VisListe.Click += new System.EventHandler(this.Knap_VisListe_Click);
            // 
            // Knap_Tilfoj
            // 
            this.Knap_Tilfoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knap_Tilfoj.Location = new System.Drawing.Point(57, 321);
            this.Knap_Tilfoj.Name = "Knap_Tilfoj";
            this.Knap_Tilfoj.Size = new System.Drawing.Size(109, 43);
            this.Knap_Tilfoj.TabIndex = 9;
            this.Knap_Tilfoj.Text = "Tilfoj";
            this.Knap_Tilfoj.UseVisualStyleBackColor = true;
            this.Knap_Tilfoj.Click += new System.EventHandler(this.Knap_Tilfoj_Click);
            // 
            // Knap_Fjern
            // 
            this.Knap_Fjern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knap_Fjern.Location = new System.Drawing.Point(206, 321);
            this.Knap_Fjern.Name = "Knap_Fjern";
            this.Knap_Fjern.Size = new System.Drawing.Size(98, 43);
            this.Knap_Fjern.TabIndex = 10;
            this.Knap_Fjern.Text = "Fjern";
            this.Knap_Fjern.UseVisualStyleBackColor = true;
            this.Knap_Fjern.Click += new System.EventHandler(this.Knap_Fjern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Knap_Fjern);
            this.Controls.Add(this.Knap_Tilfoj);
            this.Controls.Add(this.Knap_VisListe);
            this.Controls.Add(this.TekstBoks_TfN);
            this.Controls.Add(this.Label_TfN);
            this.Controls.Add(this.TekstBoks_Efternavn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Efternavn);
            this.Controls.Add(this.Label_Fornavn);
            this.Controls.Add(this.Label_KontaktFormular);
            this.Controls.Add(this.TekstBoks_Fornavn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TekstBoks_Fornavn;
        private System.Windows.Forms.Label Label_KontaktFormular;
        private System.Windows.Forms.Label Label_Fornavn;
        private System.Windows.Forms.Label Label_Efternavn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TekstBoks_Efternavn;
        private System.Windows.Forms.Label Label_TfN;
        private System.Windows.Forms.TextBox TekstBoks_TfN;
        private System.Windows.Forms.Button Knap_VisListe;
        private System.Windows.Forms.Button Knap_Tilfoj;
        private System.Windows.Forms.Button Knap_Fjern;
    }
}

