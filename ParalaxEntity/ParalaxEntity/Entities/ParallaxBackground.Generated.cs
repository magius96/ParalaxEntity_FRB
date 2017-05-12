#if ANDROID
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif

using BitmapFont = FlatRedBall.Graphics.BitmapFont;
using Cursor = FlatRedBall.Gui.Cursor;
using GuiManager = FlatRedBall.Gui.GuiManager;
// Generated Usings
using ParalaxEntity.Screens;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using ParalaxEntity.Entities;
using FlatRedBall;
using FlatRedBall.Screens;
using System;
using System.Collections.Generic;
using System.Text;

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
#endif

#if FRB_XNA && !MONODROID
using Model = Microsoft.Xna.Framework.Graphics.Model;
#endif

namespace ParalaxEntity.Entities
{
	public partial class ParallaxBackground : PositionedObject, IDestroyable, IVisible
	{
        // This is made global so that static lazy-loaded content can access it.
        public static string ContentManagerName
        {
            get;
            set;
        }

		// Generated Fields
		#if DEBUG
		static bool HasBeenLoadedWithGlobalContentManager = false;
		#endif
		static object mLockObject = new object();
		static List<string> mRegisteredUnloads = new List<string>();
		static List<string> LoadedContentManagers = new List<string>();
		protected static System.String License;
		
		private FlatRedBall.Sprite PS1;
		private FlatRedBall.Sprite PS2;
		private FlatRedBall.Sprite PS3;
		private FlatRedBall.Sprite PS4;
		private FlatRedBall.Sprite PS5;
		private FlatRedBall.Sprite PS6;
		private FlatRedBall.Sprite PS7;
		private FlatRedBall.Sprite PS8;
		private FlatRedBall.Sprite PS9;
		public event EventHandler BeforeXSet;
		public event EventHandler AfterXSet;
		public new float X
		{
			set
			{
				if (BeforeXSet != null)
				{
					BeforeXSet(this, null);
				}
				base.X = value;
				if (AfterXSet != null)
				{
					AfterXSet(this, null);
				}
			}
			get
			{
				return base.X;
			}
		}
		public event EventHandler BeforeYSet;
		public event EventHandler AfterYSet;
		public new float Y
		{
			set
			{
				if (BeforeYSet != null)
				{
					BeforeYSet(this, null);
				}
				base.Y = value;
				if (AfterYSet != null)
				{
					AfterYSet(this, null);
				}
			}
			get
			{
				return base.Y;
			}
		}
		public event EventHandler BeforeZSet;
		public event EventHandler AfterZSet;
		public new float Z
		{
			set
			{
				if (BeforeZSet != null)
				{
					BeforeZSet(this, null);
				}
				base.Z = value;
				if (AfterZSet != null)
				{
					AfterZSet(this, null);
				}
			}
			get
			{
				return base.Z;
			}
		}
		public float MovementRatio = 0.5f;
		public event EventHandler BeforeParallaxImageSet;
		public event EventHandler AfterParallaxImageSet;
		Microsoft.Xna.Framework.Graphics.Texture2D mParallaxImage;
		public Microsoft.Xna.Framework.Graphics.Texture2D ParallaxImage
		{
			set
			{
				if (BeforeParallaxImageSet != null)
				{
					BeforeParallaxImageSet(this, null);
				}
				mParallaxImage = value;
				if (AfterParallaxImageSet != null)
				{
					AfterParallaxImageSet(this, null);
				}
			}
			get
			{
				return mParallaxImage;
			}
		}
		public event EventHandler BeforeVisibleSet;
		public event EventHandler AfterVisibleSet;
		protected bool mVisible = true;
		public virtual bool Visible
		{
			get
			{
				return mVisible;
			}
			set
			{
				if (BeforeVisibleSet != null)
				{
					BeforeVisibleSet(this, null);
				}
				mVisible = value;
				if (AfterVisibleSet != null)
				{
					AfterVisibleSet(this, null);
				}
			}
		}
		public bool IgnoresParentVisibility { get; set; }
		public bool AbsoluteVisible
		{
			get
			{
				return Visible && (Parent == null || IgnoresParentVisibility || Parent is IVisible == false || (Parent as IVisible).AbsoluteVisible);
			}
		}
		IVisible IVisible.Parent
		{
			get
			{
				if (this.Parent != null && this.Parent is IVisible)
				{
					return this.Parent as IVisible;
				}
				else
				{
					return null;
				}
			}
		}
		protected Layer LayerProvidedByContainer = null;

        public ParallaxBackground()
            : this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {

        }

        public ParallaxBackground(string contentManagerName) :
            this(contentManagerName, true)
        {
        }


        public ParallaxBackground(string contentManagerName, bool addToManagers) :
			base()
		{
			// Don't delete this:
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);

		}

