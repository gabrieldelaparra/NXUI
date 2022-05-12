// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class LayoutTransformControlExtensions
{
    // LayoutTransformProperty

    public static T LayoutTransform<T>(this T obj, Avalonia.Media.ITransform value) where T : Avalonia.Controls.LayoutTransformControl
    {
        obj[Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty] = value;
        return obj;
    }

    public static T LayoutTransform<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.LayoutTransformControl
    {
        obj[Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T LayoutTransform<T>(this T obj, IObservable<Avalonia.Media.ITransform> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.LayoutTransformControl
    {
        obj[Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindLayoutTransform(this Avalonia.Controls.LayoutTransformControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.ITransform> ObserveLayoutTransform(this Avalonia.Controls.LayoutTransformControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty);
    }

    public static T OnLayoutTransform<T>(this T obj, Action<IObservable<Avalonia.Media.ITransform>> handler) where T : Avalonia.Controls.LayoutTransformControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty);
        handler(observable);
        return obj;
    }

    // UseRenderTransformProperty

    public static T UseRenderTransform<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl
    {
        obj[Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty] = value;
        return obj;
    }

    public static T UseRenderTransform<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.LayoutTransformControl
    {
        obj[Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T UseRenderTransform<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.LayoutTransformControl
    {
        obj[Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindUseRenderTransform(this Avalonia.Controls.LayoutTransformControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveUseRenderTransform(this Avalonia.Controls.LayoutTransformControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty);
    }

    public static T OnUseRenderTransform<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.LayoutTransformControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty);
        handler(observable);
        return obj;
    }
}
