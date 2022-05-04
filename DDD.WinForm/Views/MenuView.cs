namespace DDD.WinForm.Views
{
    public partial class MenuView : BaseForm
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            using (var f = new MeasureView())
            {
                f.ShowDialog();
            }
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            using (var f = new LatestView())
            {
                f.ShowDialog();
            }
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            using (var f = new MeasureListView())
            {
                f.ShowDialog();
            }
        }
    }
}