// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ListBoxItem"/> class property extension methods.
/// </summary>
public static partial class ListBoxItemExtensions
{
    // Avalonia.Controls.ListBoxItem.IsSelectedProperty

    public static Builder<T> IsSelected1<T>(this Builder<T> builder, Builder<System.Boolean> value)
        where T : Avalonia.Controls.ListBoxItem
    {
        void Setter(T obj) => obj[Avalonia.Controls.ListBoxItem.IsSelectedProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsSelected<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ListBoxItem
    {
        obj[Avalonia.Controls.ListBoxItem.IsSelectedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsSelected<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ListBoxItem
    {
        var descriptor = Avalonia.Controls.ListBoxItem.IsSelectedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsSelected<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ListBoxItem
    {
        var descriptor = Avalonia.Controls.ListBoxItem.IsSelectedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsSelected(
        this Avalonia.Controls.ListBoxItem obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ListBoxItem.IsSelectedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsSelected(this Avalonia.Controls.ListBoxItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.ListBoxItem.IsSelectedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ListBoxItem.IsSelectedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsSelected<T>(this T obj, Action<Avalonia.Controls.ListBoxItem, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ListBoxItem
    {
        var observable = obj.GetObservable(Avalonia.Controls.ListBoxItem.IsSelectedProperty);
        handler(obj, observable);
        return obj;
    }
}
