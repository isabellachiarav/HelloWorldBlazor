using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor.Components
{
    public partial class PersonRenderer : ComponentBase
    {
        [Parameter]
        public IPerson Person { get; set; }
    }
}
