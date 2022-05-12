// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class LinearGradientBrushExtensions
{
    // StartPointProperty

    public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.LinearGradientBrush.StartPointProperty] = value;
        return obj;
    }

    public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.LinearGradientBrush.StartPointProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush obj, IObservable<Avalonia.RelativePoint> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.LinearGradientBrush.StartPointProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindStartPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.LinearGradientBrush.StartPointProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.RelativePoint> ObserveStartPoint(this Avalonia.Media.LinearGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.LinearGradientBrush.StartPointProperty);
    }

    // EndPointProperty

    public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.LinearGradientBrush.EndPointProperty] = value;
        return obj;
    }

    public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.LinearGradientBrush.EndPointProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush obj, IObservable<Avalonia.RelativePoint> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.LinearGradientBrush.EndPointProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindEndPoint(this Avalonia.Media.LinearGradientBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.LinearGradientBrush.EndPointProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.RelativePoint> ObserveEndPoint(this Avalonia.Media.LinearGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.LinearGradientBrush.EndPointProperty);
    }
}
