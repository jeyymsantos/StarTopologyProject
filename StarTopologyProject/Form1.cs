using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarTopologyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] comp = {"", "OFF", "OFF", "OFF", "OFF", "OFF", "OFF", "OFF", "OFF", "OFF", "OFF" }; // 6

        private void setComputer(int comp_no)
        {
            if (all_switch.Checked)
            {
                if (comp[comp_no] == "OFF")
                {
                    comp[comp_no] = "ON";
                }
                else
                {
                    comp[comp_no] = "OFF";
                }
            }
            
        }
        private void validate(Guna2CircleButton comp_switch, int comp_no, Guna2PictureBox picture, Guna2ToggleSwitch net_toggle, Guna2CircleButton sw_net)
        {

            if (all_switch.Checked)
            {
                if (sw_toggle.Checked)
                {
                    if (comp[comp_no] == "ON")
                    {
                        // Check Network & Switch if On
                        if (net_toggle.Checked)
                        {
                            picture.Image = Properties.Resources.ALL_ON;
                            sw_net.FillColor = Color.Green;
                            //panel.BackColor = Color.Green;
                        }

                        // If Not, Turn Off Both
                        else
                        {
                            picture.Image = Properties.Resources.NETWORK_OFF;
                            sw_net.FillColor = Color.Red;
                            //panel.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        picture.Image = Properties.Resources.ALL_OFF;
                        sw_net.FillColor = Color.Red;
                        //panel.BackColor = Color.Red;
                    }
                }
                else
                {
                    if (comp[comp_no] == "OFF")
                    {
                        picture.Image = Properties.Resources.ALL_OFF;
                    }
                    else
                    {
                        picture.Image = Properties.Resources.NETWORK_OFF; 
                    }
                    sw_net.FillColor = Color.Gray;
                    //panel.BackColor = Color.Gray;
                }
            }
            else
            {
                comp[comp_no] = "OFF";
                sw_net.FillColor = Color.Gray;
                picture.Image = Properties.Resources.ALL_OFF;
            }
        }

        private void checker(Guna2ToggleSwitch comp_toggle, Guna2PictureBox picture, Guna2ToggleSwitch net_toggle, Guna2CircleButton sw_net, Panel panel)
        {
            if (all_switch.Checked)
            {
                if (sw_toggle.Checked)
                {
                    if (comp_toggle.Checked)
                    {
                        // Check Network & Switch if On
                        if (net_toggle.Checked)
                        {
                            picture.Image = Properties.Resources.ALL_ON;
                            sw_net.FillColor = Color.Green;
                            panel.BackColor = Color.Green;
                        }

                        // If Not, Turn Off Both
                        else
                        {
                            picture.Image = Properties.Resources.NETWORK_OFF;
                            sw_net.FillColor = Color.Red;
                            panel.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        picture.Image = Properties.Resources.ALL_OFF;
                        sw_net.FillColor = Color.Red;
                        panel.BackColor = Color.Red;
                    }
                }
                else
                {
                    if (comp_toggle.Checked)
                    {
                        picture.Image = Properties.Resources.NETWORK_OFF;
                    }
                    else
                    {
                        picture.Image = Properties.Resources.ALL_OFF;
                    }
                    sw_net.FillColor = Color.Gray;
                    panel.BackColor = Color.Gray;
                }
            }
            else
            {
                sw_net.FillColor = Color.Gray;
                picture.Image = Properties.Resources.ALL_OFF;
            }
        }

        private void comp_toggle_1_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_1_switch, 1, comp_1, net_toggle_1, sw_net_1);
        }

        private void net_toggle_1_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_1_switch, 1, comp_1, net_toggle_1, sw_net_1);
        }

        private void net_toggle_2_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_2_switch, 2, comp_2, net_toggle_2, sw_net_2);
        }

        private void net_toggle_3_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_3_switch, 3, comp_3, net_toggle_3, sw_net_3);
        }


        private void net_toggle_4_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_4_switch, 4, comp_4, net_toggle_4, sw_net_4);
        }


        private void net_toggle_5_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_5_switch, 5, comp_5, net_toggle_5, sw_net_5);
        }

        private void all_switch_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_1_switch, 1, comp_1, net_toggle_1, sw_net_1);
            validate(comp_2_switch, 2, comp_2, net_toggle_2, sw_net_2);
            validate(comp_3_switch, 3, comp_3, net_toggle_3, sw_net_3);
            validate(comp_4_switch, 4, comp_4, net_toggle_4, sw_net_4);
            validate(comp_5_switch, 5, comp_5, net_toggle_5, sw_net_5);

            validate(comp_6_switch, 6, comp_6, net_toggle_6, sw_net_6);
            validate(comp_7_switch, 7, comp_7, net_toggle_7, sw_net_7);
            validate(comp_8_switch, 8, comp_8, net_toggle_8, sw_net_8);
            validate(comp_9_switch, 9, comp_9, net_toggle_9, sw_net_9);
            validate(comp_10_switch, 10, comp_10, net_toggle_10, sw_net_10);
        }

        private void sw_toggle_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_1_switch, 1, comp_1, net_toggle_1, sw_net_1);
            validate(comp_2_switch, 2, comp_2, net_toggle_2, sw_net_2);
            validate(comp_3_switch, 3, comp_3, net_toggle_3, sw_net_3);
            validate(comp_3_switch, 4, comp_4, net_toggle_4, sw_net_4);
            validate(comp_3_switch, 5, comp_5, net_toggle_5, sw_net_5);

            validate(comp_6_switch, 6, comp_6, net_toggle_6, sw_net_6);
            validate(comp_7_switch, 7, comp_7, net_toggle_7, sw_net_7);
            validate(comp_8_switch, 8, comp_8, net_toggle_8, sw_net_8);
            validate(comp_9_switch, 9, comp_9, net_toggle_9, sw_net_9);
            validate(comp_10_switch, 10, comp_10, net_toggle_10, sw_net_10);
        }

        private void comp_1_switch_Click(object sender, EventArgs e)
        {
            setComputer(1);
            validate(comp_1_switch, 1, comp_1, net_toggle_1, sw_net_1);
        }

        private void comp_2_switch_Click(object sender, EventArgs e)
        {
            setComputer(2);
            validate(comp_2_switch, 2, comp_2, net_toggle_2, sw_net_2);
        }

        private void comp_4_switch_Click(object sender, EventArgs e)
        {
            setComputer(4);
            validate(comp_4_switch, 4, comp_4, net_toggle_4, sw_net_4);
        }

        private void comp_3_switch_Click(object sender, EventArgs e)
        {
            setComputer(3);
            validate(comp_3_switch, 3, comp_3, net_toggle_3, sw_net_3);
        
        }

        private void comp_5_Click(object sender, EventArgs e)
        {

        }

        private void comp_5_switch_Click(object sender, EventArgs e)
        {
            setComputer(5);
            validate(comp_5_switch, 5, comp_5, net_toggle_5, sw_net_5);
        }

        private void sw_net_5_Click(object sender, EventArgs e)
        {

        }

        private void net_toggle_6_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_6_switch, 6, comp_6, net_toggle_6, sw_net_6);
        }

        private void net_toggle_7_CheckedChanged(object sender, EventArgs e)
        {           
            validate(comp_7_switch, 7, comp_7, net_toggle_7, sw_net_7);
        }

        private void net_toggle_8_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_8_switch, 8, comp_8, net_toggle_8, sw_net_8);
        }

        private void net_toggle_9_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_9_switch, 9, comp_9, net_toggle_9, sw_net_9);
        }

        private void net_toggle_10_CheckedChanged(object sender, EventArgs e)
        {
            validate(comp_10_switch, 10, comp_10, net_toggle_10, sw_net_10);
        }

        private void comp_10_switch_Click(object sender, EventArgs e)
        {
            setComputer(10);
            validate(comp_10_switch, 10, comp_10, net_toggle_10, sw_net_10);
        }

        private void comp_9_switch_Click(object sender, EventArgs e)
        {
            setComputer(9);
            validate(comp_9_switch, 9, comp_9, net_toggle_9, sw_net_9);
        }

        private void comp_8_switch_Click(object sender, EventArgs e)
        {
            setComputer(8);
            validate(comp_8_switch, 8, comp_8, net_toggle_8, sw_net_8);
        }

        private void comp_7_switch_Click(object sender, EventArgs e)
        {
            setComputer(7);
            validate(comp_7_switch, 7, comp_7, net_toggle_7, sw_net_7);
        }

        private void comp_6_switch_Click(object sender, EventArgs e)
        {
            setComputer(6);
            validate(comp_6_switch, 6, comp_6, net_toggle_6, sw_net_6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
