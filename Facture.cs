using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CMFacture;
using CLError;
using CLError.ErrorCheckTB;

namespace WFA_exo_002
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private Boolean checkObjName = false;
        private Boolean checkObjDate = false;
        private Boolean checkObjAmount = false;
        private Boolean checkObjZipCode = false;


        private void CheckFacture()
        {
            string validationOutput = "Nom :  " + tbName.Text + "\nDate :   " + tbDate.Text + "\nMontant :   " + tbAmount.Text.ToString() + "\nCP :   " + tbZipCode.Text.ToString();

            SetErrorFacture(tbName);
            SetErrorFacture(tbDate);
            SetErrorFacture(tbAmount);
            SetErrorFacture(tbZipCode);

            if (btnValidate.Enabled)
            {
                MessageBox.Show(validationOutput, "Facture valide");
                ClassMetierFacture classMetierFacture = new ClassMetierFacture(tbName.Text, tbDate.Text, tbAmount.Text, tbZipCode.Text);
                classMetierFacture.ToString();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void DeleteAllFields()
        {
            tbName.Clear();
            tbDate.Clear();
            tbAmount.Clear();
            tbZipCode.Clear();

            errorProvider.SetError(tbName, null);
            errorProvider.SetError(tbDate, null);
            errorProvider.SetError(tbAmount, null);
            errorProvider.SetError(tbZipCode, null);

            btnValidate.Enabled = false;
        }

        /// <summary>
        /// button "Delete" clear text boxes and error icones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAllFields();
        }

        /// <summary>
        /// button "Validate" check all text boxes and error icones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            //rtbErrorProvider.Clear();
            CheckFacture();
        }


        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            SetErrorFacture(tbName);
        }

        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            SetErrorFacture(tbDate);
        }

        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            SetErrorFacture(tbAmount);
        }

        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbZipCode_TextChanged(object sender, EventArgs e)
        {
            SetErrorFacture(tbZipCode);
        }

        /// <summary>
        /// Check all errors
        private void SetErrorFacture(TextBox _tb) // object sender,
        {

            ErrorCheckTB MyErrorCheckTB = new ErrorCheckTB();

            string objName = ((TextBox)_tb).Name;
            //string objValue = ((TextBox) _tb).Text;

            // Index label
            int startIndexLabel = 2;
            String strObjName = objName.Substring(startIndexLabel);

            //btnValidate.Enabled = true;
            btnDelete.Enabled = true;

            if (_tb.Text.Trim().Length == 0)
            {
                errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " est obligatoire.");
                btnDelete.Enabled = false;
                btnValidate.Enabled = false;
                //_tb.Focus();
            }
            else
            {
                errorProvider.SetError(_tb, null);

                if (MyErrorCheckTB.CheckName(_tb, errorProvider) == false)
                {

                }
                    // Champ Name
                    /*if (strObjName == "Name")
                    {
                        if (MyErrorCheckTB.CheckLengthMaxTextBox(tbName, 30)) // CheckLengthMinTextBox(tbName, 2) || 
                        {
                            checkObjName = false;
                            tbName.Focus();
                            errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " nécessite moins de trente caractères.");
                        }
                        else if (MyErrorCheckTB.CheckName(_tb, errorProvider) == false)
                        {
                            checkObjName = false;
                            errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " est incorrect.");
                            _tb.Focus();
                        }
                        else
                        {
                            checkObjName = true;
                        }
                    }*/

                    // Champ Date
                    if (strObjName == "Date")
                {
                    if (MyErrorCheckTB.CheckLengthMinTextBox(tbDate, 10) && MyErrorCheckTB.CheckLengthMaxTextBox(tbDate, 10))
                    {
                        checkObjDate = false;
                        tbDate.Focus();
                        errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " nécessite dix caractères.");
                    }
                    else if (MyErrorCheckTB.CheckDate(_tb, errorProvider) == false)
                    {
                        checkObjDate = false;
                        _tb.Focus();
                        //errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " est incorrect.");
                    }
                    else
                    {
                        checkObjDate = true;
                        //errorProvider.SetError(_tb, null);
                    }
                }

                // Champ Amount
                if (strObjName == "Amount")
                {
                    if (MyErrorCheckTB.CheckLengthMinTextBox(tbAmount, 1))
                    {
                        checkObjAmount = false;
                        tbAmount.Focus();
                        errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " nécessite au moins un caractère.");
                    }
                    else if (MyErrorCheckTB.CheckAmount(_tb, errorProvider) == false)
                    {
                        checkObjAmount = false;
                        _tb.Focus();
                        //errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " est incorrect.");
                    }
                    else
                    {
                        checkObjAmount = true;
                        //errorProvider.SetError(_tb, null);
                    }
                }

                // Champ Zip Code
                if (strObjName == "ZipCode")
                {
                    if (MyErrorCheckTB.CheckLengthMinTextBox(tbZipCode, 2))
                    {
                        checkObjZipCode = false;
                        _tb.Focus();
                        errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " nécessite au moins deux caractères.");
                    }
                    else if (MyErrorCheckTB.CheckZipCode(_tb, errorProvider) == false)
                    {
                        checkObjZipCode = false;
                        _tb.Focus();
                        //errorProvider.SetError(_tb, $@"Le champ " + $"{strObjName}" + " est incorrect.");
                    }
                    else
                    {
                        checkObjZipCode = true;
                        //errorProvider.SetError(_tb, null);
                    }
                }


                /// <summary>
                /// Check all errors at null
                if (checkObjName && (strObjName == "Name"))
                {
                    errorProvider.SetError(_tb, null);
                }
                if (checkObjDate && (strObjName == "Date"))
                {
                    errorProvider.SetError(_tb, null);
                }
                if (checkObjAmount && (strObjName == "Amount"))
                {
                    errorProvider.SetError(_tb, null);
                }
                if (checkObjZipCode && (strObjName == "ZipCode"))
                {
                    errorProvider.SetError(_tb, null);
                }

                //richTextBox1.Text = $"{checkObjName}" + $"{checkObjDate}" + $"{checkObjAmount}" + $"{checkObjZipCode}";
                /// <summary>
                /// Button validate eneable / desable 
                if (checkObjName && checkObjDate && checkObjAmount && checkObjZipCode)
                {
                    btnValidate.Enabled = true;
                }
                else
                {
                    btnValidate.Enabled = false;
                }

            }
        }
    }
}
