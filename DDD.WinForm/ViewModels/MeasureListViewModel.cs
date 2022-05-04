using DDD.Domain.Repositories;
using DDD.Infrastructure;
using System.ComponentModel;

namespace DDD.WinForm.ViewModels
{
    public class MeasureListViewModel : ViewModelBase
    {
        private IMeasureRepository _measureReposiory;

        public MeasureListViewModel(IMeasureRepository measureRepository)
        {
            _measureReposiory = measureRepository;
            foreach (var entity in _measureReposiory.GetData())
            {
                Measures.Add(
                    new MeasureListViewModelMeasure(
                        entity.MeasureDate.DisplayValue,
                        entity.MeasureValue.DisplayValue
                        )
                    );
            }
        }

        public MeasureListViewModel() : this(Factories.CreateMeasureRepository())
        {
        }

        public BindingList<MeasureListViewModelMeasure> Measures { get; set; } = new BindingList<MeasureListViewModelMeasure>();
    }
}