// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.ItemsControl"/> class style setters extension methods.
/// </summary>
public static partial class ItemsControlSetters
{
    // Avalonia.Controls.ItemsControl.ItemsProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItems(this Style style, System.Collections.IEnumerable value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItems(this KeyFrame keyFrame, System.Collections.IEnumerable value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItems(this Style style, IObservable<System.Collections.IEnumerable> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItems(this KeyFrame keyFrame, IObservable<System.Collections.IEnumerable> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItems(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItems(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsProperty, binding));
        return keyFrame;
    }

    // Avalonia.Controls.ItemsControl.ItemContainerThemeProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemContainerTheme(this Style style, Avalonia.Styling.ControlTheme value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemContainerTheme(this KeyFrame keyFrame, Avalonia.Styling.ControlTheme value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemContainerTheme(this Style style, IObservable<Avalonia.Styling.ControlTheme> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemContainerTheme(this KeyFrame keyFrame, IObservable<Avalonia.Styling.ControlTheme> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemContainerTheme(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemContainerThemeProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemContainerTheme(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding));
        return keyFrame;
    }

    // Avalonia.Controls.ItemsControl.ItemsPanelProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemsPanel(this Style style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemsPanel(this KeyFrame keyFrame, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemsPanel(this Style style, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemsPanel(this KeyFrame keyFrame, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemsPanel(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemsPanelProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemsPanel(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding));
        return keyFrame;
    }

    // Avalonia.Controls.ItemsControl.ItemTemplateProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemTemplate(this Style style, Avalonia.Controls.Templates.IDataTemplate value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemTemplate(this KeyFrame keyFrame, Avalonia.Controls.Templates.IDataTemplate value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemTemplate(this Style style, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemTemplate(this KeyFrame keyFrame, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlItemTemplate(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.ItemTemplateProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlItemTemplate(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding));
        return keyFrame;
    }

    // Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlDisplayMemberBinding(this Style style, Avalonia.Data.IBinding value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlDisplayMemberBinding(this KeyFrame keyFrame, Avalonia.Data.IBinding value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlDisplayMemberBinding(this Style style, IObservable<Avalonia.Data.IBinding> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlDisplayMemberBinding(this KeyFrame keyFrame, IObservable<Avalonia.Data.IBinding> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlAreHorizontalSnapPointsRegular(this Style style, System.Boolean value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlAreHorizontalSnapPointsRegular(this KeyFrame keyFrame, System.Boolean value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlAreHorizontalSnapPointsRegular(this Style style, IObservable<System.Boolean> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlAreHorizontalSnapPointsRegular(this KeyFrame keyFrame, IObservable<System.Boolean> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlAreHorizontalSnapPointsRegular(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlAreHorizontalSnapPointsRegular(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreHorizontalSnapPointsRegularProperty, binding));
        return keyFrame;
    }

    // Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlAreVerticalSnapPointsRegular(this Style style, System.Boolean value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlAreVerticalSnapPointsRegular(this KeyFrame keyFrame, System.Boolean value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlAreVerticalSnapPointsRegular(this Style style, IObservable<System.Boolean> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlAreVerticalSnapPointsRegular(this KeyFrame keyFrame, IObservable<System.Boolean> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetItemsControlAreVerticalSnapPointsRegular(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetItemsControlAreVerticalSnapPointsRegular(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.ItemsControl.AreVerticalSnapPointsRegularProperty, binding));
        return keyFrame;
    }

}
