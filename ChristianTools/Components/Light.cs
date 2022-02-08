﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ChristianTools.Components
{
    public class Light
    {
        public Point centerPosition { get; private set; }
        public Texture2D texture { get; private set; }

        public Light(Point centerPosition, Texture2D texture = null)
        {
            this.centerPosition = centerPosition;
            this.texture = texture;
        }
    }
}
