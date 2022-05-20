// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.RadioButton"/> class style setters extension methods.
/// </summary>
public static partial class RadioButtonSetters
{
    // Avalonia.Controls.RadioButton.GroupNameProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.RadioButton.GroupNameProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRadioButtonGroupName(this Style style, System.String value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.RadioButton.GroupNameProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRadioButtonGroupName(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.RadioButton.GroupNameProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetRadioButtonGroupName(this Style style, IObservable<System.String> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.RadioButton.GroupNameProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRadioButtonGroupName(this KeyFrame keyFrame, System.String value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.RadioButton.GroupNameProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRadioButtonGroupName(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.RadioButton.GroupNameProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetRadioButtonGroupName(this KeyFrame keyFrame, IObservable<System.String> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.RadioButton.GroupNameProperty, observable.ToBinding()));
        return keyFrame;
    }
}
