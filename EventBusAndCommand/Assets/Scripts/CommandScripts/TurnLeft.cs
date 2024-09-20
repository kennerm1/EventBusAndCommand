namespace Chapter.Command
{
    public class TurnLeft : Command
    {
        private CBikeController _controller;

        public TurnLeft(CBikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(CBikeController.Direction.Left);
        }
    }
}
