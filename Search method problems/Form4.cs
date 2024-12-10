using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_method_problems
{
    public partial class Form4 : Form
    {
        Random random;
        int[] Numbers;
        int element;
        Dictionary<int, int> hashTable;
        public Form4()
        {
            InitializeComponent();
            Numbers = new int[10];
            random = new Random();
            element = 0;
            hashTable = new Dictionary<int, int>();

            dgvSearch.ColumnCount = 2;
            dgvSearch.Columns[0].Name = "Index";
            dgvSearch.Columns[1].Name = "Number";

            dgvSearch.ReadOnly = true;
            dgvSearch.AllowUserToAddRows = false;

            dgvHash.ColumnCount = 2;
            dgvHash.Columns[0].Name = "Key";
            dgvHash.Columns[1].Name = "Index";

            dgvHash.ReadOnly = true;
            dgvHash.AllowUserToAddRows = false;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = random.Next(1, 10);
            }
            txtNumbers.Text = string.Join(",", Numbers);

            // Llenar el DataGridView con índices y valores
            dgvSearch.Rows.Clear(); // Limpiar filas previas
            for (int i = 0; i < Numbers.Length; i++)
            {
                dgvSearch.Rows.Add(i, Numbers[i]);
            }



            // Construir tabla hash
            hashTable.Clear();
            dgvHash.Rows.Clear();
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (!hashTable.ContainsKey(Numbers[i]))
                {
                    hashTable[Numbers[i]] = i; // Guardar el índice del primer elemento
                }
            }

            // Llenar el DataGridView de la tabla hash
            foreach (var kvp in hashTable)
            {
                dgvHash.Rows.Add(kvp.Key, kvp.Value);
            }

        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            // Obtener el número a buscar desde un cuadro de texto
            if (int.TryParse(txtSearch.Text, out element))
            {
                if (hashTable.ContainsKey(element))
                {
                    int index = hashTable[element];
                    MessageBox.Show($"Número {element} encontrado en el índice {index}.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Resaltar la fila en el DataGridView
                    foreach (DataGridViewRow row in dgvSearch.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[1].Value) == element)
                        {
                            row.Selected = true;
                            dgvSearch.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Número {element} no encontrado.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
