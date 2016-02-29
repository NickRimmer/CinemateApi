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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CinemateApitTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Person_GetSearch_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);

            var result = cinemate.Person.GetSearch("Хью Лори");

            Assert.IsNotNull(result.Person, "result person is empty");
            Assert.IsTrue(result.Person.Any(), "unexpected empty result");

        }

        [TestMethod]
        public void Person_GetMovies_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);

            var result = cinemate.Person.GetMovies(2103);

            Assert.IsNotNull(result.Person, "result person is empty");
            Assert.IsTrue(result.Person.Movies.AsActor.Movie.Any() || result.Person.Movies.AsDirector.Movie.Any(), "unexpected empty result");

        }

        [TestMethod]
        public void Person_GetInfo_Test()
        {
            var cinemate = new CinemateApi.Cinemate(Constants.Properties);

            var result = cinemate.Person.GetInfo(2103);

            Assert.IsNotNull(result.Person, "result person is empty");
        }
    }
}