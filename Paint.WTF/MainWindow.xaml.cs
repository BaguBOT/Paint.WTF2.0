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
using System.Globalization;
using System.IO;

namespace Paint.WTF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
        }

 

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

     
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
    
        }
        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; //Определяем имя контрола, который покрутили
            double value = slider.Value; // Получаем значение контрола
                                         //В зависимости от выбранного контрола, меняем ту или иную компоненту и переводим ее в тип byte
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }

            //Задаем значение переменной класса clr 
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            //Устанавливаем фон для контрола Label 
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            // Задаем цвет кисти для контрола InkCanvas
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                mcolor.red = Convert.ToByte(0);
                mcolor.green = Convert.ToByte(0);           
                mcolor.blue = Convert.ToByte(255);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(0);
            mcolor.green = Convert.ToByte(128);
            mcolor.blue = Convert.ToByte(0);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(255);
            mcolor.green = Convert.ToByte(0);
            mcolor.blue = Convert.ToByte(0);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(127);
            mcolor.green = Convert.ToByte(127);
            mcolor.blue = Convert.ToByte(127);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(0);
            mcolor.green = Convert.ToByte(0);
            mcolor.blue = Convert.ToByte(0);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(255);
            mcolor.green = Convert.ToByte(127);
            mcolor.blue = Convert.ToByte(39);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(255);
            mcolor.green = Convert.ToByte(242);
            mcolor.blue = Convert.ToByte(0);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(163);
            mcolor.green = Convert.ToByte(73);
            mcolor.blue = Convert.ToByte(164);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(240);
            mcolor.green = Convert.ToByte(240);
            mcolor.blue = Convert.ToByte(240);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(255);
            mcolor.green = Convert.ToByte(174);
            mcolor.blue = Convert.ToByte(201);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(185);
            mcolor.green = Convert.ToByte(122);
            mcolor.blue = Convert.ToByte(87);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(255);
            mcolor.green = Convert.ToByte(201);
            mcolor.blue = Convert.ToByte(14);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(181);
            mcolor.green = Convert.ToByte(230);
            mcolor.blue = Convert.ToByte(29);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(153);
            mcolor.green = Convert.ToByte(217);
            mcolor.blue = Convert.ToByte(234);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(112);
            mcolor.green = Convert.ToByte(146);
            mcolor.blue = Convert.ToByte(190);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            mcolor.red = Convert.ToByte(200);
            mcolor.green = Convert.ToByte(191);
            mcolor.blue = Convert.ToByte(231);
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Width = 5;
            this.inkCanvas1.DefaultDrawingAttributes.Height = 5;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Width = 10;
            this.inkCanvas1.DefaultDrawingAttributes.Height = 10;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Width = 15;
            this.inkCanvas1.DefaultDrawingAttributes.Height = 15;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Width = 20;
            this.inkCanvas1.DefaultDrawingAttributes.Height = 20;
        }



        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.None;
            string imgPath = @"D:\file.png";
            MemoryStream ms = new MemoryStream();
            FileStream fs = new FileStream(imgPath, FileMode.Create);

            //rtb - объект класса RenderTargetBitmap
            RenderTargetBitmap rtb = new RenderTargetBitmap((int)inkCanvas1.Width, (int)inkCanvas1.Height, 96, 96, PixelFormats.Default);
            rtb.Render(inkCanvas1);

            GifBitmapEncoder gifEnc = new GifBitmapEncoder();
            gifEnc.Frames.Add(BitmapFrame.Create(rtb));
            gifEnc.Save(fs);
            fs.Close();
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
            MessageBox.Show("Файл сохранен, " + imgPath); //Для информации
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            //Инициализация контрола tb типа TextBox
            TextBox tb = new TextBox
            {
                Width = 100,
                Height = 50,
                BorderThickness = new Thickness(1),
                BorderBrush = new SolidColorBrush(Color.FromRgb(5, 5, 5)),
                Margin = new Thickness(20, 20, 0, 0)
            };
            //Добавление контрола tb
            this.inkCanvas1.Children.Add(tb);
            //Переключение фокуса на элемент, чтоб можно было сразу ввести текст с клавиатуры
            tb.Focus();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Select;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Width = 5;
            this.inkCanvas1.DefaultDrawingAttributes.Height = 5;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

       
    }
}
