// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Decorator"/> class property extension methods.
/// </summary>
public static partial class DecoratorExtensions
{
    // Avalonia.Controls.Decorator.ChildProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Decorator.ChildProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Child<T>(this T obj, Avalonia.Controls.IControl value) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.ChildProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Decorator.ChildProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Child<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Decorator
    {
        var descriptor = Avalonia.Controls.Decorator.ChildProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Decorator.ChildProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Child<T>(
        this T obj,
        IObservable<Avalonia.Controls.IControl> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Decorator
    {
        var descriptor = Avalonia.Controls.Decorator.ChildProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Decorator.ChildProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Decorator.ChildProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindChild(
        this Avalonia.Controls.Decorator obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Decorator.ChildProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Decorator.ChildProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.IControl> ObserveChild(this Avalonia.Controls.Decorator obj)
    {
        return obj.GetObservable(Avalonia.Controls.Decorator.ChildProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Decorator.ChildProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnChild<T>(this T obj, Action<Avalonia.Controls.Decorator, IObservable<Avalonia.Controls.IControl>> handler) where T : Avalonia.Controls.Decorator
    {
        var observable = obj.GetObservable(Avalonia.Controls.Decorator.ChildProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Decorator.PaddingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Decorator.PaddingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Padding<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.PaddingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Decorator.PaddingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Padding<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Decorator
    {
        var descriptor = Avalonia.Controls.Decorator.PaddingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Decorator.PaddingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Padding<T>(
        this T obj,
        IObservable<Avalonia.Thickness> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Decorator
    {
        var descriptor = Avalonia.Controls.Decorator.PaddingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Decorator.PaddingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Decorator.PaddingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPadding(
        this Avalonia.Controls.Decorator obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Decorator.PaddingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Decorator.PaddingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Thickness> ObservePadding(this Avalonia.Controls.Decorator obj)
    {
        return obj.GetObservable(Avalonia.Controls.Decorator.PaddingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Decorator.PaddingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPadding<T>(this T obj, Action<Avalonia.Controls.Decorator, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Decorator
    {
        var observable = obj.GetObservable(Avalonia.Controls.Decorator.PaddingProperty);
        handler(obj, observable);
        return obj;
    }
}
