namespace VKBot
{
    public class Behaviour
    {
        public bool Destroing { get; private set; }

        protected virtual void OnLoad(IVkBot vkBot) { }

        protected virtual void OnDestroy() { }

        public void Destroy()
        {
            OnDestroy();
            Destroing = true;
        }
    }
}
