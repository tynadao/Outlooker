﻿using Outlooker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Outlooker.Controllers
{
    public class TopicsController : ApiController
    {
        //rather than using Ninject for dependency injection, need WebApiContrib.IoC.Ninject for dependency injection for WebAPI
        private IOutlookerRepository _repo;
        public TopicsController(IOutlookerRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Topic> Get()
        {
            var topics = _repo.GetTopics().OrderByDescending(t => t.Created).Take(25).ToList();

            return topics;
        }
    }
}