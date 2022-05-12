// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ButtonSpinnerExtensions
{
    // AllowSpinProperty

    public static T AllowSpin<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.AllowSpinProperty] = value;
        return obj;
    }

    public static T AllowSpin<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.AllowSpinProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AllowSpin<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.AllowSpinProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAllowSpin(this Avalonia.Controls.ButtonSpinner obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ButtonSpinner.AllowSpinProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveAllowSpin(this Avalonia.Controls.ButtonSpinner obj)
    {
        return obj.GetObservable(Avalonia.Controls.ButtonSpinner.AllowSpinProperty);
    }

    // ShowButtonSpinnerProperty

    public static T ShowButtonSpinner<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty] = value;
        return obj;
    }

    public static T ShowButtonSpinner<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ShowButtonSpinner<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindShowButtonSpinner(this Avalonia.Controls.ButtonSpinner obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveShowButtonSpinner(this Avalonia.Controls.ButtonSpinner obj)
    {
        return obj.GetObservable(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty);
    }

    // ButtonSpinnerLocationProperty

    public static T ButtonSpinnerLocation<T>(this T obj, Avalonia.Controls.Location value) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty] = value;
        return obj;
    }

    public static T ButtonSpinnerLocation<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ButtonSpinnerLocation<T>(this T obj, IObservable<Avalonia.Controls.Location> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindButtonSpinnerLocation(this Avalonia.Controls.ButtonSpinner obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Location> ObserveButtonSpinnerLocation(this Avalonia.Controls.ButtonSpinner obj)
    {
        return obj.GetObservable(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty);
    }

    public static T ButtonSpinnerLocationLeft<T>(this T obj) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty] = Avalonia.Controls.Location.Left;
        return obj;
    }

    public static T ButtonSpinnerLocationRight<T>(this T obj) where T : Avalonia.Controls.ButtonSpinner
    {
        obj[Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty] = Avalonia.Controls.Location.Right;
        return obj;
    }
}
