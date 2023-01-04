// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Panel"/> class style setters extension methods.
/// </summary>
public static partial class PanelSetters
{
    // Avalonia.Controls.Panel.BackgroundProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Panel.BackgroundProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPanelBackground(this Style style, Avalonia.Media.IBrush value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Panel.BackgroundProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Panel.BackgroundProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPanelBackground(this KeyFrame keyFrame, Avalonia.Media.IBrush value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Panel.BackgroundProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Panel.BackgroundProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPanelBackground(this Style style, IObservable<Avalonia.Media.IBrush> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Panel.BackgroundProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Panel.BackgroundProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPanelBackground(this KeyFrame keyFrame, IObservable<Avalonia.Media.IBrush> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Panel.BackgroundProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Panel.BackgroundProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPanelBackground(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Panel.BackgroundProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Panel.BackgroundProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPanelBackground(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Panel.BackgroundProperty, binding));
        return keyFrame;
    }
}
