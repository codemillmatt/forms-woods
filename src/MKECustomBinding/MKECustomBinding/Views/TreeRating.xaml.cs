using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MKECustomBinding
{
	public partial class TreeRating : ContentView
	{
		const string SELECTED = "tree";
		const string BLANK = "tree-outline";

		public bool TouchEnabled { get; set; }

		#region Custom Binding

		public int NumOfTrees
		{
			get { return (int)GetValue(NumOfTreesProperty); }
			set
			{
				SetValue(NumOfTreesProperty, value);
			}
		}

		public static readonly BindableProperty NumOfTreesProperty =
			BindableProperty.Create(
				"NumOfTrees",
				typeof(int),
				typeof(TreeRating),
				defaultBindingMode: BindingMode.TwoWay,
				defaultValue: 1,
				propertyChanged: (bindable, oldValue, newValue) =>
				{
					var thisView = (TreeRating)bindable;
					thisView.UpdateTreeUI();
				});

		#endregion

		#region Constructor

		public TreeRating()
		{
			InitializeComponent();

				var tg1 = new TapGestureRecognizer();
				tg1.NumberOfTapsRequired = 1;
				tg1.Tapped += (sender, e) =>
				{
					NumOfTrees = 1;
				};
				firstTree.GestureRecognizers.Add(tg1);

				var tg2 = new TapGestureRecognizer();
				tg2.NumberOfTapsRequired = 1;
				tg2.Tapped += (sender, e) =>
				{
					NumOfTrees = 2;
				};
				secondTree.GestureRecognizers.Add(tg2);

				var tg3 = new TapGestureRecognizer();
				tg3.NumberOfTapsRequired = 1;
				tg3.Tapped += (sender, e) =>
				{
					NumOfTrees = 3;
				};
				thirdTree.GestureRecognizers.Add(tg3);

				var tg4 = new TapGestureRecognizer();
				tg4.NumberOfTapsRequired = 1;
				tg4.Tapped += (sender, e) => { NumOfTrees = 4; };
				fourthTree.GestureRecognizers.Add(tg4);

				var tg5 = new TapGestureRecognizer();
				tg5.NumberOfTapsRequired = 1;
				tg5.Tapped += (sender, e) => { NumOfTrees = 5; };
				fifthTree.GestureRecognizers.Add(tg5);
		}

		#endregion

		#region UI Updates

		void UpdateTreeUI()
		{
			firstTree.Source = SELECTED;
			secondTree.Source = BLANK;
			thirdTree.Source = BLANK;
			fourthTree.Source = BLANK;
			fifthTree.Source = BLANK;

			switch (NumOfTrees)
			{
				case 1:
					firstTree.Source = SELECTED;
					break;
				case 2:
					firstTree.Source = SELECTED;
					secondTree.Source = SELECTED;
					break;
				case 3:
					firstTree.Source = SELECTED;
					secondTree.Source = SELECTED;
					thirdTree.Source = SELECTED;
					break;
				case 4:
					firstTree.Source = SELECTED;
					secondTree.Source = SELECTED;
					thirdTree.Source = SELECTED;
					fourthTree.Source = SELECTED;
					break;
				case 5:
					firstTree.Source = SELECTED;
					secondTree.Source = SELECTED;
					thirdTree.Source = SELECTED;
					fourthTree.Source = SELECTED;
					fifthTree.Source = SELECTED;
					break;
				default:
					firstTree.Source = SELECTED;
					secondTree.Source = BLANK;
					thirdTree.Source = BLANK;
					fourthTree.Source = BLANK;
					fifthTree.Source = BLANK;
					break;
			}
		}

		#endregion
	}
}
