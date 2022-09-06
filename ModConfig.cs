using StardewModdingAPI;
using System;

namespace PressToQuack
{
    /* (Regular Config- No Generic Mod Config Menu support)
    //internal class ModConfig
    //{
    //    public SButton QuackButton { get; set; } = SButton.Q;
    } */

    public class ModConfig
    {
        // Add option for Quacking keybind
        public SButton QuackButton { get; set; }

        public ModConfig()
        {
            // Default button = Q
            this.QuackButton = SButton.Q;
        }
    }

}
