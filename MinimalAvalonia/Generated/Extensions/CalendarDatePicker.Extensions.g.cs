// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class CalendarDatePickerExtensions
{
    // DisplayDateProperty

    public static T DisplayDate<T>(this T obj, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateProperty] = value;
        return obj;
    }

    public static T DisplayDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayDate<T>(this T obj, IObservable<System.DateTime> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayDate(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.DisplayDateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTime> ObserveDisplayDate(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty);
    }

    public static T OnDisplayDate<T>(this T obj, Action<IObservable<System.DateTime>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty);
        handler(observable);
        return obj;
    }

    // DisplayDateStartProperty

    public static T DisplayDateStart<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty] = value;
        return obj;
    }

    public static T DisplayDateStart<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayDateStart<T>(this T obj, IObservable<System.Nullable<System.DateTime>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayDateStart(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTime>> ObserveDisplayDateStart(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty);
    }

    public static T OnDisplayDateStart<T>(this T obj, Action<IObservable<System.Nullable<System.DateTime>>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty);
        handler(observable);
        return obj;
    }

    // DisplayDateEndProperty

    public static T DisplayDateEnd<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty] = value;
        return obj;
    }

    public static T DisplayDateEnd<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayDateEnd<T>(this T obj, IObservable<System.Nullable<System.DateTime>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayDateEnd(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTime>> ObserveDisplayDateEnd(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty);
    }

    public static T OnDisplayDateEnd<T>(this T obj, Action<IObservable<System.Nullable<System.DateTime>>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty);
        handler(observable);
        return obj;
    }

    // FirstDayOfWeekProperty

    public static T FirstDayOfWeek<T>(this T obj, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = value;
        return obj;
    }

    public static T FirstDayOfWeek<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FirstDayOfWeek<T>(this T obj, IObservable<System.DayOfWeek> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFirstDayOfWeek(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DayOfWeek> ObserveFirstDayOfWeek(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty);
    }

    public static T OnFirstDayOfWeek<T>(this T obj, Action<IObservable<System.DayOfWeek>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty);
        handler(observable);
        return obj;
    }

    public static T FirstDayOfWeekSunday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Sunday;
        return obj;
    }

    public static T FirstDayOfWeekMonday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Monday;
        return obj;
    }

    public static T FirstDayOfWeekTuesday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Tuesday;
        return obj;
    }

    public static T FirstDayOfWeekWednesday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Wednesday;
        return obj;
    }

    public static T FirstDayOfWeekThursday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Thursday;
        return obj;
    }

    public static T FirstDayOfWeekFriday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Friday;
        return obj;
    }

    public static T FirstDayOfWeekSaturday<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty] = System.DayOfWeek.Saturday;
        return obj;
    }

    // IsDropDownOpenProperty

    public static T IsDropDownOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty] = value;
        return obj;
    }

    public static T IsDropDownOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsDropDownOpen<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsDropDownOpen(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsDropDownOpen(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty);
    }

    public static T OnIsDropDownOpen<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty);
        handler(observable);
        return obj;
    }

    // IsTodayHighlightedProperty

    public static T IsTodayHighlighted<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty] = value;
        return obj;
    }

    public static T IsTodayHighlighted<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsTodayHighlighted<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsTodayHighlighted(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsTodayHighlighted(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty);
    }

    public static T OnIsTodayHighlighted<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty);
        handler(observable);
        return obj;
    }

    // SelectedDateProperty

    public static T SelectedDate<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateProperty] = value;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, IObservable<System.Nullable<System.DateTime>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedDate(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.SelectedDateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTime>> ObserveSelectedDate(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty);
    }

    public static T OnSelectedDate<T>(this T obj, Action<IObservable<System.Nullable<System.DateTime>>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty);
        handler(observable);
        return obj;
    }

    // SelectedDateFormatProperty

    public static T SelectedDateFormat<T>(this T obj, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty] = value;
        return obj;
    }

    public static T SelectedDateFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedDateFormat<T>(this T obj, IObservable<Avalonia.Controls.CalendarDatePickerFormat> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedDateFormat(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.CalendarDatePickerFormat> ObserveSelectedDateFormat(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty);
    }

    public static T OnSelectedDateFormat<T>(this T obj, Action<IObservable<Avalonia.Controls.CalendarDatePickerFormat>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty);
        handler(observable);
        return obj;
    }

    public static T SelectedDateFormatLong<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty] = Avalonia.Controls.CalendarDatePickerFormat.Long;
        return obj;
    }

    public static T SelectedDateFormatShort<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty] = Avalonia.Controls.CalendarDatePickerFormat.Short;
        return obj;
    }

    public static T SelectedDateFormatCustom<T>(this T obj) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty] = Avalonia.Controls.CalendarDatePickerFormat.Custom;
        return obj;
    }

    // CustomDateFormatStringProperty

    public static T CustomDateFormatString<T>(this T obj, System.String value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty] = value;
        return obj;
    }

    public static T CustomDateFormatString<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CustomDateFormatString<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCustomDateFormatString(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveCustomDateFormatString(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty);
    }

    public static T OnCustomDateFormatString<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty);
        handler(observable);
        return obj;
    }

    // TextProperty

    public static T Text<T>(this T obj, System.String value) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Text<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.CalendarDatePicker
    {
        obj[Avalonia.Controls.CalendarDatePicker.TextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindText(this Avalonia.Controls.CalendarDatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.CalendarDatePicker.TextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveText(this Avalonia.Controls.CalendarDatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.CalendarDatePicker.TextProperty);
    }

    public static T OnText<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.CalendarDatePicker
    {
        var observable = obj.GetObservable(Avalonia.Controls.CalendarDatePicker.TextProperty);
        handler(observable);
        return obj;
    }
}
