// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase"/> class property extension methods.
/// </summary>
public static partial class ItemsPresenterBaseExtensions
{
    // Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Items<T>(this T obj, System.Collections.IEnumerable value) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        obj[Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Items<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Items<T>(
        this T obj,
        IObservable<System.Collections.IEnumerable> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItems(
        this Avalonia.Controls.Presenters.ItemsPresenterBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Collections.IEnumerable> ObserveItems(this Avalonia.Controls.Presenters.ItemsPresenterBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItems<T>(this T obj, Action<Avalonia.Controls.Presenters.ItemsPresenterBase, IObservable<System.Collections.IEnumerable>> handler) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(this T obj, Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel> value) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        obj[Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemsPanel<T>(
        this T obj,
        IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemsPanel(
        this Avalonia.Controls.Presenters.ItemsPresenterBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>> ObserveItemsPanel(this Avalonia.Controls.Presenters.ItemsPresenterBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemsPanel<T>(this T obj, Action<Avalonia.Controls.Presenters.ItemsPresenterBase, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IPanel>>> handler) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ItemsPresenterBase.ItemsPanelProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        obj[Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ItemTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindItemTemplate(
        this Avalonia.Controls.Presenters.ItemsPresenterBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveItemTemplate(this Avalonia.Controls.Presenters.ItemsPresenterBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnItemTemplate<T>(this T obj, Action<Avalonia.Controls.Presenters.ItemsPresenterBase, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.Presenters.ItemsPresenterBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ItemsPresenterBase.ItemTemplateProperty);
        handler(obj, observable);
        return obj;
    }
}
