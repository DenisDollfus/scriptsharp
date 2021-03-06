// DatepickerOptions.cs
// Script#/Libraries/jQuery/jQuery.UI/Datepicker
// Auto-generated code!
// Copyright (c) Ivaylo Gochkov, 2012
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class DatepickerOptions
    {
        public DatepickerOptions() { }
        public DatepickerOptions(params object[] nameValuePairs) { }

        #region Events

        /// <summary>
        /// This event is triggered when datepicker is created.
        /// </summary>
        [IntrinsicProperty]
        public jQueryEventHandler Create { get { return null; } set { } }

        /// <summary>
        /// Can be a function that takes an input field and current datepicker instance and returns an options object to update the datepicker with. It is called just before the datepicker is displayed.
        /// </summary>
        [IntrinsicProperty]
        public DatepickerEventHandler1 BeforeShow { get; set; }

        /// <summary>
        /// The function takes a date as a parameter and must return an array with [0] equal to true/false indicating whether or not this date is selectable, [1] equal to a CSS class name(s) or <c>''</c> for the default presentation, and [2] an optional popup tooltip for this date. It is called for each day in the datepicker before it is displayed.
        /// </summary>
        [IntrinsicProperty]
        public DatepickerEventHandler2 BeforeShowDay { get; set; }

        /// <summary>
        /// Allows you to define your own event when the datepicker moves to a new month and/or year. The function receives the selected year, month (1-12), and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        [IntrinsicProperty]
        public DatepickerEventHandler3 OnChangeMonthYear { get; set; }

        /// <summary>
        /// Allows you to define your own event when the datepicker is closed, whether or not a date is selected. The function receives the selected date as text (<c>''</c> if none) and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        [IntrinsicProperty]
        public DatepickerEventHandler4 OnClose { get; set; }

        /// <summary>
        /// Allows you to define your own event when the datepicker is selected. The function receives the selected date as text and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        [IntrinsicProperty]
        public DatepickerEventHandler4 OnSelect { get; set; }

        #endregion

        #region Options

        /// <summary>
        /// Disables (true) or enables (false) the datepicker. Can be set when initialising (first creating) the datepicker.
        /// </summary>
        [IntrinsicProperty]
        public bool Disabled { get { return false; } set { } }

        /// <summary>
        /// The jQuery selector for another field that is to be updated with the selected date from the datepicker.
        /// </summary>
        [IntrinsicProperty]
        public object AltField { get { return null; } set { } }

        /// <summary>
        /// The dateFormat to be used for the altField option. This allows one date format to be shown to the user for selection purposes, while a different format is actually sent behind the scenes. For a full list of the possible formats see the formatDate function
        /// </summary>
        [IntrinsicProperty]
        public string AltFormat { get { return null; } set { } }

        /// <summary>
        /// The text to display after each date field, e.g. to show the required format.
        /// </summary>
        [IntrinsicProperty]
        public string AppendText { get { return null; } set { } }

        /// <summary>
        /// Set to true to automatically resize the input field to accommodate dates in the current dateFormat.
        /// </summary>
        [IntrinsicProperty]
        public bool AutoSize { get { return false; } set { } }

        /// <summary>
        /// The URL for the popup button image. If set, buttonText becomes the ''alt'' value and is not directly displayed.
        /// </summary>
        [IntrinsicProperty]
        public string ButtonImage { get { return null; } set { } }

        /// <summary>
        /// Set to true to place an image after the field to use as the trigger without it appearing on a button.
        /// </summary>
        [IntrinsicProperty]
        public bool ButtonImageOnly { get { return false; } set { } }

        /// <summary>
        /// The text to display on the trigger button. Use in conjunction with showOn equal to 'button' or 'both'.
        /// </summary>
        [IntrinsicProperty]
        public string ButtonText { get { return null; } set { } }

        /// <summary>
        /// A function to calculate the week of the year for a given date. The default implementation uses the ISO 8601 definition: weeks start on a Monday; the first week of the year contains the first Thursday of the year.
        /// </summary>
        [IntrinsicProperty]
        public Action CalculateWeek { get { return null; } set { } }

        /// <summary>
        /// Allows you to change the month by selecting from a drop-down list. You can enable this feature by setting the attribute to true.
        /// </summary>
        [IntrinsicProperty]
        public bool ChangeMonth { get { return false; } set { } }

        /// <summary>
        /// Allows you to change the year by selecting from a drop-down list. You can enable this feature by setting the attribute to true. Use the yearRange option to control which years are made available for selection.
        /// </summary>
        [IntrinsicProperty]
        public bool ChangeYear { get { return false; } set { } }

        /// <summary>
        /// The text to display for the close link. This attribute is one of the regionalisation attributes. Use the showButtonPanel to display this button.
        /// </summary>
        [IntrinsicProperty]
        public string CloseText { get { return null; } set { } }

        /// <summary>
        /// When true entry in the input field is constrained to those characters allowed by the current dateFormat.
        /// </summary>
        [IntrinsicProperty]
        public bool ConstrainInput { get { return false; } set { } }

        /// <summary>
        /// The text to display for the current day link. This attribute is one of the regionalisation attributes. Use the showButtonPanel to display this button.
        /// </summary>
        [IntrinsicProperty]
        public string CurrentText { get { return null; } set { } }

        /// <summary>
        /// The format for parsed and displayed dates. This attribute is one of the regionalisation attributes. For a full list of the possible formats see the formatDate function.
        /// </summary>
        [IntrinsicProperty]
        public string DateFormat { get { return null; } set { } }

        /// <summary>
        /// The list of long day names, starting from Sunday, for use as requested via the dateFormat setting. They also appear as popup hints when hovering over the corresponding column headings. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public Array DayNames { get { return null; } set { } }

        /// <summary>
        /// The list of minimised day names, starting from Sunday, for use as column headers within the datepicker. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public Array DayNamesMin { get { return null; } set { } }

        /// <summary>
        /// The list of abbreviated day names, starting from Sunday, for use as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public Array DayNamesShort { get { return null; } set { } }

        /// <summary>
        /// Set the date to highlight on first opening if the field is blank. Specify either an actual date via a Date object or as a string in the current dateFormat, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
        /// </summary>
        [IntrinsicProperty]
        public object DefaultDate { get { return null; } set { } }

        /// <summary>
        /// Control the speed at which the datepicker appears, it may be a time in milliseconds or a string representing one of the three predefined speeds ("slow", "normal", "fast").
        /// </summary>
        [IntrinsicProperty]
        public object Duration { get { return null; } set { } }

        /// <summary>
        /// Set the first day of the week: Sunday is 0, Monday is 1, ... This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public int FirstDay { get { return 0; } set { } }

        /// <summary>
        /// When true the current day link moves to the currently selected date instead of today.
        /// </summary>
        [IntrinsicProperty]
        public bool GotoCurrent { get { return false; } set { } }

        /// <summary>
        /// Normally the previous and next links are disabled when not applicable (see minDate/maxDate). You can hide them altogether by setting this attribute to true.
        /// </summary>
        [IntrinsicProperty]
        public bool HideIfNoPrevNext { get { return false; } set { } }

        /// <summary>
        /// True if the current language is drawn from right to left. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public bool IsRTL { get { return false; } set { } }

        /// <summary>
        /// Set a maximum selectable date via a Date object or as a string in the current dateFormat, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +1w'), or null for no limit.
        /// </summary>
        [IntrinsicProperty]
        public object MaxDate { get { return null; } set { } }

        /// <summary>
        /// Set a minimum selectable date via a Date object or as a string in the current dateFormat, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '-1y -1m'), or null for no limit.
        /// </summary>
        [IntrinsicProperty]
        public object MinDate { get { return null; } set { } }

        /// <summary>
        /// The list of full month names, for use as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public Array MonthNames { get { return null; } set { } }

        /// <summary>
        /// The list of abbreviated month names, as used in the month header on each datepicker and as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public Array MonthNamesShort { get { return null; } set { } }

        /// <summary>
        /// When true the formatDate function is applied to the prevText, nextText, and currentText values before display, allowing them to display the target month names for example.
        /// </summary>
        [IntrinsicProperty]
        public bool NavigationAsDateFormat { get { return false; } set { } }

        /// <summary>
        /// The text to display for the next month link. This attribute is one of the regionalisation attributes. With the standard ThemeRoller styling, this value is replaced by an icon.
        /// </summary>
        [IntrinsicProperty]
        public string NextText { get { return null; } set { } }

        /// <summary>
        /// Set how many months to show at once. The value can be a straight integer, or can be a two-element array to define the number of rows and columns to display.
        /// </summary>
        [IntrinsicProperty]
        public object NumberOfMonths { get { return null; } set { } }

        /// <summary>
        /// The text to display for the previous month link. This attribute is one of the regionalisation attributes. With the standard ThemeRoller styling, this value is replaced by an icon.
        /// </summary>
        [IntrinsicProperty]
        public string PrevText { get { return null; } set { } }

        /// <summary>
        /// When true days in other months shown before or after the current month are selectable. This only applies if showOtherMonths is also true.
        /// </summary>
        [IntrinsicProperty]
        public bool SelectOtherMonths { get { return false; } set { } }

        /// <summary>
        /// Set the cutoff year for determining the century for a date (used in conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then this value is used directly. If a string value is provided then it is converted to a number and added to the current year. Once the cutoff year is calculated, any dates entered with a year value less than or equal to it are considered to be in the current century, while those greater than it are deemed to be in the previous century.
        /// </summary>
        [IntrinsicProperty]
        public object ShortYearCutoff { get { return null; } set { } }

        /// <summary>
        /// Set the name of the animation used to show/hide the datepicker. Use 'show' (the default), 'slideDown', 'fadeIn', any of the show/hide [http://docs.jquery.com/UI/Effects jQuery UI effects], or <c>''</c> for no animation.
        /// </summary>
        [IntrinsicProperty]
        public string ShowAnim { get { return null; } set { } }

        /// <summary>
        /// Whether to show the button panel.
        /// </summary>
        [IntrinsicProperty]
        public bool ShowButtonPanel { get { return false; } set { } }

        /// <summary>
        /// Specify where in a multi-month display the current month shows, starting from 0 at the top/left.
        /// </summary>
        [IntrinsicProperty]
        public int ShowCurrentAtPos { get { return 0; } set { } }

        /// <summary>
        /// Whether to show the month after the year in the header. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public bool ShowMonthAfterYear { get { return false; } set { } }

        /// <summary>
        /// Have the datepicker appear automatically when the field receives focus ('focus'), appear only when a button is clicked ('button'), or appear when either event takes place ('both').
        /// </summary>
        [IntrinsicProperty]
        public string ShowOn { get { return null; } set { } }

        /// <summary>
        /// If using one of the jQuery UI effects for showAnim, you can provide additional settings for that animation via this option.
        /// </summary>
        [IntrinsicProperty]
        public object ShowOptions { get { return null; } set { } }

        /// <summary>
        /// Display dates in other months (non-selectable) at the start or end of the current month. To make these days selectable use selectOtherMonths.
        /// </summary>
        [IntrinsicProperty]
        public bool ShowOtherMonths { get { return false; } set { } }

        /// <summary>
        /// When true a column is added to show the week of the year. The calculateWeek option determines how the week of the year is calculated. You may also want to change the firstDay option.
        /// </summary>
        [IntrinsicProperty]
        public bool ShowWeek { get { return false; } set { } }

        /// <summary>
        /// Set how many months to move when clicking the Previous/Next links.
        /// </summary>
        [IntrinsicProperty]
        public int StepMonths { get { return 0; } set { } }

        /// <summary>
        /// The text to display for the week of the year column heading. This attribute is one of the regionalisation attributes. Use showWeek to display this column.
        /// </summary>
        [IntrinsicProperty]
        public string WeekHeader { get { return null; } set { } }

        /// <summary>
        /// Control the range of years displayed in the year drop-down: either relative to today's year (-nn:+nn), relative to the currently selected year (c-nn:c+nn), absolute (nnnn:nnnn), or combinations of these formats (nnnn:-nn). Note that this option only affects what appears in the drop-down, to restrict which dates may be selected use the minDate and/or maxDate options.
        /// </summary>
        [IntrinsicProperty]
        public string YearRange { get { return null; } set { } }

        /// <summary>
        /// Additional text to display after the year in the month headers. This attribute is one of the regionalisation attributes.
        /// </summary>
        [IntrinsicProperty]
        public string YearSuffix { get { return null; } set { } }

        #endregion
    }
}
