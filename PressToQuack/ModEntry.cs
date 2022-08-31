using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

//I just wanna make the farmer quack on command, because it's funny.

namespace PressToQuack
{
    public class ModEntry : Mod
    {
        private ModConfig config;

        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;

            //Config stuff
            this.config = this.Helper.ReadConfig<ModConfig>();
        }

        //When button is pressed while player is in game and not in a menu, Quack.
        private void OnButtonPressed(object sender, ButtonPressedEventArgs e) 
        {
            if (Context.IsPlayerFree)
            {
               // if (e.Button == SButton.Q) ((Old Method w/o Config))

               if (e.Button == this.config.QuackButton)
                {
                    Game1.playSound("Duck");
                }

            }
        }

    }
}
