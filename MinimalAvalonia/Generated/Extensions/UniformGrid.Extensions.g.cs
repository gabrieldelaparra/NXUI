// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class UniformGridExtensions
{
    // RowsProperty

    public static T Rows<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.RowsProperty] = value;
        return obj;
    }

    public static T Rows<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.RowsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Rows<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.RowsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindRows(this Avalonia.Controls.Primitives.UniformGrid obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.UniformGrid.RowsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveRows(this Avalonia.Controls.Primitives.UniformGrid obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.UniformGrid.RowsProperty);
    }

    // ColumnsProperty

    public static T Columns<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty] = value;
        return obj;
    }

    public static T Columns<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Columns<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindColumns(this Avalonia.Controls.Primitives.UniformGrid obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveColumns(this Avalonia.Controls.Primitives.UniformGrid obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty);
    }

    // FirstColumnProperty

    public static T FirstColumn<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty] = value;
        return obj;
    }

    public static T FirstColumn<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FirstColumn<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.UniformGrid
    {
        obj[Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFirstColumn(this Avalonia.Controls.Primitives.UniformGrid obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveFirstColumn(this Avalonia.Controls.Primitives.UniformGrid obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty);
    }
}
