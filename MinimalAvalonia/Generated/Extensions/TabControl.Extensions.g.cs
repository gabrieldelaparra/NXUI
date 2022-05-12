// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TabControlExtensions
{
    // TabStripPlacementProperty

    public static T TabStripPlacement<T>(this T obj, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty] = value;
        return obj;
    }

    public static T TabStripPlacement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TabStripPlacement<T>(this T obj, IObservable<Avalonia.Controls.Dock> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTabStripPlacement(this Avalonia.Controls.TabControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TabControl.TabStripPlacementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Dock> ObserveTabStripPlacement(this Avalonia.Controls.TabControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.TabControl.TabStripPlacementProperty);
    }

    public static T OnTabStripPlacement<T>(this T obj, Action<IObservable<Avalonia.Controls.Dock>> handler) where T : Avalonia.Controls.TabControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.TabControl.TabStripPlacementProperty);
        handler(observable);
        return obj;
    }

    public static T TabStripPlacementLeft<T>(this T obj) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty] = Avalonia.Controls.Dock.Left;
        return obj;
    }

    public static T TabStripPlacementBottom<T>(this T obj) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty] = Avalonia.Controls.Dock.Bottom;
        return obj;
    }

    public static T TabStripPlacementRight<T>(this T obj) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty] = Avalonia.Controls.Dock.Right;
        return obj;
    }

    public static T TabStripPlacementTop<T>(this T obj) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.TabStripPlacementProperty] = Avalonia.Controls.Dock.Top;
        return obj;
    }

    // SelectedContentProperty

    public static T SelectedContent<T>(this T obj, System.Object value) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.SelectedContentProperty] = value;
        return obj;
    }

    public static T SelectedContent<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.SelectedContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedContent<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.SelectedContentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedContent(this Avalonia.Controls.TabControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TabControl.SelectedContentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveSelectedContent(this Avalonia.Controls.TabControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.TabControl.SelectedContentProperty);
    }

    public static T OnSelectedContent<T>(this T obj, Action<IObservable<System.Object>> handler) where T : Avalonia.Controls.TabControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.TabControl.SelectedContentProperty);
        handler(observable);
        return obj;
    }

    // SelectedContentTemplateProperty

    public static T SelectedContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.SelectedContentTemplateProperty] = value;
        return obj;
    }

    public static T SelectedContentTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.SelectedContentTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedContentTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TabControl
    {
        obj[Avalonia.Controls.TabControl.SelectedContentTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedContentTemplate(this Avalonia.Controls.TabControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TabControl.SelectedContentTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveSelectedContentTemplate(this Avalonia.Controls.TabControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.TabControl.SelectedContentTemplateProperty);
    }

    public static T OnSelectedContentTemplate<T>(this T obj, Action<IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.TabControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.TabControl.SelectedContentTemplateProperty);
        handler(observable);
        return obj;
    }
}
