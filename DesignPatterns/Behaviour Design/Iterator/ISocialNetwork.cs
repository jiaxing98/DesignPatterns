using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    //The collection interface must declare a factory method for
    // producing iterators. You can declare several methods if there
    // are different kinds of iteration available in your program.
    public interface ISocialNetwork
    {
        void SetupMockData();   //This is to inject the mock data
        IProfileIterator CreateFriendsIterator(int profileId);
        IProfileIterator CreateCoworkersIterator(int profileId);
    }

    // Each concrete collection is coupled to a set of concrete
    // iterator classes it returns. But the client isn't, since the
    // signature of these methods returns iterator interfaces.
    public class Facebook : ISocialNetwork
    {
        public List<Profile> profiles = new List<Profile>()
        {
            new Profile(1),
            new Profile(2),
            new Profile(3),
            new Profile(4)
        };

        // ... The bulk of the collection's code should go here ...
        public void SetupMockData()
        {
            profiles[0].AddFriend(profiles[1]);
            profiles[0].AddFriend(profiles[2]);
            profiles[0].AddCoworker(profiles[3]);

            profiles[1].AddCoworker(profiles[2]);
        }

        public List<Profile>? SocialGraphRequest(int profileId, SocialType socialType)
        {
            var profile = profiles.Where(x => x.id == profileId).FirstOrDefault();
            if (profile == null) return null;

            if(socialType == SocialType.Friend)
            {
                return profile.friends;
            }
            else if(socialType == SocialType.Coworker)
            {
                return profile.coworkers;
            }
            
            return null;
        }


        // Iterator creation code.
        public IProfileIterator CreateFriendsIterator(int profileId)
        {
            return new FacebookIterator(this, profileId, SocialType.Friend);
        }

        public IProfileIterator CreateCoworkersIterator(int profileId)
        {
            return new FacebookIterator(this, profileId, SocialType.Coworker);
        }
    }
}