		protected virtual void InitializeEntity(bool addToManagers)
		{
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			PS1 = new FlatRedBall.Sprite();
			PS1.Name = "PS1";
			PS2 = new FlatRedBall.Sprite();
			PS2.Name = "PS2";
			PS3 = new FlatRedBall.Sprite();
			PS3.Name = "PS3";
			PS4 = new FlatRedBall.Sprite();
			PS4.Name = "PS4";
			PS5 = new FlatRedBall.Sprite();
			PS5.Name = "PS5";
			PS6 = new FlatRedBall.Sprite();
			PS6.Name = "PS6";
			PS7 = new FlatRedBall.Sprite();
			PS7.Name = "PS7";
			PS8 = new FlatRedBall.Sprite();
			PS8.Name = "PS8";
			PS9 = new FlatRedBall.Sprite();
			PS9.Name = "PS9";
			
			PostInitialize();
			if (addToManagers)
			{
				AddToManagers(null);
			}


		}

// Generated AddToManagers
		public virtual void ReAddToManagers (Layer layerToAddTo)
		{
			LayerProvidedByContainer = layerToAddTo;
			SpriteManager.AddPositionedObject(this);
			SpriteManager.AddToLayer(PS1, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS2, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS3, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS4, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS5, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS6, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS7, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS8, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS9, LayerProvidedByContainer);
		}
		public virtual void AddToManagers (Layer layerToAddTo)
		{
			LayerProvidedByContainer = layerToAddTo;
			SpriteManager.AddPositionedObject(this);
			SpriteManager.AddToLayer(PS1, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS2, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS3, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS4, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS5, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS6, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS7, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS8, LayerProvidedByContainer);
			SpriteManager.AddToLayer(PS9, LayerProvidedByContainer);
			AddToManagersBottomUp(layerToAddTo);
			CustomInitialize();
		}

		public virtual void Activity()
		{
			// Generated Activity
			
			CustomActivity();
			
			// After Custom Activity
		}

		public virtual void Destroy()
		{
			// Generated Destroy
			SpriteManager.RemovePositionedObject(this);
			
			if (PS1 != null)
			{
				SpriteManager.RemoveSprite(PS1);
			}
			if (PS2 != null)
			{
				SpriteManager.RemoveSprite(PS2);
			}
			if (PS3 != null)
			{
				SpriteManager.RemoveSprite(PS3);
			}
			if (PS4 != null)
			{
				SpriteManager.RemoveSprite(PS4);
			}
			if (PS5 != null)
			{
				SpriteManager.RemoveSprite(PS5);
			}
			if (PS6 != null)
			{
				SpriteManager.RemoveSprite(PS6);
			}
			if (PS7 != null)
			{
				SpriteManager.RemoveSprite(PS7);
			}
			if (PS8 != null)
			{
				SpriteManager.RemoveSprite(PS8);
			}
			if (PS9 != null)
			{
				SpriteManager.RemoveSprite(PS9);
			}


			CustomDestroy();
		}

