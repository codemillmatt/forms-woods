# Get Out of the Woods With Xamarin.Forms

As presented at MKEdotNET on October 29, 2016.

In this talk we explored several aspects of what could possibly mess up our Xamarin.Forms projects and ways to get out of those situations.

* Keeping unnecessary logic out of the views
* Performance 
* UI customization 

## Ridding the views of unnecessary logic
It's all too easy to clog up the views in our apps with logic that could be better placed in reusable components elsewhere. Three of these components are:
1. Value Converters
2. Bendable Properties
3. Behaviors

The first project, MKEValueConvert demoed value converters. While MKECustomBindings project demoed the other two.

## Performance
Who can argue that performance is crucial to an app's success? Here we looked at the following:
* XAML compilation 
* ListView performance 
* Layout performance 
* General tips

## UI Customization 
Here we looked at 2 techniques to bring native platform look and feel into Forms apps.
* Native Embedding
* Effects

The MKECustomBinding project shows Effects being put to use.
