// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GridSplitterExtensions
{
    // ResizeDirectionProperty

    public static T ResizeDirection<T>(this T obj, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = value;
        return obj;
    }

    public static T ResizeDirection<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ResizeDirection<T>(this T obj, IObservable<Avalonia.Controls.GridResizeDirection> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindResizeDirection(this Avalonia.Controls.GridSplitter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.GridResizeDirection> ObserveResizeDirection(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeDirectionProperty);
    }

    public static T OnResizeDirection<T>(this T obj, Action<IObservable<Avalonia.Controls.GridResizeDirection>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeDirectionProperty);
        handler(observable);
        return obj;
    }

    public static T ResizeDirectionAuto<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = Avalonia.Controls.GridResizeDirection.Auto;
        return obj;
    }

    public static T ResizeDirectionColumns<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = Avalonia.Controls.GridResizeDirection.Columns;
        return obj;
    }

    public static T ResizeDirectionRows<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeDirectionProperty] = Avalonia.Controls.GridResizeDirection.Rows;
        return obj;
    }

    // ResizeBehaviorProperty

    public static T ResizeBehavior<T>(this T obj, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = value;
        return obj;
    }

    public static T ResizeBehavior<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ResizeBehavior<T>(this T obj, IObservable<Avalonia.Controls.GridResizeBehavior> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindResizeBehavior(this Avalonia.Controls.GridSplitter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.GridResizeBehavior> ObserveResizeBehavior(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty);
    }

    public static T OnResizeBehavior<T>(this T obj, Action<IObservable<Avalonia.Controls.GridResizeBehavior>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty);
        handler(observable);
        return obj;
    }

    public static T ResizeBehaviorBasedOnAlignment<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.BasedOnAlignment;
        return obj;
    }

    public static T ResizeBehaviorCurrentAndNext<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.CurrentAndNext;
        return obj;
    }

    public static T ResizeBehaviorPreviousAndCurrent<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.PreviousAndCurrent;
        return obj;
    }

    public static T ResizeBehaviorPreviousAndNext<T>(this T obj) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ResizeBehaviorProperty] = Avalonia.Controls.GridResizeBehavior.PreviousAndNext;
        return obj;
    }

    // ShowsPreviewProperty

    public static T ShowsPreview<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ShowsPreviewProperty] = value;
        return obj;
    }

    public static T ShowsPreview<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ShowsPreviewProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ShowsPreview<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.ShowsPreviewProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindShowsPreview(this Avalonia.Controls.GridSplitter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.GridSplitter.ShowsPreviewProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveShowsPreview(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.ShowsPreviewProperty);
    }

    public static T OnShowsPreview<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.ShowsPreviewProperty);
        handler(observable);
        return obj;
    }

    // KeyboardIncrementProperty

    public static T KeyboardIncrement<T>(this T obj, System.Double value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.KeyboardIncrementProperty] = value;
        return obj;
    }

    public static T KeyboardIncrement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.KeyboardIncrementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T KeyboardIncrement<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.KeyboardIncrementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindKeyboardIncrement(this Avalonia.Controls.GridSplitter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.GridSplitter.KeyboardIncrementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveKeyboardIncrement(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty);
    }

    public static T OnKeyboardIncrement<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty);
        handler(observable);
        return obj;
    }

    // DragIncrementProperty

    public static T DragIncrement<T>(this T obj, System.Double value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.DragIncrementProperty] = value;
        return obj;
    }

    public static T DragIncrement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.DragIncrementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DragIncrement<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.DragIncrementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDragIncrement(this Avalonia.Controls.GridSplitter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.GridSplitter.DragIncrementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveDragIncrement(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.DragIncrementProperty);
    }

    public static T OnDragIncrement<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.DragIncrementProperty);
        handler(observable);
        return obj;
    }

    // PreviewContentProperty

    public static T PreviewContent<T>(this T obj, Avalonia.Controls.ITemplate<Avalonia.Controls.IControl> value) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.PreviewContentProperty] = value;
        return obj;
    }

    public static T PreviewContent<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.PreviewContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PreviewContent<T>(this T obj, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.GridSplitter
    {
        obj[Avalonia.Controls.GridSplitter.PreviewContentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPreviewContent(this Avalonia.Controls.GridSplitter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.GridSplitter.PreviewContentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> ObservePreviewContent(this Avalonia.Controls.GridSplitter obj)
    {
        return obj.GetObservable(Avalonia.Controls.GridSplitter.PreviewContentProperty);
    }

    public static T OnPreviewContent<T>(this T obj, Action<IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>>> handler) where T : Avalonia.Controls.GridSplitter
    {
        var observable = obj.GetObservable(Avalonia.Controls.GridSplitter.PreviewContentProperty);
        handler(observable);
        return obj;
    }
}
