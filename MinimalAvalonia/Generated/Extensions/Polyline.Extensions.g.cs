// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class PolylineExtensions
{
    // PointsProperty

    public static T Points<T>(this T obj, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline
    {
        obj[Avalonia.Controls.Shapes.Polyline.PointsProperty] = value;
        return obj;
    }

    public static T Points<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Shapes.Polyline
    {
        obj[Avalonia.Controls.Shapes.Polyline.PointsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Points<T>(this T obj, IObservable<System.Collections.Generic.IList<Avalonia.Point>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Shapes.Polyline
    {
        obj[Avalonia.Controls.Shapes.Polyline.PointsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPoints(this Avalonia.Controls.Shapes.Polyline obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Shapes.Polyline.PointsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Collections.Generic.IList<Avalonia.Point>> ObservePoints(this Avalonia.Controls.Shapes.Polyline obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Polyline.PointsProperty);
    }
}
