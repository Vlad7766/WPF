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

namespace WpfApp1
{
    class Point
    {
        delegate double Force(double t);
        delegate double Resist(double v, double c, double alpha);
        delegate double Acceleration(Force F, Resist R, double t, double v);
        void push(double x, double y, double z) { this.x.Add(x); this.y.Add(y); this.z.Add(z); return; }
        Force Fx = t => { return 0; };
        Force Fy = t => { return 0; };
        Force Fz = t => { return -9.8; };
        Resist R = (v, c, alpha) => { return c * Math.Pow(v, alpha); };
        List<double> x;
        List<double> y;
        List<double> z;
        double vx;
        double vy;
        double vz;
        double wx = 0;
        double wy = 0;
        double wz = 0;
        double mass;
        // R = c/mass*v^alpha
        double c;
        double alpha;
        double dt;
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
