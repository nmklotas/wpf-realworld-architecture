﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleApp.Application;

namespace SampleApp.TesonetApi
{
    public interface IServers
    {
        /// <summary>
        /// Gets servers
        /// </summary>
        /// <exception cref="AppException">Thrown if servers retrieval fails</exception>
        Task<IList<Server>> Fetch(CancellationToken cancellationToken);
    }
}