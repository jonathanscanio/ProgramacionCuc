﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoWindowsForm
{
    class ModoNivelesScreen
    {
        Form1 mainScreen;
        public ModoNivelesScreen(Form1 mainScreen)
        {
            this.mainScreen = mainScreen;
            //
            // mainMenuButton
            //
            new MainMenuButton(mainScreen);

            //
            // Buttons
            //
            int level = 1;
            int x = 0;
            int y = 0;

            for (int i = 0; i < 4; i++)
            {
                y += 90;
                x = 0;
                for (int j = 0; j < 5; j++)
                {
                    x += 130;
                    new BotonesNivelesButton(mainScreen, level.ToString(), x, y);
                    level++;
                }
            }
        }
        
    }
}
