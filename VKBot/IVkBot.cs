using System;
using System.Threading.Tasks;
using VKBot.Args;
using VkNet.Abstractions;

namespace VKBot
{
    public interface IVkBot
    {
        event EventHandler<MessageEventArgs> ReceiveMessage;
        event EventHandler<MessageEventArgs> SendMessage;

        IVkApi VkApi { get; }

        void Run();
        Task RunAsync();

        void AddBehaviour(Behaviour behaviour);
        Behaviour GetBehaviour<T>() where T : Behaviour;
        Behaviour[] GetBehaviours<T>() where T : Behaviour;
        Behaviour[] GetBehaviours();
    }
}
