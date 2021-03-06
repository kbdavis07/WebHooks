﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;

namespace WebHook.WebHooks
{
    /// <summary>
    /// Use an <see cref="IWebHookFilterProvider"/> implementation to describe the events that users can 
    /// subscribe to. A wildcard filter is always registered meaning that users can register for 
    /// "all events". It is possible to have 0, 1, or more <see cref="IWebHookFilterProvider"/> 
    /// implementations.
    /// </summary>
    public class CustomFilterProvider : IWebHookFilterProvider
    {
        private readonly Collection<WebHookFilter> filters = new Collection<WebHookFilter>
    {
        new WebHookFilter { Name = "New_Order", Description = "A New Order is Placed." },
        new WebHookFilter { Name = "event2", Description = "This event happened." },
    };

        public Task<Collection<WebHookFilter>> GetFiltersAsync()
        {
            return Task.FromResult(this.filters);
        }
    }


    //For Receiver
    public class TestHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            return Task.FromResult(true);
        }
    }


}