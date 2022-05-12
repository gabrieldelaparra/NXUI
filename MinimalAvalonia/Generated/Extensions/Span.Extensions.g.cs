// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SpanExtensions
{
    // InlinesProperty

    public static Avalonia.Data.IBinding BindInlines(this Avalonia.Controls.Documents.Span obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.Documents.Span.InlinesProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Documents.InlineCollection> ObserveInlines(this Avalonia.Controls.Documents.Span obj)
    {
        return obj.GetObservable(Avalonia.Controls.Documents.Span.InlinesProperty);
    }
}
