// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Slider"/> class property extension methods.
/// </summary>
public static partial class SliderExtensions
{
    // Avalonia.Controls.Slider.OrientationProperty

    public static Builder<T> Orientation1<T>(this Builder<T> builder, Builder<Avalonia.Layout.Orientation> value)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.OrientationProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.OrientationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.OrientationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.OrientationProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.OrientationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        IObservable<Avalonia.Layout.Orientation> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Slider.OrientationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Slider.OrientationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOrientation(
        this Avalonia.Controls.Slider obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Slider.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Slider.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Controls.Slider obj)
    {
        return obj.GetObservable(Avalonia.Controls.Slider.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Slider.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientation<T>(this T obj, Action<Avalonia.Controls.Slider, IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Controls.Slider
    {
        var observable = obj.GetObservable(Avalonia.Controls.Slider.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> OrientationHorizontal1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Horizontal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    public static Builder<T> OrientationVertical1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Vertical"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }

    // Avalonia.Controls.Slider.IsDirectionReversedProperty

    public static Builder<T> IsDirectionReversed1<T>(this Builder<T> builder, Builder<System.Boolean> value)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.IsDirectionReversedProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsDirectionReversed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.IsDirectionReversedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsDirectionReversed<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.IsDirectionReversedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsDirectionReversed<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.IsDirectionReversedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsDirectionReversed(
        this Avalonia.Controls.Slider obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Slider.IsDirectionReversedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsDirectionReversed(this Avalonia.Controls.Slider obj)
    {
        return obj.GetObservable(Avalonia.Controls.Slider.IsDirectionReversedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Slider.IsDirectionReversedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsDirectionReversed<T>(this T obj, Action<Avalonia.Controls.Slider, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Slider
    {
        var observable = obj.GetObservable(Avalonia.Controls.Slider.IsDirectionReversedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Slider.IsSnapToTickEnabledProperty

    public static Builder<T> IsSnapToTickEnabled1<T>(this Builder<T> builder, Builder<System.Boolean> value)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.IsSnapToTickEnabledProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsSnapToTickEnabled<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.IsSnapToTickEnabledProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsSnapToTickEnabled<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.IsSnapToTickEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsSnapToTickEnabled<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.IsSnapToTickEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsSnapToTickEnabled(
        this Avalonia.Controls.Slider obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Slider.IsSnapToTickEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsSnapToTickEnabled(this Avalonia.Controls.Slider obj)
    {
        return obj.GetObservable(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Slider.IsSnapToTickEnabledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsSnapToTickEnabled<T>(this T obj, Action<Avalonia.Controls.Slider, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Slider
    {
        var observable = obj.GetObservable(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Slider.TickFrequencyProperty

    public static Builder<T> TickFrequency1<T>(this Builder<T> builder, Builder<System.Double> value)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TickFrequencyProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickFrequency<T>(this T obj, System.Double value) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TickFrequencyProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickFrequency<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.TickFrequencyProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickFrequency<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.TickFrequencyProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTickFrequency(
        this Avalonia.Controls.Slider obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Slider.TickFrequencyProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveTickFrequency(this Avalonia.Controls.Slider obj)
    {
        return obj.GetObservable(Avalonia.Controls.Slider.TickFrequencyProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Slider.TickFrequencyProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTickFrequency<T>(this T obj, Action<Avalonia.Controls.Slider, IObservable<System.Double>> handler) where T : Avalonia.Controls.Slider
    {
        var observable = obj.GetObservable(Avalonia.Controls.Slider.TickFrequencyProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Slider.TickPlacementProperty

    public static Builder<T> TickPlacement1<T>(this Builder<T> builder, Builder<Avalonia.Controls.TickPlacement> value)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TickPlacementProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacement<T>(this T obj, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TickPlacementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.TickPlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacement<T>(
        this T obj,
        IObservable<Avalonia.Controls.TickPlacement> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.TickPlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTickPlacement(
        this Avalonia.Controls.Slider obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Slider.TickPlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.TickPlacement> ObserveTickPlacement(this Avalonia.Controls.Slider obj)
    {
        return obj.GetObservable(Avalonia.Controls.Slider.TickPlacementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTickPlacement<T>(this T obj, Action<Avalonia.Controls.Slider, IObservable<Avalonia.Controls.TickPlacement>> handler) where T : Avalonia.Controls.Slider
    {
        var observable = obj.GetObservable(Avalonia.Controls.Slider.TickPlacementProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> TickPlacementNone1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.None;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> property value to <see cref="Avalonia.Controls.TickPlacement.None"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacementNone<T>(this T obj) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.None;
        return obj;
    }

    public static Builder<T> TickPlacementTopLeft1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.TopLeft;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> property value to <see cref="Avalonia.Controls.TickPlacement.TopLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacementTopLeft<T>(this T obj) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.TopLeft;
        return obj;
    }

    public static Builder<T> TickPlacementBottomRight1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.BottomRight;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> property value to <see cref="Avalonia.Controls.TickPlacement.BottomRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacementBottomRight<T>(this T obj) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.BottomRight;
        return obj;
    }

    public static Builder<T> TickPlacementOutside1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.Outside;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TickPlacementProperty"/> property value to <see cref="Avalonia.Controls.TickPlacement.Outside"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TickPlacementOutside<T>(this T obj) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TickPlacementProperty] = Avalonia.Controls.TickPlacement.Outside;
        return obj;
    }

    // Avalonia.Controls.Slider.TicksProperty

    public static Builder<T> Ticks1<T>(this Builder<T> builder, Builder<Avalonia.Collections.AvaloniaList<System.Double>> value)
        where T : Avalonia.Controls.Slider
    {
        void Setter(T obj) => obj[Avalonia.Controls.Slider.TicksProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Slider.TicksProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Ticks<T>(this T obj, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider
    {
        obj[Avalonia.Controls.Slider.TicksProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.TicksProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Ticks<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.TicksProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Slider.TicksProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Ticks<T>(
        this T obj,
        IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Slider
    {
        var descriptor = Avalonia.Controls.Slider.TicksProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Slider.TicksProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Slider.TicksProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTicks(
        this Avalonia.Controls.Slider obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Slider.TicksProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Slider.TicksProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Collections.AvaloniaList<System.Double>> ObserveTicks(this Avalonia.Controls.Slider obj)
    {
        return obj.GetObservable(Avalonia.Controls.Slider.TicksProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Slider.TicksProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTicks<T>(this T obj, Action<Avalonia.Controls.Slider, IObservable<Avalonia.Collections.AvaloniaList<System.Double>>> handler) where T : Avalonia.Controls.Slider
    {
        var observable = obj.GetObservable(Avalonia.Controls.Slider.TicksProperty);
        handler(obj, observable);
        return obj;
    }
}
