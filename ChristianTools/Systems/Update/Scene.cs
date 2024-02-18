using System.Linq;
using ChristianTools.Helpers;

namespace ChristianTools.Systems.Update
{

    public class Scene
    {
        public static void UpdateSystem(InputState lastInputState, InputState inputState)
        {
            IScene scene = ChristianGame.scenes[ChristianGame.actualScene];

            // UIs
            {
                if (scene.UIs != null)
                    foreach (var ui in scene.UIs)
                        ui.dxUpdateSystem?.Invoke(lastInputState: lastInputState, inputState: inputState);
            }
         

            // Entities
            {
                if (scene.entities != null)
                {
                    for (int i = 0; i < scene.entities.Count; i++)
                    {
                        ChristianTools.Systems.Update.Entity.UpdateSystem(scene.entities[i]);
                        scene.entities[i].dxUpdateSystem?.Invoke(lastInputState, inputState);
                    }
                }
            }


            // Camera
            {
                if (scene.camera != null)
                {
                    scene.camera.UpdateCamera();

                    if (scene.entities != null)
                    {
                        if (scene.entities.Where(x => x.tag == "player").Count() > 0)
                        {
                            IEntity player = scene.entities.Where(x => x.tag == "player").FirstOrDefault();
                            scene.camera.UpdateCamera(player.rigidbody.rectangle.Center);
                        }
                    }
                }
            }
        }
    }    
}
