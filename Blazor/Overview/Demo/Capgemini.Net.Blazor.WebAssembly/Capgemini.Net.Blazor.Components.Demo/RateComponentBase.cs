﻿using Microsoft.AspNetCore.Components;

namespace Capgemini.Net.Blazor.Components.Demo
{
    public class RateComponentBase : ComponentBase
    {
        public static readonly string ACTIVE_STYLE = "fas";

        public static readonly string INACTIVE_STYLE = "far";

        private int rate = 0;

        private int tempRate = 0;

        protected int Rate
        {
            get => rate + 1;
            set
            {
                rate = value - 1;
                tempRate = rate;
            }
        }

        protected virtual void SetRate() => rate = tempRate;

        protected void ShowRate(int index) => tempRate = index;

        protected void RevertRate() => tempRate = rate;

        protected bool IsActive(int index) => index <= tempRate;
    }
}
