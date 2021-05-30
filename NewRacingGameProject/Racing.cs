using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewRacingGameProject
{
    public partial class Racing : Form
    {
        //instances of the classes which can be use to call the function 
        public runner obj = new runner();
        
        Plyers plyers = new Plyers();

        int playerNo = 0,henNo=0;


        public Racing()
        {
            InitializeComponent();
            MessageBox.Show("Please Select the Bet Amount According to the Rules");
            plyers.miller = 50;
            plyers.david = 50;
            plyers.joe = 50;
            plyers.garry = 50;
            Start_Running_button.Hide();
        }

        private void set_bet_button_Click(object sender, EventArgs e)
        {
            //here we need to check the details of the server 
          //  try {
                switch (playerNo)
                {
                    case 1:
                        // here we need to set the plyer details 
                        if (amount.SelectedIndex >= 0) {
                            if (plyers.miller >= Convert.ToInt32(amount.SelectedItem.ToString()) && henNo > 0)
                            {
                                lblMiller.Text = "Miller want to choose " + henNo + " with the amount " + amount.SelectedItem;
                                Start_Running_button.Show();

                                selected_gary.Checked = false;
                                selected_joe.Checked = false;
                                selected_david.Checked = false;
                                Selected_miller.Checked = false;

                                hen1_selc.Checked = false; hen2_selec.Checked = false; hen3_selec.Checked = false; hen4_selec.Checked = false;
                                amount.Text = "";
                            henNo = 0;
                            playerNo = 0;

                        }
                        else
                            {
                                MessageBox.Show("You don't have Enough Balance or need to select the Hen ");
                            }

                        }

                        break;
                    case 2:
                        // here we need to set the plyer details 
                        if (amount.SelectedIndex>=0)
                          {

                            if (plyers.david >= Convert.ToInt32(amount.SelectedItem.ToString()) && henNo > 0)
                            {
                                lblDavid.Text = "David want to choose " + henNo + " with the amount " + amount.SelectedItem;
                                Start_Running_button.Show();

                                selected_gary.Checked = false;
                                selected_joe.Checked = false;
                                selected_david.Checked = false;
                                Selected_miller.Checked = false;

                                hen1_selc.Checked = false; hen2_selec.Checked = false; hen3_selec.Checked = false; hen4_selec.Checked = false;
                                amount.Text = "";
                            henNo = 0;
                            playerNo = 0;

                        }
                        else
                            {
                                MessageBox.Show("You don't have Enough Balance or need to select the Hen ");
                            }
                        }
                       


                        break;
                    case 3:
                        // here we need to set the plyer details 
                        if (amount.SelectedIndex>=0) {
                            if (plyers.joe >= Convert.ToInt32(amount.SelectedItem.ToString()) && henNo > 0)
                            {
                                lblJoe.Text = "Joe want to choose " + henNo + " with the amount " + amount.SelectedItem;
                                Start_Running_button.Show();

                                selected_gary.Checked = false;
                                selected_joe.Checked = false;
                                selected_david.Checked = false;
                                Selected_miller.Checked = false;

                                hen1_selc.Checked = false; hen2_selec.Checked = false; hen3_selec.Checked = false; hen4_selec.Checked = false;
                                amount.Text = "";
                            henNo = 0;
                            playerNo = 0;

                        }
                        else
                            {
                                MessageBox.Show("You don't have Enough Balance or need to select the Hen ");
                            }
                        }
                       

                        break;
                    case 4:
                        // here we need to set the plyer details 
                        if (amount.SelectedIndex>=0) {
                            if (plyers.garry >= Convert.ToInt32(amount.SelectedItem.ToString()) && henNo > 0)
                            {
                                lblGary.Text = "Garry want to choose " + henNo + " with the amount " + amount.SelectedItem;
                                Start_Running_button.Show();

                                selected_gary.Checked = false;
                                selected_joe.Checked = false;
                                selected_david.Checked = false;
                                Selected_miller.Checked = false;

                                hen1_selc.Checked = false; hen2_selec.Checked = false; hen3_selec.Checked = false; hen4_selec.Checked = false;
                                amount.Text = "";
                            henNo = 0;
                            playerNo = 0;

                        }
                        else
                            {
                                MessageBox.Show("You don't have Enough Balance  or need to select the Hen");
                            }

                        }

                        break;
                    default:
                        MessageBox.Show("You need to follow the Instructions ");
                        break;
                }

         /*   }
            catch (Exception ex) {
                MessageBox.Show("You need to follow the Rules ");
            }*/
            
        }

        //use the concept of the nested class to crete the working concept 
        public class runner {
            Random rd = new Random();
            public int jumpHen() {
                return rd.Next(1, 50);
            }

            public int checkWinner(String data,int winner,int budget) {
                String[] h = data.Split(' ');
                if (Convert.ToInt32(h[4]) == winner)
                {
                    return budget+Convert.ToInt32(h[8]) ;

                }
                else {
                    return budget-Convert.ToInt32(h[8]);
                }

            }
        }

        private void selected_david_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which plyer interested in the bet 
            if (selected_david.Checked == true)
            {
                playerNo = 2;
                Selected_miller.Checked = false;
                selected_joe.Checked = false;
                selected_gary.Checked = false;
            }

        }

        private void selected_joe_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which plyer interested in the bet 
            if (selected_joe.Checked == true)
            {
                playerNo = 3;
                Selected_miller.Checked = false;
                selected_david.Checked = false;
                selected_gary.Checked = false;
            }
        }

        private void selected_gary_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which plyer interested in the bet 
            if (selected_gary.Checked == true)
            {
                playerNo = 4;
                Selected_miller.Checked = false;
                selected_joe.Checked = false;
                selected_david.Checked = false;
            }
        }

        private void hen1_selc_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which hen is selected for the bet 
            if (hen1_selc.Checked == true)
            {
                henNo = 1;
                hen2_selec.Checked = false;
                hen3_selec.Checked = false;
                hen4_selec.Checked = false;
            }
        }

        private void hen2_selec_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which hen is selected for the bet 
            if (hen2_selec.Checked == true)
            {
                henNo = 2;
                hen1_selc.Checked = false;
                hen3_selec.Checked = false;
                hen4_selec.Checked = false;
            }
        }

        private void hen3_selec_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which hen is selected for the bet 
            if (hen3_selec.Checked == true)
            {
                henNo = 3;
                hen1_selc.Checked = false;
                hen2_selec.Checked = false;
                hen4_selec.Checked = false;
            }
        }

        private void hen4_selec_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which hen is selected for the bet 
            if(hen4_selec.Checked == true)
            {
                henNo = 4;
                hen1_selc.Checked = false;
                hen2_selec.Checked = false;
                hen3_selec.Checked = false;
            }
        }

        private void Start_Running_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // here we need to perform the code to execute the working process 
            pbHen1.Left += obj.jumpHen();
            pbHen2.Left += obj.jumpHen();
            pbHen3.Left += obj.jumpHen();
            pbHen4.Left += obj.jumpHen();
            if (pbHen1.Left > 800) {
                timer1.Stop();
                MessageBox.Show("Hen No 1 reach his house First");
                if (lblMiller.Text.Contains("amount"))
                {
                    plyers.miller = obj.checkWinner(lblMiller.Text,1,plyers.miller);
                    lblMiller.Text = "Miller has $" + plyers.miller + " with his ";
                }
                if (lblDavid.Text.Contains("amount"))
                {
                    plyers.david = obj.checkWinner(lblDavid.Text, 1, plyers.david);
                    lblDavid.Text = "David has $" + plyers.david+ " with his ";
                }

                if (lblJoe.Text.Contains("amount"))
                {
                    plyers.joe= obj.checkWinner(lblJoe.Text, 1, plyers.joe);
                    lblJoe.Text = "Joe has $" + plyers.joe + " with his ";
                }
                if (lblGary.Text.Contains("amount"))
                {
                    plyers.garry=obj.checkWinner(lblGary.Text, 1, plyers.garry);
                    lblGary.Text = "Garry has $" + plyers.garry + " with his ";
                }
                
                pbHen1.Left = 0; pbHen2.Left = 0; pbHen3.Left = 0; pbHen4.Left = 0;
                playerNo = 0;
                henNo = 0;
                hen4_selec.Checked = false;hen3_selec.Checked = false;hen2_selec.Checked = false;hen1_selc.Checked = false;
                Selected_miller.Checked = false;selected_david.Checked = false;selected_gary.Checked = false;selected_joe.Checked = false;
                amount.Text = "";
                Start_Running_button.Hide();


            }
            if (pbHen2.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Hen No 2 reach his house First");
                if (lblMiller.Text.Contains("amount"))
                {
                    plyers.miller = obj.checkWinner(lblMiller.Text, 2, plyers.miller);
                    lblMiller.Text = "Miller has $" + plyers.miller + " with his ";
                }
                if (lblDavid.Text.Contains("amount"))
                {
                    plyers.david = obj.checkWinner(lblDavid.Text, 2, plyers.david);
                    lblDavid.Text = "David has $" + plyers.david + " with his ";
                }

                if (lblJoe.Text.Contains("amount"))
                {
                    plyers.joe = obj.checkWinner(lblJoe.Text, 2, plyers.joe);
                    lblJoe.Text = "Joe has $" + plyers.joe + " with his ";
                }
                if (lblGary.Text.Contains("amount"))
                {
                    plyers.garry = obj.checkWinner(lblGary.Text, 2, plyers.garry);
                    lblGary.Text = "Garry has $" + plyers.garry + " with his ";
                }

                pbHen1.Left = 0; pbHen2.Left = 0; pbHen3.Left = 0; pbHen4.Left = 0;
                playerNo = 0;
                henNo = 0;
                hen4_selec.Checked = false; hen3_selec.Checked = false; hen2_selec.Checked = false; hen1_selc.Checked = false;
                Selected_miller.Checked = false; selected_david.Checked = false; selected_gary.Checked = false; selected_joe.Checked = false;
                amount.Text = "";
                Start_Running_button.Hide();


            }
            if (pbHen3.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Hen No 3 reach his house First");

                if (lblMiller.Text.Contains("amount"))
                {
                    plyers.miller = obj.checkWinner(lblMiller.Text, 3, plyers.miller);
                    lblMiller.Text = "Miller has $" + plyers.miller + " with his ";
                }
                if (lblDavid.Text.Contains("amount"))
                {
                    plyers.david = obj.checkWinner(lblDavid.Text, 3, plyers.david);
                    lblDavid.Text = "David has $" + plyers.david + " with his ";
                }

                if (lblJoe.Text.Contains("amount"))
                {
                    plyers.joe = obj.checkWinner(lblJoe.Text, 3, plyers.joe);
                    lblJoe.Text = "Joe has $" + plyers.joe + " with his ";
                }
                if (lblGary.Text.Contains("amount"))
                {
                    plyers.garry = obj.checkWinner(lblGary.Text, 3, plyers.garry);
                    lblGary.Text = "Garry has $" + plyers.garry + " with his ";
                }

                pbHen1.Left = 0; pbHen2.Left = 0; pbHen3.Left = 0; pbHen4.Left = 0;
                playerNo = 0;
                henNo = 0;
                hen4_selec.Checked = false; hen3_selec.Checked = false; hen2_selec.Checked = false; hen1_selc.Checked = false;
                Selected_miller.Checked = false; selected_david.Checked = false; selected_gary.Checked = false; selected_joe.Checked = false;
                amount.Text = "";
                Start_Running_button.Hide();


            }
            if (pbHen4.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Hen No 4 reach his house First");
                if (lblMiller.Text.Contains("amount"))
                {
                    plyers.miller = obj.checkWinner(lblMiller.Text, 4, plyers.miller);
                    lblMiller.Text = "Miller has $" + plyers.miller + " with his ";
                }
                if (lblDavid.Text.Contains("amount"))
                {
                    plyers.david = obj.checkWinner(lblDavid.Text, 4, plyers.david);
                    lblDavid.Text = "David has $" + plyers.david + " with his ";
                }

                if (lblJoe.Text.Contains("amount"))
                {
                    plyers.joe = obj.checkWinner(lblJoe.Text, 4, plyers.joe);
                    lblJoe.Text = "Joe has $" + plyers.joe + " with his ";
                }
                if (lblGary.Text.Contains("amount"))
                {
                    plyers.garry = obj.checkWinner(lblGary.Text, 4, plyers.garry);
                    lblGary.Text = "Garry has $" + plyers.garry + " with his ";
                }

                pbHen1.Left = 0; pbHen2.Left = 0; pbHen3.Left = 0; pbHen4.Left = 0;
                playerNo = 0;
                henNo = 0;
                hen4_selec.Checked = false; hen3_selec.Checked = false; hen2_selec.Checked = false; hen1_selc.Checked = false;
                Selected_miller.Checked = false; selected_david.Checked = false; selected_gary.Checked = false; selected_joe.Checked = false;
                amount.Text = "";
                Start_Running_button.Hide();


            }

        }

        private void exit_Game_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Racing_Load(object sender, EventArgs e)
        {

        }

        private void Selected_miller_CheckedChanged(object sender, EventArgs e)
        {
            //here i need to varify that which plyer interested in the bet 
            if (Selected_miller.Checked==true) {
                playerNo = 1;
                selected_david.Checked = false;
                selected_joe.Checked = false;
                selected_gary.Checked = false;
            }

        }
    }
}
