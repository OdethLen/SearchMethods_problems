using System.Windows.Forms.Design;

namespace Search_method_problems
{
    public partial class Form1 : Form
    {
        Random random;
        int[] Numbers;
        int element;
        public Form1()
        {
            InitializeComponent();
            Numbers = new int[10];
            random = new Random();
            element = 0;

            dgvSearch.ColumnCount = 2;
            dgvSearch.Columns[0].Name = "Index";
            dgvSearch.Columns[1].Name = "Number";

            dgvSearch.ReadOnly = true;
            dgvSearch.AllowUserToAddRows = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generar números aleatorios y llenar el arreglo
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
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("You must enter a number to search.");
                return;
            }
            LinearSearch();
        }

        public async void LinearSearch()
        {
            // Obtener el número buscado
            element = Convert.ToInt32(txtSearch.Text);

            // Limpiar colores previos
            ClearCellColors();

            // Recorrer el arreglo y actualizar la tabla
            for (int i = 0; i < Numbers.Length; i++)
            {
                // Pintar la celda actual
                dgvSearch.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                dgvSearch.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                // Esperar un momento para simular el recorrido
                await Task.Delay(500);

                // Verificar si el número fue encontrado
                if (Numbers[i] == element)
                {
                    MessageBox.Show($"The number {Numbers[i]} was found at index {i}.");
                    return;
                }

                // Restaurar color de la celda después de avanzar
                dgvSearch.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgvSearch.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }

            // Si el número no fue encontrado
            MessageBox.Show("The number was not found.");
        }

        private void ClearCellColors()
        {
            foreach (DataGridViewRow row in dgvSearch.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }

}