		// Generated Methods
		public virtual void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			this.AfterZSet += OnAfterZSet;
			this.AfterParallaxImageSet += OnAfterParallaxImageSet;
			if (PS1.Parent == null)
			{
				PS1.CopyAbsoluteToRelative();
				PS1.AttachTo(this, false);
			}
			if (PS2.Parent == null)
			{
				PS2.CopyAbsoluteToRelative();
				PS2.AttachTo(this, false);
			}
			if (PS3.Parent == null)
			{
				PS3.CopyAbsoluteToRelative();
				PS3.AttachTo(this, false);
			}
			if (PS4.Parent == null)
			{
				PS4.CopyAbsoluteToRelative();
				PS4.AttachTo(this, false);
			}
			if (PS5.Parent == null)
			{
				PS5.CopyAbsoluteToRelative();
				PS5.AttachTo(this, false);
			}
			if (PS6.Parent == null)
			{
				PS6.CopyAbsoluteToRelative();
				PS6.AttachTo(this, false);
			}
			if (PS7.Parent == null)
			{
				PS7.CopyAbsoluteToRelative();
				PS7.AttachTo(this, false);
			}
			if (PS8.Parent == null)
			{
				PS8.CopyAbsoluteToRelative();
				PS8.AttachTo(this, false);
			}
			if (PS9.Parent == null)
			{
				PS9.CopyAbsoluteToRelative();
				PS9.AttachTo(this, false);
			}
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}
		public virtual void AddToManagersBottomUp (Layer layerToAddTo)
		{
			AssignCustomVariables(false);
		}
		public virtual void RemoveFromManagers ()
		{
			SpriteManager.ConvertToManuallyUpdated(this);
			if (PS1 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS1);
			}
			if (PS2 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS2);
			}
			if (PS3 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS3);
			}
			if (PS4 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS4);
			}
			if (PS5 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS5);
			}
			if (PS6 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS6);
			}
			if (PS7 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS7);
			}
			if (PS8 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS8);
			}
			if (PS9 != null)
			{
				SpriteManager.RemoveSpriteOneWay(PS9);
			}
		}
		public virtual void AssignCustomVariables (bool callOnContainedElements)
		{
			if (callOnContainedElements)
			{
			}
			MovementRatio = 0.5f;
		}
		public virtual void ConvertToManuallyUpdated ()
		{
			this.ForceUpdateDependenciesDeep();
			SpriteManager.ConvertToManuallyUpdated(this);
			SpriteManager.ConvertToManuallyUpdated(PS1);
			SpriteManager.ConvertToManuallyUpdated(PS2);
			SpriteManager.ConvertToManuallyUpdated(PS3);
			SpriteManager.ConvertToManuallyUpdated(PS4);
			SpriteManager.ConvertToManuallyUpdated(PS5);
			SpriteManager.ConvertToManuallyUpdated(PS6);
			SpriteManager.ConvertToManuallyUpdated(PS7);
			SpriteManager.ConvertToManuallyUpdated(PS8);
			SpriteManager.ConvertToManuallyUpdated(PS9);
		}
		public static void LoadStaticContent (string contentManagerName)
		{
			if (string.IsNullOrEmpty(contentManagerName))
			{
				throw new ArgumentException("contentManagerName cannot be empty or null");
			}
			ContentManagerName = contentManagerName;
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
			bool registerUnload = false;
			if (LoadedContentManagers.Contains(contentManagerName) == false)
			{
				LoadedContentManagers.Add(contentManagerName);
				lock (mLockObject)
				{
					if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBallServices.GlobalContentManager)
					{
						FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("ParallaxBackgroundStaticUnload", UnloadStaticContent);
						mRegisteredUnloads.Add(ContentManagerName);
					}
				}
				if (!FlatRedBallServices.IsLoaded<System.String>(@"content/entities/parallaxbackground/license.txt", ContentManagerName))
				{
					registerUnload = true;
				}
				License = FlatRedBallServices.Load<System.String>(@"content/entities/parallaxbackground/license.txt", ContentManagerName);
			}
			if (registerUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
			{
				lock (mLockObject)
				{
					if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBallServices.GlobalContentManager)
					{
						FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("ParallaxBackgroundStaticUnload", UnloadStaticContent);
						mRegisteredUnloads.Add(ContentManagerName);
					}
				}
			}
			CustomLoadStaticContent(contentManagerName);
		}
		public static void UnloadStaticContent ()
		{
			if (LoadedContentManagers.Count != 0)
			{
				LoadedContentManagers.RemoveAt(0);
				mRegisteredUnloads.RemoveAt(0);
			}
			if (LoadedContentManagers.Count == 0)
			{
				if (License != null)
				{
					License= null;
				}
			}
		}
		[System.Obsolete("Use GetFile instead")]
		public static object GetStaticMember (string memberName)
		{
			switch(memberName)
			{
				case  "License":
					return License;
			}
			return null;
		}
		public static object GetFile (string memberName)
		{
			switch(memberName)
			{
				case  "License":
					return License;
			}
			return null;
		}
		object GetMember (string memberName)
		{
			switch(memberName)
			{
				case  "License":
					return License;
			}
			return null;
		}
		protected bool mIsPaused;
		public override void Pause (FlatRedBall.Instructions.InstructionList instructions)
		{
			base.Pause(instructions);
			mIsPaused = true;
		}
		public virtual void SetToIgnorePausing ()
		{
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS1);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS2);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS3);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS4);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS5);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS6);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS7);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS8);
			FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(PS9);
		}
		public virtual void MoveToLayer (Layer layerToMoveTo)
		{
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS1);
			}
			SpriteManager.AddToLayer(PS1, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS2);
			}
			SpriteManager.AddToLayer(PS2, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS3);
			}
			SpriteManager.AddToLayer(PS3, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS4);
			}
			SpriteManager.AddToLayer(PS4, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS5);
			}
			SpriteManager.AddToLayer(PS5, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS6);
			}
			SpriteManager.AddToLayer(PS6, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS7);
			}
			SpriteManager.AddToLayer(PS7, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS8);
			}
			SpriteManager.AddToLayer(PS8, layerToMoveTo);
			if (LayerProvidedByContainer != null)
			{
				LayerProvidedByContainer.Remove(PS9);
			}
			SpriteManager.AddToLayer(PS9, layerToMoveTo);
			LayerProvidedByContainer = layerToMoveTo;
		}

    }
	
	
		public static class ParallaxBackgroundExtensionMethods
	{
		public static void SetVisible (this PositionedObjectList<ParallaxBackground> list, bool value)
		{
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				list[i].Visible = value;
			}
		}
	}

	
}
