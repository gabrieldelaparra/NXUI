// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.PolyLineSegment"/> class property extension methods.
/// </summary>
public static partial class PolyLineSegmentExtensions
{
    // Avalonia.Media.PolyLineSegment.PointsProperty

    public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment obj, Avalonia.Points value)
    {
        obj[Avalonia.Media.PolyLineSegment.PointsProperty] = value;
        return obj;
    }

    public static Avalonia.Media.PolyLineSegment Points(
        this Avalonia.Media.PolyLineSegment obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.PolyLineSegment Points(
        this Avalonia.Media.PolyLineSegment obj,
        IObservable<Avalonia.Points> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPoints(
        this Avalonia.Media.PolyLineSegment obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Points> ObservePoints(this Avalonia.Media.PolyLineSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.PolyLineSegment.PointsProperty);
    }

    public static Avalonia.Media.PolyLineSegment OnPoints(this Avalonia.Media.PolyLineSegment obj, Action<Avalonia.Media.PolyLineSegment, IObservable<Avalonia.Points>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PolyLineSegment.PointsProperty);
        handler(obj, observable);
        return obj;
    }
}
