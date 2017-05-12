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

using FlatRedBall.Graphics.Model;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Splines;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;
using FlatRedBall.Localization;

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
#endif
#endregion

namespace ParalaxEntity.Screens
{
	public partial class TestScreen
	{
	    private bool _autoScroll = false;
	    private float _moveSpeed = 10f;

		void CustomInitialize()
		{


		}

		void CustomActivity(bool firstTimeCalled)
		{
            if (InputManager.Keyboard.KeyDown(Keys.Up))
            {
                _autoScroll = false;
                Camera.Main.Y += _moveSpeed;
            }
            if (InputManager.Keyboard.KeyDown(Keys.Down))
            {
                _autoScroll = false;
                Camera.Main.Y -= _moveSpeed;
            }
            if (InputManager.Keyboard.KeyDown(Keys.Left))
            {
                _autoScroll = false;
                Camera.Main.X -= _moveSpeed;
            }
            if (InputManager.Keyboard.KeyDown(Keys.Right))
            {
                _autoScroll = false;
                Camera.Main.X += _moveSpeed;
            }
            if(InputManager.Keyboard.KeyPushed(Keys.Space))
            {
                _autoScroll = !_autoScroll;
            }

            if (InputManager.Keyboard.KeyPushed(Keys.OemMinus)) _moveSpeed--;
            if (InputManager.Keyboard.KeyPushed(Keys.OemPlus)) _moveSpeed++;

		    _moveSpeed = Math.Max(Math.Min(_moveSpeed, 10), 0);

            if(_autoScroll)
            {
                Camera.Main.X += _moveSpeed;
                Camera.Main.Y += _moveSpeed;
            }
		}

		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
