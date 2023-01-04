// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Animation.Animatable"/> class style setters extension methods.
/// </summary>
public static partial class AnimatableSetters
{
    // Avalonia.Animation.Animatable.ClockProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatableClock(this Style style, Avalonia.Animation.IClock value)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.Animatable.ClockProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatableClock(this KeyFrame keyFrame, Avalonia.Animation.IClock value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.Animatable.ClockProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatableClock(this Style style, IObservable<Avalonia.Animation.IClock> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.Animatable.ClockProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatableClock(this KeyFrame keyFrame, IObservable<Avalonia.Animation.IClock> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.Animatable.ClockProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatableClock(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.Animatable.ClockProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatableClock(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.Animatable.ClockProperty, binding));
        return keyFrame;
    }

    // Avalonia.Animation.Animatable.TransitionsProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatableTransitions(this Style style, Avalonia.Animation.Transitions value)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.Animatable.TransitionsProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatableTransitions(this KeyFrame keyFrame, Avalonia.Animation.Transitions value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.Animatable.TransitionsProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatableTransitions(this Style style, IObservable<Avalonia.Animation.Transitions> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.Animatable.TransitionsProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatableTransitions(this KeyFrame keyFrame, IObservable<Avalonia.Animation.Transitions> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.Animatable.TransitionsProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetAnimatableTransitions(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Animation.Animatable.TransitionsProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetAnimatableTransitions(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Animation.Animatable.TransitionsProperty, binding));
        return keyFrame;
    }
}
