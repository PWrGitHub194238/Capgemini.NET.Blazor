﻿using Microsoft.AspNetCore.Components;

namespace Capgemini.Net.Blazor.Components.Demo06.Start
{
    public partial class ContainerComponent
    {
        private readonly RateContext rateContext = new RateContext();

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
    }
}
