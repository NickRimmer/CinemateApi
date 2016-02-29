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
using System.Collections.Generic;
using CinemateApi.Enums;
using CinemateApi.Models.Remote;
using CinemateApi.Models.Response;
using CinemateApi.Tools;

namespace CinemateApi.Methods
{
    public class AccountMethods
    {
        private Cinemate _cinemate;

        /// <summary>
        /// Collection of "account" methods
        /// </summary>
        /// <param name="cinemate">instance of <see cref="Cinemate"/>, with prepared preferences</param>
        public AccountMethods(Cinemate cinemate)
        {
            _cinemate = cinemate;
        }

        #region "account.auth"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.auth/
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="userPassword">password</param>
        /// <returns></returns>
        public AccountResponseModel GetAuth(string userName, string userPassword)
        {
            var args = new Dictionary<string, object>
            {
                { "username", userName },
                { "password", userPassword },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountResponseModel>(_cinemate.Properties.BaseUrl, "account.auth", args);
        }
        #endregion

        #region "account.profile"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.profile/
        /// </summary>
        /// <returns></returns>
        public AccountProfileResponseModel GetProfile()
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountProfileResponseModel>(_cinemate.Properties.BaseUrl, "account.profile", args);
        }
        #endregion

        #region "account.updatelist"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.updatelist/
        /// </summary>
        /// <returns></returns>
        public AccountUpdateListResponseModel GetUpdateList(bool newOnly = false)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey },
                { "newonly" , newOnly ? 1 : 0}
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountUpdateListResponseModel>(_cinemate.Properties.BaseUrl, "account.updatelist", args);
        }
        #endregion

        #region "account.watchlist"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.watchlist/
        /// </summary>
        /// <returns></returns>
        public AccountWatchListResponseModel GetWatchList()
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey }
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountWatchListResponseModel>(_cinemate.Properties.BaseUrl, "account.watchlist", args);
        }
        #endregion

        #region "account.moviebox"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.moviebox/
        /// </summary>
        /// <returns></returns>
        public AccountMovieBoxResponseModel GetMovieBox(int? page=null)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey }
            };

            if (page.HasValue) args.Add("page", page.Value < 0 ? 0 : page.Value);

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountMovieBoxResponseModel>(_cinemate.Properties.BaseUrl, "account.moviebox", args);
        }

        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.moviebox/
        /// </summary>
        /// <returns></returns>
        public AccountMovieBoxResponseModel DeleteMovieBox(int movieId)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey },
                { "movie_id", movieId }
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountMovieBoxResponseModel>(_cinemate.Properties.BaseUrl, "account.moviebox", args, HttpMethodEnum.Delete);
        }

        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.moviebox/
        /// </summary>
        /// <returns></returns>
        public AccountMovieBoxResponseModel AddMovieBox(int movieId)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey },
                { "movie_id", movieId }
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountMovieBoxResponseModel>(_cinemate.Properties.BaseUrl, "account.moviebox", args, HttpMethodEnum.Post);
        }
        #endregion

        #region "account.votes"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.votes/
        /// </summary>
        /// <returns></returns>
        public AccountVoteResponseModel GetVotes(int? page=null, VoteValueEnum? filter=null)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey }
            };

            if (page.HasValue) args.Add("page", page < 0 ? 0 : page);
            if (filter.HasValue) args.Add("filter", (short) filter);

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountVoteResponseModel>(_cinemate.Properties.BaseUrl, "account.votes", args);
        }

        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.votes/
        /// </summary>
        /// <returns></returns>
        public AccountVoteResponseModel AddVote(int movieId, VoteValueEnum value)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey },
                { "movie_id", movieId },
                { "value", (short) value }
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountVoteResponseModel>(_cinemate.Properties.BaseUrl, "account.votes", args, HttpMethodEnum.Post);
        }

        /// <summary>
        /// Api info: http://cinemate.cc/help/api/account.votes/
        /// </summary>
        /// <returns></returns>
        public AccountVoteResponseModel DeleteVote(int movieId)
        {
            var args = new Dictionary<string, object>
            {
                { "passkey", _cinemate.Properties.PassKey },
                { "movie_id", movieId }
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<AccountVoteResponseModel>(_cinemate.Properties.BaseUrl, "account.votes", args, HttpMethodEnum.Delete);
        }
        #endregion
    }
}