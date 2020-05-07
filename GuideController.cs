using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwinGameSDK;
namespace MyGame.src
{
    static class GuideController
    {
		public static void HandleInstructionsInput()
		{
			if (SwinGame.MouseClicked(MouseButton.LeftButton) || SwinGame.KeyTyped(KeyCode.EscapeKey))
			{
				GameController.EndCurrentState();
			}
		}
	}
}
