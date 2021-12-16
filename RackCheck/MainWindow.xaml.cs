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

namespace RackCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        List<TextBox> rackTextBoxes = new List<TextBox>();

        List<Ellipse> ellipses = new List<Ellipse>();

        int lastOne = -1;

        int currentX = 10;
        int currentY = 10;
        const int MARGIN = 5;
        const int WIDTH = 95;
        bool isRackTextBoxesOnScreen = false;



        public MainWindow()
        {
            InitializeComponent();
            addRackTextBoxesToList();
            addEllipsesToList();
            clearAllForms();
            //RackTextBox1.Focus();

            //makeRackTextBoxes();
            //insertRackTextBoxes();
           
        }

        private void makeRackTextBoxes()
        {
            for (int x = 0; x < 50; x++)
            { 
                TextBox newTextBox = new TextBox();
                newTextBox.Text = $"";
                newTextBox.Name = $"rackTextBox{x}";
                newTextBox.TextWrapping = TextWrapping.NoWrap;
                newTextBox.Width = WIDTH;
                rackTextBoxes.Add(newTextBox);
            }
        }

        private void insertRackTextBoxes()
        {
            if (!isRackTextBoxesOnScreen)
            {
                int i = 0;
                foreach (var item in rackTextBoxes)
                {
                    if (i == 10)
                    {
                        currentX = 10;
                        currentY += 25;
                        i = 0;
                    }
                    
                    Canvas.SetLeft(item, currentX + MARGIN);
                    Canvas.SetTop(item, currentY + MARGIN);
                    MainCanvas.Children.Add(item);
                    currentX += 100;
                    i++;
                }
                isRackTextBoxesOnScreen = true;
            }
        }

        public void addRackTextBoxesToList() // poka guziki
        {
            rackTextBoxes.Add(RackTextBox1);
            rackTextBoxes.Add(RackTextBox2);
            rackTextBoxes.Add(RackTextBox3);
            rackTextBoxes.Add(RackTextBox4);
            rackTextBoxes.Add(RackTextBox5);
            rackTextBoxes.Add(RackTextBox6);
            rackTextBoxes.Add(RackTextBox7);
            rackTextBoxes.Add(RackTextBox8);
            rackTextBoxes.Add(RackTextBox9);
            rackTextBoxes.Add(RackTextBox10);

            rackTextBoxes.Add(RackTextBox11);
            rackTextBoxes.Add(RackTextBox12);
            rackTextBoxes.Add(RackTextBox13);
            rackTextBoxes.Add(RackTextBox14);
            rackTextBoxes.Add(RackTextBox15);
            rackTextBoxes.Add(RackTextBox16);
            rackTextBoxes.Add(RackTextBox17);
            rackTextBoxes.Add(RackTextBox18);
            rackTextBoxes.Add(RackTextBox19);
            rackTextBoxes.Add(RackTextBox20);

            rackTextBoxes.Add(RackTextBox21);
            rackTextBoxes.Add(RackTextBox22);
            rackTextBoxes.Add(RackTextBox23);
            rackTextBoxes.Add(RackTextBox24);
            rackTextBoxes.Add(RackTextBox25);
            rackTextBoxes.Add(RackTextBox26);
            rackTextBoxes.Add(RackTextBox27);
            rackTextBoxes.Add(RackTextBox28);
            rackTextBoxes.Add(RackTextBox29);
            
            rackTextBoxes.Add(RackTextBox30);
            rackTextBoxes.Add(RackTextBox31);
            rackTextBoxes.Add(RackTextBox32);
            rackTextBoxes.Add(RackTextBox33);
            rackTextBoxes.Add(RackTextBox34);
            rackTextBoxes.Add(RackTextBox35);
            rackTextBoxes.Add(RackTextBox36);
            rackTextBoxes.Add(RackTextBox37);
            rackTextBoxes.Add(RackTextBox38);
            rackTextBoxes.Add(RackTextBox39);

            rackTextBoxes.Add(RackTextBox40);
            rackTextBoxes.Add(RackTextBox41);
            rackTextBoxes.Add(RackTextBox42);
            rackTextBoxes.Add(RackTextBox43);
            rackTextBoxes.Add(RackTextBox44);
            rackTextBoxes.Add(RackTextBox45);
            rackTextBoxes.Add(RackTextBox46);
            rackTextBoxes.Add(RackTextBox47);
            rackTextBoxes.Add(RackTextBox48);
            rackTextBoxes.Add(RackTextBox49);
            rackTextBoxes.Add(RackTextBox50);
        }
        public void addEllipsesToList()
        {
            ellipses.Add(Ellipse1);
            ellipses.Add(Ellipse2);
            ellipses.Add(Ellipse3);
            ellipses.Add(Ellipse4);
            ellipses.Add(Ellipse5);
            ellipses.Add(Ellipse6);
            ellipses.Add(Ellipse7);
            ellipses.Add(Ellipse8);
            ellipses.Add(Ellipse9);
            ellipses.Add(Ellipse10);

            ellipses.Add(Ellipse11);
            ellipses.Add(Ellipse12);
            ellipses.Add(Ellipse13);
            ellipses.Add(Ellipse14);
            ellipses.Add(Ellipse15);
            ellipses.Add(Ellipse16);
            ellipses.Add(Ellipse17);
            ellipses.Add(Ellipse18);
            ellipses.Add(Ellipse19);
            ellipses.Add(Ellipse20);

            ellipses.Add(Ellipse21);
            ellipses.Add(Ellipse22);
            ellipses.Add(Ellipse23);
            ellipses.Add(Ellipse24);
            ellipses.Add(Ellipse25);
            ellipses.Add(Ellipse26);
            ellipses.Add(Ellipse27);
            ellipses.Add(Ellipse28);
            ellipses.Add(Ellipse29);
            ellipses.Add(Ellipse30);

            ellipses.Add(Ellipse31);
            ellipses.Add(Ellipse32);
            ellipses.Add(Ellipse33);
            ellipses.Add(Ellipse34);
            ellipses.Add(Ellipse35);
            ellipses.Add(Ellipse36);
            ellipses.Add(Ellipse37);
            ellipses.Add(Ellipse38);
            ellipses.Add(Ellipse39);
            ellipses.Add(Ellipse40);

            ellipses.Add(Ellipse41);
            ellipses.Add(Ellipse42);
            ellipses.Add(Ellipse43);
            ellipses.Add(Ellipse44);
            ellipses.Add(Ellipse45);
            ellipses.Add(Ellipse46);
            ellipses.Add(Ellipse47);
            ellipses.Add(Ellipse48);
            ellipses.Add(Ellipse49);
            ellipses.Add(Ellipse50);
        }
        public void clearAllForms() // poka guziki
        {
   
            foreach (var textBox in rackTextBoxes)
            {
                textBox.Text = "";
                textBox.Background = new SolidColorBrush(Colors.White);
            }
            foreach (var ellipse in ellipses)
            {
                ellipse.Fill = new SolidColorBrush(Colors.White);
            }
            RackTextBox1.Focus();
            int lastOne = -1;
        }

        private void BtClear_Click(object sender, RoutedEventArgs e)
        {
            clearAllForms();
        }

        private void TB_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox txtbx = sender as TextBox;
            /*
            if (txtbx != null)
            {
                txtbx.Text = txtbx.Name;
            }
/*/
            for (int i = 0; i < rackTextBoxes.Count; i++)
            {
                if (rackTextBoxes[i].Text.Length == 10)
                {
                    ellipses[i].Fill = new SolidColorBrush(Colors.LightSeaGreen);
                    rackTextBoxes[i].Background = new SolidColorBrush(Colors.LightSeaGreen);

                    //  warunek dla 50+ popraw ten focus
                    if ((i + 1) < rackTextBoxes.Count)
                    {
                        rackTextBoxes[i + 1].Focus();
                    }
                    else
                    {
                        FindTextBox.Focus();
                    }
                }
                else if ((rackTextBoxes[i].Text.Length > 0) && (rackTextBoxes[i].Text.Length < 10))
                {
                    ellipses[i].Fill = new SolidColorBrush(Colors.Yellow);
                    rackTextBoxes[i].Background = new SolidColorBrush(Colors.LightYellow);
                }
                else if (rackTextBoxes[i].Text.Length > 10)
                {
                    ellipses[i].Fill = new SolidColorBrush(Colors.White);
                    rackTextBoxes[i].Text = "";
                    rackTextBoxes[i].Background = new SolidColorBrush(Colors.White);
                }
            }

        }

        private void FindTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {            
            if (FindTextBox.Text.Length == 10)
            {               
                for (int i = 0; i < 50; i++)
                {
                    if (rackTextBoxes[i].Text.Length == 10)
                    {
                        if (FindTextBox.Text.Substring(0, 9) == rackTextBoxes[i].Text.Substring(0, 9))
                        {
                            ellipses[i].Fill = new SolidColorBrush(Colors.Red);

                            rackTextBoxes[i].Background = new SolidColorBrush(Colors.LightPink);
                            ellipses[i].Fill = new SolidColorBrush(Colors.LightPink);


                            if (lastOne != -1)
                            {
                                rackTextBoxes[lastOne].Background = new SolidColorBrush(Colors.LightGray);
                                ellipses[lastOne].Fill = new SolidColorBrush(Colors.LightGray);
                            }
                            lastOne = i;
                        }
                    }
                }
                FindTextBox.Text = "";
                FindTextBox.Focus();
            }
        }

        private void BtAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ostatnie znaki w barcodach są ignorowane przy porównywaniu.\nWszelkie uwagi zgłaszać na lukasz.kordela@diag.pl");
        }
    }
}


