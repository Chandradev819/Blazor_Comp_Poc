using Blazor_Comp_Poc.Data;
using Blazor_Comp_Poc.Data.Service;
using Microsoft.AspNetCore.Components;

namespace Blazor_Comp_Poc.Shared
{
    public partial class AddressComponentForUSA : ComponentBase
    {
        [Inject]
        public ICurrentLocation? CurrentLocationService { get; set; }
        public LocaltionDetails? details { get; set; }

        protected override async Task OnInitializedAsync()
        {
            details = await CurrentLocationService.GetLocaltionDetails();
            StateHasChanged();
        }
    }
}
