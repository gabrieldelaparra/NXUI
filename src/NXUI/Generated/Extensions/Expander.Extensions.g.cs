// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Expander"/> class property extension methods.
/// </summary>
public static partial class ExpanderExtensions
{
    // Avalonia.Controls.Expander.ContentTransitionProperty

    public static Builder<T> ContentTransition1<T>(this Builder<T> builder, Builder<Avalonia.Animation.IPageTransition> value)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.ContentTransitionProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ContentTransition<T>(this T obj, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ContentTransitionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ContentTransition<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Expander
    {
        var descriptor = Avalonia.Controls.Expander.ContentTransitionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ContentTransition<T>(
        this T obj,
        IObservable<Avalonia.Animation.IPageTransition> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Expander
    {
        var descriptor = Avalonia.Controls.Expander.ContentTransitionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindContentTransition(
        this Avalonia.Controls.Expander obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Expander.ContentTransitionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Animation.IPageTransition> ObserveContentTransition(this Avalonia.Controls.Expander obj)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.ContentTransitionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Expander.ContentTransitionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnContentTransition<T>(this T obj, Action<Avalonia.Controls.Expander, IObservable<Avalonia.Animation.IPageTransition>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.ContentTransitionProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Expander.ExpandDirectionProperty

    public static Builder<T> ExpandDirection1<T>(this Builder<T> builder, Builder<Avalonia.Controls.ExpandDirection> value)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirection<T>(this T obj, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirection<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Expander
    {
        var descriptor = Avalonia.Controls.Expander.ExpandDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirection<T>(
        this T obj,
        IObservable<Avalonia.Controls.ExpandDirection> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Expander
    {
        var descriptor = Avalonia.Controls.Expander.ExpandDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindExpandDirection(
        this Avalonia.Controls.Expander obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Expander.ExpandDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.ExpandDirection> ObserveExpandDirection(this Avalonia.Controls.Expander obj)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.ExpandDirectionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnExpandDirection<T>(this T obj, Action<Avalonia.Controls.Expander, IObservable<Avalonia.Controls.ExpandDirection>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.ExpandDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> ExpandDirectionDown1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Down;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> property value to <see cref="Avalonia.Controls.ExpandDirection.Down"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirectionDown<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Down;
        return obj;
    }

    public static Builder<T> ExpandDirectionUp1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Up;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> property value to <see cref="Avalonia.Controls.ExpandDirection.Up"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirectionUp<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Up;
        return obj;
    }

    public static Builder<T> ExpandDirectionLeft1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Left;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> property value to <see cref="Avalonia.Controls.ExpandDirection.Left"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirectionLeft<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Left;
        return obj;
    }

    public static Builder<T> ExpandDirectionRight1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Right;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.ExpandDirectionProperty"/> property value to <see cref="Avalonia.Controls.ExpandDirection.Right"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ExpandDirectionRight<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Right;
        return obj;
    }

    // Avalonia.Controls.Expander.IsExpandedProperty

    public static Builder<T> IsExpanded1<T>(this Builder<T> builder, Builder<System.Boolean> value)
        where T : Avalonia.Controls.Expander
    {
        void Setter(T obj) => obj[Avalonia.Controls.Expander.IsExpandedProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsExpanded<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.IsExpandedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsExpanded<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Expander
    {
        var descriptor = Avalonia.Controls.Expander.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsExpanded<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Expander
    {
        var descriptor = Avalonia.Controls.Expander.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsExpanded(
        this Avalonia.Controls.Expander obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Expander.IsExpandedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsExpanded(this Avalonia.Controls.Expander obj)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.IsExpandedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Expander.IsExpandedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsExpanded<T>(this T obj, Action<Avalonia.Controls.Expander, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.IsExpandedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Expander.CollapsedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.CollapsedEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnCollapsedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        obj.AddHandler(Avalonia.Controls.Expander.CollapsedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.CollapsedEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnCollapsed<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.CollapsedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Expander.CollapsedEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCollapsed(
        this Avalonia.Controls.Expander obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.CollapsedEvent, routes);
    }

    // Avalonia.Controls.Expander.CollapsingEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.CollapsingEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnCollapsingHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        obj.AddHandler(Avalonia.Controls.Expander.CollapsingEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.CollapsingEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnCollapsing<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.CollapsingEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Expander.CollapsingEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCollapsing(
        this Avalonia.Controls.Expander obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.CollapsingEvent, routes);
    }

    // Avalonia.Controls.Expander.ExpandedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.ExpandedEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnExpandedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        obj.AddHandler(Avalonia.Controls.Expander.ExpandedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.ExpandedEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnExpanded<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.ExpandedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Expander.ExpandedEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnExpanded(
        this Avalonia.Controls.Expander obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.ExpandedEvent, routes);
    }

    // Avalonia.Controls.Expander.ExpandingEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.ExpandingEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnExpandingHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        obj.AddHandler(Avalonia.Controls.Expander.ExpandingEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Expander.ExpandingEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnExpanding<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.ExpandingEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Expander.ExpandingEvent"/> event on an object of type <see cref="Avalonia.Controls.Expander"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnExpanding(
        this Avalonia.Controls.Expander obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.ExpandingEvent, routes);
    }

    // Avalonia.Controls.Expander.Collapsed

    /// <summary>
    /// Adds a handler to the `Collapsed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCollapsedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Collapsed += h, 
                h => obj.Collapsed -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Collapsed` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Collapsed` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCollapsedEvent(this Avalonia.Controls.Expander obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Collapsed += h, 
                h => obj.Collapsed -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Expander.Collapsing

    /// <summary>
    /// Adds a handler to the `Collapsing` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCollapsingEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Collapsing += h, 
                h => obj.Collapsing -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Collapsing` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Collapsing` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCollapsingEvent(this Avalonia.Controls.Expander obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Collapsing += h, 
                h => obj.Collapsing -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Expander.Expanded

    /// <summary>
    /// Adds a handler to the `Expanded` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnExpandedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Expanded += h, 
                h => obj.Expanded -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Expanded` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Expanded` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnExpandedEvent(this Avalonia.Controls.Expander obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Expanded += h, 
                h => obj.Expanded -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Expander.Expanding

    /// <summary>
    /// Adds a handler to the `Expanding` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnExpandingEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Expanding += h, 
                h => obj.Expanding -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Expanding` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Expanding` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnExpandingEvent(this Avalonia.Controls.Expander obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Expanding += h, 
                h => obj.Expanding -= h)
            .Select(x => x.EventArgs);
    }
}
