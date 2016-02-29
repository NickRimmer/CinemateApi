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
using System.Linq;
using CinemateApi.Enums;
using CinemateApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemateApitTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Account_GetAuth_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);

            var result = cinemate.Account.GetAuth(Constants.UserName, Constants.Password);

            Assert.IsNotNull(result, "result is empty");
            Assert.IsNotNull(result.PassKey, "passkey is empty");
            Console.WriteLine("passkey: {0}", result.PassKey);
        }

        [TestMethod]
        public void Account_GetProfile_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.GetProfile();

            Assert.IsNotNull(result, "result is empty");
            Assert.IsNotNull(result.UserName, "unexpected result");
        }

        [TestMethod]
        public void Account_GetUpdateList_Test()
        {
            //throw new NotImplementedException();

            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.GetUpdateList(true);

            Assert.IsNotNull(result, "result is empty");
        }

        [TestMethod]
        public void Account_GetWatchList_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.GetWatchList();

            Assert.IsNotNull(result, "result is empty");
            Assert.IsNotNull(result.Movie, "unexpected result");
        }

        [TestMethod]
        public void Account_GetMovieBox_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.GetMovieBox();

            Assert.IsNotNull(result, "result is empty");
            Assert.IsNotNull(result.MovieBox, "unexpected result");
        }

        [TestMethod]
        public void Account_AddMovieBox_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.AddMovieBox(137456);

            Assert.IsNotNull(result, "result is empty");
            Assert.IsNotNull(result.MovieBox, "unexpected result");
        }

        [TestMethod]
        public void Account_DeleteMovieBox_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var movieBox = cinemate.Account.GetMovieBox();

            var count_before = movieBox.MovieBox.Count;

            Assert.IsNotNull(movieBox, "result is empty");
            Assert.IsTrue(count_before>0, "can't test with empty list");


            cinemate.Account.DeleteMovieBox(137456);
            movieBox = cinemate.Account.GetMovieBox();

            Assert.IsTrue(movieBox.MovieBox.Count.Equals(count_before-1), "unexpected result");
        }

        [TestMethod]
        public void Account_GetVotes_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.GetVotes();

            Assert.IsNotNull(result, "result is empty");
        }

        [TestMethod]
        public void Account_AddVotes_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.AddVote(157582, VoteValueEnum.Negative);

            Assert.IsNotNull(result, "result is empty");
            Assert.IsNotNull(result.Vote.SingleOrDefault(), "unexpected result");
        }

        [TestMethod]
        public void Account_DeleteVote_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);
            var result = cinemate.Account.DeleteVote(157582);

            Assert.IsNotNull(result, "result is empty");
        }
    }
}