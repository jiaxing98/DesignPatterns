using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    // The common interface for all iterators.
    public interface IProfileIterator
    {
        Profile? GetNext();
        bool HasMore();
    }

    //The concrete iterator class.
    public class FacebookIterator : IProfileIterator
    {
        //The iterator needs a reference to the collection that it
        // traverses.
        private Facebook facebook;
        private int profileId;
        private SocialType socialType;

        // An iterator object traverses the collection independently
        // from other iterators. Therefore it has to store the
        // iteration state.
        private int currentPosition = -1;
        private List<Profile>? cache = new List<Profile>();

        public FacebookIterator(Facebook facebook, int profileId, SocialType socialType)
        {
            this.facebook = facebook;
            this.profileId = profileId;
            this.socialType = socialType;
        }

        private void LazyInit()
        {
            if (cache?.Count == 0)
                cache = facebook.SocialGraphRequest(profileId, socialType);

            if (cache == null)
                Console.WriteLine($"profile {profileId} not exists.");

            if(cache?.Count == 0)
            {
                Console.WriteLine($"Profile {profileId} don't have any {socialType}");
            }
        }

        // Each concrete iterator class has its own implementation
        // of the common iterator interface.
        public Profile? GetNext()
        {
            if (HasMore())
            {
                currentPosition++;
                return cache?[currentPosition];
            }
            return null;
        }

        public bool HasMore()
        {
            LazyInit();
            return currentPosition < cache?.Count - 1;
        }
    }
}
