using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для House.xaml
    /// </summary>
    public partial class Houses: Page
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable House;

        public Houses()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Def"].ConnectionString;
        }
        private void duuuuuuud(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM ResidentialComplex";
            SqlConnection connection = null;
            House = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);


                connection.Open();
                adapter.Fill(House);
                Duuud.SelectedItem = House.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }
        private void BtnEdit2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
