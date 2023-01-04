// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Input.KeyBinding"/> class property extension methods.
/// </summary>
public static partial class KeyBindingExtensions
{
    // Avalonia.Input.KeyBinding.CommandProperty

    public static Builder<T> Command1<T>(this Builder<T> builder, Builder<System.Windows.Input.ICommand> value)
        where T : Avalonia.Input.KeyBinding
    {
        void Setter(T obj) => obj[Avalonia.Input.KeyBinding.CommandProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.KeyBinding.CommandProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Command<T>(this T obj, System.Windows.Input.ICommand value) where T : Avalonia.Input.KeyBinding
    {
        obj[Avalonia.Input.KeyBinding.CommandProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.KeyBinding.CommandProperty"/> with binding source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.KeyBinding
    {
        var descriptor = Avalonia.Input.KeyBinding.CommandProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.KeyBinding.CommandProperty"/> with observable source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.KeyBinding
    {
        var descriptor = Avalonia.Input.KeyBinding.CommandProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Input.KeyBinding.CommandProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Input.KeyBinding.CommandProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCommand(
        this Avalonia.Input.KeyBinding obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Input.KeyBinding.CommandProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Input.KeyBinding.CommandProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Windows.Input.ICommand> ObserveCommand(this Avalonia.Input.KeyBinding obj)
    {
        return obj.GetObservable(Avalonia.Input.KeyBinding.CommandProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Input.KeyBinding.CommandProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCommand<T>(this T obj, Action<Avalonia.Input.KeyBinding, IObservable<System.Windows.Input.ICommand>> handler) where T : Avalonia.Input.KeyBinding
    {
        var observable = obj.GetObservable(Avalonia.Input.KeyBinding.CommandProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Input.KeyBinding.CommandParameterProperty

    public static Builder<T> CommandParameter1<T>(this Builder<T> builder, Builder<System.Object> value)
        where T : Avalonia.Input.KeyBinding
    {
        void Setter(T obj) => obj[Avalonia.Input.KeyBinding.CommandParameterProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T CommandParameter<T>(this T obj, System.Object value) where T : Avalonia.Input.KeyBinding
    {
        obj[Avalonia.Input.KeyBinding.CommandParameterProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/> with binding source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.KeyBinding
    {
        var descriptor = Avalonia.Input.KeyBinding.CommandParameterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/> with observable source value.
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
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.KeyBinding
    {
        var descriptor = Avalonia.Input.KeyBinding.CommandParameterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCommandParameter(
        this Avalonia.Input.KeyBinding obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Input.KeyBinding.CommandParameterProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveCommandParameter(this Avalonia.Input.KeyBinding obj)
    {
        return obj.GetObservable(Avalonia.Input.KeyBinding.CommandParameterProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Input.KeyBinding.CommandParameterProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCommandParameter<T>(this T obj, Action<Avalonia.Input.KeyBinding, IObservable<System.Object>> handler) where T : Avalonia.Input.KeyBinding
    {
        var observable = obj.GetObservable(Avalonia.Input.KeyBinding.CommandParameterProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Input.KeyBinding.GestureProperty

    public static Builder<T> Gesture1<T>(this Builder<T> builder, Builder<Avalonia.Input.KeyGesture> value)
        where T : Avalonia.Input.KeyBinding
    {
        void Setter(T obj) => obj[Avalonia.Input.KeyBinding.GestureProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Input.KeyBinding.GestureProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Gesture<T>(this T obj, Avalonia.Input.KeyGesture value) where T : Avalonia.Input.KeyBinding
    {
        obj[Avalonia.Input.KeyBinding.GestureProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.KeyBinding.GestureProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Gesture<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.KeyBinding
    {
        var descriptor = Avalonia.Input.KeyBinding.GestureProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Input.KeyBinding.GestureProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Gesture<T>(
        this T obj,
        IObservable<Avalonia.Input.KeyGesture> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Input.KeyBinding
    {
        var descriptor = Avalonia.Input.KeyBinding.GestureProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Input.KeyBinding.GestureProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Input.KeyBinding.GestureProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindGesture(
        this Avalonia.Input.KeyBinding obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Input.KeyBinding.GestureProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Input.KeyBinding.GestureProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Input.KeyGesture> ObserveGesture(this Avalonia.Input.KeyBinding obj)
    {
        return obj.GetObservable(Avalonia.Input.KeyBinding.GestureProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Input.KeyBinding.GestureProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnGesture<T>(this T obj, Action<Avalonia.Input.KeyBinding, IObservable<Avalonia.Input.KeyGesture>> handler) where T : Avalonia.Input.KeyBinding
    {
        var observable = obj.GetObservable(Avalonia.Input.KeyBinding.GestureProperty);
        handler(obj, observable);
        return obj;
    }
}
