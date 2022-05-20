// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.Brush"/> class style setters extension methods.
/// </summary>
public static partial class BrushSetters
{
    // Avalonia.Media.Brush.OpacityProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Brush.OpacityProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetBrushOpacity(this Style style, System.Double value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Brush.OpacityProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Brush.OpacityProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetBrushOpacity(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Brush.OpacityProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Brush.OpacityProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetBrushOpacity(this Style style, IObservable<System.Double> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Brush.OpacityProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Brush.OpacityProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetBrushOpacity(this KeyFrame keyFrame, System.Double value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Brush.OpacityProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Brush.OpacityProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetBrushOpacity(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Brush.OpacityProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Brush.OpacityProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetBrushOpacity(this KeyFrame keyFrame, IObservable<System.Double> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Brush.OpacityProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Media.Brush.TransformProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Brush.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetBrushTransform(this Style style, Avalonia.Media.ITransform value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Brush.TransformProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Brush.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetBrushTransform(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Brush.TransformProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Media.Brush.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetBrushTransform(this Style style, IObservable<Avalonia.Media.ITransform> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.Brush.TransformProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Brush.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetBrushTransform(this KeyFrame keyFrame, Avalonia.Media.ITransform value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Brush.TransformProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Brush.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetBrushTransform(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Brush.TransformProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Media.Brush.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetBrushTransform(this KeyFrame keyFrame, IObservable<Avalonia.Media.ITransform> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.Brush.TransformProperty, observable.ToBinding()));
        return keyFrame;
    }
}
