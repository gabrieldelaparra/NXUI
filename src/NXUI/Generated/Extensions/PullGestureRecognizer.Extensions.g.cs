// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Input.PullGestureRecognizer"/> class property extension methods.
/// </summary>
public static partial class PullGestureRecognizerExtensions
{
    // Avalonia.Input.PullGestureRecognizer.PullDirectionProperty

    public static Builder<T> PullDirection1<T>(this Builder<T> builder, Builder<Avalonia.Input.PullDirection> value)
        where T : Avalonia.Input.PullGestureRecognizer
    {
        void Setter(T obj) => obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirection<T>(this T obj, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer
    {
        obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirection<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.PullGestureRecognizer
    {
        var descriptor = Avalonia.Input.PullGestureRecognizer.PullDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirection<T>(
        this T obj,
        IObservable<Avalonia.Input.PullDirection> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.PullGestureRecognizer
    {
        var descriptor = Avalonia.Input.PullGestureRecognizer.PullDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPullDirection(
        this Avalonia.Input.PullGestureRecognizer obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Input.PullGestureRecognizer.PullDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Input.PullDirection> ObservePullDirection(this Avalonia.Input.PullGestureRecognizer obj)
    {
        return obj.GetObservable(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPullDirection<T>(this T obj, Action<Avalonia.Input.PullGestureRecognizer, IObservable<Avalonia.Input.PullDirection>> handler) where T : Avalonia.Input.PullGestureRecognizer
    {
        var observable = obj.GetObservable(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> PullDirectionTopToBottom1<T>(this Builder<T> builder)
        where T : Avalonia.Input.PullGestureRecognizer
    {
        void Setter(T obj) => obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.TopToBottom;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.TopToBottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionTopToBottom<T>(this T obj) where T : Avalonia.Input.PullGestureRecognizer
    {
        obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.TopToBottom;
        return obj;
    }

    public static Builder<T> PullDirectionBottomToTop1<T>(this Builder<T> builder)
        where T : Avalonia.Input.PullGestureRecognizer
    {
        void Setter(T obj) => obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.BottomToTop;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.BottomToTop"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionBottomToTop<T>(this T obj) where T : Avalonia.Input.PullGestureRecognizer
    {
        obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.BottomToTop;
        return obj;
    }

    public static Builder<T> PullDirectionLeftToRight1<T>(this Builder<T> builder)
        where T : Avalonia.Input.PullGestureRecognizer
    {
        void Setter(T obj) => obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.LeftToRight;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.LeftToRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionLeftToRight<T>(this T obj) where T : Avalonia.Input.PullGestureRecognizer
    {
        obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.LeftToRight;
        return obj;
    }

    public static Builder<T> PullDirectionRightToLeft1<T>(this Builder<T> builder)
        where T : Avalonia.Input.PullGestureRecognizer
    {
        void Setter(T obj) => obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.RightToLeft;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.PullGestureRecognizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.RightToLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionRightToLeft<T>(this T obj) where T : Avalonia.Input.PullGestureRecognizer
    {
        obj[Avalonia.Input.PullGestureRecognizer.PullDirectionProperty] = Avalonia.Input.PullDirection.RightToLeft;
        return obj;
    }
}
