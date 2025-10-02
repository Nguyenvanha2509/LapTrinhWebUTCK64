using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT13_tr76
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateColor()
        {
            int red = hscRed.Value;
            int green = hscGreen.Value;
            int blue = hscBlue.Value;

            // Cập nhật màu nền cho TextBox
            txtColor.BackColor = Color.FromArgb(red, green, blue);

            // Hiển thị giá trị RGB lên các Label
            label1.Text = $"Red: {red}";
            label2.Text = $"Green: {green}";
            lable3.Text = $"Blue: {blue}";

            // Cập nhật giá trị hiển thị
            lblRedValue.Text = red.ToString();
            lblGreenValue.Text = green.ToString();
            lblBlueValue.Text = blue.ToString();
        }

        private void hscGreen_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hscRed_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hscBlue_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }
    }
}
