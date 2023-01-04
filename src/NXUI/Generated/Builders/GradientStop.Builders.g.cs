// <auto-generated />
namespace NXUI;

/// <summary>
/// The avalonia builders.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.GradientStop"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Media.GradientStop"/> class.</returns>
    public static Avalonia.Media.GradientStop GradientStop()
        => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.GradientStop"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.GradientStop"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.GradientStop"/> class.</returns>
    public static Avalonia.Media.GradientStop GradientStop(out Avalonia.Media.GradientStop @ref)
        => @ref = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.GradientStop"/> class.
    /// </summary>
    /// <param name="color">The color value.</param>
    /// <param name="offset">The offset value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.GradientStop"/> class.</returns>
    public static Avalonia.Media.GradientStop GradientStop(Avalonia.Media.Color color, System.Double offset)
        => new(color, offset);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.GradientStop"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.GradientStop"/> instantiated class.</param>
    /// <param name="color">The color value.</param>
    /// <param name="offset">The offset value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.GradientStop"/> class.</returns>
    public static Avalonia.Media.GradientStop GradientStop(out Avalonia.Media.GradientStop @ref, Avalonia.Media.Color color, System.Double offset)
        => @ref = new(color, offset);

    public static Builder<Avalonia.Media.GradientStop> GradientStop1()
    {
        return new Builder<Avalonia.Media.GradientStop>() { Activator = () => new Avalonia.Media.GradientStop() };
    }
/*
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.GradientStop"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Media.GradientStop"/> class.</returns>
    public static Avalonia.Media.GradientStop GradientStop() => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.GradientStop"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.GradientStop"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.GradientStop"/> class.</returns>
    public static Avalonia.Media.GradientStop GradientStop(out Avalonia.Media.GradientStop @ref) => @ref = new();*/
}
