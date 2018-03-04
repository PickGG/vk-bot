using System;
using System.Threading.Tasks;
using VKBot.Args;
using VkNet.Abstractions;

namespace VKBot
{
    public interface IVkBot : IDisposable
    {
        event EventHandler<MessageEventArgs> ReceiveMessage;
        event EventHandler<MessageEventArgs> SendMessage;

        IVkApi VkApi { get; }
        int LongPollCheckInterval { get; }
        bool LongPollWatcherWorking { get; }

        void RunLongPollWatcher();
        Task RunLongPollWatcherAsync();
        void StopLongPollWatcher();

        void AddBehaviour(Behaviour behaviour);
        Behaviour GetBehaviour<T>() where T : Behaviour;
        Behaviour[] GetBehaviours<T>() where T : Behaviour;
        Behaviour[] GetBehaviours();
    }
}
