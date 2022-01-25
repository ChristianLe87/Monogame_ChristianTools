﻿using System;
using System.Collections.Generic;
using ChristianTools.Components;
using ChristianTools.Entities;
using ChristianTools.Helpers;
using ChristianTools.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Scene_Components_Rigidbody : IScene
    {
        public GameState gameState { get; private set; }
        public List<IEntity> entities { get; set; }
        public List<IUI> UIs { get; set; }
        public List<SoundEffect> soundEffects { get; }
        public Camera camera { get; private set; }
        public Map map { get; }

        public DxSceneUpdateSystem dxSceneUpdateSystem { get; private set; }
        public DxSceneDrawSystem dxSceneDrawSystem { get; }

        public void Initialize(Vector2? playerPosition = null)
        {
            this.UIs = new List<IUI>()
            {
                new Button(
                    rectangle: new Rectangle (10, 10, 230, 30),
                    text: "Jump",
                    defaultTexture: WK.Texture.LightGray,
                    mouseOverTexture: WK.Texture.Gray,
                    spriteFont: WK.Font.font_7,
                    tag: "jump",
                    OnClickAction: null
                ),
                new Button(
                    rectangle: new Rectangle (0, 470, 230, 30),
                    text: "<- Components",
                    defaultTexture: WK.Texture.LightGray,
                    mouseOverTexture: WK.Texture.Gray,
                    spriteFont: WK.Font.font_7,
                    tag: "goToComponents",
                    OnClickAction: () => Game1.ChangeToScene(WK.Scene.Components)
                ),
            };


            Entity entity = new Entity(
                texture2D: WK.Texture.Player.IdleLeft_Multiply,
                centerPosition: new Vector2(ChristianGame.Default.canvasWidth/2, ChristianGame.Default.canvasHeight/2),
                dxUpdateSystem: null//() => Jump()
            );
            entity.rigidbody.force = entity.rigidbody.force + new Vector2(0, 1);

            this.entities = new List<IEntity>();
            this.entities.Add(entity);
        }
    }
}