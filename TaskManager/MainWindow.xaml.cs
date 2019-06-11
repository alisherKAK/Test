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
using TaskManager.DataAccess;
using TaskManager.Services;
using System.IO;
using System.Threading;

namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Timer> _timers = new List<Timer>();

        public MainWindow()
        {
            InitializeComponent();
            using(var context = new TasksContext())
            {
                context.Tasks.ToList();
                context.SaveChanges();
            }
        }
    }
}
