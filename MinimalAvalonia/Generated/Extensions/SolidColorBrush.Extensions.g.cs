// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SolidColorBrushExtensions
{
    // ColorProperty

    public static T Color<T>(this T obj, Avalonia.Media.Color value) where T : Avalonia.Media.SolidColorBrush
    {
        obj[Avalonia.Media.SolidColorBrush.ColorProperty] = value;
        return obj;
    }

    public static T Color<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.SolidColorBrush
    {
        obj[Avalonia.Media.SolidColorBrush.ColorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Color<T>(this T obj, IObservable<Avalonia.Media.Color> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.SolidColorBrush
    {
        obj[Avalonia.Media.SolidColorBrush.ColorProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindColor(this Avalonia.Media.SolidColorBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.SolidColorBrush.ColorProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Color> ObserveColor(this Avalonia.Media.SolidColorBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.SolidColorBrush.ColorProperty);
    }
}
