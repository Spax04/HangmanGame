using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HangmanGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        GameStart gameStart;
        GameMananger gameMananger;
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void easyBtn_Click(object sender, RoutedEventArgs e)
        {
            /* gameMananger = new GameMananger();
             gameStart = new GameStart(gameMananger.EasyLvlChose);*/
            Start();
            removeGameMenu();
        }

        private void mediumBtn_Click(object sender, RoutedEventArgs e)
        {
            gameMananger = new GameMananger();
            gameStart = new GameStart(gameMananger.MediumLvlChose);
            removeGameMenu();
        }

        private void removeGameMenu()
        {
            myCanvas.Children.Remove(gameStartDifLvl);
            myCanvas.Children.Remove(gameStartRec);
            myCanvas.Children.Remove(easyBtn);
            myCanvas.Children.Remove(mediumBtn);
            myCanvas.Children.Remove(gameStartTitle);
        }

        public void Start()
        {
            gameMananger = new GameMananger();
            gameStart = new GameStart(gameMananger.EasyLvlChose);
            reultTextBlock.Text = gameStart.Final;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
