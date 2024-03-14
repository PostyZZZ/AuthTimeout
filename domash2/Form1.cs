using Npgsql;
using System.Data;

namespace domash2
{
    public partial class Form1 : Form
    {
        private int attempts = 0;
        private DateTime lastAttemptTime = DateTime.MinValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (attempts >= 3 && (DateTime.Now - lastAttemptTime).TotalSeconds < 20)
            {
                MessageBox.Show("Слишком много попыток. Попробуйте снова через 20 секунд.");
                return;
            }


            String username = logintext.Text;
            String passUser = passwordtext.Text;

            Database db = new Database();
            DataTable table = new DataTable();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT \"username\", \"password\" FROM public.\"users\" WHERE \"username\" = @Username AND \"password\" = @passUser", db.GetConnection());
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@passUser", passUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                attempts = 0;
                Form2 form2 = new Form2();
                form2.labelUsername.Text = username; 
                form2.Show();
                this.Hide();
            }
            else
            {
                attempts++;
                lastAttemptTime = DateTime.Now;
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
