using System.Collections.ObjectModel;
using WPFBackupMaker.ViewModels;
using WPFBackupMaker.ViewModels.Tabs;

namespace WPFBackupMaker
{
    class MainWindowViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ITabItemViewModel> _tabCollection = [];
        public ObservableCollection<ITabItemViewModel> TabCollection
        {
            get { return _tabCollection; }
        }

        public MainWindowViewModel()
        {
            _tabCollection.Add(new UIKitAtomsViewModel());
            _tabCollection.Add(new UIKitMoleculesViewModel());
            _tabCollection.Add(new UIKitOrganismsViewModel());
            SelectedTabIndex = 0;
        }

        private int _selectedTabIndex;

        public int SelectedTabIndex
        {
            get { return _selectedTabIndex; }
            set
            {
                SetProperty(ref _selectedTabIndex, value);
            }
        }
    }
}
