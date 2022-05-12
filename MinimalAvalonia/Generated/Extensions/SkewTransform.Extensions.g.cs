// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SkewTransformExtensions
{
    // AngleXProperty

    public static T AngleX<T>(this T obj, System.Double value) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleXProperty] = value;
        return obj;
    }

    public static T AngleX<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleXProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AngleX<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleXProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAngleX(this Avalonia.Media.SkewTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.SkewTransform.AngleXProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveAngleX(this Avalonia.Media.SkewTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.SkewTransform.AngleXProperty);
    }

    // AngleYProperty

    public static T AngleY<T>(this T obj, System.Double value) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleYProperty] = value;
        return obj;
    }

    public static T AngleY<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleYProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AngleY<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleYProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAngleY(this Avalonia.Media.SkewTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.SkewTransform.AngleYProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveAngleY(this Avalonia.Media.SkewTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.SkewTransform.AngleYProperty);
    }
}
