// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.SkewTransform"/> class property extension methods.
/// </summary>
public static partial class SkewTransformExtensions
{
    // Avalonia.Media.SkewTransform.AngleXProperty

    public static Builder<T> AngleX1<T>(this Builder<T> builder, Builder<System.Double> value)
        where T : Avalonia.Media.SkewTransform
    {
        void Setter(T obj) => obj[Avalonia.Media.SkewTransform.AngleXProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AngleX<T>(this T obj, System.Double value) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleXProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AngleX<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.SkewTransform
    {
        var descriptor = Avalonia.Media.SkewTransform.AngleXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AngleX<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.SkewTransform
    {
        var descriptor = Avalonia.Media.SkewTransform.AngleXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAngleX(
        this Avalonia.Media.SkewTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.SkewTransform.AngleXProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveAngleX(this Avalonia.Media.SkewTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.SkewTransform.AngleXProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.SkewTransform.AngleXProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAngleX<T>(this T obj, Action<Avalonia.Media.SkewTransform, IObservable<System.Double>> handler) where T : Avalonia.Media.SkewTransform
    {
        var observable = obj.GetObservable(Avalonia.Media.SkewTransform.AngleXProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.SkewTransform.AngleYProperty

    public static Builder<T> AngleY1<T>(this Builder<T> builder, Builder<System.Double> value)
        where T : Avalonia.Media.SkewTransform
    {
        void Setter(T obj) => obj[Avalonia.Media.SkewTransform.AngleYProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AngleY<T>(this T obj, System.Double value) where T : Avalonia.Media.SkewTransform
    {
        obj[Avalonia.Media.SkewTransform.AngleYProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AngleY<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.SkewTransform
    {
        var descriptor = Avalonia.Media.SkewTransform.AngleYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AngleY<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.SkewTransform
    {
        var descriptor = Avalonia.Media.SkewTransform.AngleYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAngleY(
        this Avalonia.Media.SkewTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.SkewTransform.AngleYProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveAngleY(this Avalonia.Media.SkewTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.SkewTransform.AngleYProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.SkewTransform.AngleYProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAngleY<T>(this T obj, Action<Avalonia.Media.SkewTransform, IObservable<System.Double>> handler) where T : Avalonia.Media.SkewTransform
    {
        var observable = obj.GetObservable(Avalonia.Media.SkewTransform.AngleYProperty);
        handler(obj, observable);
        return obj;
    }
}
