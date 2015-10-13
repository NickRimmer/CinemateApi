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

using System.Linq;
using System.Threading;
using CinemateApi.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemateApitTests
{
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        public void MovieList_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.BaseUrl, Constants.ApiKey);

            var result = cinemate.Movie.GetSoonList();

            Assert.IsNotNull(result.Movie, "result movie is empty");
            Assert.IsTrue(result.Movie.Any(), "unexpected empty result");
        }

        [TestMethod]
        public void MovieSearch_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.BaseUrl, Constants.ApiKey);

            var result = cinemate.Movie.GetSearch("Дживс и Вустер");

            Assert.IsNotNull(result.Movie, "result movie is empty");
            Assert.IsTrue(result.Movie.Any(), "unexpected empty result");
        }

        [TestMethod]
        public void MovieInfo_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.BaseUrl, Constants.ApiKey);

            var resultSearch = cinemate.Movie.GetSearch("Дживс и Вустер");
            Assert.IsNotNull(resultSearch.Movie, "resultSearch movie is empty");
            Assert.IsTrue(resultSearch.Movie.Any(), "unexpected empty resultSearch");

            var resultInfo = cinemate.Movie.GetInfo(resultSearch.Movie.First().Id);

            Assert.IsNotNull(resultInfo.Movie, "result movie is empty");
        }
    }
}