// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.SplitButton"/> class property extension methods.
/// </summary>
public static partial class SplitButtonExtensions
{
    // Avalonia.Controls.SplitButton.CommandProperty

    public static Builder<T> Command1<T>(this Builder<T> builder, Builder<System.Windows.Input.ICommand> value)
        where T : Avalonia.Controls.SplitButton
    {
        void Setter(T obj) => obj[Avalonia.Controls.SplitButton.CommandProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.SplitButton.CommandProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Command<T>(this T obj, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton
    {
        obj[Avalonia.Controls.SplitButton.CommandProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitButton.CommandProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Command<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitButton
    {
        var descriptor = Avalonia.Controls.SplitButton.CommandProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitButton.CommandProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Command<T>(
        this T obj,
        IObservable<System.Windows.Input.ICommand> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitButton
    {
        var descriptor = Avalonia.Controls.SplitButton.CommandProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.SplitButton.CommandProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.SplitButton.CommandProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCommand(
        this Avalonia.Controls.SplitButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.SplitButton.CommandProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.SplitButton.CommandProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Windows.Input.ICommand> ObserveCommand(this Avalonia.Controls.SplitButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitButton.CommandProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.SplitButton.CommandProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCommand<T>(this T obj, Action<Avalonia.Controls.SplitButton, IObservable<System.Windows.Input.ICommand>> handler) where T : Avalonia.Controls.SplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitButton.CommandProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.SplitButton.CommandParameterProperty

    public static Builder<T> CommandParameter1<T>(this Builder<T> builder, Builder<System.Object> value)
        where T : Avalonia.Controls.SplitButton
    {
        void Setter(T obj) => obj[Avalonia.Controls.SplitButton.CommandParameterProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CommandParameter<T>(this T obj, System.Object value) where T : Avalonia.Controls.SplitButton
    {
        obj[Avalonia.Controls.SplitButton.CommandParameterProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CommandParameter<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitButton
    {
        var descriptor = Avalonia.Controls.SplitButton.CommandParameterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CommandParameter<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitButton
    {
        var descriptor = Avalonia.Controls.SplitButton.CommandParameterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCommandParameter(
        this Avalonia.Controls.SplitButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.SplitButton.CommandParameterProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveCommandParameter(this Avalonia.Controls.SplitButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitButton.CommandParameterProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.SplitButton.CommandParameterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCommandParameter<T>(this T obj, Action<Avalonia.Controls.SplitButton, IObservable<System.Object>> handler) where T : Avalonia.Controls.SplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitButton.CommandParameterProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.SplitButton.FlyoutProperty

    public static Builder<T> Flyout1<T>(this Builder<T> builder, Builder<Avalonia.Controls.Primitives.FlyoutBase> value)
        where T : Avalonia.Controls.SplitButton
    {
        void Setter(T obj) => obj[Avalonia.Controls.SplitButton.FlyoutProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Flyout<T>(this T obj, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton
    {
        obj[Avalonia.Controls.SplitButton.FlyoutProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Flyout<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitButton
    {
        var descriptor = Avalonia.Controls.SplitButton.FlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Flyout<T>(
        this T obj,
        IObservable<Avalonia.Controls.Primitives.FlyoutBase> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitButton
    {
        var descriptor = Avalonia.Controls.SplitButton.FlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindFlyout(
        this Avalonia.Controls.SplitButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.SplitButton.FlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Primitives.FlyoutBase> ObserveFlyout(this Avalonia.Controls.SplitButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitButton.FlyoutProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.SplitButton.FlyoutProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnFlyout<T>(this T obj, Action<Avalonia.Controls.SplitButton, IObservable<Avalonia.Controls.Primitives.FlyoutBase>> handler) where T : Avalonia.Controls.SplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitButton.FlyoutProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.SplitButton.ClickEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.SplitButton.ClickEvent"/> event on an object of type <see cref="Avalonia.Controls.SplitButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnClickHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.SplitButton
    {
        obj.AddHandler(Avalonia.Controls.SplitButton.ClickEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.SplitButton.ClickEvent"/> event on an object of type <see cref="Avalonia.Controls.SplitButton"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnClick<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.SplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitButton.ClickEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.SplitButton.ClickEvent"/> event on an object of type <see cref="Avalonia.Controls.SplitButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnClick(
        this Avalonia.Controls.SplitButton obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.SplitButton.ClickEvent, routes);
    }

    // Avalonia.Controls.SplitButton.Click

    /// <summary>
    /// Adds a handler to the `Click` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnClickEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.SplitButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Click += h, 
                h => obj.Click -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Click` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Click` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnClickEvent(this Avalonia.Controls.SplitButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Click += h, 
                h => obj.Click -= h)
            .Select(x => x.EventArgs);
    }
}
