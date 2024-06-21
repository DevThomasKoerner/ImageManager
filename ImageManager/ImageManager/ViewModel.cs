using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageManager
{
  public class ViewModel : INotifyPropertyChanged
  {
    private string _selectedDirectory;
    public string SelectedDirectory
    {
      get => _selectedDirectory;
      set
      {
        _selectedDirectory = value;
        OnPropertyChanged ();
      }
    }

    private string _imageSource;
    public string ImageSource
    {
      get => _imageSource;
      set
      {
        _imageSource = value;
        OnPropertyChanged ();
      }
    }

    public ViewModel ()
    {
      // Setze hier die Logik, um das Bild dynamisch zu wählen
      // Beispiel:
      ImageSource = "";
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged ([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
    }
  }
}
