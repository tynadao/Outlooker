using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlooker.Data
{
    public interface IOutlookerRepository
    {
        IQueryable<Topic> GetTopics();
        IQueryable<Topic> GetTopicsIncludingReplies();
        IQueryable<Reply> GetRepliesByTopic(int topicId);

        bool Save();
        bool AddTopic(Topic newTopic);
        bool AddReply(Reply newReply);
    }
}
