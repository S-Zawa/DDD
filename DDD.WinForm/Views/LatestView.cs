using DDD.WinForm.ViewModels;

namespace DDD.WinForm.Views
{
    public partial class LatestView : BaseForm
    {
        public LatestView()
        {
            InitializeComponent();
            var viewModel = new LatestViewModel();

            this.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureDate));
            MeasureViewLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
        }
    }
}