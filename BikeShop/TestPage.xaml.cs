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

namespace BikeShop
{
    /// <summary>
    /// TestPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();

            ChildClass c = new ChildClass();
            c.AddMethod();
            c.Car = "";
            c.Money = 0;
            c.Spend();

            BaseClass b = new BaseClass();
            b.Car = "";
            b.money = 0;

           
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Init()
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car()
                {
                    Speed = i * 10,
                    Color = Color.FromRgb((byte)(255/(i+2)), (byte)(255 / (i + 30)), (byte)(255 / (i + 5)))
                }) ;
            }
            this.DataContext = cars; // 여기서 this는 스택패널
        }
    }
}
