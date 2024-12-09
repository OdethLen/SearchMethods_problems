

using System.Xml.Linq;

namespace Search_method_problems
{
    public partial class Form3 : Form
    {
        Random random;
        int[] Numbers;
        int element;
        public Form3()
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


            dgvSorted.ColumnCount = 2;
            dgvSorted.Columns[0].Name = "Index";
            dgvSorted.Columns[1].Name = "Number";

            dgvSorted.ReadOnly = true;
            dgvSorted.AllowUserToAddRows = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generar números aleatorios y llenar el arreglo
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = random.Next(1, 10);
            }
            txtNumbers.Text = string.Join(",", Numbers);

            dgvSearch.Rows.Clear(); 
            for (int i = 0; i < Numbers.Length; i++)
            {
                dgvSearch.Rows.Add(i, Numbers[i]);
            }




            Array.Sort(Numbers);
            dgvSorted.Rows.Clear(); 
            for (int i = 0; i < Numbers.Length; i++) 
            { 
                dgvSorted.Rows.Add(i, Numbers[i]); 
            }
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
           
                if (!int.TryParse(txtSearch.Text, out element))
                {
                    MessageBox.Show("Please enter a valid number to search.");
                    return;
                }

                // Ordenar el arreglo antes de la búsqueda binaria
                Array.Sort(Numbers);
                dgvSorted.Rows.Clear();
                for (int i = 0; i < Numbers.Length; i++)
                {
                    dgvSorted.Rows.Add(i, Numbers[i]);
                    // Restaurar el color de fondo por defecto
                    dgvSorted.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }

                int left = 0;
                int right = Numbers.Length - 1;
                bool found = false;

                while (left <= right)
                {
                    int mid = (left + right) / 2;

                    // Restaurar el color de fondo por defecto en todas las filas
                    for (int i = 0; i < Numbers.Length; i++)
                    {
                        dgvSorted.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }

                    // Resaltar la fila actual en rosa claro
                    dgvSorted.Rows[mid].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;

                    // Agregar un pequeño retraso para visualizar los cambios (opcional)
                    System.Threading.Thread.Sleep(500);
                    Application.DoEvents();

                    if (Numbers[mid] == element)
                    {
                        found = true;
                        dgvSorted.Rows[mid].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                    else if (Numbers[mid] < element)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Element not found.");
                return;
                }
            






        }
    }
}
