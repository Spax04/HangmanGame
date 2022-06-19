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
            removeGameOverStuff();
            removeAlphabet();
            removeHangman();
        }

        private void easyBtn_Click(object sender, RoutedEventArgs e)
        {

            creatNewGame(1);
        }

        private void mediumBtn_Click(object sender, RoutedEventArgs e)
        {
            creatNewGame(2);
        }
        public void creatNewGame(int num)
        {
            gameMananger = new GameMananger();
            if(num == 1)
            {
                gameStart = new GameStart(gameMananger.EasyLvlChose);
                gameMananger.MaxMiss = gameMananger.EasyMissAmount;
            }
            else if(num == 2)
            {
                gameStart = new GameStart(gameMananger.MediumLvlChose);
                gameMananger.MaxMiss = gameMananger.MediumMissAmount;
            }
            reultTextBlock.Text = gameStart.Result.ToString();
            gameMananger.WordLength = gameStart.PlayerWord.Length;
            removeHangman();
            removeGameOverStuff();
            addAlphabet();
            removeStartMenu();
            allBtnEnablet();
        }
        //-------------- Grafic User Interface-------------
        private void removeStartMenu()
        {
            myCanvas.Children.Remove(gameStartDifLvl);
            myCanvas.Children.Remove(gameRec);
            myCanvas.Children.Remove(easyBtn);
            myCanvas.Children.Remove(mediumBtn);
            myCanvas.Children.Remove(gameStartTitle);
            myCanvas.Children.Remove(hangmanTitle);
            myCanvas.Children.Remove(myTitle);
        }
        public void addGameOverMenu()
        {
            removeAlphabet();
            myCanvas.Children.Add(gameRec);
            myCanvas.Children.Add(gameOvetTxt);
            myCanvas.Children.Add(playAgainTitle);
            myCanvas.Children.Add(myTitle);
            myCanvas.Children.Add(easyBtn);
            myCanvas.Children.Add(mediumBtn);
            myCanvas.Children.Add(gameStartDifLvl);

        }
        public void addWinMenu()
        {
            removeAlphabet();
            myCanvas.Children.Add(gameRec);
            myCanvas.Children.Add(winTitle);
            myCanvas.Children.Add(playAgainTitle);
            myCanvas.Children.Add(myTitle);
            myCanvas.Children.Add(easyBtn);
            myCanvas.Children.Add(mediumBtn);
            myCanvas.Children.Add(gameStartDifLvl);
        }
        public void removeGameOverStuff()
        {
            myCanvas.Children.Remove(gameOvetTxt);
            myCanvas.Children.Remove(playAgainTitle);
            myCanvas.Children.Remove(winTitle);
        }
        public void removeHangman()
        {
            myCanvas.Children.Remove(missOne);
            myCanvas.Children.Remove(missTwo);
            myCanvas.Children.Remove(missThree);
            myCanvas.Children.Remove(missThree1);
            myCanvas.Children.Remove(missFour);
            myCanvas.Children.Remove(missFive);
            myCanvas.Children.Remove(missSix);
            myCanvas.Children.Remove(missSeven);
            myCanvas.Children.Remove(missEight);
            myCanvas.Children.Remove(missNine);
            myCanvas.Children.Remove(missTen);
        }
        public void removeAlphabet()
        {
            myCanvas.Children.Remove(btnA);
            myCanvas.Children.Remove(btnB);
            myCanvas.Children.Remove(btnC);
            myCanvas.Children.Remove(btnD);
            myCanvas.Children.Remove(btnE);
            myCanvas.Children.Remove(btnF);
            myCanvas.Children.Remove(btnG);
            myCanvas.Children.Remove(btnH);
            myCanvas.Children.Remove(btnI);
            myCanvas.Children.Remove(btnJ);
            myCanvas.Children.Remove(btnK);
            myCanvas.Children.Remove(btnL);
            myCanvas.Children.Remove(btnM);
            myCanvas.Children.Remove(btnN);
            myCanvas.Children.Remove(btnO);
            myCanvas.Children.Remove(btnP);
            myCanvas.Children.Remove(btnQ);
            myCanvas.Children.Remove(btnR);
            myCanvas.Children.Remove(btnS);
            myCanvas.Children.Remove(btnT);
            myCanvas.Children.Remove(btnU);
            myCanvas.Children.Remove(btnV);
            myCanvas.Children.Remove(btnW);
            myCanvas.Children.Remove(btnX);
            myCanvas.Children.Remove(btnY);
            myCanvas.Children.Remove(btnZ);
        }
        public void addAlphabet()
        {
            myCanvas.Children.Add(btnA);
            myCanvas.Children.Add(btnB);
            myCanvas.Children.Add(btnC);
            myCanvas.Children.Add(btnD);
            myCanvas.Children.Add(btnE);
            myCanvas.Children.Add(btnF);
            myCanvas.Children.Add(btnG);
            myCanvas.Children.Add(btnH);
            myCanvas.Children.Add(btnI);
            myCanvas.Children.Add(btnJ);
            myCanvas.Children.Add(btnK);
            myCanvas.Children.Add(btnL);
            myCanvas.Children.Add(btnM);
            myCanvas.Children.Add(btnN);
            myCanvas.Children.Add(btnO);
            myCanvas.Children.Add(btnP);
            myCanvas.Children.Add(btnQ);
            myCanvas.Children.Add(btnR);
            myCanvas.Children.Add(btnS);
            myCanvas.Children.Add(btnT);
            myCanvas.Children.Add(btnU);
            myCanvas.Children.Add(btnV);
            myCanvas.Children.Add(btnW);
            myCanvas.Children.Add(btnX);
            myCanvas.Children.Add(btnY);
            myCanvas.Children.Add(btnZ);
        }
        public void allBtnEnablet()
        {
            btnA.IsEnabled = true;
            btnB.IsEnabled = true;
            btnC.IsEnabled = true;
            btnD.IsEnabled = true;
            btnE.IsEnabled = true;
            btnF.IsEnabled = true;
            btnG.IsEnabled = true;
            btnH.IsEnabled = true;
            btnI.IsEnabled = true;
            btnJ.IsEnabled = true;
            btnK.IsEnabled = true;
            btnL.IsEnabled = true;
            btnM.IsEnabled = true;
            btnN.IsEnabled = true;
            btnO.IsEnabled = true;
            btnP.IsEnabled = true;
            btnQ.IsEnabled = true;
            btnR.IsEnabled = true;
            btnS.IsEnabled = true;
            btnT.IsEnabled = true;
            btnU.IsEnabled = true;
            btnV.IsEnabled = true;
            btnW.IsEnabled = true;
            btnX.IsEnabled = true;
            btnY.IsEnabled = true;
            btnZ.IsEnabled = true;
        }
        public void HangmanDraw(int num)
        {
            if (gameMananger.MaxMiss == gameMananger.EasyMissAmount)
            {
                switch (num)
                {
                    case 1:
                        myCanvas.Children.Add(missOne);
                        break;
                    case 2:
                        myCanvas.Children.Add(missTwo);
                        break;
                    case 3:
                        myCanvas.Children.Add(missThree);
                        myCanvas.Children.Add(missThree1);
                        break;
                    case 4:
                        myCanvas.Children.Add(missFour);
                        break;
                    case 5:
                        myCanvas.Children.Add(missFive);
                        break;
                    case 6:
                        myCanvas.Children.Add(missSix);
                        break;
                    case 7:
                        myCanvas.Children.Add(missSeven);
                        break;
                    case 8:
                        myCanvas.Children.Add(missEight);
                        break;
                    case 9:
                        myCanvas.Children.Add(missNine);
                        break;
                    case 10:
                        myCanvas.Children.Add(missTen);
                        break;
                    default:
                        break;
                }
            }
            else if (gameMananger.MaxMiss == gameMananger.MediumMissAmount)
            {
                switch (gameMananger.MissCounter)
                {
                    case 1:
                        myCanvas.Children.Add(missOne);
                        myCanvas.Children.Add(missTwo);
                        break;
                    case 2:
                        myCanvas.Children.Add(missThree);
                        myCanvas.Children.Add(missThree1);
                        break;
                    case 3:
                        myCanvas.Children.Add(missFour);
                        myCanvas.Children.Add(missFive);
                        break;
                    case 4:
                        myCanvas.Children.Add(missSix);
                        break;
                    case 5:
                        myCanvas.Children.Add(missSeven);
                        break;
                    case 6:
                        myCanvas.Children.Add(missEight);
                        break;
                    case 7:
                        myCanvas.Children.Add(missNine);
                        break;
                    case 8:
                        myCanvas.Children.Add(missTen);
                        break;
                }
            }
        }
        //-------------------------------------------

        // -------------- Buttons --------------
        private void btnA_Click(object sender, RoutedEventArgs e) // A 
        {
            btnFuction('A', btnA);
            
        }  
        private void btnB_Click(object sender, RoutedEventArgs e) // B 
        {
            btnFuction('B', btnB);
            
        }
        private void btnC_Click(object sender, RoutedEventArgs e) // C 
        {
            btnFuction('C', btnC);
            
        }
        private void btnD_Click(object sender, RoutedEventArgs e) // D 
        {
            btnFuction('D', btnD);
        }
        private void btnE_Click(object sender, RoutedEventArgs e) // E 
        {
            btnFuction('E',btnE);
        }
        private void btnF_Click(object sender, RoutedEventArgs e) // F 
        {
            btnFuction('F', btnF);
        }
        private void btnG_Click(object sender, RoutedEventArgs e) // G 
        {
            btnFuction('G', btnG);
        }
        private void btnH_Click(object sender, RoutedEventArgs e) // H 
        {
            btnFuction('H', btnH);
        }
        private void btnI_Click(object sender, RoutedEventArgs e) // I 
        {
            btnFuction('I', btnI);
        }
        private void btnJ_Click(object sender, RoutedEventArgs e) // J 
        {
            btnFuction('J', btnJ);
        }
        private void btnK_Click(object sender, RoutedEventArgs e) // K 
        {
            btnFuction('K', btnK);
        }
        private void btnL_Click(object sender, RoutedEventArgs e) // L 
        {
            btnFuction('L', btnL);
        }
        private void btnM_Click(object sender, RoutedEventArgs e) // M 
        {
            btnFuction('M', btnM);
        }
        private void btnN_Click(object sender, RoutedEventArgs e) // N 
        {
            btnFuction('N', btnN);
        }
        private void btnO_Click(object sender, RoutedEventArgs e) // O
        {
            btnFuction('O', btnO);
        }
        private void btnP_Click(object sender, RoutedEventArgs e) // P 
        {
            btnFuction('P', btnP);
        }
        private void btnQ_Click(object sender, RoutedEventArgs e) // Q 
        {
            btnFuction('Q', btnQ);
        }
        private void btnR_Click(object sender, RoutedEventArgs e) // R 
        {
            btnFuction('R', btnR);
        }
        private void btnS_Click(object sender, RoutedEventArgs e) // S 
        {
            btnFuction('S', btnS);
        }
        private void btnT_Click(object sender, RoutedEventArgs e) // T 
        {
            btnFuction('T', btnT);
        }
        private void btnU_Click(object sender, RoutedEventArgs e) // U 
        {
            btnFuction('U', btnU);
        }
        private void btnV_Click(object sender, RoutedEventArgs e) // V 
        {
            btnFuction('V', btnV);
        }
        private void btnW_Click(object sender, RoutedEventArgs e) // W 
        {
            btnFuction('W', btnW);
        }
        private void btnX_Click(object sender, RoutedEventArgs e) // X
        {
            btnFuction('X', btnX);
        }
        private void btnY_Click(object sender, RoutedEventArgs e) // Y
        {
            btnFuction('Y', btnY);
        }
        private void btnZ_Click(object sender, RoutedEventArgs e) // Z
        {
            btnFuction('Z', btnZ);
           
        }
        public void btnFuction(char c,Button btn)  // Functon for all btns
        {
            
            bool status = gameStart.letterCheck(c, gameStart.PlayerWord);
            if(status == false)
            {
                gameMananger.MissCounter++;
                HangmanDraw(gameMananger.MissCounter);
                if (gameMananger.looseCheck())
                {
                    addGameOverMenu();
                    removeAlphabet();
                }
            }
            else if (status == true)
            {
                gameMananger.GuessCounter++;
                if (gameMananger.winCheck())
                {
                    addWinMenu();
                    
                    removeAlphabet();
                }
            }
            reultTextBlock.Text = gameStart.Result.ToString();

            txtBlock1.Text = gameMananger.GuessCounter.ToString();            
            txtBlock.Text = gameMananger.MissCounter.ToString();
            btn.IsEnabled = false;
        }

// -------------------------------------------------------------------------------
       
    }
}
