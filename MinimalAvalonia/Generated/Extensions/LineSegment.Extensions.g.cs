// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class LineSegmentExtensions
{
    // PointProperty

    public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.LineSegment.PointProperty] = value;
        return obj;
    }

    public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.LineSegment.PointProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment obj, IObservable<Avalonia.Point> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.LineSegment.PointProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPoint(this Avalonia.Media.LineSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.LineSegment.PointProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Point> ObservePoint(this Avalonia.Media.LineSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.LineSegment.PointProperty);
    }
}
