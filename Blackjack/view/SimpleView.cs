﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BlackJack.model;

namespace BlackJack.view
{
    public class SimpleView : IView
    {

        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine("Hello Black Jack World");
            System.Console.Write("Type '" + (char)MenuOptions.PLAY + "' to Play, '");
            System.Console.Write((char)MenuOptions.HIT + "' to Hit, '");
            System.Console.Write((char)MenuOptions.STAND + "' to Stand or '");
            System.Console.Write((char)MenuOptions.QUIT + "' to Quit\n");
            System.Console.WriteLine();
        }

        public MenuOptions GetInput()
        {
            return (view.MenuOptions)System.Console.In.Read();
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }
        }
        public void Pause(int duration)
        {
            Thread.Sleep(duration);
        }
    }
}
