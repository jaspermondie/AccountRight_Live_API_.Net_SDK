﻿using MYOB.AccountRight.SDK.Communication;
using MYOB.AccountRight.SDK.Contracts.Version2;

namespace MYOB.AccountRight.SDK.Services
{
    /// <summary>
    /// A service that provides access to the <see cref="CurrentUser"/> resources
    /// </summary>
    public class CurrentUserService : GetOnlyService<CurrentUser> // : ServiceBase
    {       
        /// <summary>
        /// Initialise a service that can use <see cref="CurrentUser"/> resources
        /// </summary>
        /// <param name="configuration">The configuration required to communicate with the API service</param>
        /// <param name="webRequestFactory">A custom implementation of the <see cref="WebRequestFactory"/>, if one is not supplied a default <see cref="WebRequestFactory"/> will be used.</param>
        /// <param name="keyService">An implementation of a service that will store/persist the OAuth tokens required to communicate with the cloud based API at http://api.myob.com/accountright </param>
        public CurrentUserService(IApiConfiguration configuration, IWebRequestFactory webRequestFactory = null, IOAuthKeyService keyService = null)
            : base(configuration, webRequestFactory, keyService)
        {
        }

        internal override string Route { get { return "CurrentUser"; } }
    }
}