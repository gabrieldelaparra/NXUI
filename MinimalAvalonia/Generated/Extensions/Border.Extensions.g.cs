// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class BorderExtensions
{
    // BackgroundProperty

    public static T Background<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundProperty] = value;
        return obj;
    }

    public static T Background<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Background<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBackground(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BackgroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBackground(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BackgroundProperty);
    }

    // BorderBrushProperty

    public static T BorderBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderBrushProperty] = value;
        return obj;
    }

    public static T BorderBrush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderBrush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderBrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderBrush(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BorderBrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBorderBrush(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderBrushProperty);
    }

    // BorderThicknessProperty

    public static T BorderThickness<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderThicknessProperty] = value;
        return obj;
    }

    public static T BorderThickness<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderThicknessProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderThickness<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderThicknessProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderThickness(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BorderThicknessProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObserveBorderThickness(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderThicknessProperty);
    }

    // CornerRadiusProperty

    public static T CornerRadius<T>(this T obj, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.CornerRadiusProperty] = value;
        return obj;
    }

    public static T CornerRadius<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.CornerRadiusProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CornerRadius<T>(this T obj, IObservable<Avalonia.CornerRadius> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.CornerRadiusProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCornerRadius(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.CornerRadiusProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.CornerRadius> ObserveCornerRadius(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.CornerRadiusProperty);
    }

    // BoxShadowProperty

    public static T BoxShadow<T>(this T obj, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BoxShadowProperty] = value;
        return obj;
    }

    public static T BoxShadow<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BoxShadowProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BoxShadow<T>(this T obj, IObservable<Avalonia.Media.BoxShadows> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BoxShadowProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBoxShadow(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BoxShadowProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.BoxShadows> ObserveBoxShadow(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BoxShadowProperty);
    }

    // BorderDashOffsetProperty

    public static T BorderDashOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderDashOffsetProperty] = value;
        return obj;
    }

    public static T BorderDashOffset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderDashOffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderDashOffset<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderDashOffsetProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderDashOffset(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BorderDashOffsetProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveBorderDashOffset(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderDashOffsetProperty);
    }

    // BorderDashArrayProperty

    public static T BorderDashArray<T>(this T obj, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderDashArrayProperty] = value;
        return obj;
    }

    public static T BorderDashArray<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderDashArrayProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderDashArray<T>(this T obj, IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderDashArrayProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderDashArray(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BorderDashArrayProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Collections.AvaloniaList<System.Double>> ObserveBorderDashArray(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderDashArrayProperty);
    }

    // BorderLineCapProperty

    public static T BorderLineCap<T>(this T obj, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineCapProperty] = value;
        return obj;
    }

    public static T BorderLineCap<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineCapProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderLineCap<T>(this T obj, IObservable<Avalonia.Media.PenLineCap> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineCapProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderLineCap(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BorderLineCapProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.PenLineCap> ObserveBorderLineCap(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderLineCapProperty);
    }

    public static T BorderLineCapFlat<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineCapProperty] = Avalonia.Media.PenLineCap.Flat;
        return obj;
    }

    public static T BorderLineCapRound<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineCapProperty] = Avalonia.Media.PenLineCap.Round;
        return obj;
    }

    public static T BorderLineCapSquare<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineCapProperty] = Avalonia.Media.PenLineCap.Square;
        return obj;
    }

    // BorderLineJoinProperty

    public static T BorderLineJoin<T>(this T obj, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineJoinProperty] = value;
        return obj;
    }

    public static T BorderLineJoin<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineJoinProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderLineJoin<T>(this T obj, IObservable<Avalonia.Media.PenLineJoin> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineJoinProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderLineJoin(this Avalonia.Controls.Border obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Border.BorderLineJoinProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.PenLineJoin> ObserveBorderLineJoin(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderLineJoinProperty);
    }

    public static T BorderLineJoinBevel<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineJoinProperty] = Avalonia.Media.PenLineJoin.Bevel;
        return obj;
    }

    public static T BorderLineJoinMiter<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineJoinProperty] = Avalonia.Media.PenLineJoin.Miter;
        return obj;
    }

    public static T BorderLineJoinRound<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderLineJoinProperty] = Avalonia.Media.PenLineJoin.Round;
        return obj;
    }
}
