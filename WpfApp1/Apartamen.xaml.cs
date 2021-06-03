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
    /// Логика взаимодействия для Apartamen.xaml
    /// </summary>
    public partial class Apartamen : Page
    {

        string connectionString;
        SqlDataAdapter adapter;
        DataTable Apartment;

        public Apartamen()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Def"].ConnectionString;
        }
        private void duuuuud(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Apartment";
            SqlConnection connection = null;
            Apartment = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);


                connection.Open();
                adapter.Fill(Apartment);
                Dud.SelectedItem = Apartment.DefaultView;

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

        private void BtnEdit3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
