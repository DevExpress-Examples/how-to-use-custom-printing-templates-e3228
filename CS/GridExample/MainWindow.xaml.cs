using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Windows.Resources;
using System.IO;
using System.Drawing;
using System.Windows.Data;
using DevExpress.Xpf.Printing;


namespace GridExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            grid.ItemsSource = new List<TestData>() {
                new TestData() { PlainText = "Mercedes-Benz SLK", MemoText = "LMA AG \n2004 \nSilver", BooleanMember = true, Image = GetImage("/Images/1.jpg"), Price = 25 },
                new TestData() { PlainText = "Rolls-Royce Corniche", MemoText ="Western Motors \n1975 \nSnowy whight", BooleanMember = false, Image = GetImage("/Images/2.jpg"), Price = 15 },
                new TestData() { PlainText = "Ford Ranger FX-4", MemoText = "Sun car rent\n1999 \nRed rock", BooleanMember = true, Image = GetImage("/Images/3.jpg"), Price = 20 }
            };
        }

        ImageSource GetImage(string path) {
            return new BitmapImage(new Uri(path, UriKind.Relative));
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e) {
            view.ShowPrintPreview(this);
        }
    }
}
