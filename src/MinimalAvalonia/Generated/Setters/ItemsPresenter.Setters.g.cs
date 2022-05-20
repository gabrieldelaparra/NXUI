// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Presenters.ItemsPresenter"/> class style setters extension methods.
/// </summary>
public static partial class ItemsPresenterSetters
{
    // Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsPresenterVirtualizationMode(this Style style, Avalonia.Controls.ItemVirtualizationMode value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsPresenterVirtualizationMode(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsPresenterVirtualizationMode(this Style style, IObservable<Avalonia.Controls.ItemVirtualizationMode> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsPresenterVirtualizationMode(this KeyFrame keyFrame, Avalonia.Controls.ItemVirtualizationMode value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsPresenterVirtualizationMode(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsPresenterVirtualizationMode(this KeyFrame keyFrame, IObservable<Avalonia.Controls.ItemVirtualizationMode> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, observable.ToBinding()));
        return keyFrame;
    }
}
