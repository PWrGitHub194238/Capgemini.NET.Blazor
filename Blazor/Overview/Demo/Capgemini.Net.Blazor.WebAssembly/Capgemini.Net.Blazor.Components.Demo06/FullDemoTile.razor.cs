﻿using Capgemini.Net.Blazor.Shared.Interfaces.Context;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace Capgemini.Net.Blazor.Components.Demo06
{
    [Route(DemoTile.Href)]
    [Route(DemoTile.Href + "/{*pageRoute}")]
    public partial class FullDemoTile : ComponentBase
    {
        [Parameter]
        public string PageRoute { get; set; } = default!;

        internal static DemoChecklistContext Context => new DemoChecklistContext
        {
            Name = typeof(FullDemoTile).FullName!,
            Points = new Collection<DemoChecklistPointContext>()
            {
                new DemoChecklistPointContext
                {
                    Name = "Add generic parameter to the RenderFragment",
                    Order = 1,
                    IsDone = false,
                    Label = "Add a payload to the render fragment to pass a context object",
                    Content = PointContext1!
                },
                new DemoChecklistPointContext
                {
                    Name = "Pass context object to child component",
                    Order = 2,
                    IsDone = false,
                    Label = "Pass context object to the child component",
                    Content = PointContext2!
                }
            }
        };
    }
}
