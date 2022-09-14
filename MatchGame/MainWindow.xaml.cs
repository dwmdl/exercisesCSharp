using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MatchGame
{
	using System.Windows.Threading;

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		DispatcherTimer timer = new DispatcherTimer();
		private int _tenthsOfSecondsElapsed;
		private int _matchesFound;

		public MainWindow()
		{
			InitializeComponent();

			timer.Interval = TimeSpan.FromSeconds(.1);
			timer.Tick += Timer_Tick;
			SetUpGame();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			_tenthsOfSecondsElapsed++;
			timeTextBlock.Text = (_tenthsOfSecondsElapsed / 10F).ToString("0.0s");
			if (_matchesFound == 8)
			{
				timer.Stop();
				timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
			}
		}

		private void SetUpGame()
		{
			List<string> animalEmoji = new List<string>()
			{
				"🐙", "🐙",
				"🐡", "🐡",
				"🐘", "🐘",
				"🐳", "🐳",
				"🐪", "🐪",
				"🦕", "🦕",
				"🦘", "🦘",
				"🦔", "🦔",
			};

			Random random = new Random();

			foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
			{
				if (textBlock.Name != "timeTextBlock")
				{
					textBlock.Visibility = Visibility.Visible;
					int index = random.Next(animalEmoji.Count);
					string nextEmoji = animalEmoji[index];
					textBlock.Text = nextEmoji;
					animalEmoji.RemoveAt(index);
				}
			}

			timer.Start();
			_tenthsOfSecondsElapsed = 0;
			_matchesFound = 0;
		}

		TextBlock lastTextBlockClicked;
		bool findingMatch = false;

		private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
		{
			TextBlock textBlock = sender as TextBlock;
			if (findingMatch == false)
			{
				textBlock.Visibility = Visibility.Hidden;
				lastTextBlockClicked = textBlock;
				findingMatch = true;
			}
			else if (textBlock.Text == lastTextBlockClicked.Text)
			{
				_matchesFound++;
				textBlock.Visibility = Visibility.Hidden;
				findingMatch = false;
			}
			else
			{
				lastTextBlockClicked.Visibility = Visibility.Visible;
				findingMatch = false;
			}
		}

		private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (_matchesFound == 8)
			{
				SetUpGame();
			}
		}
	}
}