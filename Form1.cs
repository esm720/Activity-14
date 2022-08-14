using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillButton.Checked = true;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            TriangleOutImage.Visible = false;
            TriangleFillImage.Visible = false;
            SquareOutImage.Visible = false;
            SquareFillImage.Visible = false;
            PentagonOutImage.Visible = false;
            PentagonFillImage.Visible = false;
            SidesLabel.Text = " ";
            NamesLabel.Text = " ";

            if (ShapeListBox.SelectedItems.Count != -1) {
                string selectedShape = ShapeListBox.SelectedItem.ToString();

                if (selectedShape.Equals("Triangle"))
                {
                    if (FillButton.Checked)
                    {
                        TriangleFillImage.Visible = true;
                    }
                    else if (OutlineButton.Checked)
                    {
                        TriangleFillImage.Visible = false;
                        TriangleOutImage.Visible = true;
                    }

                    if (SidesCheckbox.Checked)
                    {
                        SidesLabel.Text = "Three Sides";
                    }
                    if (NamesCheckbox.Checked)
                    {
                        NamesLabel.Text = "Triangle";
                    }

                }

                if (selectedShape.Equals("Square"))
                {
                    if (FillButton.Checked)
                    {
                        SquareFillImage.Visible = true;
                    }
                    else if (OutlineButton.Checked)
                    {
                        SquareFillImage.Visible = false;
                        SquareOutImage.Visible = true;
                    }

                    if (SidesCheckbox.Checked)
                    {
                        SidesLabel.Text = "Four Sides";
                    }
                    if (NamesCheckbox.Checked)
                    {
                        NamesLabel.Text = "Square";
                    }

                }

                if (selectedShape.Equals("Pentagon"))
                {
                    if (FillButton.Checked)
                    {
                        PentagonFillImage.Visible = true;
                    }
                    else if (OutlineButton.Checked)
                    {
                        PentagonFillImage.Visible = false;
                        PentagonOutImage.Visible = true;
                    }

                    if (SidesCheckbox.Checked)
                    {
                        SidesLabel.Text = "Five Sides";
                    }
                    if (NamesCheckbox.Checked)
                    {
                        NamesLabel.Text = "Pentagon";
                    }

                }

                }
            else {
                MessageBox.Show("Select a Shape");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
