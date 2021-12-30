using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor.Components
{
    public partial class PersonRenderer : ComponentBase
    {
        [Parameter]
        public IPerson Person { get; set; }
        [Parameter]
        public EventCallback<IPerson> OnClickPersonEventCallback { get; set; }

        private void FireOnClickPersonEventCallback()
        {
            if (OnClickPersonEventCallback.HasDelegate)
                OnClickPersonEventCallback.InvokeAsync(Person);
        }
    }
}
