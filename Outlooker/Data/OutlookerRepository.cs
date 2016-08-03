using System.Linq;

namespace Outlooker.Data
{
    public class OutlookerRepository : IOutlookerRepository
    {
        OutlookerContext _ctx;
        public OutlookerRepository(OutlookerContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Topic> GetTopics()
        {
            return _ctx.Topics;
        }

        public IQueryable<Reply> GetRepliesByTopic(int topicId)
        {
            return _ctx.Replies.Where(r => r.TopicId == topicId);
        }
    }
}