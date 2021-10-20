namespace DevAndreaCarratta.HelloWorld
{
    public class SayHelloWorld
    {
        private readonly SayHelloWorld _logic;

        public SayHelloWorld()
        {
            _logic = new SayHelloWorld();
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