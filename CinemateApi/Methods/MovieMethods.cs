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
using System.Net;
using System.Text;
using CinemateApi.Enums;
using CinemateApi.Models.Response;
using CinemateApi.Tools;

namespace CinemateApi.Methods
{
    /// <summary>
    /// Collection of "movie" methods
    /// </summary>
    public class MovieMethods
    {
        private Cinemate _cinemate;

        /// <summary>
        /// Collection of "movie" methods
        /// </summary>
        /// <param name="cinemate">instance of <see cref="Cinemate"/>, with prepared preferences</param>
        public MovieMethods(Cinemate cinemate)
        {
            _cinemate = cinemate;
        }

        #region "movie.list" method
        /// <summary>
        /// Short version of <see cref="GetList"/>.
        /// </summary>
        /// <param name="page">page number</param>
        /// <param name="perPage">results per page</param>
        /// <returns>Soon movies list</returns>
        public MovieListResponseModel GetSoonList(
            int page = 0,
            int perPage = 25)
        {
            return GetList(page: page, perPage: perPage, state: MovieStateEnum.Soon);
        }

        /// <summary>
        /// Short version of <see cref="GetList"/>.
        /// </summary>
        /// <param name="page">page number</param>
        /// <param name="perPage">results per page</param>
        /// <returns>Current movies list</returns>
        public MovieListResponseModel GetCurrentList(
            int page = 0,
            int perPage = 25)
        {
            return GetList(page: page, perPage: perPage, state: MovieStateEnum.Cinema);
        }

        /// <summary>
        /// Api info: http://cinemate.cc/help/api/movie.list/
        /// </summary>
        public MovieListResponseModel GetList(
            int? year=null,
            string genre=null,
            string country=null,
            DateTime? dateFrom=null,
            DateTime? dateTo=null,

            int page = 0,
            int perPage = 10,

            MovieTypeEnum? type=null, 
            MovieStateEnum state= MovieStateEnum.Cinema,
            MovieViewModeEnum? mode=null,
            MovieOrderTargetEnum orderBy= MovieOrderTargetEnum.ReleaseDateRus,
            MovieOrderDirectionEnum order=MovieOrderDirectionEnum.Desc)
        {

            #region page values correction
            page = perPage < 0 ? 0 : page;
            perPage = perPage < 1 ? 1 : perPage;
            perPage = perPage > 25 ? 25 : perPage;
            #endregion

            var args = new Dictionary<string, object>
            {
                { "apikey", _cinemate.Properties.ApiKey },
                { "state", MovieEnumsConverter.GetStringValue(state) },
                { "order_by", MovieEnumsConverter.GetStringValue(orderBy) },
                { "order", MovieEnumsConverter.GetStringValue(order) },
                { "page", page },
                { "per_page", perPage },
            };

            if (type.HasValue) args.Add("type", MovieEnumsConverter.GetStringValue(type.Value));
            if (mode.HasValue) args.Add("mode", MovieEnumsConverter.GetStringValue(mode.Value));
            if (year.HasValue) args.Add("year", year);
            if (!string.IsNullOrWhiteSpace(genre)) args.Add("genre", genre);
            if (!string.IsNullOrWhiteSpace(country)) args.Add("country", country);
            if (dateFrom.HasValue) args.Add("from", dateFrom.Value.ToString("yyyy.MM.dd"));
            if (dateTo.HasValue) args.Add("to", dateTo.Value.ToString("yyyy.MM.dd"));

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<MovieListResponseModel>(_cinemate.Properties.BaseUrl, "movie.list", args);
        }
        #endregion

        #region "movie.search" method
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/movie.search/
        /// </summary>
        /// <param name="searchString">name or part of name for search</param>
        /// <returns></returns>
        public MovieSearchResponseModel GetSearch(string searchString)
        {
            var args = new Dictionary<string, object>
            {
                { "apikey", _cinemate.Properties.ApiKey },
                { "term", searchString },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<MovieSearchResponseModel>(_cinemate.Properties.BaseUrl, "movie.search", args);
        }
        #endregion

        #region "movie"
        /// <summary>
        /// Api info: http://cinemate.cc/help/api/movie/
        /// </summary>
        /// <param name="id">movie id</param>
        /// <returns></returns>
        public MovieInfoResponseModel GetInfo(int id)
        {
            var args = new Dictionary<string, object>
            {
                { "apikey", _cinemate.Properties.ApiKey },
                { "id", id },
            };

            _cinemate.BeginWaitForNextExecute();
            return RemoteHelper.DownloadJson<MovieInfoResponseModel>(_cinemate.Properties.BaseUrl, "movie", args);
        }
        #endregion
    }
}