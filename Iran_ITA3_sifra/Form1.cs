using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iran_ITA3_sifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sifra_Click(object sender, EventArgs e)
        {
            char[] sifra = vstup.Text.ToCharArray();
            int celkem = sifra.GetLength(0);
            string vys = "";

            string rot3 = Convert.ToString(rot.Text);

            try
            {
                int rot2 = Convert.ToInt32(rot.Text);

                for (int i = 0; i < celkem; i++)
                {
                    int x = 0;
                    if (sifra[i] >= 'a' && sifra[i] <= 'm')
                    {
                        x = 1;
                    }
                    else if (sifra[i] >= 'n' && sifra[i] <= 'z')
                    {
                        x = 2;
                    }
                    else if (sifra[i] >= 'A' && sifra[i] <= 'M')
                    {
                        x = 1;
                    }
                    else if (sifra[i] >= 'N' && sifra[i] <= 'Z')
                    {
                        x = 2;
                    }

                    switch (x)
                    {
                        case 1:
                            {
                                sifra[i] = (char)((int)sifra[i] + rot2);
                                break;
                            }
                        case 2:
                            {
                                if (sifra[i] > 122)
                                {
                                    sifra[i] = (char)((int)sifra[i] - 26);
                                }

                                sifra[i] = (char)((int)sifra[i] - rot2);
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }

                    vys += sifra[i];
                }

                MessageBox.Show(vys, "Výsledek", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Zadej hodnoty!", "Error");
            }
        }

        private void desifrovat_Click(object sender, EventArgs e)
        {
            char[] sifra = vstup.Text.ToCharArray();
            int celkem = sifra.GetLength(0);
            string vys = "";

            string rot3 = Convert.ToString(rot.Text);

            try
            {
                int rot2 = 26 - Convert.ToInt32(rot.Text);

                for (int i = 0; i < celkem; i++)
                {
                    int x = 0;
                    if (sifra[i] >= 'a' && sifra[i] <= 'm')
                    {
                        x = 1;
                    }
                    else if (sifra[i] >= 'n' && sifra[i] <= 'z')
                    {
                        x = 2;
                    }
                    else if (sifra[i] >= 'A' && sifra[i] <= 'M')
                    {
                        x = 1;
                    }
                    else if (sifra[i] >= 'N' && sifra[i] <= 'Z')
                    {
                        x = 2;
                    }

                    switch (x)
                    {
                        case 1:
                            {
                                sifra[i] = (char)((int)sifra[i] + rot2);
                                break;
                            }
                        case 2:
                            {
                                if (sifra[i] > 122)
                                {
                                    sifra[i] = (char)((int)sifra[i] - 26);
                                }

                                sifra[i] = (char)((int)sifra[i] - rot2);
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }

                    vys += sifra[i];
                }

                MessageBox.Show(vys, "Výsledek", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Zadej hodnoty!", "Error");
            }
        }
    }
}