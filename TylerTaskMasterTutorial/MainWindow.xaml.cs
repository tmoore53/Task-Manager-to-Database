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
using TylerTaskMasterTutorial.Model;

namespace TylerTaskMasterTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private taskMngDBContext tmContext;


        public MainWindow()
        {
            InitializeComponent();

            tmContext = new taskMngDBContext();

            var statuses = tmContext.Statuses.ToList();

            foreach (Status s in statuses)
            {
                comBoxStatus.Items.Add(s);
            }
        }

        private void btnCreateTask_Click(object sender, RoutedEventArgs e)
        {
            if (comBoxStatus.SelectedItem != null && TxtTask.Text != string.Empty)
            {
                var newTask = new Model.Task { 
                Name = TxtTask.Text,
                StatusId = (comBoxStatus.SelectedItem as Model.Status).Id,
                DueDate = datePicker1.SelectedDate
                };

                //Add it(task) to the tmContext instance

                tmContext.Tasks.Add(newTask);

                //Looks for pending changes and updates database with contents
                tmContext.SaveChanges();
            }
            else
                MessageBox.Show("Please describe the Task and Select the status.");
        }
    }
}
