// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Image"/> class property extension methods.
/// </summary>
public static partial class ImageExtensions
{
    // Avalonia.Controls.Image.SourceProperty

    public static Builder<T> Source1<T>(this Builder<T> builder, Builder<Avalonia.Media.IImage> value)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.SourceProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.SourceProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Source<T>(this T obj, Avalonia.Media.IImage value) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.SourceProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Image.SourceProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Source<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Image
    {
        var descriptor = Avalonia.Controls.Image.SourceProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Image.SourceProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Source<T>(
        this T obj,
        IObservable<Avalonia.Media.IImage> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Image
    {
        var descriptor = Avalonia.Controls.Image.SourceProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Image.SourceProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Image.SourceProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSource(
        this Avalonia.Controls.Image obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Image.SourceProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Image.SourceProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IImage> ObserveSource(this Avalonia.Controls.Image obj)
    {
        return obj.GetObservable(Avalonia.Controls.Image.SourceProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Image.SourceProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSource<T>(this T obj, Action<Avalonia.Controls.Image, IObservable<Avalonia.Media.IImage>> handler) where T : Avalonia.Controls.Image
    {
        var observable = obj.GetObservable(Avalonia.Controls.Image.SourceProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Image.StretchProperty

    public static Builder<T> Stretch1<T>(this Builder<T> builder, Builder<Avalonia.Media.Stretch> value)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Stretch<T>(this T obj, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Image.StretchProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Stretch<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Image
    {
        var descriptor = Avalonia.Controls.Image.StretchProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Image.StretchProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Stretch<T>(
        this T obj,
        IObservable<Avalonia.Media.Stretch> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Image
    {
        var descriptor = Avalonia.Controls.Image.StretchProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Image.StretchProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Image.StretchProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindStretch(
        this Avalonia.Controls.Image obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Image.StretchProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Image.StretchProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Stretch> ObserveStretch(this Avalonia.Controls.Image obj)
    {
        return obj.GetObservable(Avalonia.Controls.Image.StretchProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Image.StretchProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnStretch<T>(this T obj, Action<Avalonia.Controls.Image, IObservable<Avalonia.Media.Stretch>> handler) where T : Avalonia.Controls.Image
    {
        var observable = obj.GetObservable(Avalonia.Controls.Image.StretchProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> StretchNone1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.None;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchProperty"/> property value to <see cref="Avalonia.Media.Stretch.None"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchNone<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.None;
        return obj;
    }

    public static Builder<T> StretchFill1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.Fill;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchProperty"/> property value to <see cref="Avalonia.Media.Stretch.Fill"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchFill<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.Fill;
        return obj;
    }

    public static Builder<T> StretchUniform1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.Uniform;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchProperty"/> property value to <see cref="Avalonia.Media.Stretch.Uniform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchUniform<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.Uniform;
        return obj;
    }

    public static Builder<T> StretchUniformToFill1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.UniformToFill;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchProperty"/> property value to <see cref="Avalonia.Media.Stretch.UniformToFill"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchUniformToFill<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchProperty] = Avalonia.Media.Stretch.UniformToFill;
        return obj;
    }

    // Avalonia.Controls.Image.StretchDirectionProperty

    public static Builder<T> StretchDirection1<T>(this Builder<T> builder, Builder<Avalonia.Media.StretchDirection> value)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchDirectionProperty] = value.Build();
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchDirection<T>(this T obj, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchDirectionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchDirection<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Image
    {
        var descriptor = Avalonia.Controls.Image.StretchDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchDirection<T>(
        this T obj,
        IObservable<Avalonia.Media.StretchDirection> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Image
    {
        var descriptor = Avalonia.Controls.Image.StretchDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindStretchDirection(
        this Avalonia.Controls.Image obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Image.StretchDirectionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.StretchDirection> ObserveStretchDirection(this Avalonia.Controls.Image obj)
    {
        return obj.GetObservable(Avalonia.Controls.Image.StretchDirectionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnStretchDirection<T>(this T obj, Action<Avalonia.Controls.Image, IObservable<Avalonia.Media.StretchDirection>> handler) where T : Avalonia.Controls.Image
    {
        var observable = obj.GetObservable(Avalonia.Controls.Image.StretchDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static Builder<T> StretchDirectionUpOnly1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchDirectionProperty] = Avalonia.Media.StretchDirection.UpOnly;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> property value to <see cref="Avalonia.Media.StretchDirection.UpOnly"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchDirectionUpOnly<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchDirectionProperty] = Avalonia.Media.StretchDirection.UpOnly;
        return obj;
    }

    public static Builder<T> StretchDirectionDownOnly1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchDirectionProperty] = Avalonia.Media.StretchDirection.DownOnly;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> property value to <see cref="Avalonia.Media.StretchDirection.DownOnly"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchDirectionDownOnly<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchDirectionProperty] = Avalonia.Media.StretchDirection.DownOnly;
        return obj;
    }

    public static Builder<T> StretchDirectionBoth1<T>(this Builder<T> builder)
        where T : Avalonia.Controls.Image
    {
        void Setter(T obj) => obj[Avalonia.Controls.Image.StretchDirectionProperty] = Avalonia.Media.StretchDirection.Both;
        builder.Setters.Add(Setter);
        return builder;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Image.StretchDirectionProperty"/> property value to <see cref="Avalonia.Media.StretchDirection.Both"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T StretchDirectionBoth<T>(this T obj) where T : Avalonia.Controls.Image
    {
        obj[Avalonia.Controls.Image.StretchDirectionProperty] = Avalonia.Media.StretchDirection.Both;
        return obj;
    }
}
