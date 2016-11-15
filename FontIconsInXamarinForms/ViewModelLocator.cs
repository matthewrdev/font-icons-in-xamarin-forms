using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FontIconsInXamarinForms
{
	public class ViewModel : INotifyPropertyChanged
	{
		public System.Windows.Input.ICommand Scizzors
		{
			get
			{
				return new Xamarin.Forms.Command(() =>
				{
					Selection = "Scizzors";
				}

				);
			}
		}

		public System.Windows.Input.ICommand Paper
		{
			get
			{
				return new Xamarin.Forms.Command(() =>
				{
					Selection = "Paper!";
				}

				);
			}
		}

		public System.Windows.Input.ICommand Rock
		{
			get
			{
				return new Xamarin.Forms.Command(() =>
				{
					Selection = "Rock!";
				}

				);
			}
		}

		private string _selection;
		public string Selection
		{
			get
			{
				return _selection;
			}

			set
			{
				_selection = value;
				NotifyChanged();
			}
		}

		private double _colorValue;
		public double ColorValue
		{
			get
			{
				return _colorValue;
			}

			set
			{
				_colorValue = value;
				NotifyChanged();
			}
		}

		private double _sizeValue;
		public double SizeValue
		{
			get
			{
				return _sizeValue;
			}

			set
			{
				_sizeValue = value;
				NotifyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}

	public static class ViewModelLocator
	{
		public static readonly ViewModel ViewModel = new ViewModel();
	}
}