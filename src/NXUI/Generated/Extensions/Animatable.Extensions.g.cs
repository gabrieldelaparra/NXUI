// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Animation.Animatable"/> class property extension methods.
/// </summary>
public static partial class AnimatableExtensions
{
    // Avalonia.Animation.Animatable.ClockProperty

    public static Builder<T> Clock1<T>(this Builder<T> builder, Builder<Avalonia.Animation.IClock> value)
        where T : Avalonia.Animation.Animatable
    {
        void Setter(T obj) => obj[Avalonia.Animation.Animatable.ClockProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Animation.Animatable.ClockProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Clock<T>(this T obj, Avalonia.Animation.IClock value) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.ClockProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.Animatable.ClockProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Clock<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.Animatable
    {
        var descriptor = Avalonia.Animation.Animatable.ClockProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.Animatable.ClockProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Clock<T>(
        this T obj,
        IObservable<Avalonia.Animation.IClock> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.Animatable
    {
        var descriptor = Avalonia.Animation.Animatable.ClockProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Animation.Animatable.ClockProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Animation.Animatable.ClockProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindClock(
        this Avalonia.Animation.Animatable obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Animation.Animatable.ClockProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Animation.IClock> ObserveClock(this Avalonia.Animation.Animatable obj)
    {
        return obj.GetObservable(Avalonia.Animation.Animatable.ClockProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Animation.Animatable.ClockProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnClock<T>(this T obj, Action<Avalonia.Animation.Animatable, IObservable<Avalonia.Animation.IClock>> handler) where T : Avalonia.Animation.Animatable
    {
        var observable = obj.GetObservable(Avalonia.Animation.Animatable.ClockProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Animation.Animatable.TransitionsProperty

    public static Builder<T> Transitions1<T>(this Builder<T> builder, Builder<Avalonia.Animation.Transitions> value)
        where T : Avalonia.Animation.Animatable
    {
        void Setter(T obj) => obj[Avalonia.Animation.Animatable.TransitionsProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Transitions<T>(this T obj, Avalonia.Animation.Transitions value) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.TransitionsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Transitions<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.Animatable
    {
        var descriptor = Avalonia.Animation.Animatable.TransitionsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Transitions<T>(
        this T obj,
        IObservable<Avalonia.Animation.Transitions> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Animation.Animatable
    {
        var descriptor = Avalonia.Animation.Animatable.TransitionsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTransitions(
        this Avalonia.Animation.Animatable obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Animation.Animatable.TransitionsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Animation.Transitions> ObserveTransitions(this Avalonia.Animation.Animatable obj)
    {
        return obj.GetObservable(Avalonia.Animation.Animatable.TransitionsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Animation.Animatable.TransitionsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTransitions<T>(this T obj, Action<Avalonia.Animation.Animatable, IObservable<Avalonia.Animation.Transitions>> handler) where T : Avalonia.Animation.Animatable
    {
        var observable = obj.GetObservable(Avalonia.Animation.Animatable.TransitionsProperty);
        handler(obj, observable);
        return obj;
    }
}
