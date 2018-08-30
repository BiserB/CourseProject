using Microsoft.AspNetCore.Http;
using Vote.Common;

namespace Vote.App.Infrastructure.Session
{
    public static class SessionHelper
    {
        public static void SetPollId(this ISession session, string key, string value)
        {
            session.SetString(key, value);
        }

        public static bool VotedInPoll(this ISession session, string key)
        {
            var value = session.GetString(key);

            if (value == null || value != VoteConstants.Voted)
            {
                return false;
            }

            return true;
        }
    }
}