// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ListBoxExtensions
{
    // ScrollProperty

    public static Avalonia.Data.IBinding BindScroll(this Avalonia.Controls.ListBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.ListBox.ScrollProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Primitives.IScrollable> ObserveScroll(this Avalonia.Controls.ListBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ListBox.ScrollProperty);
    }
}
