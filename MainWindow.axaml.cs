using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace SeaLevelPressurePredictor;

public partial class MainWindow : Window
{
    private bool _isUpdatingText;

    public MainWindow()
    {
        InitializeComponent();
        TextBox_High = this.FindControl<TextBox>("TextBox_High");
        TextBox_Pressure = this.FindControl<TextBox>("TextBox_Pressure");
        TextBox_High.TextChanged += TextBox_High_TextChanged;
        TextBox_Pressure.TextChanged += TextBox_Pressure_TextChanged;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void TextBox_High_TextChanged(object sender, RoutedEventArgs e)
    {
        if (!_isUpdatingText)
        {
            _isUpdatingText = true;
            TextBox_Pressure.Text = ((TextBox)sender).Text;
            _isUpdatingText = false;
        }
    }
    private void TextBox_Pressure_TextChanged(object sender, RoutedEventArgs e)
    {
        if (!_isUpdatingText)
        {
            _isUpdatingText = true;
            TextBox_High.Text = ((TextBox)sender).Text;
            _isUpdatingText = false;
        }
    }
}
