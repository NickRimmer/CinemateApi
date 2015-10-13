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
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
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
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
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
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
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
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        public static string GetStringValue(MovieViewModeEnum value)
        {
            switch (value)
            {
                case MovieViewModeEnum.Best:
                    return "best";
                    
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
