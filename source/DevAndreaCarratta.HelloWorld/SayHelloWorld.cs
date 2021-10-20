namespace DevAndreaCarratta.HelloWorld
{
    public class SayHelloWorld
    {
        private readonly SayHelloWorldLogic _logic;

        public SayHelloWorld()
        {
            _logic = new SayHelloWorldLogic();
        }

        public string SayToAnonymous()
        {
            return _logic.SayToAnonymous();
        }

        public string SayToFriend(string friend)
        {
            return _logic.SayToFriend(friend);
        }
    }
}