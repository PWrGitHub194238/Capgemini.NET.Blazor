﻿using Capgemini.Net.Blazor.Components.Demo;

namespace Capgemini.Net.Blazor.Components.Demo05.End
{
    public partial class RateComponent : RateComponentBase
    {
        protected override void OnParametersSet()
        {
            if (Rate >= RateContext.MaxRate)
            {
                Rate = RateContext.MaxRate;
            }
        }
    }
}
