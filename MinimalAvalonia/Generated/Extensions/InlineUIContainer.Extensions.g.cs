// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class InlineUIContainerExtensions
{
    // ChildProperty

    public static T Child<T>(this T obj, Avalonia.Controls.IControl value) where T : Avalonia.Controls.Documents.InlineUIContainer
    {
        obj[Avalonia.Controls.Documents.InlineUIContainer.ChildProperty] = value;
        return obj;
    }

    public static T Child<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.InlineUIContainer
    {
        obj[Avalonia.Controls.Documents.InlineUIContainer.ChildProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Child<T>(this T obj, IObservable<Avalonia.Controls.IControl> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.InlineUIContainer
    {
        obj[Avalonia.Controls.Documents.InlineUIContainer.ChildProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindChild(this Avalonia.Controls.Documents.InlineUIContainer obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Documents.InlineUIContainer.ChildProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.IControl> ObserveChild(this Avalonia.Controls.Documents.InlineUIContainer obj)
    {
        return obj.GetObservable(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty);
    }
}
