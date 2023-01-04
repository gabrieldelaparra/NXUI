// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.TransformGroup"/> class style setters extension methods.
/// </summary>
public static partial class TransformGroupSetters
{
    // Avalonia.Media.TransformGroup.ChildrenProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetTransformGroupChildren(this Style style, Avalonia.Media.Transforms value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.TransformGroup.ChildrenProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetTransformGroupChildren(this KeyFrame keyFrame, Avalonia.Media.Transforms value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.TransformGroup.ChildrenProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetTransformGroupChildren(this Style style, IObservable<Avalonia.Media.Transforms> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.TransformGroup.ChildrenProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetTransformGroupChildren(this KeyFrame keyFrame, IObservable<Avalonia.Media.Transforms> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.TransformGroup.ChildrenProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetTransformGroupChildren(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.TransformGroup.ChildrenProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetTransformGroupChildren(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.TransformGroup.ChildrenProperty, binding));
        return keyFrame;
    }
}
