// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class MenuFlyoutExtensions
{
    // ItemsProperty

    public static T Items<T>(this T obj, System.Collections.IEnumerable value) where T : Avalonia.Controls.MenuFlyout
    {
        obj[Avalonia.Controls.MenuFlyout.ItemsProperty] = value;
        return obj;
    }

    public static T Items<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuFlyout
    {
        obj[Avalonia.Controls.MenuFlyout.ItemsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Items<T>(this T obj, IObservable<System.Collections.IEnumerable> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuFlyout
    {
        obj[Avalonia.Controls.MenuFlyout.ItemsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindItems(this Avalonia.Controls.MenuFlyout obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuFlyout.ItemsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Collections.IEnumerable> ObserveItems(this Avalonia.Controls.MenuFlyout obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuFlyout.ItemsProperty);
    }

    // ItemTemplateProperty

    public static T ItemTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.MenuFlyout
    {
        obj[Avalonia.Controls.MenuFlyout.ItemTemplateProperty] = value;
        return obj;
    }

    public static T ItemTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuFlyout
    {
        obj[Avalonia.Controls.MenuFlyout.ItemTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ItemTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuFlyout
    {
        obj[Avalonia.Controls.MenuFlyout.ItemTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindItemTemplate(this Avalonia.Controls.MenuFlyout obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuFlyout.ItemTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveItemTemplate(this Avalonia.Controls.MenuFlyout obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuFlyout.ItemTemplateProperty);
    }
}
