// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DashStyleExtensions
{
    // DashesProperty

    public static T Dashes<T>(this T obj, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Media.DashStyle
    {
        obj[Avalonia.Media.DashStyle.DashesProperty] = value;
        return obj;
    }

    public static T Dashes<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.DashStyle
    {
        obj[Avalonia.Media.DashStyle.DashesProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Dashes<T>(this T obj, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.DashStyle
    {
        obj[Avalonia.Media.DashStyle.DashesProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDashes(this Avalonia.Media.DashStyle obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.DashStyle.DashesProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Collections.AvaloniaList<System.Double>> ObserveDashes(this Avalonia.Media.DashStyle obj)
    {
        return obj.GetObservable(Avalonia.Media.DashStyle.DashesProperty);
    }

    // OffsetProperty

    public static T Offset<T>(this T obj, System.Double value) where T : Avalonia.Media.DashStyle
    {
        obj[Avalonia.Media.DashStyle.OffsetProperty] = value;
        return obj;
    }

    public static T Offset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.DashStyle
    {
        obj[Avalonia.Media.DashStyle.OffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Offset<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.DashStyle
    {
        obj[Avalonia.Media.DashStyle.OffsetProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindOffset(this Avalonia.Media.DashStyle obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.DashStyle.OffsetProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveOffset(this Avalonia.Media.DashStyle obj)
    {
        return obj.GetObservable(Avalonia.Media.DashStyle.OffsetProperty);
    }
}
