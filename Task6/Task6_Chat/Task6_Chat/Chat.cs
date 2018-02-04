using System.Collections.Generic;

namespace Task6_Chat
{
    class Chat
    {
        private readonly ISet<User> _colleagues = new HashSet<User>();

        public void SignOn(User participant)
        {
            _colleagues.Add(participant);
        }

        public void SendMessage(string message, string from)
        {
            foreach (var item in _colleagues)
            {
                item.RecieveMessage(message, from);
            }
        }
    }
}
