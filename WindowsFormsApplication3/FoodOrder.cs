using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FoodOrder : Form
    {
        public FoodOrder()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Food Selection

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu gà nầm tươi");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 550000));
                listView1.Items.Add(item);

            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu gà đen");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 700000));
                listView1.Items.Add(item);

            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu cua đồng bắp bò, sườn sụn");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 550000));
                listView1.Items.Add(item);

            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu cá lăng");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 550000));
                listView1.Items.Add(item);

            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu đuôi bò");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 500000));
                listView1.Items.Add(item);

            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu ba ba om chuối đậu");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 900000));
                listView1.Items.Add(item);

            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu vịt măng cay");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 400000));
                listView1.Items.Add(item);

            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu cháo chim câu");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 600000));
                listView1.Items.Add(item);

            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu sườn");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 500000));
                listView1.Items.Add(item);

            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu thập cẩm chua cay");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 700000));
                listView1.Items.Add(item);

            }

            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu cá chép");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 500000));
                listView1.Items.Add(item);

            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu cá quả");
                item.SubItems.Add("");
                item.SubItems.Add("400000");
                listView1.Items.Add(item);

            }


            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu bỏ nhúng dấm");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 500000));
                listView1.Items.Add(item);

            }

            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Lẩu chim rừng");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 800000));
                listView1.Items.Add(item);

            }

            //Drink Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Rượu gạo");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 30000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Rượu ngô");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 40000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Rượu chuối hột");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 50000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Rượu táo mèo");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 50000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bia");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 15000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Nước lọc");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 10000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Nước ngọt");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 10000;
                string dCost = string.Format("{0:#,##0}", cost);
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }

            //Topping Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ngô chiên");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 40000));
                listView1.Items.Add(item);

            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Khoai chiên");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 40000));
                listView1.Items.Add(item);

            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bánh mì chiên");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 30000));
                listView1.Items.Add(item);

            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bánh banh chiên");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 30000));
                listView1.Items.Add(item);

            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Nộm chân gà rút xương");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 40000));
                listView1.Items.Add(item);

            }


            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Nộm hoa chuối");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 40000));
                listView1.Items.Add(item);

            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Salad củ quả");
                item.SubItems.Add("");
                item.SubItems.Add(string.Format("{0:#,##0}", 70000));
                listView1.Items.Add(item);

            }


            double total = 0;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            hst = total * 0.1;
            totaldue = hst + total;

            /*string hstDisplay = hst.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");*/

            string hstDisplay = string.Format("{0:#,##0}", hst);
            string totalDisplay = string.Format("{0:#,##0}", totaldue);
            string amount = string.Format("{0:#,##0}", total);

            textBox8.Text = amount;
            textBox9.Text = hstDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;

            button8.Enabled = false;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Checkout order
            if (textBox11.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các trường bắt buộc (*)");
            }

            else
            {
                string money = textBox19.Text;
                char[] vnd = { 'đ' };
                string paymoney = money.TrimStart(vnd);
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox21.Text = string.Format("{0:#,##0}", change);

                if (change < 0)
                {
                    MessageBox.Show("Vui lòng nhập số tiền thanh toán");

                }

                else
                {
                    button8.Enabled = true;
                }


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Complete Payment
            DialogResult dialog = MessageBox.Show("Cảm ơn quý khách đã đặt món. Món ăn của quý khách sẽ được mang tới trong vòng 30 phút!", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                //Clearing all data
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

                listView1.Items.Clear();
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

                textBox11.Text = "";
                textBox13.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                comboBox2.Text = "";

                tabControl1.SelectTab("tabPage1");
            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Payment Method
            if (comboBox2.Text == "Tiền mặt")
            {

            }
        }
    }
} 
//cpfn
