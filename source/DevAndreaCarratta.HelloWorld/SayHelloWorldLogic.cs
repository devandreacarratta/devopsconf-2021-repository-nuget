namespace DevAndreaCarratta.HelloWorld
{
    internal class SayHelloWorldLogic
    {
        private const string HELLO_WORLD_SENTENCE = "Hello World";
        private const string EXCLAMATION_POINT = "!";

        public SayHelloWorldLogic()
        {
        }

        internal string SayToAnonymous()
        {
            return $"{HELLO_WORLD_SENTENCE}{EXCLAMATION_POINT}";
        }

        internal string SayToFriend(string friend)
        {
            return $"{HELLO_WORLD_SENTENCE} {friend}{EXCLAMATION_POINT}";
        }
    }
}