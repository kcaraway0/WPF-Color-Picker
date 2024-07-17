using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Color_Picker;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private byte _redValue;
    partial void OnRedValueChanged(byte value) => SetColor();
    [ObservableProperty]
    private byte _greenValue;
    partial void OnGreenValueChanged(byte value) => SetColor();
    [ObservableProperty]
    private byte _blueValue;
    partial void OnBlueValueChanged(byte value) => SetColor();
    [ObservableProperty]
    private SolidColorBrush _colorBrush;


    [RelayCommand]
    private void SetColor()
    {
        Color color = Color.FromRgb(_redValue, _greenValue, _blueValue);
        ColorBrush = new SolidColorBrush(color);
    }
}
