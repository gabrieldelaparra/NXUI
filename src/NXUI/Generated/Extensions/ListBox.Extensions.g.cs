// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ListBox"/> class property extension methods.
/// </summary>
public static partial class ListBoxExtensions
{
    // Avalonia.Controls.ListBox.ScrollProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ListBox.ScrollProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ListBox.ScrollProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindScroll(
        this Avalonia.Controls.ListBox obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ListBox.ScrollProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ListBox.ScrollProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Primitives.IScrollable> ObserveScroll(this Avalonia.Controls.ListBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ListBox.ScrollProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ListBox.ScrollProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.ListBox OnScroll(this Avalonia.Controls.ListBox obj, Action<Avalonia.Controls.ListBox, IObservable<Avalonia.Controls.Primitives.IScrollable>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.ListBox.ScrollProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ListBox.VirtualizationModeProperty

    public static Builder<T> VirtualizationMode1<T>(this Builder<T> builder, Builder<Avalonia.Controls.ItemVirtualizationMode> value)
        where T : Avalonia.Controls.ListBox
    {
        void Setter(T obj) => obj[Avalonia.Controls.ListBox.VirtualizationModeProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VirtualizationMode<T>(this T obj, Avalonia.Controls.ItemVirtualizationMode value) where T : Avalonia.Controls.ListBox
    {
        obj[Avalonia.Controls.ListBox.VirtualizationModeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VirtualizationMode<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ListBox
    {
        var descriptor = Avalonia.Controls.ListBox.VirtualizationModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VirtualizationMode<T>(
        this T obj,
        IObservable<Avalonia.Controls.ItemVirtualizationMode> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ListBox
    {
        var descriptor = Avalonia.Controls.ListBox.VirtualizationModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindVirtualizationMode(
        this Avalonia.Controls.ListBox obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ListBox.VirtualizationModeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.ItemVirtualizationMode> ObserveVirtualizationMode(this Avalonia.Controls.ListBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ListBox.VirtualizationModeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVirtualizationMode<T>(this T obj, Action<Avalonia.Controls.ListBox, IObservable<Avalonia.Controls.ItemVirtualizationMode>> handler) where T : Avalonia.Controls.ListBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ListBox.VirtualizationModeProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> VirtualizationModeNone1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.ListBox
    {
        void Setter(T obj) => obj[Avalonia.Controls.ListBox.VirtualizationModeProperty] = Avalonia.Controls.ItemVirtualizationMode.None;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> property value to <see cref="Avalonia.Controls.ItemVirtualizationMode.None"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VirtualizationModeNone<T>(this T obj) where T : Avalonia.Controls.ListBox
    {
        obj[Avalonia.Controls.ListBox.VirtualizationModeProperty] = Avalonia.Controls.ItemVirtualizationMode.None;
        return obj;
    }

    public static Builder<T> VirtualizationModeSimple1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.ListBox
    {
        void Setter(T obj) => obj[Avalonia.Controls.ListBox.VirtualizationModeProperty] = Avalonia.Controls.ItemVirtualizationMode.Simple;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ListBox.VirtualizationModeProperty"/> property value to <see cref="Avalonia.Controls.ItemVirtualizationMode.Simple"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T VirtualizationModeSimple<T>(this T obj) where T : Avalonia.Controls.ListBox
    {
        obj[Avalonia.Controls.ListBox.VirtualizationModeProperty] = Avalonia.Controls.ItemVirtualizationMode.Simple;
        return obj;
    }
}
