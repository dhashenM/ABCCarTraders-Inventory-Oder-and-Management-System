using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData4.car_parts' table. You can move, or remove it, as needed.
            this.car_partsTableAdapter.Fill(this.appData4.car_parts);
            // TODO: This line of code loads data into the 'appData3.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.appData3.car);
            // TODO: This line of code loads data into the 'appData2.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter1.Fill(this.appData2.order);
            // TODO: This line of code loads data into the 'aBCCarTradersDataSet1.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.aBCCarTradersDataSet1.order);
            // TODO: This line of code loads data into the 'appData.user' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.appData.user);
            // TODO: This line of code loads data into the 'aBCCarTradersDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.aBCCarTradersDataSet.user);

        }

        private void gcr_b_Click(object sender, EventArgs e)
        {
            //Code used to export data from the SQL database table into an Excel document
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData.user.CopyToDataTable(), "Users");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("The User Report has been successfully generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to generate the User Report!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData2.order.CopyToDataTable(), "Orders");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("The Order Report has been successfully generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to generate the Order Report!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData3.car.CopyToDataTable(), "Cars");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("The Car Inventory Report has been successfully generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to generate the Car Inventory Report!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData4.car_parts.CopyToDataTable(), "Car Parts");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("The Car Part Inventory Report has been successfully generated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to generate the Car Part Inventory Report!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void admin_hp_b_Click(object sender, EventArgs e)
        {
            AdminF ah = new AdminF();
            ah.Show();
            this.Hide();
        }
    }
}
