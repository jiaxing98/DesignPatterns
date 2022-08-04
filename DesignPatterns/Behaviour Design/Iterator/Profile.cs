using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public enum SocialType
    {
        Friend = 0,
        Coworker = 1
    }

    public class Profile
    {
        public int id { get; set; }
        public List<Profile> friends = new List<Profile>();
        public List<Profile> coworkers = new List<Profile>();

        public Profile(int id)
        {
            this.id = id;
        }

        public void AddFriend(Profile friend)
        {
            friends.Add(friend);
        }

        public void AddCoworker(Profile coworker)
        {
            coworkers.Add(coworker);
        }
    }

    // Here is another useful trick: you can pass an iterator to a
    // client class instead of giving it access to a whole
    // collection. This way, you don't expose the collection to the
    // client.

    // And there's another benefit: you can change the way the
    // client works with the collection at runtime by passing it a
    // different iterator. This is possible because the client code
    // isn't coupled to concrete iterator classes.

    public class SocialSpammer
    {
        public void Send(IProfileIterator iterator, string message)
        {
            while (iterator.HasMore())
            {
                var profile = iterator.GetNext();
                if (profile != null)
                    Console.WriteLine($"Sending message: {message} to profile {profile.id}");
            }
        }
    }
}
