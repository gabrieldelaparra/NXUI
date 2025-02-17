// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.RefreshVisualizer"/> class property extension methods.
/// </summary>
public static partial class RefreshVisualizerExtensions
{
    // Avalonia.Controls.RefreshVisualizer.PullDirectionProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirection<T>(this T obj, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.PullDirectionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> with binding source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RefreshVisualizer
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.PullDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> with observable source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RefreshVisualizer
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.PullDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPullDirection(
        this Avalonia.Controls.RefreshVisualizer obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.PullDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Input.PullDirection> ObservePullDirection(this Avalonia.Controls.RefreshVisualizer obj)
    {
        return obj.GetObservable(Avalonia.Controls.RefreshVisualizer.PullDirectionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPullDirection<T>(this T obj, Action<Avalonia.Controls.RefreshVisualizer, IObservable<Avalonia.Input.PullDirection>> handler) where T : Avalonia.Controls.RefreshVisualizer
    {
        var observable = obj.GetObservable(Avalonia.Controls.RefreshVisualizer.PullDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.TopToBottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionTopToBottom<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.PullDirectionProperty] = Avalonia.Input.PullDirection.TopToBottom;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.BottomToTop"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionBottomToTop<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.PullDirectionProperty] = Avalonia.Input.PullDirection.BottomToTop;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.LeftToRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionLeftToRight<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.PullDirectionProperty] = Avalonia.Input.PullDirection.LeftToRight;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.PullDirectionProperty"/> property value to <see cref="Avalonia.Input.PullDirection.RightToLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PullDirectionRightToLeft<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.PullDirectionProperty] = Avalonia.Input.PullDirection.RightToLeft;
        return obj;
    }

    // Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRefreshVisualizerState(
        this Avalonia.Controls.RefreshVisualizer obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.RefreshVisualizerState> ObserveRefreshVisualizerState(this Avalonia.Controls.RefreshVisualizer obj)
    {
        return obj.GetObservable(Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.RefreshVisualizer OnRefreshVisualizerState(this Avalonia.Controls.RefreshVisualizer obj, Action<Avalonia.Controls.RefreshVisualizer, IObservable<Avalonia.Controls.RefreshVisualizerState>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.RefreshVisualizer.RefreshVisualizerStateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.RefreshVisualizer.OrientationProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(this T obj, Avalonia.Controls.RefreshVisualizerOrientation value) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.OrientationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> with binding source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RefreshVisualizer
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Orientation<T>(
        this T obj,
        IObservable<Avalonia.Controls.RefreshVisualizerOrientation> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.RefreshVisualizer
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOrientation(
        this Avalonia.Controls.RefreshVisualizer obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.RefreshVisualizer.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.RefreshVisualizerOrientation> ObserveOrientation(this Avalonia.Controls.RefreshVisualizer obj)
    {
        return obj.GetObservable(Avalonia.Controls.RefreshVisualizer.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientation<T>(this T obj, Action<Avalonia.Controls.RefreshVisualizer, IObservable<Avalonia.Controls.RefreshVisualizerOrientation>> handler) where T : Avalonia.Controls.RefreshVisualizer
    {
        var observable = obj.GetObservable(Avalonia.Controls.RefreshVisualizer.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> property value to <see cref="Avalonia.Controls.RefreshVisualizerOrientation.Auto"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationAuto<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.OrientationProperty] = Avalonia.Controls.RefreshVisualizerOrientation.Auto;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> property value to <see cref="Avalonia.Controls.RefreshVisualizerOrientation.Normal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationNormal<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.OrientationProperty] = Avalonia.Controls.RefreshVisualizerOrientation.Normal;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> property value to <see cref="Avalonia.Controls.RefreshVisualizerOrientation.Rotate90DegreesCounterclockwise"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationRotate90DegreesCounterclockwise<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.OrientationProperty] = Avalonia.Controls.RefreshVisualizerOrientation.Rotate90DegreesCounterclockwise;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.RefreshVisualizer.OrientationProperty"/> property value to <see cref="Avalonia.Controls.RefreshVisualizerOrientation.Rotate270DegreesCounterclockwise"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationRotate270DegreesCounterclockwise<T>(this T obj) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj[Avalonia.Controls.RefreshVisualizer.OrientationProperty] = Avalonia.Controls.RefreshVisualizerOrientation.Rotate270DegreesCounterclockwise;
        return obj;
    }

    // Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent"/> event on an object of type <see cref="Avalonia.Controls.RefreshVisualizer"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnRefreshRequestedHandler<T>(
        this T obj,
        Action<T, Avalonia.Controls.RefreshRequestedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.RefreshVisualizer
    {
        obj.AddHandler(Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent"/> event on an object of type <see cref="Avalonia.Controls.RefreshVisualizer"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnRefreshRequested<T>(
        this T obj, Action<T, IObservable<Avalonia.Controls.RefreshRequestedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.RefreshVisualizer
    {
        var observable = obj.GetObservable(Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent"/> event on an object of type <see cref="Avalonia.Controls.RefreshVisualizer"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Controls.RefreshRequestedEventArgs> ObserveOnRefreshRequested(
        this Avalonia.Controls.RefreshVisualizer obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent, routes);
    }

    // Avalonia.Controls.RefreshVisualizer.RefreshRequested

    /// <summary>
    /// Adds a handler to the `RefreshRequested` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnRefreshRequestedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Controls.RefreshRequestedEventArgs>> handler) where T : Avalonia.Controls.RefreshVisualizer
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.RefreshRequestedEventArgs>, Avalonia.Controls.RefreshRequestedEventArgs>(
                h => obj.RefreshRequested += h, 
                h => obj.RefreshRequested -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `RefreshRequested` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `RefreshRequested` event on the specified object.</returns>
    public static IObservable<Avalonia.Controls.RefreshRequestedEventArgs> ObserveOnRefreshRequestedEvent(this Avalonia.Controls.RefreshVisualizer obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.RefreshRequestedEventArgs>, Avalonia.Controls.RefreshRequestedEventArgs>(
                h => obj.RefreshRequested += h, 
                h => obj.RefreshRequested -= h)
            .Select(x => x.EventArgs);
    }
}