/*
 * <Window x:Class="RackCheck.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:RackCheck"
        mc:Ignorable="d"
        Title="RackCheck" Height="450" Width="1400">

    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="59*"/>
            <ColumnDefinition Width="1342*"/>
        </Grid.ColumnDefinitions>
        <Label Content="X" HorizontalAlignment="Left" Margin="10,10,0,0" VerticalAlignment="Top" FontSize="16"/>
        <Label Content="1" HorizontalAlignment="Left" Margin="22,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="2" HorizontalAlignment="Left" Margin="122,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="3" HorizontalAlignment="Left" Margin="222,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="4" HorizontalAlignment="Left" Margin="322,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="5" HorizontalAlignment="Left" Margin="422,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="6" HorizontalAlignment="Left" Margin="522,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="7" HorizontalAlignment="Left" Margin="622,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="8" HorizontalAlignment="Left" Margin="722,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="9" HorizontalAlignment="Left" Margin="822,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>
        <Label Content="0" HorizontalAlignment="Left" Margin="922,10,0,0" VerticalAlignment="Top" FontSize="16" Grid.Column="1"/>


        <Label Content="A" HorizontalAlignment="Left" Margin="10,40,0,0" VerticalAlignment="Top" FontSize="16"/>
        <Label Content="B" HorizontalAlignment="Left" Margin="10,70,0,0" VerticalAlignment="Top" FontSize="16"/>
        <Label Content="C" HorizontalAlignment="Left" Margin="10,100,0,0" VerticalAlignment="Top" FontSize="16"/>
        <Label Content="D" HorizontalAlignment="Left" Margin="10,130,0,0" VerticalAlignment="Top" FontSize="16"/>
        <Label Content="E" HorizontalAlignment="Left" Margin="10,160,0,0" VerticalAlignment="Top" FontSize="16"/>

        <TextBox x:Name="RackTextBox11" HorizontalAlignment="Left" Margin="40,45,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="95" FontSize="16" TextChanged="TB_TextChanged" Grid.ColumnSpan="2"/>
        <TextBox x:Name="RackTextBox12" HorizontalAlignment="Left" Margin="82,45,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="95" FontSize="16" TextChanged="TB_TextChanged" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox13" HorizontalAlignment="Left" Margin="182,45,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="95" FontSize="16" TextChanged="TB_TextChanged" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox14" HorizontalAlignment="Left" Margin="282,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox15" HorizontalAlignment="Left" Margin="382,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox16" HorizontalAlignment="Left" Margin="482,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox17" HorizontalAlignment="Left" Margin="582,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox18" HorizontalAlignment="Left" Margin="682,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox19" HorizontalAlignment="Left" Margin="782,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox10" HorizontalAlignment="Left" Margin="882,45,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>

        <TextBox x:Name="RackTextBox21" HorizontalAlignment="Left" Margin="40,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.ColumnSpan="2"/>
        <TextBox x:Name="RackTextBox22" HorizontalAlignment="Left" Margin="82,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox23" HorizontalAlignment="Left" Margin="182,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox24" HorizontalAlignment="Left" Margin="282,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox25" HorizontalAlignment="Left" Margin="382,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox26" HorizontalAlignment="Left" Margin="482,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox27" HorizontalAlignment="Left" Margin="582,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox28" HorizontalAlignment="Left" Margin="682,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox29" HorizontalAlignment="Left" Margin="782,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox20" HorizontalAlignment="Left" Margin="882,75,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>

        <TextBox x:Name="RackTextBox31" HorizontalAlignment="Left" Margin="40,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.ColumnSpan="2"/>
        <TextBox x:Name="RackTextBox32" HorizontalAlignment="Left" Margin="82,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox33" HorizontalAlignment="Left" Margin="182,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox34" HorizontalAlignment="Left" Margin="282,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox35" HorizontalAlignment="Left" Margin="382,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox36" HorizontalAlignment="Left" Margin="482,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox37" HorizontalAlignment="Left" Margin="582,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox38" HorizontalAlignment="Left" Margin="682,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox39" HorizontalAlignment="Left" Margin="782,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox30" HorizontalAlignment="Left" Margin="882,105,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>

        <TextBox x:Name="RackTextBox41" HorizontalAlignment="Left" Margin="40,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.ColumnSpan="2"/>
        <TextBox x:Name="RackTextBox42" HorizontalAlignment="Left" Margin="82,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox43" HorizontalAlignment="Left" Margin="182,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox44" HorizontalAlignment="Left" Margin="282,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox45" HorizontalAlignment="Left" Margin="382,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox46" HorizontalAlignment="Left" Margin="482,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox47" HorizontalAlignment="Left" Margin="582,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox48" HorizontalAlignment="Left" Margin="682,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox49" HorizontalAlignment="Left" Margin="782,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox40" HorizontalAlignment="Left" Margin="882,135,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>

        <TextBox x:Name="RackTextBox51" HorizontalAlignment="Left" Margin="40,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.ColumnSpan="2"/>
        <TextBox x:Name="RackTextBox52" HorizontalAlignment="Left" Margin="82,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox53" HorizontalAlignment="Left" Margin="182,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox54" HorizontalAlignment="Left" Margin="282,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox55" HorizontalAlignment="Left" Margin="382,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox56" HorizontalAlignment="Left" Margin="482,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox57" HorizontalAlignment="Left" Margin="582,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox58" HorizontalAlignment="Left" Margin="682,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox59" HorizontalAlignment="Left" Margin="782,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>
        <TextBox x:Name="RackTextBox50" HorizontalAlignment="Left" Margin="882,165,0,0" TextWrapping="Wrap" Text="0123456789" VerticalAlignment="Top" Width="95" FontSize="16" Grid.Column="1"/>



        <Ellipse x:Name="Ellipse11" HorizontalAlignment="Left" Height="15" Margin="992,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse12" HorizontalAlignment="Left" Height="15" Margin="1012,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse13" HorizontalAlignment="Left" Height="15" Margin="1032,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse14" HorizontalAlignment="Left" Height="15" Margin="1052,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse15" HorizontalAlignment="Left" Height="15" Margin="1072,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse16" HorizontalAlignment="Left" Height="15" Margin="1092,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse17" HorizontalAlignment="Left" Height="15" Margin="1112,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse18" HorizontalAlignment="Left" Height="15" Margin="1132,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse19" HorizontalAlignment="Left" Height="15" Margin="1152,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse10" HorizontalAlignment="Left" Height="15" Margin="1172,50,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>

        <Ellipse x:Name="Ellipse21" HorizontalAlignment="Left" Height="15" Margin="992,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse22" HorizontalAlignment="Left" Height="15" Margin="1012,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse23" HorizontalAlignment="Left" Height="15" Margin="1032,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse24" HorizontalAlignment="Left" Height="15" Margin="1052,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse25" HorizontalAlignment="Left" Height="15" Margin="1072,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse26" HorizontalAlignment="Left" Height="15" Margin="1092,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse27" HorizontalAlignment="Left" Height="15" Margin="1112,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse28" HorizontalAlignment="Left" Height="15" Margin="1132,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse29" HorizontalAlignment="Left" Height="15" Margin="1152,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse20" HorizontalAlignment="Left" Height="15" Margin="1172,80,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>

        <Ellipse x:Name="Ellipse31" HorizontalAlignment="Left" Height="15" Margin="992,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse32" HorizontalAlignment="Left" Height="15" Margin="1012,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse33" HorizontalAlignment="Left" Height="15" Margin="1032,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse34" HorizontalAlignment="Left" Height="15" Margin="1052,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse35" HorizontalAlignment="Left" Height="15" Margin="1072,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse36" HorizontalAlignment="Left" Height="15" Margin="1092,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse37" HorizontalAlignment="Left" Height="15" Margin="1112,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse38" HorizontalAlignment="Left" Height="15" Margin="1132,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse39" HorizontalAlignment="Left" Height="15" Margin="1152,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse30" HorizontalAlignment="Left" Height="15" Margin="1172,110,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>

        <Ellipse x:Name="Ellipse41" HorizontalAlignment="Left" Height="15" Margin="992,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse42" HorizontalAlignment="Left" Height="15" Margin="1012,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse43" HorizontalAlignment="Left" Height="15" Margin="1032,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse44" HorizontalAlignment="Left" Height="15" Margin="1052,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse45" HorizontalAlignment="Left" Height="15" Margin="1072,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse46" HorizontalAlignment="Left" Height="15" Margin="1092,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse47" HorizontalAlignment="Left" Height="15" Margin="1112,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse48" HorizontalAlignment="Left" Height="15" Margin="1132,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse49" HorizontalAlignment="Left" Height="15" Margin="1152,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse40" HorizontalAlignment="Left" Height="15" Margin="1172,140,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>

        <Ellipse x:Name="Ellipse51" HorizontalAlignment="Left" Height="15" Margin="992,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse52" HorizontalAlignment="Left" Height="15" Margin="1012,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse53" HorizontalAlignment="Left" Height="15" Margin="1032,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse54" HorizontalAlignment="Left" Height="15" Margin="1052,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse55" HorizontalAlignment="Left" Height="15" Margin="1072,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse56" HorizontalAlignment="Left" Height="15" Margin="1092,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse57" HorizontalAlignment="Left" Height="15" Margin="1112,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse58" HorizontalAlignment="Left" Height="15" Margin="1132,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse59" HorizontalAlignment="Left" Height="15" Margin="1152,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Ellipse x:Name="Ellipse50" HorizontalAlignment="Left" Height="15" Margin="1172,170,0,0" Stroke="Black" VerticalAlignment="Top" Width="15" StrokeThickness="2" Fill="#FFFFFFFF" Grid.Column="1"/>
        <Button x:Name="BtClear" Content="Nowy" HorizontalAlignment="Left" Margin="40,202,0,0" VerticalAlignment="Top" Width="995" Click="BtClear_Click" Grid.ColumnSpan="2"/>


    </Grid>
</Window>


-------------------------------



    <Window x:Class="RackCheck.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:RackCheck"
        mc:Ignorable="d"
        Title="RackCheck" Height="450" Width="1400">

    <Canvas x:Name="MainCanvas">
        <Button Content="Button" Canvas.Left="350" Canvas.Top="340"/>


    </Canvas>

</Window>

*/