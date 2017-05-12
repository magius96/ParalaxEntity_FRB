#region Usings

using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;

using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;
using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;

#endif
#endregion

namespace ParalaxEntity.Entities
{
	public partial class ParallaxBackground
	{
	    private float _screenWidth = 800;
	    private float _screenHeight = 600;

		private void CustomInitialize()
		{
            _screenWidth = FlatRedBallServices.GraphicsDevice.Viewport.Width;
            _screenHeight = FlatRedBallServices.GraphicsDevice.Viewport.Height;

            InitSprite(PS1, -1, -1);
            InitSprite(PS2, 0, -1);
            InitSprite(PS3, 1, -1);
            InitSprite(PS4, -1, 0);
            InitSprite(PS5, 0, 0);
            InitSprite(PS6, 1, 0);
            InitSprite(PS7, -1, 1);
            InitSprite(PS8, 0, 1);
            InitSprite(PS9, 1, 1);
		}

        private void InitSprite(Sprite target, float tx, float ty)
        {
            target.Width = _screenWidth;
            target.Height = _screenHeight;
            target.RelativeX = _screenWidth*tx;
            target.RelativeY = _screenHeight*ty;
        }

		private void CustomActivity()
		{
		    X = (Camera.Main.X - ((Camera.Main.X*MovementRatio)%_screenWidth));
		    Y = (Camera.Main.Y - ((Camera.Main.Y*MovementRatio)%_screenHeight));
        }

		private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
