﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.model;

namespace BlackJack
{
    public class Program
    {
        static void Main(string[] args)
        {
            model.Game g = new model.Game();
            view.IView v = new view.SimpleView(); // new view.SwedishView();
            controller.PlayGame ctrl = new controller.PlayGame();

            while (ctrl.Play(g, v));
        }
    }
}
