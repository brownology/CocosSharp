using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;

namespace tests
{
    public class TestLayer : CCLayer
    {
        public override void OnEnter()
        {
            base.OnEnter();
            float x, y;
            CCSize size = CCApplication.SharedApplication.MainWindowDirector.WindowSizeInPoints;
            x = size.Width;
            y = size.Height;
            //CCMutableArray *array = [UIFont familyNames];
            //for( CCString *s in array )
            //	NSLog( s );
            CCLabelTtf label = new CCLabelTtf("cocos2d", "arial", 64);
            label.Position = new CCPoint(x / 2, y / 2);
            AddChild(label);
        }

        public static new TestLayer node()
        {
            TestLayer node = new TestLayer();
            return node;
        }
    }
}
