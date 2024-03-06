using System;
using System.Linq;
using ChristianTools;
using ChristianTools.Components;
using ChristianTools.Helpers;
using ChristianTools.Prefabs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Vector2 = System.Numerics.Vector2;

namespace Showroom
{
    public class Entity_Platformer_Player : BaseEntity
    {
        public Entity_Platformer_Player(Rectangle rectangle, Rectangle imageFromAtlas, string tag = "", Vector2 force = new Vector2(), bool isActive = true) : base(rectangle, imageFromAtlas, tag, force, isActive)
        {
            this.rigidbody = new Rigidbody(rectangle, force);
            this.dxUpdateSystem = (InputState lastInputState, InputState inputState) => Update(lastInputState, inputState);
        }

        private void Update(InputState lastInputState, InputState inputState)
        {
            ChristianTools.Systems.Update.Entity.Move_WASD(inputState, this, 5);
            ChristianTools.Systems.Update.Entity.SetForce(inputState, this, 1);
        }
    }
}