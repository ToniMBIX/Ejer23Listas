using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ejer23Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isChecked; 
        private string lastSelectedListBoxItem = string.Empty;
        private string lastSelectedComboBoxItem = string.Empty;
        private string lastSelectedCheckedListBoxItem = string.Empty;
        private List<string> selectedCheckedListBoxItems = new List<string>();

        private void UpdateItemCount()
        {
            labelElementosListBox.Text = $"{listBoxLB.Items.Count}";
            labelElementosComboBox.Text = $"{comboBoxCB.Items.Count}";
            labelElementosCheckedListBox.Text = $"{checkedListBoxCLB.Items.Count}";
        }
        private void checkBoxListBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isChecked && checkBoxListBox.Checked)
            {
                isChecked = true;
                checkBoxComboBox.Checked = false;
                checkBoxCheckedListBox.Checked = false;
                isChecked = false;
            }
            else if (!isChecked && !checkBoxListBox.Checked && !checkBoxComboBox.Checked && !checkBoxCheckedListBox.Checked)
            {
                isChecked = true;
                checkBoxListBox.Checked = true;
                isChecked = false;
            }
        }

        private void checkBoxComboBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isChecked && checkBoxComboBox.Checked)
            {
                isChecked = true;
                checkBoxListBox.Checked = false;
                checkBoxCheckedListBox.Checked = false;
                isChecked = false;
            }
            else if (!isChecked && !checkBoxListBox.Checked && !checkBoxComboBox.Checked && !checkBoxCheckedListBox.Checked)
            {
                isChecked = true;
                checkBoxComboBox.Checked = true;
                isChecked = false;
            }
        }

        private void checkBoxCheckedListBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isChecked && checkBoxCheckedListBox.Checked)
            {
                isChecked = true;
                checkBoxListBox.Checked = false;
                checkBoxComboBox.Checked = false;
                isChecked = false;
            }
            else if (!isChecked && !checkBoxListBox.Checked && !checkBoxComboBox.Checked && !checkBoxCheckedListBox.Checked)
            {
                isChecked = true;
                checkBoxCheckedListBox.Checked = true;
                isChecked = false;
            }
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxElemento.Text, out int numItems))
            {
                if (checkBoxCheckedListBox.Checked)
                {
                    checkedListBoxCLB.Items.Clear();
                    for (int i = 0; i < numItems; i++)
                    {
                        checkedListBoxCLB.Items.Add($"Item CLB {i + 1}");
                        UpdateItemCount();
                    }
                }
                else if (checkBoxComboBox.Checked)
                {
                    comboBoxCB.Items.Clear();
                    for (int i = 0; i < numItems; i++)
                    {
                        comboBoxCB.Items.Add($"Item CB {i + 1}");
                        UpdateItemCount();
                    }
                }
                else if (checkBoxListBox.Checked)
                {
                    listBoxLB.Items.Clear();
                    for (int i = 0; i < numItems; i++)
                    {
                        listBoxLB.Items.Add($"Item LB {i + 1}");
                        UpdateItemCount();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido en la TextBox.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxElemento.Text, out int numItems))
            {
                if (checkBoxCheckedListBox.Checked)
                {
                    for (int i = 0; i < numItems && checkedListBoxCLB.Items.Count > 0; i++)
                    {
                        checkedListBoxCLB.Items.RemoveAt(checkedListBoxCLB.Items.Count - 1);
                        UpdateItemCount();
                    }
                }
                else if (checkBoxComboBox.Checked)
                {
                    for (int i = 0; i < numItems && comboBoxCB.Items.Count > 0; i++)
                    {
                        comboBoxCB.Items.RemoveAt(comboBoxCB.Items.Count - 1);
                        UpdateItemCount();
                    }
                }
                else if (checkBoxListBox.Checked)
                {
                    for (int i = 0; i < numItems && listBoxLB.Items.Count > 0; i++)
                    {
                        listBoxLB.Items.RemoveAt(listBoxLB.Items.Count - 1);
                        UpdateItemCount();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido en la TextBox.");
            }
        }
        private void buttonMostrarSeleccion_Click(object sender, EventArgs e)
        {
            textBoxSeleccionUnica.Text = string.Empty;
            textBoxSeleccionUnica.Text = $"{lastSelectedListBoxItem}";
            listBoxMultiseleccion.Items.Clear();
            listBoxMultiseleccion.Items.Add(lastSelectedComboBoxItem);
            foreach (string item in selectedCheckedListBoxItems)
            {
                listBoxMultiseleccion.Items.Add(item);
            }

        }

        private void listBoxLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastSelectedListBoxItem = listBoxLB.SelectedItem.ToString();
        }

        private void comboBoxCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastSelectedComboBoxItem = comboBoxCB.SelectedItem.ToString();
        }

        private void checkedListBoxCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastSelectedCheckedListBoxItem = checkedListBoxCLB.SelectedItem.ToString();
        }
    
        private void checkedListBoxCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBoxCLB.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked && !selectedCheckedListBoxItems.Contains(item))
            {
                selectedCheckedListBoxItems.Add(item);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                selectedCheckedListBoxItems.Remove(item);
            }
        }
    }
}
