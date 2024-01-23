namespace PictureShapes
{
    class Picture
    {

        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            Square wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);

            // Write your code here
            Square window = new Square();
            window.MakeVisible();
            window.ChangeColor("black");
            window.ChangeSize(75);
            window.MoveHorizontal(70);
            window.MoveVertical(20);
        }
    }
}
