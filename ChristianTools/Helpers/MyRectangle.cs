using Microsoft.Xna.Framework;

namespace ChristianTools.Helpers
{
    public static class MyRectangle
    {
        public static Rectangle CreateRectangle(Point centerPosition, int Width, int Height)
        {
            Rectangle rectangle = new Rectangle(
                x: (int)(centerPosition.X - (Width / 2)),
                y: (int)(centerPosition.Y - (Height / 2)),
                width: Width,
                height: Height
            );

            return rectangle;
        }


        public static Rectangle MoveRectangle_X(Rectangle rectangle, int steps)
        {
            return new Rectangle(x: rectangle.X + steps, y: rectangle.Y, width: rectangle.Width, height: rectangle.Height);
        }
        /*public static Rectangle MoveRectangleDown(Rectangle rectangle, int steps= 1)
        {
            return new Rectangle(x: rectangle.X, y: rectangle.Y + steps, width: rectangle.Width, height: rectangle.Height);
        }
        public static Rectangle MoveRectangleUp(Rectangle rectangle, int steps= 1)
        {
            return MoveRectangleDown(rectangle, steps * -1);
        }*/

        public static Rectangle MoveRectangle_Y(Rectangle rectangle, int steps)
        {
            return new Rectangle(x: rectangle.X, y: rectangle.Y + steps, width: rectangle.Width, height: rectangle.Height);
        }

        /*public static Rectangle MoveRectangleRight(Rectangle rectangle, int steps = 1)
        {
            return MoveRectangleLeft(rectangle, steps * -1);
        }

        public static Rectangle MoveRectangleLeft(Rectangle rectangle, int steps = 1)
        {
            return new Rectangle(x: rectangle.X - steps, y: rectangle.Y, width: rectangle.Width, height: rectangle.Height);
        }*/


        /*public static Rectangle CreateRectangle(Point centerPosition, Texture2D texture2D)
        {
            return CreateRectangle(centerPosition, texture2D.Width, texture2D.Height);
        }*/

        /*public static Rectangle ScaleRectangleSides(Rectangle originalRectangle, int scaleFactor = 1)
        {
            Rectangle rectangle = new Rectangle(
                x: (int)(originalRectangle.X - scaleFactor),
                y: (int)(originalRectangle.Y - scaleFactor),
                width: originalRectangle.Width + (scaleFactor * 2),
                height: originalRectangle.Height + (scaleFactor * 2)
            );

            return rectangle;
        }*/

        public static Rectangle GetRectangleUp(Rectangle mainRectangle, int height)
        {
            Rectangle rectangleUp = new Rectangle(
                x: mainRectangle.X,
                y: mainRectangle.Y - height,
                width: mainRectangle.Width,
                height: height
            );

            return rectangleUp;
        }

        public static Rectangle GetRectangleDown(Rectangle mainRectangle, int height)
        {
            Rectangle rectangleDown = new Rectangle(
                x: mainRectangle.X,
                y: mainRectangle.Bottom,
                width: mainRectangle.Width,
                height: height
            );

            return rectangleDown;
        }

        public static Rectangle GetRectangleLeft(Rectangle mainRectangle, int width)
        {
            Rectangle rectangleLeft = new Rectangle(
                x: mainRectangle.X - width,
                y: mainRectangle.Y,
                width: width,
                height: mainRectangle.Height
            );

            return rectangleLeft;
        }

        public static Rectangle GetRectangleRight(Rectangle mainRectangle, int width)
        {
            Rectangle rectangleRight = new Rectangle(
                x: mainRectangle.Right,
                y: mainRectangle.Y,
                width: width,
                height: mainRectangle.Height
            );

            return rectangleRight;
        }
    }
}
