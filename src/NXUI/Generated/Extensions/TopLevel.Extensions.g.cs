// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.TopLevel"/> class property extension methods.
/// </summary>
public static partial class TopLevelExtensions
{
    // Avalonia.Controls.TopLevel.ClientSizeProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TopLevel.ClientSizeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TopLevel.ClientSizeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindClientSize(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TopLevel.ClientSizeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TopLevel.ClientSizeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Size> ObserveClientSize(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.ClientSizeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TopLevel.ClientSizeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.TopLevel OnClientSize(this Avalonia.Controls.TopLevel obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Size>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.ClientSizeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TopLevel.FrameSizeProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TopLevel.FrameSizeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TopLevel.FrameSizeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindFrameSize(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TopLevel.FrameSizeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TopLevel.FrameSizeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Nullable<Avalonia.Size>> ObserveFrameSize(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.FrameSizeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TopLevel.FrameSizeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.TopLevel OnFrameSize(this Avalonia.Controls.TopLevel obj, Action<Avalonia.Controls.TopLevel, IObservable<System.Nullable<Avalonia.Size>>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.FrameSizeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TopLevel.PointerOverElementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PointerOverElement<T>(this T obj, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.PointerOverElementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PointerOverElement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.TopLevel.PointerOverElementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PointerOverElement<T>(
        this T obj,
        IObservable<Avalonia.Input.IInputElement> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.TopLevel.PointerOverElementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPointerOverElement(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TopLevel.PointerOverElementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Input.IInputElement> ObservePointerOverElement(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.PointerOverElementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TopLevel.PointerOverElementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPointerOverElement<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Input.IInputElement>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.PointerOverElementProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TopLevel.TransparencyLevelHintProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHint<T>(this T obj, Avalonia.Controls.WindowTransparencyLevel value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHint<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.TopLevel.TransparencyLevelHintProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHint<T>(
        this T obj,
        IObservable<Avalonia.Controls.WindowTransparencyLevel> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.TopLevel.TransparencyLevelHintProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTransparencyLevelHint(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TopLevel.TransparencyLevelHintProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.WindowTransparencyLevel> ObserveTransparencyLevelHint(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTransparencyLevelHint<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Controls.WindowTransparencyLevel>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property value to <see cref="Avalonia.Controls.WindowTransparencyLevel.None"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHintNone<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.None;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property value to <see cref="Avalonia.Controls.WindowTransparencyLevel.Transparent"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHintTransparent<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.Transparent;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property value to <see cref="Avalonia.Controls.WindowTransparencyLevel.Blur"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHintBlur<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.Blur;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property value to <see cref="Avalonia.Controls.WindowTransparencyLevel.AcrylicBlur"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHintAcrylicBlur<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.AcrylicBlur;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property value to <see cref="Avalonia.Controls.WindowTransparencyLevel.ForceAcrylicBlur"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHintForceAcrylicBlur<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.ForceAcrylicBlur;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyLevelHintProperty"/> property value to <see cref="Avalonia.Controls.WindowTransparencyLevel.Mica"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyLevelHintMica<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.Mica;
        return obj;
    }

    // Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindActualTransparencyLevel(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.WindowTransparencyLevel> ObserveActualTransparencyLevel(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.TopLevel OnActualTransparencyLevel(this Avalonia.Controls.TopLevel obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Controls.WindowTransparencyLevel>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyBackgroundFallback<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyBackgroundFallback<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T TransparencyBackgroundFallback<T>(
        this T obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.TopLevel
    {
        var descriptor = Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTransparencyBackgroundFallback(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveTransparencyBackgroundFallback(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnTransparencyBackgroundFallback<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.TopLevel.BackRequestedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.TopLevel.BackRequestedEvent"/> event on an object of type <see cref="Avalonia.Controls.TopLevel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnBackRequestedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.TopLevel
    {
        obj.AddHandler(Avalonia.Controls.TopLevel.BackRequestedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.TopLevel.BackRequestedEvent"/> event on an object of type <see cref="Avalonia.Controls.TopLevel"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnBackRequested<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.BackRequestedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.TopLevel.BackRequestedEvent"/> event on an object of type <see cref="Avalonia.Controls.TopLevel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnBackRequested(
        this Avalonia.Controls.TopLevel obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.BackRequestedEvent, routes);
    }

    // Avalonia.Controls.TopLevel.Opened

    /// <summary>
    /// Adds a handler to the `Opened` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOpenedEvent<T>(this T obj, Action<T, IObservable<EventArgs>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = Observable
            .FromEventPattern<EventHandler, EventArgs>(
                h => obj.Opened += h, 
                h => obj.Opened -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Opened` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Opened` event on the specified object.</returns>
    public static IObservable<EventArgs> ObserveOnOpenedEvent(this Avalonia.Controls.TopLevel obj)
    {
        return Observable
            .FromEventPattern<EventHandler, EventArgs>(
                h => obj.Opened += h, 
                h => obj.Opened -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.TopLevel.Closed

    /// <summary>
    /// Adds a handler to the `Closed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnClosedEvent<T>(this T obj, Action<T, IObservable<EventArgs>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = Observable
            .FromEventPattern<EventHandler, EventArgs>(
                h => obj.Closed += h, 
                h => obj.Closed -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Closed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Closed` event on the specified object.</returns>
    public static IObservable<EventArgs> ObserveOnClosedEvent(this Avalonia.Controls.TopLevel obj)
    {
        return Observable
            .FromEventPattern<EventHandler, EventArgs>(
                h => obj.Closed += h, 
                h => obj.Closed -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.TopLevel.BackRequested

    /// <summary>
    /// Adds a handler to the `BackRequested` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBackRequestedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.BackRequested += h, 
                h => obj.BackRequested -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `BackRequested` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `BackRequested` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnBackRequestedEvent(this Avalonia.Controls.TopLevel obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.BackRequested += h, 
                h => obj.BackRequested -= h)
            .Select(x => x.EventArgs);
    }
}
