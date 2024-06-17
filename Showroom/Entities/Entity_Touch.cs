namespace Showroom
{
    public class Entity_Touch : BaseEntity
    {
        public Entity_Touch(Rectangle rectangle, string tag = "", bool isActive = true) : base(rectangle, tag, isActive)
        {
            this.dxCustomUpdateSystem = (InputState lastInputState, InputState inputState) => Update(lastInputState, inputState);
        }

        private void Update(InputState lastInputState, InputState inputState)
        {
            ChristianTools.Systems.Update.Entity.Move_WASD(lastInputState, inputState, this);
            if (inputState.Action || inputState.touch.IsTouchDown())
            {
                rigidbody.rectangle = ChristianTools.Helpers.MyRectangle.CreateRectangle(inputState.GetActionOnWorldPosition(), 16, 16);
            }
        }
    }
}