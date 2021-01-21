using AppConsultaAPI.Droid.Renderers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612
[assembly: ExportRenderer(typeof(Button), typeof(CustomButtonRenderer))]
#pragma warning restore CS0612
namespace AppConsultaAPI.Droid.Renderers
{
    [Obsolete]
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.SetAllCaps(false);
        }
    }
}