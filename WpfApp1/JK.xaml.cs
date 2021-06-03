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
    /// Логика взаимодействия для JK.xaml
    /// </summary>
    public partial class JK : Page
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable ResidentialComplex;

        public JK()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Def"].ConnectionString;
        }
        private void duuuuuud(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM ResidentialComplex";
            SqlConnection connection = null;
            ResidentialComplex = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                

                connection.Open();
                adapter.Fill(ResidentialComplex);
                Duud.SelectedItem = ResidentialComplex.DefaultView;

            }
            catch(Exception ex)
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
