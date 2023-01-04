// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.DockPanel"/> class property extension methods.
/// </summary>
public static partial class DockPanelExtensions
{
    // Avalonia.Controls.DockPanel.DockProperty

    public static Builder<T> Dock1<T>(this Builder<T> builder, Builder<Avalonia.Controls.Dock> value)
        where T : Avalonia.Controls.Control
    {
        void Setter(T obj) => obj[Avalonia.Controls.DockPanel.DockProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DockPanel.DockProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Dock<T>(this T obj, Avalonia.Controls.Dock value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DockPanel.DockProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DockPanel.DockProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Dock<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DockPanel.DockProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DockPanel.DockProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Dock<T>(
        this T obj,
        IObservable<Avalonia.Controls.Dock> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.DockPanel.DockProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DockPanel.DockProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DockPanel.DockProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDock(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DockPanel.DockProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DockPanel.DockProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Dock> ObserveDock(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.DockPanel.DockProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DockPanel.DockProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDock<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.Dock>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.DockPanel.DockProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> DockLeft1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Control
    {
        void Setter(T obj) => obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Left;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DockPanel.DockProperty"/> property value to <see cref="Avalonia.Controls.Dock.Left"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DockLeft<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Left;
        return obj;
    }

    public static Builder<T> DockBottom1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Control
    {
        void Setter(T obj) => obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Bottom;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DockPanel.DockProperty"/> property value to <see cref="Avalonia.Controls.Dock.Bottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DockBottom<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Bottom;
        return obj;
    }

    public static Builder<T> DockRight1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Control
    {
        void Setter(T obj) => obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Right;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DockPanel.DockProperty"/> property value to <see cref="Avalonia.Controls.Dock.Right"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DockRight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Right;
        return obj;
    }

    public static Builder<T> DockTop1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Control
    {
        void Setter(T obj) => obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Top;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DockPanel.DockProperty"/> property value to <see cref="Avalonia.Controls.Dock.Top"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DockTop<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.DockPanel.DockProperty] = Avalonia.Controls.Dock.Top;
        return obj;
    }

    // Avalonia.Controls.DockPanel.LastChildFillProperty

    public static Builder<T> LastChildFill1<T>(this Builder<T> builder, Builder<System.Boolean> value)
        where T : Avalonia.Controls.DockPanel
    {
        void Setter(T obj) => obj[Avalonia.Controls.DockPanel.LastChildFillProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T LastChildFill<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DockPanel
    {
        obj[Avalonia.Controls.DockPanel.LastChildFillProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T LastChildFill<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DockPanel
    {
        var descriptor = Avalonia.Controls.DockPanel.LastChildFillProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T LastChildFill<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.DockPanel
    {
        var descriptor = Avalonia.Controls.DockPanel.LastChildFillProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindLastChildFill(
        this Avalonia.Controls.DockPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.DockPanel.LastChildFillProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveLastChildFill(this Avalonia.Controls.DockPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.DockPanel.LastChildFillProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.DockPanel.LastChildFillProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnLastChildFill<T>(this T obj, Action<Avalonia.Controls.DockPanel, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.DockPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.DockPanel.LastChildFillProperty);
        handler(obj, observable);
        return obj;
    }
}
