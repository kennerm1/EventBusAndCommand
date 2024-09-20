namespace Chapter.Command
{
    public class TurnRight : Command
    {
        private CBikeController _controller;

        public TurnRight(CBikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(CBikeController.Direction.Right);
        }
    }
}
