using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Invercion : Form
    {
        public Invercion()
        {
            InitializeComponent();
        }

        private void Invercion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte fila;
            byte columna;
            double b, aux;
            double IngI,Ing, Egr,Egre,Ingr, Ut,h,g,imp;

            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite un ingreso inicial");
                maskedTextBox1.Focus();
            }
            else if (comboBox1.Text == " ")
            {
                MessageBox.Show("No se aceptan espacios, digite un plazo");
                comboBox1.Focus();
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite su salario mensual");
                maskedTextBox2.Focus();
            }else if (maskedTextBox3.Text=="")
            {
                MessageBox.Show("No se aceptan espacios, digite su Egreso mensual");
                maskedTextBox3.Focus();
            }
            else
            {
                if (comboBox1.Text == "1 - 3 Años")
                {
                    IngI = Convert.ToDouble(maskedTextBox1.Text);
                    Ing = Convert.ToDouble(maskedTextBox2.Text);
                    Egr = Convert.ToDouble(maskedTextBox3.Text);
                    if (IngI < 100 || IngI > 25000)
                    {
                        MessageBox.Show("Rango entre 100 A 25000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                    else
                    {


                        if (Egr > Ing)
                        {
                            MessageBox.Show("El Egreso no puede ser mayor al Ingreso");
                            maskedTextBox3.Focus();
                        }
                        else
                        {
                            fila = 6; columna = 4;
                            Ingr = Ing * 12;
                            Egre = Egr * 12;
                            data.ColumnCount = columna;
                            data.RowCount = fila;

                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                data[i, 0].Value = "Año " + (i);
                            }
                            data[0, 1].Value = IngI;



                            for (int i = 1; i < data.ColumnCount; i++)
                            {
                                data[i, 2].Value = Ingr;
                                Ingr = (Ingr * 0.10) + Ingr;
                            }

                            for (int n = 1; n < data.ColumnCount; n++)
                            {
                                data[n, 3].Value = Egre;
                                Egre = (Egre * 0.10) + Egre;

                            }
                            h = Ing * 12;
                            g = Egr * 12;
                            for (int l = 1; l < data.ColumnCount; l++)
                            {
                                Ut = h - g;
                                data[l, 4].Value = Ut;
                                h = (h * 0.10) + h;
                                g = (g * 0.10) + g;


                            }
                            h = Ing * 12;
                            g = Egr * 12;
                            for (int m = 1; m < data.ColumnCount; m++)
                            {

                                Ut = h - g;
                                h = (h * 0.10) + h;
                                g = (g * 0.10) + g;
                                imp = Ut * 0.30;
                                data[m, 5].Value = imp;

                            }
                        }
                    }
                }else if(comboBox1.Text=="4 - 10 Años")
                {
                    IngI = Convert.ToDouble(maskedTextBox1.Text);
                    Ing = Convert.ToDouble(maskedTextBox2.Text);
                    Egr = Convert.ToDouble(maskedTextBox3.Text);
                    if (IngI < 100 || IngI > 25000)
                    {
                        MessageBox.Show("Rango entre 100 A 25000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                    else
                    {
                        if (Egr > Ing)
                        {
                            MessageBox.Show("El Egreso no puede ser mayor al Ingreso");
                            maskedTextBox3.Focus();
                        }
                        else
                        {
                            fila = 6; columna = 11;
                            Ingr = Ing * 12;
                            Egre = Egr * 12;
                            data.ColumnCount = columna;
                            data.RowCount = fila;

                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                data[i, 0].Value = "Año " + (i);
                            }
                            data[0, 1].Value = IngI;



                            for (int i = 1; i < data.ColumnCount; i++)
                            {
                                data[i, 2].Value = Ingr;
                                Ingr = (Ingr * 0.10) + Ingr;
                            }

                            for (int n = 1; n < data.ColumnCount; n++)
                            {
                                data[n, 3].Value = Egre;
                                Egre = (Egre * 0.10) + Egre;

                            }
                            h = Ing * 12;
                            g = Egr * 12;
                            for (int l = 1; l < data.ColumnCount; l++)
                            {
                                Ut = h - g;
                                data[l, 4].Value = Ut;
                                h = (h * 0.10) + h;
                                g = (g * 0.10) + g;


                            }
                            h = Ing * 12;
                            g = Egr * 12;
                            for (int m = 1; m < data.ColumnCount; m++)
                            {

                                Ut = h - g;
                                h = (h * 0.10) + h;
                                g = (g * 0.10) + g;
                                imp = Ut * 0.30;
                                data[m, 5].Value = imp;

                            }
                        }
                    }
                }else if(comboBox1.Text=="10  + Años")
                {
                    IngI = Convert.ToDouble(maskedTextBox1.Text);
                    Ing = Convert.ToDouble(maskedTextBox2.Text);
                    Egr = Convert.ToDouble(maskedTextBox3.Text);
                    if (IngI < 100 || IngI > 25000)
                    {
                        MessageBox.Show("Rango entre 100 A 25000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                    else
                    {
                        if (Egr > Ing)
                        {
                            MessageBox.Show("El Egreso no puede ser mayor al Ingreso");
                            maskedTextBox3.Focus();
                        }
                        else
                        {
                            fila = 6; columna = 16;
                            Ingr = Ing * 12;
                            Egre = Egr * 12;
                            data.ColumnCount = columna;
                            data.RowCount = fila;

                            for (int i = 0; i < data.ColumnCount; i++)
                            {
                                data[i, 0].Value = "Año " + (i);
                            }
                            data[0, 1].Value = IngI;



                            for (int i = 1; i < data.ColumnCount; i++)
                            {
                                data[i, 2].Value = Ingr;
                                Ingr = (Ingr * 0.10) + Ingr;
                            }

                            for (int n = 1; n < data.ColumnCount; n++)
                            {
                                data[n, 3].Value = Egre;
                                Egre = (Egre * 0.10) + Egre;

                            }
                            h = Ing * 12;
                            g = Egr * 12;
                            for (int l = 1; l < data.ColumnCount; l++)
                            {
                                Ut = h - g;
                                data[l, 4].Value = Ut;
                                h = (h * 0.10) + h;
                                g = (g * 0.10) + g;
                            }
                            h = Ing * 12;
                            g = Egr * 12;
                            for (int m = 1; m < data.ColumnCount; m++)
                            {

                                Ut = h - g;
                                h = (h * 0.10) + h;
                                g = (g * 0.10) + g;
                                imp = Ut * 0.30;
                                data[m, 5].Value = imp;
                            }
                        }
                    }
                }
                else if (comboBox1.Text != "1 - 3" && comboBox1.Text != "4 - 10" && comboBox1.Text != "10 +")
                {
                    MessageBox.Show("Digite un plazo valido");
                    comboBox1.Text = "";
                    comboBox1.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            comboBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




