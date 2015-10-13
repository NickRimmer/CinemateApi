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

using System.Collections.Generic;
using CinemateApi.Models.Response;
using CinemateApi.Tools;

namespace CinemateApi.Methods
{
    /// <summary>
    /// Collection of "person" methods
    /// </summary>
    public class PersonMethods
    {
        private Cinemate _cinemate;

        /// <summary>
        /// /// Collection of "person" methods
        /// </summary>
        /// <param name="cinemate">instance of <see cref="Cinemate"/>, with prepared preferences</param>
        public PersonMethods(Cinemate cinemate)
        {
            _cinemate = cinemate;
        }

        #region "person.search" method
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/person.search/
        /// </summary>
        /// <param name="searchName">name or part for search</param>
        public PersonSearchResponseModel GetSearch(string searchName)
        {
            var args = new Dictionary<string, object>
            {
                { "apikey", _cinemate.ApiKey },
                { "term", searchName },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<PersonSearchResponseModel>(_cinemate.BaseUrl, "person.search", args);
        }
        #endregion

        #region "person.movies" method
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/person.movies/
        /// </summary>
        /// <param name="id">id of person</param>
        /// <returns></returns>
        public PersonMoviesResponseModel GetMovies(int id)
        {
            var args = new Dictionary<string, object>
            {
                { "apikey", _cinemate.ApiKey },
                { "id", id },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<PersonMoviesResponseModel>(_cinemate.BaseUrl, "person.movies", args);
        }
        #endregion

        #region "person" method
        /// <summary>
        /// info about person (i don't know for what, don't ask me)
        /// </summary>
        /// <param name="id">id of person</param>
        /// <returns></returns>
        public PersonInfoResponseModel GetInfo(int id)
        {
            var args = new Dictionary<string, object>
            {
                { "apikey", _cinemate.ApiKey },
                { "id", id },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<PersonInfoResponseModel>(_cinemate.BaseUrl, "person", args);
        }
        #endregion
    }
}