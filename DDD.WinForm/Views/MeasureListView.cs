using DDD.WinForm.ViewModels;

namespace DDD.WinForm.Views
{
    public partial class MeasureListView : BaseForm
    {
        public MeasureListView()
        {
            InitializeComponent();
            var viewModel = new MeasureListViewModel();

            MeasureDataGrid.DataBindings.Add("DataSource", viewModel, nameof(viewModel.Measures));
        }
    }
}