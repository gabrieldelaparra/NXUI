// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ContentControlExtensions
{
    // ContentProperty

    public static T Content<T>(this T obj, System.Object value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentProperty] = value;
        return obj;
    }

    public static T Content<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Content<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContent(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.ContentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveContent(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.ContentProperty);
    }

    public static T OnContent<T>(this T obj, Action<IObservable<System.Object>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.ContentProperty);
        handler(observable);
        return obj;
    }

    // ContentTemplateProperty

    public static T ContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentTemplateProperty] = value;
        return obj;
    }

    public static T ContentTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ContentTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContentTemplate(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.ContentTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveContentTemplate(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
    }

    public static T OnContentTemplate<T>(this T obj, Action<IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.ContentTemplateProperty);
        handler(observable);
        return obj;
    }

    // HorizontalContentAlignmentProperty

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.HorizontalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHorizontalContentAlignment(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.HorizontalAlignment> ObserveHorizontalContentAlignment(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
    }

    public static T OnHorizontalContentAlignment<T>(this T obj, Action<IObservable<Avalonia.Layout.HorizontalAlignment>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty);
        handler(observable);
        return obj;
    }

    public static T HorizontalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    public static T HorizontalContentAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    public static T HorizontalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    public static T HorizontalContentAlignmentRight<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // VerticalContentAlignmentProperty

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.VerticalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindVerticalContentAlignment(this Avalonia.Controls.ContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.VerticalAlignment> ObserveVerticalContentAlignment(this Avalonia.Controls.ContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
    }

    public static T OnVerticalContentAlignment<T>(this T obj, Action<IObservable<Avalonia.Layout.VerticalAlignment>> handler) where T : Avalonia.Controls.ContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty);
        handler(observable);
        return obj;
    }

    public static T VerticalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    public static T VerticalContentAlignmentTop<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    public static T VerticalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    public static T VerticalContentAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.ContentControl
    {
        obj[Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }
}
