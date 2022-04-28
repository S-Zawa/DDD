using DDD.Infrastructure.Fake;
using DDD.WinForm.ViewModels;

namespace DDD.WinForm.Views
{
    public partial class MeasureView : BaseForm
    {
        public MeasureView()
        {
            InitializeComponent();
            var viewModel = new MeasureViewModel(new SensorFake());

            MeasureValueLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
            MeasureButton.Click += (sender, args) => viewModel.Measure();
        }
    }
}