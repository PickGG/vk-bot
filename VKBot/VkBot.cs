using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKBot.Args;
using VkNet.Abstractions;

namespace VKBot
{
    public class VkBot : IVkBot
    {
        #region Events
        public event EventHandler<MessageEventArgs> ReceiveMessage;
        public event EventHandler<MessageEventArgs> SendMessage;
        #endregion

        #region Properties
        public bool LongPollWatcherWorking => throw new NotImplementedException();
        public IVkApi VkApi => throw new NotImplementedException();

        int IVkBot.LongPollCheckInterval { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        public VkBot(IVkApi vkApi)
        {
            throw new NotImplementedException();
        }

        #region Methods

        public void RunLongPollWatcher()
        {
            throw new NotImplementedException();
        }

        public Task RunLongPollWatcherAsync()
        {
            throw new NotImplementedException();
        }

        public void StopLongPollWatcher()
        {
            throw new NotImplementedException();
        }

        public void AddBehaviour(Behaviour behaviour)
        {
            throw new NotImplementedException();
        }
        
        public Behaviour GetBehaviour<T>() where T : Behaviour
        {
            throw new NotImplementedException();
        }

        public Behaviour[] GetBehaviours<T>() where T : Behaviour
        {
            throw new NotImplementedException();
        }

        public Behaviour[] GetBehaviours()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
