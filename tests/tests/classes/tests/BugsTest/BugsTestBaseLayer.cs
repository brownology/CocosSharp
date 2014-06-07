using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;

namespace tests
{
    public class BugsTestBaseLayer : CCLayer
    {
        public override void OnEnter()
        {
            base.OnEnter();

            CCSize s = CCApplication.SharedApplication.MainWindowDirector.WindowSizeInPoints;

            CCMenuItemFont pMainItem = new CCMenuItemFont("Back", backCallback);
            pMainItem.Position = new CCPoint(s.Width - 50, 25);
            CCMenu pMenu = new CCMenu(pMainItem, null);
            pMenu.Position = new CCPoint(0, 0);
            AddChild(pMenu);
        }

        public void backCallback(object pSender)
        {
            //CCApplication.SharedApplication.MainWindowDirector.EnableRetinaDisplay(false);
            BugsTestScene pScene = new BugsTestScene();
            pScene.runThisTest();
        }
    }
}
