using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemateApi.Enums
{
    internal static class MovieEnumsConverter
    {
        public static string GetStringValue(MovieTypeEnum value)
        {
            switch (value)
            {
                case MovieTypeEnum.Movie:
                    return "movie";

                case MovieTypeEnum.Serial:
                    return "serial";

                case MovieTypeEnum.Short:
                    return "sort";

                default:
                    throw new ArgumentOutOfRangeException(value.ToString(), value, null);
            }
        }

        public static string GetStringValue(MovieOrderDirectionEnum value)
        {
            switch (value)
            {
                case MovieOrderDirectionEnum.Asc:
                    return "asc";

                case MovieOrderDirectionEnum.Desc:
                    return "desc";

                default:
                    throw new ArgumentOutOfRangeException(value.ToString(), value, null);
            }
        }

        public static string GetStringValue(MovieOrderTargetEnum value)
        {
            switch (value)
            {
                case MovieOrderTargetEnum.CreateDate:
                    return "create_date";

                case MovieOrderTargetEnum.ReleaseDateWorld:
                    return "release_date";

                case MovieOrderTargetEnum.ReleaseDateRus:
                    return "ru_release_date";

                default:
                    throw new ArgumentOutOfRangeException(value.ToString(), value, null);
            }
        }

        public static string GetStringValue(MovieStateEnum value)
        {
            switch (value)
            {
                case MovieStateEnum.Cinema:
                    return "cinema";

                case MovieStateEnum.Soon:
                    return "soon";

                default:
                    throw new ArgumentOutOfRangeException(value.ToString(), value, null);
            }
        }

        public static string GetStringValue(MovieViewModeEnum value)
        {
            switch (value)
            {
                case MovieViewModeEnum.Best:
                    return "best";
                    
                default:
                    throw new ArgumentOutOfRangeException(value.ToString(), value, null);
            }
        }

        public static MovieTypeEnum GetMovieTypeEnum(string value)
        {
            switch (value.ToLower().Trim())
            {
                case "movie":
                case "movies":
                    return MovieTypeEnum.Movie;

                case "serial":
                case "serials":
                    return MovieTypeEnum.Serial;
                
                case "short":
                case "shorts":
                    return MovieTypeEnum.Short;

                default:
                    throw new ArgumentOutOfRangeException(value, value, null);
            }
        }
    }
}
