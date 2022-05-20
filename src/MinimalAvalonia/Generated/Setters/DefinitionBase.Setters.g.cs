// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.DefinitionBase"/> class style setters extension methods.
/// </summary>
public static partial class DefinitionBaseSetters
{
    // Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDefinitionBaseSharedSizeGroup(this Style style, System.String value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDefinitionBaseSharedSizeGroup(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDefinitionBaseSharedSizeGroup(this Style style, IObservable<System.String> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDefinitionBaseSharedSizeGroup(this KeyFrame keyFrame, System.String value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDefinitionBaseSharedSizeGroup(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDefinitionBaseSharedSizeGroup(this KeyFrame keyFrame, IObservable<System.String> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, observable.ToBinding()));
        return keyFrame;
    }
}
