using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemateApi.Models;

namespace CinemateApitTests
{
    public static class Constants
    {
        public static string 
            BaseUrl = "http://api.cinemate.cc",

            //TODO set your api key
            ApiKey = "",

			//TODO set your pass key
			PassKey = "",

			//TODO set your user name
			UserName = "",
            
            //TODO set your password
            Password = "";

		public static CinimateProperties Properties 
			= new CinimateProperties { BaseUrl = BaseUrl, PassKey = PassKey, ApiKey = ApiKey };
	}
}
