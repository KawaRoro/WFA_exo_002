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
//using CLError;
//using CLError.ErrorCheckTB;
using CLVerification;

namespace WFA_exo_002
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }


        private void CheckFacture()
        {
            string validationOutput = "Nom :  " + tbName.Text + "\nDate :   " + tbDate.Text + "\nMontant :   " + tbAmount.Text.ToString() + "\nCP :   " + tbZipCode.Text.ToString();

            if ((Verification.CheckName(tbName.Text) == "") & (Verification.CheckDate(tbDate.Text) == "") & (Verification.CheckAmount(tbAmount.Text) == "") & (Verification.CheckZipCode(tbZipCode.Text) == ""))
            {
                //if (btnValidate.Enabled)
                //{
                    CultureInfo myCIintl = new CultureInfo("fr-FR", false);
                    
                    //Boolean tbNameExact = string.TryParse(tbName.Text, out string resultNameExactValue);
                    Boolean tbDateExact = DateTime.TryParseExact(tbDate.Text, "dd/MM/yyyy", myCIintl, DateTimeStyles.None, out DateTime resultDateExactValue);
                    Boolean tbAmountExact = double.TryParse(tbAmount.Text, out double resultAmountExactValue);
                    Boolean tbZipCodeExact = int.TryParse(tbZipCode.Text, out int resultZipCodeExactValue);

                //DateTime d = DateTime.MinValue;

                //richTextBox1.Text = $"{tbNameExact} {tbDateExact} {tbAmountExact} {tbZipCodeExact}";

                if ((tbName.Text != "") & tbDateExact & tbAmountExact & tbZipCodeExact)
                {
                    MessageBox.Show(validationOutput, "Facture valide");
                    ClassMetierFacture classMetierFacture = new ClassMetierFacture(tbName.Text, resultDateExactValue, resultAmountExactValue, resultZipCodeExactValue); // resultNameExactValue
                    classMetierFacture.ToString();
                    DeleteAllFields();
                }
                else
                {
                    MessageBox.Show(validationOutput, "Une exeption est levée - V1");
                    CheckAllFields();
                    SystemSounds.Beep.Play();
                }

            }
            else
            {
                MessageBox.Show(validationOutput, "Une exeption est levée - V2");
                CheckAllFields();
                //richTextBox1.Text = validationOutput;
                SystemSounds.Beep.Play();
            }
        }

        private void CheckAllFields()
        {
            // Check each field
            if (!(Verification.CheckName(tbName.Text) == ""))
            {
                errorProvider.SetError(tbName, Verification.CheckName(tbName.Text));
                tbName.Focus();
            }
            else
            {
                errorProvider.SetError(tbName, null);
            }
            if (!(Verification.CheckDate(tbDate.Text) == ""))
            {
                errorProvider.SetError(tbDate, Verification.CheckDate(tbDate.Text));
                tbDate.Focus();
            }
            else
            {
                errorProvider.SetError(tbDate, null);
            }
            if (!(Verification.CheckAmount(tbAmount.Text) == ""))
            {
                errorProvider.SetError(tbAmount, Verification.CheckAmount(tbAmount.Text));
                tbAmount.Focus();
            }
            else
            {
                errorProvider.SetError(tbAmount, null);
            }
            if (!(Verification.CheckZipCode(tbZipCode.Text) == ""))
            {
                errorProvider.SetError(tbZipCode, Verification.CheckZipCode(tbZipCode.Text));
                tbZipCode.Focus();
            }
            else
            {
                errorProvider.SetError(tbZipCode, null);
            }
            // All is checked
            if ((Verification.CheckName(tbName.Text) == "") & (Verification.CheckDate(tbDate.Text) == "") & (Verification.CheckAmount(tbAmount.Text) == "")  & (Verification.CheckZipCode(tbZipCode.Text) == ""))
            {
                btnValidate.Enabled = true;
            }
            else
            {
                btnValidate.Enabled = false;
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
            if( (Verification.CheckName(tbName.Text)=="") & (Verification.CheckDate(tbDate.Text) == "") & (Verification.CheckAmount(tbAmount.Text) == "") & (Verification.CheckZipCode(tbZipCode.Text) == ""))
            {
                CheckFacture();
            }
            else
            {
                CheckAllFields();
                SystemSounds.Beep.Play();
            }
            //rtbErrorProvider.Clear();
            //CheckFacture();
        }


        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            //SetErrorFacture(tbName);
            if(!(Verification.CheckName(tbName.Text) == ""))
            {
                errorProvider.SetError(tbName, Verification.CheckName(tbName.Text) );
                btnValidate.Enabled = false;
            }
            else
            {
                errorProvider.SetError(tbName, null);
                btnValidate.Enabled = true;
            }
        }

        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            //SetErrorFacture(tbDate);
            if (!(Verification.CheckDate(tbDate.Text) == ""))
            {
                errorProvider.SetError(tbDate, Verification.CheckDate(tbDate.Text));
                btnValidate.Enabled = false;
            }
            else
            {
                errorProvider.SetError(tbDate, null);
                btnValidate.Enabled = true;
            }
        }

        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            //SetErrorFacture(tbAmount);
            if (!(Verification.CheckAmount(tbAmount.Text) == ""))
            {
                errorProvider.SetError(tbAmount, Verification.CheckAmount(tbAmount.Text));
                btnValidate.Enabled = false;
            }
            else
            {
                errorProvider.SetError(tbAmount, null);
                btnValidate.Enabled = true;
            }
        }

        /// <summary>
        /// textBox "TextChanged" check text boxes and error icones
        private void tbZipCode_TextChanged(object sender, EventArgs e)
        {
            //SetErrorFacture(tbZipCode);
            if (!(Verification.CheckZipCode(tbZipCode.Text) == ""))
            {
                errorProvider.SetError(tbZipCode, Verification.CheckZipCode(tbZipCode.Text));
                btnValidate.Enabled = false;
            }
            else
            {
                errorProvider.SetError(tbZipCode, null);
                btnValidate.Enabled = true;
            }
        }

    }
}
