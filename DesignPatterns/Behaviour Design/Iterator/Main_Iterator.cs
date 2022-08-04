using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    //Use the Iterator pattern when your collection has a complex
    //data structure under the hood, but you want to hide its complexity
    //from clients(either for convenience or security
    //reasons).

    //Use the pattern to reduce duplication of the traversal code
    //across your app.

    //Use the Iterator when you want your code to be able to traverse
    //different data structures or when types of these structures
    //are unknown beforehand.

    public static class Main_Iterator
    {
        private static ISocialNetwork network = new Facebook();
        private static SocialSpammer spammer = new SocialSpammer();

        public static void Init()
        {
            var profile1 = new Profile(1);
            var profile2 = new Profile(2);
            network.SetupMockData();

            Console.WriteLine("--- <Profile 1> ---");
            SendSpamToFriends(profile1);
            SendSpamToCoworkers(profile1);

            Console.WriteLine("--- <Profile 2> ---");
            SendSpamToFriends(profile2);
            SendSpamToCoworkers(profile2);
        }

        private static void SendSpamToFriends(Profile profile)
        {
            var iterator = network.CreateFriendsIterator(profile.id);
            spammer.Send(iterator, "Your all are precious");
        }

        private static void SendSpamToCoworkers(Profile profile)
        {
            var iterator = network.CreateCoworkersIterator(profile.id);
            spammer.Send(iterator, "Your all are sucks");
        }

    }
}
