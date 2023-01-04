// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Input.PullGestureRecognizer"/> class style setters extension methods.
/// </summary>
public static partial class PullGestureRecognizerSetters
{
    // Avalonia.Input.PullGestureRecognizer.PullDirectionProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPullGestureRecognizerPullDirection(this Style style, Avalonia.Input.PullDirection value)
    {
        style.Setters.Add(new Setter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPullGestureRecognizerPullDirection(this KeyFrame keyFrame, Avalonia.Input.PullDirection value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPullGestureRecognizerPullDirection(this Style style, IObservable<Avalonia.Input.PullDirection> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPullGestureRecognizerPullDirection(this KeyFrame keyFrame, IObservable<Avalonia.Input.PullDirection> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPullGestureRecognizerPullDirection(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPullGestureRecognizerPullDirection(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding));
        return keyFrame;
    }
}
