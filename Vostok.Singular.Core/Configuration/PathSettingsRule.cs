﻿using System;

namespace Vostok.Singular.Core
{
    [Serializable]
    internal class PathSettingsRule
    {
        public string Method;

        public string PathPattern;

        public string SettingsAlias;

        public TimeSpan? TimeBudget;

        public StrategySettings StrategySettings;

        public RedirectSettings RedirectSettings;
    }
}