#if ANDROID
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif


using BitmapFont = FlatRedBall.Graphics.BitmapFont;

using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;

#if XNA4 || WINDOWS_8
using Color = Microsoft.Xna.Framework.Color;
#elif FRB_MDX
using Color = System.Drawing.Color;
#else
using Color = Microsoft.Xna.Framework.Graphics.Color;
#endif

#if FRB_XNA || SILVERLIGHT
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Vector3 = Microsoft.Xna.Framework.Vector3;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;
using Microsoft.Xna.Framework.Media;
#endif

// Generated Usings
using ParalaxEntity.Entities;
using FlatRedBall;
using FlatRedBall.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace ParalaxEntity.Screens
{
	public partial class TestScreen : Screen
	{
		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		protected static Microsoft.Xna.Framework.Graphics.Texture2D Gold;
		protected static Microsoft.Xna.Framework.Graphics.Texture2D ParallaxTexture;
		
		private ParalaxEntity.Entities.ParallaxBackground ParallaxBackgroundInstance;

		public TestScreen()
			: base("TestScreen")
		{
		}

        public override void Initialize(bool addToManagers)
        {
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			ParallaxBackgroundInstance = new ParalaxEntity.Entities.ParallaxBackground(ContentManagerName, false);
			ParallaxBackgroundInstance.Name = "ParallaxBackgroundInstance";
			
			
			PostInitialize();
			base.Initialize(addToManagers);
			if (addToManagers)
			{
				AddToManagers();
			}

        }
        
// Generated AddToManagers
		public override void AddToManagers ()
		{
			ParallaxBackgroundInstance.AddToManagers(mLayer);
			base.AddToManagers();
			AddToManagersBottomUp();
			CustomInitialize();
		}


		public override void Activity(bool firstTimeCalled)
		{
			// Generated Activity
			if (!IsPaused)
			{
				
				ParallaxBackgroundInstance.Activity();
			}
			else
			{
			}
			base.Activity(firstTimeCalled);
			if (!IsActivityFinished)
			{
				CustomActivity(firstTimeCalled);
			}


				// After Custom Activity
				
            
		}

		public override void Destroy()
		{
			// Generated Destroy
			Gold = null;
			ParallaxTexture = null;
			
			if (ParallaxBackgroundInstance != null)
			{
				ParallaxBackgroundInstance.Destroy();
				ParallaxBackgroundInstance.Detach();
			}

			base.Destroy();

			CustomDestroy();

		}

		// Generated Methods
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			if (ParallaxBackgroundInstance.Parent == null)
			{
				ParallaxBackgroundInstance.Z = -1f;
			}
			else
			{
				ParallaxBackgroundInstance.RelativeZ = -1f;
			}
			ParallaxBackgroundInstance.MovementRatio = 0.5f;
			ParallaxBackgroundInstance.ParallaxImage = ParallaxTexture;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}
		public virtual void AddToManagersBottomUp ()
		{
			CameraSetup.ResetCamera(SpriteManager.Camera);
			AssignCustomVariables(false);
		}
		public virtual void RemoveFromManagers ()
		{
			ParallaxBackgroundInstance.RemoveFromManagers();
		}
		public virtual void AssignCustomVariables (bool callOnContainedElements)
		{
			if (callOnContainedElements)
			{
				ParallaxBackgroundInstance.AssignCustomVariables(true);
			}
			if (ParallaxBackgroundInstance.Parent == null)
			{
				ParallaxBackgroundInstance.Z = -1f;
			}
			else
			{
				ParallaxBackgroundInstance.RelativeZ = -1f;
			}
			ParallaxBackgroundInstance.MovementRatio = 0.5f;
			ParallaxBackgroundInstance.ParallaxImage = ParallaxTexture;
		}
		public virtual void ConvertToManuallyUpdated ()
		{
			ParallaxBackgroundInstance.ConvertToManuallyUpdated();
		}
		public static void LoadStaticContent (string contentManagerName)
		{
			if (string.IsNullOrEmpty(contentManagerName))
			{
				throw new ArgumentException("contentManagerName cannot be empty or null");
			}
			#if DEBUG
			if (contentManagerName == FlatRedBallServices.GlobalContentManager)
			{
				HasBeenLoadedWithGlobalContentManager = true;
			}
			else if (HasBeenLoadedWithGlobalContentManager)
			{
				throw new Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
			}
			#endif
			if (!FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/testscreen/gold.png", contentManagerName))
			{
			}
			Gold = FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/screens/testscreen/gold.png", contentManagerName);
			if (!FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/parallaxbackground/parallaxtexture.png", contentManagerName))
			{
			}
			ParallaxTexture = FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/parallaxbackground/parallaxtexture.png", contentManagerName);
			ParalaxEntity.Entities.ParallaxBackground.LoadStaticContent(contentManagerName);
			CustomLoadStaticContent(contentManagerName);
		}
		[System.Obsolete("Use GetFile instead")]
		public static object GetStaticMember (string memberName)
		{
			switch(memberName)
			{
				case  "Gold":
					return Gold;
				case  "ParallaxTexture":
					return ParallaxTexture;
			}
			return null;
		}
		public static object GetFile (string memberName)
		{
			switch(memberName)
			{
				case  "Gold":
					return Gold;
				case  "ParallaxTexture":
					return ParallaxTexture;
			}
			return null;
		}
		object GetMember (string memberName)
		{
			switch(memberName)
			{
				case  "Gold":
					return Gold;
				case  "ParallaxTexture":
					return ParallaxTexture;
			}
			return null;
		}


	}
}
