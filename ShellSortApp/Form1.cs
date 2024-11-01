namespace ShellSortApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Name = "labelInput";
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Ingrese los números (separados por comas):";
            // 
            // txtInput
            // 
            this.txtInput.Name = "txtInput";
            this.txtInput.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Name = "btnSort";
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Ordenar";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Números ordenados:";
            // 
            // txtOutput
            // 
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.TabIndex = 4;
        }
        private void btnSort_Click(object? sender, EventArgs e)
        {

            // Lee la entrada del TextBox
            string input = txtInput.Text.Trim();

            // Verifica si la entrada está vacía
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Por favor, ingrese números separados por comas.");
                return; // Sale del método si está vacío
            }

            // Usa una expresión regular para validar que solo contenga números y comas en el formato correcto
            bool isValidInput = System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+(,\d+)*$");

            if (!isValidInput)
            {
                MessageBox.Show("Por favor, ingrese solo números válidos separados por comas.");
                return; // Sale del método si la entrada no es válida
            }

            try
            {
                // Convertir la cadena de entrada en un arreglo de números
                int[] numbers = input.Split(',').Select(int.Parse).ToArray();

                // Llama al método de ordenamiento
                var sortedNumbers = ShellSort(numbers);

                // Muestra el resultado en el TextBox de salida
                txtOutput.Text = string.Join(", ", sortedNumbers);
            }
            catch (Exception ex)
            {
                // Captura cualquier error en el proceso y muestra un mensaje
                MessageBox.Show($"Ocurrió un error al procesar los números: {ex.Message}");
            }
        }
        private int[] ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;
                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }
                gap /= 2;
            }

            return array;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;  // Limpia el campo de entrada
            txtOutput.Text = string.Empty; // Limpia el campo de salida
        }
    }
}    
