// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.RadialGradientBrush"/> class property extension methods.
/// </summary>
public static partial class RadialGradientBrushExtensions
{
    // Avalonia.Media.RadialGradientBrush.CenterProperty

    public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.RadialGradientBrush.CenterProperty] = value;
        return obj;
    }

    public static Avalonia.Media.RadialGradientBrush Center(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.RadialGradientBrush Center(
        this Avalonia.Media.RadialGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCenter(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.RelativePoint> ObserveCenter(this Avalonia.Media.RadialGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.RadialGradientBrush.CenterProperty);
    }

    public static Avalonia.Media.RadialGradientBrush OnCenter(this Avalonia.Media.RadialGradientBrush obj, Action<Avalonia.Media.RadialGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RadialGradientBrush.CenterProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RadialGradientBrush.GradientOriginProperty

    public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.RadialGradientBrush.GradientOriginProperty] = value;
        return obj;
    }

    public static Avalonia.Media.RadialGradientBrush GradientOrigin(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.GradientOriginProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.RadialGradientBrush GradientOrigin(
        this Avalonia.Media.RadialGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.GradientOriginProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindGradientOrigin(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.GradientOriginProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.RelativePoint> ObserveGradientOrigin(this Avalonia.Media.RadialGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.RadialGradientBrush.GradientOriginProperty);
    }

    public static Avalonia.Media.RadialGradientBrush OnGradientOrigin(this Avalonia.Media.RadialGradientBrush obj, Action<Avalonia.Media.RadialGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RadialGradientBrush.GradientOriginProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RadialGradientBrush.RadiusProperty

    public static Avalonia.Media.RadialGradientBrush Radius(this Avalonia.Media.RadialGradientBrush obj, System.Double value)
    {
        obj[Avalonia.Media.RadialGradientBrush.RadiusProperty] = value;
        return obj;
    }

    public static Avalonia.Media.RadialGradientBrush Radius(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.RadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.RadialGradientBrush Radius(
        this Avalonia.Media.RadialGradientBrush obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.RadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindRadius(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.RadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<System.Double> ObserveRadius(this Avalonia.Media.RadialGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.RadialGradientBrush.RadiusProperty);
    }

    public static Avalonia.Media.RadialGradientBrush OnRadius(this Avalonia.Media.RadialGradientBrush obj, Action<Avalonia.Media.RadialGradientBrush, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RadialGradientBrush.RadiusProperty);
        handler(obj, observable);
        return obj;
    }
}
