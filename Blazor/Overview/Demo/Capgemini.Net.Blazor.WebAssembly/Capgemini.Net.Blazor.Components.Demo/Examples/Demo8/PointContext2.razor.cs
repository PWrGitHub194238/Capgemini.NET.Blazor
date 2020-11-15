﻿using Capgemini.Net.Blazor.Components.Demo.Examples.Demo8.End;
using Microsoft.AspNetCore.Components;

namespace Capgemini.Net.Blazor.Components.Demo.Examples.Demo8
{
    public partial class PointContext2
    {
        [Parameter]
        public int Example { get; set; }

        private readonly RateContext rateContext = new RateContext()
        {
            MaxRate = 3
        };
    }
}
