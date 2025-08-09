using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;

namespace MyFarmWeb.Repository
{
    public class CustomFormValidation : ComponentBase
    {

        [CascadingParameter]
        public EditContext EditContext { get; set; }
        private ValidationMessageStore _validationMessageStore;

        protected override void OnInitialized()
        {
            _validationMessageStore = new(EditContext);
            EditContext.OnValidationRequested += (sender, o) => _validationMessageStore.Clear();
            EditContext.OnFieldChanged += (sender, o) => _validationMessageStore.Clear(o.FieldIdentifier);
        }
        public void ClearAllErrors()
        {
            _validationMessageStore.Clear();
            EditContext.NotifyValidationStateChanged();
        }
        public void DisplayAllErrors(Dictionary<string, string> errors)
        {
            foreach (var error in errors)
            {
                _validationMessageStore.Add(EditContext.Field(error.Key), error.Value);

            }
            EditContext.NotifyValidationStateChanged();

        }
    }
}
