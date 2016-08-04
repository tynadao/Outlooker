using Outlooker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Outlooker.Controllers
{
    public class RepliesController : ApiController
    {
        private IOutlookerRepository _repo;
        public RepliesController(IOutlookerRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Reply> Get(int topicId)
        {
            return _repo.GetRepliesByTopic(topicId);
        }
    }
}
