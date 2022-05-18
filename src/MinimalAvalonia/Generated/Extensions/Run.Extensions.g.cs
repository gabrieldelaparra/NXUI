// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class RunExtensions
{
    // TextProperty

    public static T Text<T>(this T obj, System.String value) where T : Avalonia.Controls.Documents.Run
    {
        obj[Avalonia.Controls.Documents.Run.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.Run
    {
        obj[Avalonia.Controls.Documents.Run.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Text<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.Run
    {
        obj[Avalonia.Controls.Documents.Run.TextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindText(this Avalonia.Controls.Documents.Run obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Documents.Run.TextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveText(this Avalonia.Controls.Documents.Run obj)
    {
        return obj.GetObservable(Avalonia.Controls.Documents.Run.TextProperty);
    }

    public static T OnText<T>(this T obj, Action<Avalonia.Controls.Documents.Run, IObservable<System.String>> handler) where T : Avalonia.Controls.Documents.Run
    {
        var observable = obj.GetObservable(Avalonia.Controls.Documents.Run.TextProperty);
        handler(obj, observable);
        return obj;
    }
}
