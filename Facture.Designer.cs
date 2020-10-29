using System;

namespace WFA_exo_002
{
    partial class Facture
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labName = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labAmount = new System.Windows.Forms.Label();
            this.labZipCode = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.infoDate = new System.Windows.Forms.Label();
            this.infoMoney = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(68, 61);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(29, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Nom";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(68, 95);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(30, 13);
            this.labDate.TabIndex = 1;
            this.labDate.Text = "Date";
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(68, 126);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(46, 13);
            this.labAmount.TabIndex = 2;
            this.labAmount.Text = "Montant";
            // 
            // labZipCode
            // 
            this.labZipCode.AutoSize = true;
            this.labZipCode.Location = new System.Drawing.Point(68, 158);
            this.labZipCode.Name = "labZipCode";
            this.labZipCode.Size = new System.Drawing.Size(64, 13);
            this.labZipCode.TabIndex = 3;
            this.labZipCode.Text = "Code Postal";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(143, 90);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(127, 20);
            this.tbDate.TabIndex = 5;
            this.tbDate.TextChanged += new System.EventHandler(this.tbDate_TextChanged);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(143, 122);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(74, 20);
            this.tbAmount.TabIndex = 6;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(143, 154);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(74, 20);
            this.tbZipCode.TabIndex = 7;
            this.tbZipCode.TextChanged += new System.EventHandler(this.tbZipCode_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(331, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // infoDate
            // 
            this.infoDate.AutoSize = true;
            this.infoDate.Location = new System.Drawing.Point(284, 94);
            this.infoDate.Name = "infoDate";
            this.infoDate.Size = new System.Drawing.Size(79, 13);
            this.infoDate.TabIndex = 10;
            this.infoDate.Text = "DD/MM/AAAA";
            // 
            // infoMoney
            // 
            this.infoMoney.AutoSize = true;
            this.infoMoney.Location = new System.Drawing.Point(231, 127);
            this.infoMoney.Name = "infoMoney";
            this.infoMoney.Size = new System.Drawing.Size(13, 13);
            this.infoMoney.TabIndex = 11;
            this.infoMoney.Text = "€";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(331, 202);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Valider";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(119, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(271, 31);
            this.labTitle.TabIndex = 13;
            this.labTitle.Text = "Saisie d\'une facture";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.infoMoney);
            this.Controls.Add(this.infoDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labZipCode);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labName);
            this.Name = "Facture";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labZipCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.Label infoDate;
        private System.Windows.Forms.Label infoMoney;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

