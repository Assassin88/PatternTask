using System;

namespace Task6_Chat
{
    class User
    {
        private readonly string _name;

        public User(string name)
        {
            _name = name;
        }

        public void AddUser(Chat chat)
        {
            chat.SignOn(this);
        }

        public virtual void RecieveMessage(string message, string from)
        {
            if (_name != from)
            {
                Console.WriteLine("{0} => {1}: {2}", from, _name, message);
            }
        }

        public void Send(string message, Chat chat)
        {
            if (chat != null)
            {
                Console.WriteLine("{0} ===> {1}", _name, message);
                chat.SendMessage(message, _name);
            }
        }

        public Chat LocalGroup(params User[] users)
        {
            var localChat = new Chat();
            AddUser(localChat);
            foreach (var item in users)
            {
                item.AddUser(localChat);
            }
            return localChat;
        }
    }
}
