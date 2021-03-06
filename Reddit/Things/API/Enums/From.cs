﻿namespace Reddit.Things.API.Enums
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public sealed class From
    {
        internal readonly string Arg;

        public static readonly From ThisYear = new From("year");
        public static readonly From ThisMonth = new From("month");
        public static readonly From ThisWeek = new From("week");
        public static readonly From Today = new From("day");
        public static readonly From ThisHour = new From("hour");
        public static readonly From AllTime = new From("all");

        private From(string Name)
        {
            this.Arg = Name;
        }
    }
}