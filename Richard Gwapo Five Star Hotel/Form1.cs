using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richard_Gwapo_Five_Star_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckOutbutton_Click(object sender, EventArgs e)
        {
            DateTime In = Convert.ToDateTime(INdateTimePicker.Text);
            DateTime Out = Convert.ToDateTime(OUTdateTimePicker.Text);
            if (Out > In)
            {
                NoOfDaysTextBox.Text = Out.Subtract(In).Days.ToString();
            }
            else if (Out == In)
            {
                this.NoOfDaysTextBox.Text = "1";
                int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                NoOfDaysTextBox.Text = NoOfDays.ToString();
            }
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            if (RegularRadioButton.Checked)
            {
                if (String.IsNullOrEmpty(RoomCapacityComboBox.Text))
                {
                    MessageBox.Show("Please select a room capacity", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (RoomCapacityComboBox.SelectedItem.ToString() == "Single")
                    {
                        this.TotalAmountTextBox.Text = "100";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                    else if (RoomCapacityComboBox.SelectedItem.ToString() == "Double")
                    {
                        this.TotalAmountTextBox.Text = "200";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                    else if (RoomCapacityComboBox.SelectedItem.ToString() == "Family")
                    {
                        this.TotalAmountTextBox.Text = "500";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                }
            }
            else if (DeLuxeRadioButton.Checked)
            {
                if (String.IsNullOrEmpty(RoomCapacityComboBox.Text))
                {
                    MessageBox.Show("Please select a room capacity", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (RoomCapacityComboBox.SelectedItem.ToString() == "Single")
                    {
                        this.TotalAmountTextBox.Text = "300";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                    else if (RoomCapacityComboBox.SelectedItem.ToString() == "Double")
                    {
                        this.TotalAmountTextBox.Text = "500";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                    else if (RoomCapacityComboBox.SelectedItem.ToString() == "Family")
                    {
                        this.TotalAmountTextBox.Text = "750";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                }
            }
            else if (SuiteRadioButton.Checked)
            {
                if (String.IsNullOrEmpty(RoomCapacityComboBox.Text))
                {
                    MessageBox.Show("Please select a room capacity ", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (RoomCapacityComboBox.SelectedItem.ToString() == "Single")
                    {
                        this.TotalAmountTextBox.Text = "500";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                    else if (RoomCapacityComboBox.SelectedItem.ToString() == "Double")
                    {
                        this.TotalAmountTextBox.Text = "800";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                    else if (RoomCapacityComboBox.SelectedItem.ToString() == "Family")
                    {
                        this.TotalAmountTextBox.Text = "1000";
                        int NoOfDays = Convert.ToInt16(NoOfDaysTextBox.Text);
                        int rate = Convert.ToInt16(TotalAmountTextBox.Text);
                        int amount = rate * NoOfDays;
                        TotalAmountTextBox.Text = amount.ToString();

                        if (String.IsNullOrEmpty(TypeOfPaymentListBox.Text))
                        {
                            MessageBox.Show("Please select a type of payment", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (TypeOfPaymentListBox.SelectedItem.ToString() == "Check")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.05);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Credit Card")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + (totalamount * 0.10);
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                            else if (TypeOfPaymentListBox.SelectedItem.ToString() == "Cash")
                            {
                                double totalamount = Convert.ToDouble(TotalAmountTextBox.Text);
                                double charge = totalamount + 0;
                                TotalAmountTextBox.Text = charge.ToString("C");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room type", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SuiteRadioButton.Checked = false;
            DeLuxeRadioButton.Checked = false;
            RegularRadioButton.Checked = false;
            RoomCapacityComboBox.ResetText();
            TypeOfPaymentListBox.SelectedItem = null;
            INdateTimePicker.CustomFormat = "";
            OUTdateTimePicker.CustomFormat = "";
            NoOfDaysTextBox.Clear();
            TotalAmountTextBox.Clear();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
