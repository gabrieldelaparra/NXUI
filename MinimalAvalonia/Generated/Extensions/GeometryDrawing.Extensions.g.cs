// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GeometryDrawingExtensions
{
    // GeometryProperty

    public static T Geometry<T>(this T obj, Avalonia.Media.Geometry value) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.GeometryProperty] = value;
        return obj;
    }

    public static T Geometry<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.GeometryProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Geometry<T>(this T obj, IObservable<Avalonia.Media.Geometry> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.GeometryProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindGeometry(this Avalonia.Media.GeometryDrawing obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GeometryDrawing.GeometryProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Geometry> ObserveGeometry(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
    }

    public static T OnGeometry<T>(this T obj, Action<IObservable<Avalonia.Media.Geometry>> handler) where T : Avalonia.Media.GeometryDrawing
    {
        var observable = obj.GetObservable(Avalonia.Media.GeometryDrawing.GeometryProperty);
        handler(observable);
        return obj;
    }

    // BrushProperty

    public static T Brush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.BrushProperty] = value;
        return obj;
    }

    public static T Brush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.BrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Brush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.BrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBrush(this Avalonia.Media.GeometryDrawing obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GeometryDrawing.BrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBrush(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
    }

    public static T OnBrush<T>(this T obj, Action<IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Media.GeometryDrawing
    {
        var observable = obj.GetObservable(Avalonia.Media.GeometryDrawing.BrushProperty);
        handler(observable);
        return obj;
    }

    // PenProperty

    public static T Pen<T>(this T obj, Avalonia.Media.Pen value) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.PenProperty] = value;
        return obj;
    }

    public static T Pen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.PenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Pen<T>(this T obj, IObservable<Avalonia.Media.Pen> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GeometryDrawing
    {
        obj[Avalonia.Media.GeometryDrawing.PenProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPen(this Avalonia.Media.GeometryDrawing obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GeometryDrawing.PenProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Pen> ObservePen(this Avalonia.Media.GeometryDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GeometryDrawing.PenProperty);
    }

    public static T OnPen<T>(this T obj, Action<IObservable<Avalonia.Media.Pen>> handler) where T : Avalonia.Media.GeometryDrawing
    {
        var observable = obj.GetObservable(Avalonia.Media.GeometryDrawing.PenProperty);
        handler(observable);
        return obj;
    }
}
