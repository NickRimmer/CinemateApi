#region Copyright
// Library for use www.cinemate.cc API
// Copyright (C) 2015 Nick Rimmer. Contacts: <xan@dipteam.com>
// 
// This file is part of CinemateApi.
// 
// CinemateApi is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// License: http://opensource.org/licenses/GPL-2.0
#endregion

using System;
using System.Threading;
using CinemateApi.Methods;

namespace CinemateApi
{
    /// <summary>
    /// Main class for use Cinemate.cc API
    /// </summary>
    public class Cinemate
    {
        /// <summary>
        /// Base url for requests
        /// </summary>
        internal string BaseUrl { get; private set; }

        /// <summary>
        /// Api key for access to API
        /// </summary>
        internal string ApiKey { get; private set; }

        /// <summary>
        /// Collection of "movie" methods
        /// </summary>
        public MovieMethods Movie;

        /// <summary>
        /// Collection of "stats" methods
        /// </summary>
        public StatsMethods Stats;

        /// <summary>
        /// Collection of "person" methods
        /// </summary>
        public PersonMethods Person;

        /// <summary>
        /// Collection of "acount" methods
        /// </summary>
        public AccountMethods Account;

        #region cinemate.cc frequency limits
        private const int MinWaitTimeMs = 1000;
        private DateTime _lastTimeExecute = DateTime.MinValue;

        internal TimeSpan WaitToNextExecute
        {
            get
            {
                var result = MinWaitTimeMs - ((DateTime.Now - _lastTimeExecute).TotalMilliseconds);
                return TimeSpan.FromMilliseconds(result > 0 ? result : 0);
            }
        }

        internal void BeginWaitForNextExecute()
        {
            Thread.Sleep(WaitToNextExecute);
            _lastTimeExecute=DateTime.Now;
        }
        #endregion

        /// <summary>
        /// Main class for use Cinemate.cc API
        /// </summary>
        /// <param name="baseUrl">base url for requests</param>
        /// <param name="apiKey">api key for access to API</param>
        public Cinemate(string baseUrl, string apiKey=null)
        {
            BaseUrl = baseUrl;
            ApiKey = apiKey;

            Movie = new MovieMethods(this);
            Stats = new StatsMethods(this);
            Person = new PersonMethods(this);
            Account = new AccountMethods(this);
        }

    }
}
