namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia events.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaEvents
{
    public static Avalonia.Interactivity.RoutedEvent<Avalonia.Controls.SelectionChangedEventArgs> AutoCompleteBoxSelectionChanged => Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent;
}
