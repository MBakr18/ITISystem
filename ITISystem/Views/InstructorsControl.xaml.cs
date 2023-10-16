using System.Windows;
using System.Windows.Controls;
using ITISystem.ViewModel;

namespace ITISystem.Views
{
    /// <summary>
    /// Interaction logic for InstructorsControl.xaml
    /// </summary>
    public partial class InstructorsControl : UserControl
    {
        public InstructorsControl()
        {
            InitializeComponent();
            DataContext = new InstructorsViewModel();
        }
    }
}
