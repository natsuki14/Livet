﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// EasingMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class EasingModeAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private EasingMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのEasingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public EasingMode ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private EasingMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのEasingMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public EasingMode ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is EasingMode)) throw new ArgumentException();

            var enumValue = (EasingMode)value;

			switch(enumValue.ToString())
			{
				case "EaseIn":
					if (_isConvertBackWhenEaseInSet)
					{
						return ConvertBackWhenEaseIn;
					}
					break;
				case "EaseOut":
					if (_isConvertBackWhenEaseOutSet)
					{
						return ConvertBackWhenEaseOut;
					}
					break;
				case "EaseInOut":
					if (_isConvertBackWhenEaseInOutSet)
					{
						return ConvertBackWhenEaseInOut;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// EasingModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenEaseInSet;
        private bool _convertBackWhenEaseIn;
		/// <summary>
        /// EasingModeの値がEaseInの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEaseIn
        {
            get
            {
                return _convertBackWhenEaseIn;
            }
            set
            {
                _convertBackWhenEaseIn = value;
                _isConvertBackWhenEaseInSet = true;
            }
        }
        private bool _isConvertBackWhenEaseOutSet;
        private bool _convertBackWhenEaseOut;
		/// <summary>
        /// EasingModeの値がEaseOutの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEaseOut
        {
            get
            {
                return _convertBackWhenEaseOut;
            }
            set
            {
                _convertBackWhenEaseOut = value;
                _isConvertBackWhenEaseOutSet = true;
            }
        }
        private bool _isConvertBackWhenEaseInOutSet;
        private bool _convertBackWhenEaseInOut;
		/// <summary>
        /// EasingModeの値がEaseInOutの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEaseInOut
        {
            get
            {
                return _convertBackWhenEaseInOut;
            }
            set
            {
                _convertBackWhenEaseInOut = value;
                _isConvertBackWhenEaseInOutSet = true;
            }
        }
    }
}