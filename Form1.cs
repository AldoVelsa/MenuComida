using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menucomida
{
    public partial class Form1 : Form
    {
        string[] baseDescripcion ;
        string[] toppingDescripcion ;
        string[] proteinasDescripcion ;
        string[] crujientesDescripcion;
        string[] aderesoDescripcion;
        int baseTotal = 0;
        bool bAse = false;
        int toppingTotal = 0;
        bool topping = false;
        int proteinasTotal = 0;
        bool proteinas = false;
        int crujienteTotal = 0;
        bool crujiente = false;
        int aderesoTotal = 0;
        bool adereso = false;
        public Form1()
        {
            InitializeComponent();
        }
        //base para que tu sepas que estas activando
        private void chbxArroz_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxArroz.CheckState == CheckState.Checked)
            {
                baseTotal++;

                //baseDescripcion[] = " Arroz";
            }
            else if (chbxArroz.ThreeState == false)
            {
                baseTotal--;
            }
        }

        private void chbxTallarines_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxTallarines.CheckState == CheckState.Checked)
            {
                baseTotal++;

                //baseDescripcion[] = " Tallarines ";
            }
            else if (chbxTallarines.ThreeState == false)
            {
                baseTotal--;
            }
        }

        private void chbxFideos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxFideos.CheckState == CheckState.Checked)
            {
                baseTotal++;

                //baseDescripcion[] = " Fideos";
            }
            else if (chbxFideos.ThreeState == false)
            {
                baseTotal--;
            }
        }

        private void chbxLechuga_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxLechuga.CheckState == CheckState.Checked)
            {
                baseTotal++;

                //baseDescripcion[] = " lechuga ";
            }
            else if (chbxLechuga.ThreeState == false)
            {
                baseTotal--;
            }
        }
        //toppings
        private void chbxMango_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMango.CheckState == CheckState.Checked)
            {
                toppingTotal++;

                //toppingDescripcion[] = " Mango ";
            }
            else if (chbxMango.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxDurazno_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDurazno.CheckState == CheckState.Checked)
            {
                toppingTotal++;

                //toppingDescripcion[] = " Durazno ";
            }
            else if (chbxDurazno.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxTomate.CheckState == CheckState.Checked)
            {
                toppingTotal++;

                //toppingDescripcion[] = " Tomate ";
            }
            else if (chbxTomate.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxChampinones_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxChampinones.CheckState == CheckState.Checked)
            {
                toppingTotal++;

                //toppingDescripcion[] = " Champinones ";
            }
            else if (chbxChampinones.ThreeState == false)
            {
                toppingTotal--;
            }
        }
        //PROTEINAS
        private void chbxPollo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxPollo.CheckState == CheckState.Checked)
            {
                proteinasTotal++;

                //proteinaDescripcion[] = " Pollo ";
            }
            else if (chbxPollo.ThreeState == false)
            {
                proteinasTotal--;
            }
        }

        private void chbxCerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCerdo.CheckState == CheckState.Checked)
            {
                proteinasTotal++;

                //proteinasDescripcion[] = " Cerdo ";
            }
            else if (chbxCerdo.ThreeState == false)
            {
                proteinasTotal--;
            }
        }

        private void chbxRolloPrimavera_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxRolloprimavera.CheckState == CheckState.Checked)
            {
                proteinasTotal++;

                //proteinasDescripcion[] = " Rollo primavera ";
            }
            else if (chbxRolloprimavera.ThreeState == false)
            {
                proteinasTotal--;
            }
        }
        private void chbxSurimi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSurimi.CheckState == CheckState.Checked)
            {
                proteinasTotal++;

                //proteinasDescripcion[] = " Surimi ";
            }
            else if (chbxSurimi.ThreeState == false)
            {
                proteinasTotal--;
            }
        }
        //CRUJIENTES
        private void chbxArandanos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxArandanos.CheckState == CheckState.Checked)
            {
                crujienteTotal++;

                //crujienteDescripcion[] = " Arandanos";
            }
            else if (chbxArandanos.ThreeState == false)
            {
                crujienteTotal--;
            }
        }

        private void chbxAmaranto_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAmaranto.CheckState == CheckState.Checked)
            {
                crujienteTotal++;

                //crujienteDescripcion[] = " Amaranto ";
            }
            else if (chbxAmaranto.ThreeState == false)
            {
                crujienteTotal--;
            }
        }
        private void chbxCacahuate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCacahuate.CheckState == CheckState.Checked)
            {
                crujienteTotal++;

                //crujienteDescripcion[] = " Cacahuate";
            }
            else if (chbxCacahuate.ThreeState == false)
            {
                crujienteTotal--;
            }
        }
        private void chbxSemillagirasol_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSemillagirasol.CheckState == CheckState.Checked)
            {
                crujienteTotal++;

                //crujienteDescripcion[] = " Semillagirasol ";
            }
            else if (chbxSemillagirasol.ThreeState == false)
            {
                crujienteTotal--;
            }
        }

       //ADEREZOS

        private void aderezohke_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAderezohke.CheckState == CheckState.Checked)
            {
                aderesoTotal++;

                //aderesoDescripcion[] = " Aderezohke";
            }
            else if (chbxAderezohke.ThreeState == false)
            {
                aderesoTotal--;
            }
        }
        private void chbxAgridulce_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAgridulce.CheckState == CheckState.Checked)
            {
                aderesoTotal++;

                //aderesoDescripcion[] = " Agridulce";
            }
            else if (chbxAgridulce.ThreeState == false)
            {
                aderesoTotal--;
            }
        }

        private void chbxSoya_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSoya.CheckState == CheckState.Checked)
            {
                aderesoTotal++;

                //aderesoDescripcion[] = " Soya ";
            }
            else if (chbxSoya.ThreeState == false)
            {
                aderesoTotal--;
            }
        }

        private void chbxAderMango_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAderMango.CheckState == CheckState.Checked)
            {
                aderesoTotal++;

                //aderesoDescripcion[] = " AderMango ";
            }
            else if (chbxAderMango.ThreeState == false)
            {
                aderesoTotal--;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //BASE
            if (baseTotal == 1)
            {
                avisoBase.Text = "Base OK";
                bAse = true;
            }
            else if (baseTotal == 0)
            {
                avisoBase.Text = " elige una base";
            }
            else
            {
                avisoBase.Text = " elige solo una base";
            }
            //Topping
            if (toppingTotal >= 1 && toppingTotal <= 3)
            {

                avisoTopping.Text = "topping OK";
                topping = true;
            }
            else if (toppingTotal == 0)
            {
                avisoTopping.Text = " elige un topping";

            }
            else
            {
                avisoTopping.Text = " elige hasta 3 toppings ";

            }
            //PROTEINA
            if (proteinasTotal >= 1 && proteinasTotal <= 2)
            {

                avisoProteina.Text = "Proteina OK";
                proteinas = true;
            }
            else if (proteinasTotal == 0)
            {
                avisoProteina.Text = " elige por lo menos 1 proteina ";

            }
            else
            {
                avisoProteina.Text = " elige hasta 2 proteinas";

            }
            //Crujientes
            if (crujienteTotal >= 1 && crujienteTotal <= 2)
            {

                avisoCrujientes.Text = "Crujiente OK";
                crujiente = true;
            }
            else if (crujienteTotal == 0)
            {
                avisoCrujientes.Text = " elige por lo menos 1 crujiente ";

            }
            else
            {
                avisoCrujientes.Text = " elige hasta 2 crujientes ";

            }
            //Aderesos
            if (aderesoTotal >= 1 && aderesoTotal <= 2)
            {

                avisoAdereso.Text = " Adereso OK ";
                adereso = true;
            }
            else if (aderesoTotal == 0)
            {
               avisoAdereso.Text = " elige por lo menos 1 Adereso ";

            }
            else
            {
                avisoAdereso.Text = " elige hasta 2 proteinas";

            }
            if (bAse == true && topping == true )  
            {
                if(proteinas == true && crujiente == true)
                {
                    if(adereso == true)
                    {
                        MessageBox.Show("Tu orden será generada");
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("Revisa tu orden");
            }
        }
    }
}
