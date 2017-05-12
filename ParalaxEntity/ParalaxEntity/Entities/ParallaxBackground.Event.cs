using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using ParalaxEntity.Entities;
using ParalaxEntity.Screens;
namespace ParalaxEntity.Entities
{
	public partial class ParallaxBackground
	{
	    void OnAfterZSet (object sender, EventArgs e)
        {
            PS1.Z = Z;
            PS2.Z = Z;
            PS3.Z = Z;
            PS4.Z = Z;
            PS5.Z = Z;
            PS6.Z = Z;
            PS7.Z = Z;
            PS8.Z = Z;
            PS9.Z = Z;
        }
        void OnAfterParallaxImageSet(object sender, EventArgs e)
        {
            PS1.Texture = ParallaxImage;
            PS2.Texture = ParallaxImage;
            PS3.Texture = ParallaxImage;
            PS4.Texture = ParallaxImage;
            PS5.Texture = ParallaxImage;
            PS6.Texture = ParallaxImage;
            PS7.Texture = ParallaxImage;
            PS8.Texture = ParallaxImage;
            PS9.Texture = ParallaxImage;
        }
	}
}
