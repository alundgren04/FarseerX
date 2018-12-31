﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tainicom.Aether.Physics2D.Collision;

namespace tainicom.Aether.Physics2D.Dynamics.Hibernation
{
    public abstract class BaseActiveArea
    {
        public AABB AABB;

        public Vector2 Position { get; protected set; }
        public float Radius { get; protected set; }

        internal virtual void UpdateAABB()
        {
            var diameter = this.Radius * 2.0f;
            this.AABB = new AABB(this.Position, diameter, diameter);
        }
    }
}