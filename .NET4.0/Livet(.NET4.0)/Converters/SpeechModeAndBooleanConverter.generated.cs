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
    /// SpeechMode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class SpeechModeAndBooleanConverter : IValueConverter
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
        private SpeechMode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのSpeechMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SpeechMode ConvertWhenTrue
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
        private SpeechMode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのSpeechMode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SpeechMode ConvertWhenFalse
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
            if (!(value is SpeechMode)) throw new ArgumentException();

            var enumValue = (SpeechMode)value;

			switch(enumValue.ToString())
			{
				case "Dictation":
					if (_isConvertBackWhenDictationSet)
					{
						return ConvertBackWhenDictation;
					}
					break;
				case "Command":
					if (_isConvertBackWhenCommandSet)
					{
						return ConvertBackWhenCommand;
					}
					break;
				case "Indeterminate":
					if (_isConvertBackWhenIndeterminateSet)
					{
						return ConvertBackWhenIndeterminate;
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
        /// SpeechModeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenDictationSet;
        private bool _convertBackWhenDictation;
		/// <summary>
        /// SpeechModeの値がDictationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDictation
        {
            get
            {
                return _convertBackWhenDictation;
            }
            set
            {
                _convertBackWhenDictation = value;
                _isConvertBackWhenDictationSet = true;
            }
        }
        private bool _isConvertBackWhenCommandSet;
        private bool _convertBackWhenCommand;
		/// <summary>
        /// SpeechModeの値がCommandの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCommand
        {
            get
            {
                return _convertBackWhenCommand;
            }
            set
            {
                _convertBackWhenCommand = value;
                _isConvertBackWhenCommandSet = true;
            }
        }
        private bool _isConvertBackWhenIndeterminateSet;
        private bool _convertBackWhenIndeterminate;
		/// <summary>
        /// SpeechModeの値がIndeterminateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIndeterminate
        {
            get
            {
                return _convertBackWhenIndeterminate;
            }
            set
            {
                _convertBackWhenIndeterminate = value;
                _isConvertBackWhenIndeterminateSet = true;
            }
        }
    }
}